import java.util.Scanner;


public class _2_Triangle_Area {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		String[] pointsA = input.nextLine().split(" ");
		String[] pointsB = input.nextLine().split(" ");
		String[] pointsC = input.nextLine().split(" ");
		
		int aX = Integer.parseInt(pointsA[0]);
		int aY = Integer.parseInt(pointsA[1]);
		int bX = Integer.parseInt(pointsB[0]);
		int bY = Integer.parseInt(pointsB[1]);
		int cX = Integer.parseInt(pointsC[0]);
		int cY = Integer.parseInt(pointsC[1]);
		
		int area = Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY))/2);
		
		System.out.print(area);
	}

}
