import java.util.Scanner;

public class _3_Largest_3_Rectangles {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		String numbers = input.nextLine();
		String[] rectNumbers = numbers.split("\\D+");

		int maxSum = Integer.MIN_VALUE;

		for (int i = 6; i < rectNumbers.length; i += 2) {
			int numOne = Integer.parseInt(rectNumbers[i - 5]);
			int numTwo = Integer.parseInt(rectNumbers[i - 4]);
			int numThree = Integer.parseInt(rectNumbers[i - 3]);
			int numFour = Integer.parseInt(rectNumbers[i - 2]);
			int numFive = Integer.parseInt(rectNumbers[i - 1]);
			int numSix = Integer.parseInt(rectNumbers[i]);

			int sum = numOne * numTwo + numThree * numFour + numFive * numSix;

			if (sum > maxSum) {
				maxSum = sum;
			}
		}
		System.out.print(maxSum);
	}

}
