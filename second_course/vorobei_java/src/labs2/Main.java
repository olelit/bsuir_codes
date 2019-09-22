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
				System.out.println(numbers[i]);
			}
		}
		
		
		int twoDiversionMatrix[][] = new int [][] {
			{1,0,2},
			{0,0,0},
			{2,0,0}
		};
		
		int defaultZero = findZeros(twoDiversionMatrix[0]);
		for(int y = 1; y < twoDiversionMatrix.length; y++) {
			if(findZero > defaultZero)
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