import java.util.Scanner;


public class _5CountAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().split("\\W+");
		System.out.print(text.length);
	}

}
