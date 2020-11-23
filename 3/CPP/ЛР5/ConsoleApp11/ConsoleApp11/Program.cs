using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;

public class UdpFileClient
{

    [Serializable]
    public class FileDetails
    {
        public string FILETYPE = "";
        public long FILESIZE = 0;
    }

    private static FileDetails fileDet;

    private static int localPort = 5002;
    private static UdpClient receivingUdpClient = new UdpClient(localPort);
    private static IPEndPoint RemoteIpEndPoint = null;

    private static FileStream fs;
    private static Byte[] receiveBytes = new Byte[0];

    [STAThread]
    static void Main(string[] args)
    {

        GetFileDetails();

        ReceiveFile();
    }
    private static void GetFileDetails()
    {
        try
        {
            Console.WriteLine("Waitin for file info");

            receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);
            Console.WriteLine("file info is gotten");

            XmlSerializer fileSerializer = new XmlSerializer(typeof(FileDetails));
            MemoryStream stream1 = new MemoryStream();

            stream1.Write(receiveBytes, 0, receiveBytes.Length);
            stream1.Position = 0;

            fileDet = (FileDetails)fileSerializer.Deserialize(stream1);
            Console.WriteLine("Gettin file type ." + fileDet.FILETYPE +
                " size of " + fileDet.FILESIZE.ToString() + " Byte");
        }
        catch (Exception eR)
        {
            Console.WriteLine(eR.ToString());
        }
    }

    public static void ReceiveFile()
    {
        try
        {
            Console.WriteLine("Waitin for file");

            receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);

            fs = new FileStream("temp." + fileDet.FILETYPE, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            fs.Write(receiveBytes, 0, receiveBytes.Length);

            Console.WriteLine("File saved");

            Console.WriteLine("Openin file");

            Process.Start(fs.Name);
        }
        catch (Exception eR)
        {
            Console.WriteLine(eR.ToString());
        }
        finally
        {
            fs.Close();
            receivingUdpClient.Close();
            Console.Read();
        }
    }
}