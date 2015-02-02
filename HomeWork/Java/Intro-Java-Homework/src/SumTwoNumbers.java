import java.util.Scanner;

public class SumTwoNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		int numberOne = input.nextInt();
		int secondNumber = input.nextInt();
		int sum = numberOne + secondNumber;

		System.out.print(sum);
	}
}
