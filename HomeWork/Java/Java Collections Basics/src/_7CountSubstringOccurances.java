import java.util.Scanner;

public class _7CountSubstringOccurances {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		String searchSubString = input.next();
		int lastIndex = 0;
		int count = 0;

		while (lastIndex != -1) {

			lastIndex = text.indexOf(searchSubString, lastIndex);

			if (lastIndex != -1) {
				count++;
				lastIndex += searchSubString.length();
			}
		}
		System.out.println(count);
	}

}
