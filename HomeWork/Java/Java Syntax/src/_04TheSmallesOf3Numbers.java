import java.util.Scanner;


public class _04TheSmallesOf3Numbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double a = input.nextDouble();
		double b = input.nextDouble();
		double c = input.nextDouble();
		double smallest;
		if(a<b && a<c){
		    smallest = a;
		}else if(b<c && b<a){
		    smallest = b;
		}else{
		    smallest = c;
		}
		System.out.print(smallest);

	}

}
