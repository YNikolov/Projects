import java.util.Scanner;

public class _1_SymmetricNumbersInRange {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] number = input.nextLine().split(" ");

		int start = Integer.parseInt(number[0]);
		int end = Integer.parseInt(number[1]);
		checkNumbers(start, end);
	}

	private static void checkNumbers(int startNumber, int endNumber) {
		for (int i = startNumber; i <= endNumber; i++) {
			char[] number = Integer.toString(i).toCharArray();
			boolean symmetric = true;
			for (int j = 0, k = 1; j < number.length / 2; j++, k++) {
				if (symmetric) {
					if (number[j] != number[number.length - k]) {
						symmetric = false;
					}
				}
			}
			if (symmetric) {
				System.out.print(i + " ");
			}
		}
	}
}