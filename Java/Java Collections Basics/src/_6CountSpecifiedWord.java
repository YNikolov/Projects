import java.util.Scanner;

public class _6CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().toLowerCase().split("\\W+");		
		String searchWord = input.next();
		int count = 0;
		for (int i = 0; i < text.length; i++) {
			if (text[i].equals(searchWord)) {
				count++;
			}
		}
		System.out.println(count);			
	}
}
