import java.util.Scanner;

public class _01_RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);

		int sideA = input.nextInt();
		int sideB = input.nextInt();
		int area = sideA * sideB;
		System.out.print(area);

	}

}
