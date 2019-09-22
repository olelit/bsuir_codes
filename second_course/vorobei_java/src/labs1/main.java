package second_course.vorobei_java.src.labs1;
import java.util.Arrays;

class Main{

    public static int[] addElementToArray(int[] array, int index,  int value){
        array[index] = value;
        return  array;
    }

    public static int[][] addElementToArray(int[][] array, int indexX ,int indexY,  int value){
        array[indexY][indexX] = value;
        return array;
    }

    public static int[] removeElementFromArray(int[] array, int index){
        int[] newArray = new int[array.length-1];
        int newIndex = 0;

        for(int i = 0; i < array.length; i++) {
        	if(i!=index) {
            	newArray[newIndex] = array[i];
            	newIndex++;
        	}
        }

        return newArray;
    }

    public static int[][] removeElementFromArray(int[][] array, int indexX ,int indexY){
    	int[] new_array = removeElementFromArray(array[indexY], indexX);
        array[indexY] = new_array;
        return array;
    }

    public static int[] editElementInArray(int[] array, int index, int value){
        array[index] = value;
        return array;
    }

    public static int[][] editElementInArray(int[][] array, int indexX ,int indexY, int value){
        return array;
    }

    public static void main(String[] args){
        Person person = new Person();

        int[] oneDiversionArray = new int[] {1,2,3,4,5,6,7,8,9};
        int[][] twoDiversionArray = new int[][] {{1,2,3},{4,5,6},{7,8,9}};

        long startTime = System.nanoTime();
        oneDiversionArray = addElementToArray(oneDiversionArray, 2, 4);
        oneDiversionArray = editElementInArray(oneDiversionArray, 3 ,6);
        oneDiversionArray = removeElementFromArray(oneDiversionArray, 4);
        
        for(int i = 0;i<oneDiversionArray.length;i++) {
        	System.out.print(oneDiversionArray[i]+" ");
        }
        
        System.out.println("\n");
        
        long oneDiversionTime = System.nanoTime() - startTime;
        
        startTime = System.nanoTime();
        twoDiversionArray = addElementToArray(twoDiversionArray, 2,2,6);
        twoDiversionArray = editElementInArray(twoDiversionArray, 2,3,8);
        twoDiversionArray = removeElementFromArray(twoDiversionArray, 1,1);
        
        for (int i = 0; i < twoDiversionArray.length; i++) {
            for (int j = 0; j <twoDiversionArray[i].length; j++) {
              System.out.print(twoDiversionArray[i][j]+" ");
       
            }
            System.out.println();
        }
        System.out.println();
        long twoDiversionTime = System.nanoTime() - startTime;

        System.out.print(String.format("���������� ������: %s ����������; ��������� ������: %s ����������", oneDiversionTime,twoDiversionTime));
    }
}
