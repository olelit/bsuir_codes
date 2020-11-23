using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.Threading;

public class UdpFileServer
{
    [Serializable]
    public class FileDetails
    {
        public string FILETYPE = "";
        public long FILESIZE = 0;
    }

    private static FileDetails fileDet = new FileDetails();  

    private static IPAddress remoteIPAddress;

    private const int remotePort = 5002;

    private static UdpClient sender = new UdpClient();

    private static IPEndPoint endPoint;

    private static FileStream fs;

    [STAThread]
    static void Main(string[] args)
    {
        try
        {
       
            Console.WriteLine("IP-Addres");

            remoteIPAddress = IPAddress.Parse(Console.ReadLine().ToString());

            endPoint = new IPEndPoint(remoteIPAddress, remotePort);    

            Console.WriteLine("Enter file");

            fs = new FileStream(@Console.ReadLine().ToString(), FileMode.Open, FileAccess.Read);

            if (fs.Length > 18192)
            {
                Console.Write("File size is too big");
                sender.Close();
                fs.Close();
                return;
            }

            SendFileInfo();

            Thread.Sleep(2000);

            SendFile();

            Console.ReadLine();

        }
        catch (Exception eR)
        {
            Console.WriteLine(eR.ToString());
        }
    }

    public static void SendFileInfo()
    {

        fileDet.FILETYPE = fs.Name.Substring((int)fs.Name.Length - 3, 3);

        fileDet.FILESIZE = fs.Length;

        XmlSerializer fileSerializer = new XmlSerializer(typeof(FileDetails));

        MemoryStream stream = new MemoryStream();

        fileSerializer.Serialize(stream, fileDet);

        stream.Position = 0;

        Byte[] bytes = new Byte[stream.Length];

        stream.Read(bytes, 0, Convert.ToInt32(stream.Length));

        Console.WriteLine("Sending file...");

        sender.Send(bytes, bytes.Length, endPoint);

        stream.Close();

    }

    private static void SendFile()
    { 
        Byte[] bytes = new Byte[fs.Length];

        fs.Read(bytes, 0, bytes.Length);

        Console.WriteLine("Sending file " + fs.Length + " Byte");
        try
        {
            sender.Send(bytes, bytes.Length, endPoint);
        }
        catch (Exception eR)
        {
            Console.WriteLine(eR.ToString());
        }
        finally
        {
            fs.Close();
            sender.Close();
        }
        Console.WriteLine("File sent.");
        Console.Read();
    }
}