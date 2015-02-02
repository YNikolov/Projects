import java.util.Scanner;

public class _7_CountOfBitsOne {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		String numBinary = Integer.toBinaryString(num);
		int count = 0;

		for (int i = 0; i < numBinary.length(); i++) {
			if (numBinary.charAt(i) == '1') {
				count++;
			}
		}
		System.out.println(count);
	}
}
