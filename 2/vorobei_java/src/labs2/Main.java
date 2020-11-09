package labs2;

class Main {
	
	public static void main(String[] args) {
		int n = 40;
		int[] numbers = new int[n];
		
		for(int i = 0; i < n; i++) {
			numbers[i] = (int) (1 + (Math.random() *(10-1)));
		}	
		
		for(int i = 0;i < n;i++) {
			if(numbers[i] % 3 == 0 && numbers[i] % 5 !=0 ) {
				System.out.print(numbers[i]);
			}
		}
		
		System.out.println();
		
		
		int twoDiversionMatrix[][] = new int [][] {
			{1,0,2},
			{0,0,0},
			{2,0,0}
		};
		
		int newMatrix[][] = new int[3][3];
		
		int zeros = 0;
		for(int y = 0; y < twoDiversionMatrix.length; y++) {
			zeros = findZeros(twoDiversionMatrix[y]);
			for(int i = 0; i < twoDiversionMatrix.length;i++) {
				if( i != y) {
					int newZeros = findZeros(twoDiversionMatrix[i]);
					if(newZeros > zeros) {
						int buf[] = twoDiversionMatrix[y];
						twoDiversionMatrix[y] = twoDiversionMatrix[i];
						twoDiversionMatrix[i] = buf;
					}
				}
					
			}
		}	
		
		for(int i = 0; i < 3;i++) {
			for(int j = 0;j<3;j++) {
				System.out.print(twoDiversionMatrix[i][j]);
			}
			System.out.println();
		}
	}
	
	public static int findZeros(int[] arr) {
		int count = 0;
		
		for(int i = 0; i < arr.length; i++) {
			if(arr[i] == 0) {
				count++;
			}
		}
		
		return count;
	}
	
}