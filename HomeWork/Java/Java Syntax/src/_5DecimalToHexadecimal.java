import java.util.Scanner;


public class _5DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		String hexadecimal = Integer.toHexString(num).toUpperCase();
		System.out.println(hexadecimal);
	}

}
