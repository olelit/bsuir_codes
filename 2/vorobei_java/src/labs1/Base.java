package labs1;
import java.util.Scanner;

public class Base {

	public static void main(String[] args) {
		System.out.println("N1");
		String text = "Она шла шагом вольным и свободным, как ходят арлезианки и \n"
				+ " андалузки. Городская девушка попыталась бы, может быть, скрыть \n"
				+ " свою радость под вуалью или по крайней мере под бархатом \n"
				+ "ресниц, но Мерседес улыбалась и смотрела на всех окружавших, и \n"
				+ " улыбка и взгляд говорили так же откровенно, как могли бы \n"
				+ "сказать уста: «Если вы друзья мне, то радуйтесь со мною, потому что я поистине очень \n"
				+ "счастлива!»";
		
		System.out.println(text);
		
		System.out.println("N2");
		Scanner in = new Scanner(System.in);
		double x1 = in.nextDouble();
		double x2 = in.nextDouble();
		double e = 2.718;
		
		double part1 = (Math.pow(Math.cos(x1+1.3), 2)+x2)/(Math.pow(e, x2));
		double part2 = Math.cos(Math.pow(x2,2)+1.5);
		double part3 = (5+x2)/Math.pow(x1, 0.5);
		
		double y = part1 + part2 + part3;
		System.out.println(y);
		
		System.out.println("N3");
		double maxSin = Math.sin(5);
		int grade = 1;
		
		for(int i = 2;i<=3;i++) {
			double sin = Math.sin(5*i);
			if(sin > maxSin) {
				maxSin = sin;
				grade = i;
			}
		}
		
		System.out.println("Наибольший sin(x) при x="+ grade+"и равен:"+maxSin);
		
		int n = 30;
		int sum = 0;
		
		System.out.println("N4");
		for(int i = 1; i<=n;i++) {
			sum+=((2*i)-1)*((2*i)+1);
		}
		
		System.out.println(sum);
		System.out.println("N5");
		double eps = 1.5;
		double number = 1;
		int iter = 1;
		double sumNew = 0;
		
		while(sumNew < eps) {
			sumNew += number;
			number /= 2;
			iter++;
		}
		
		System.out.println("Сумма: "+sumNew);
		System.out.println("Последнее значение: "+number);
		System.out.println("Количесво значений: "+iter);
					

	}

}
