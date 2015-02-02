import java.util.Scanner;


public class _6_FormattingNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		float b = input.nextFloat();
		float c = input.nextFloat();
				
		
		String aHex = Integer.toHexString(a).toUpperCase();
		String aBin = Integer.toBinaryString(a);
		aBin = String.format("%10s", aBin).replace(" ", "0");
		
		System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", aHex, aBin, b, c);
	}
}
