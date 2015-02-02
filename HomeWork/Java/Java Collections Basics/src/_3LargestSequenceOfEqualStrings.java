import java.util.Scanner;

public class _3LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().split(" ");
		int currentCount = 1;
		int maxCount = 1;
		int wordIndex = 0;
		for (int i = 1; i < text.length; i++) {

			if (text[i].equals(text[i - 1])) {
				currentCount++;

			} else {
				currentCount = 1;
			}
			if (currentCount > maxCount) {
				maxCount = currentCount;
				wordIndex = i;
			}
		}
		for (int i = 0; i < maxCount; i++) {
			System.out.print(text[wordIndex] + " ");
		}
	}
}