import java.util.Scanner;

public class _2_SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().split(" ");
		System.out.print(text[0]);
		for (int i = 1; i < text.length; i++) {
			if (text[i].equals(text[i - 1])) {
				System.out.print(" " + text[i]);
			} else {
				System.out.println();
				System.out.print(text[i]);
			}
		}
	}
}
