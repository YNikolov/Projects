import java.util.Arrays;
import java.util.Scanner;

public class SortArray {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		int n = input.nextInt();
		String[] inputText = new String[n];
		
		for (int i = 0; i < inputText.length; i++) {
			inputText[i] = input.next();
		}
		
		Arrays.sort(inputText);
		for (int i = 0; i < inputText.length; i++) {
			System.out.println(inputText[i]);
		}
	}
}
