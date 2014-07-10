import java.util.Scanner;

public class _1_VideoDurations {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int duration = 0;
		while (true) {
			String inputTime = input.nextLine();

			if (inputTime.equals("End")) {
				break;
			}
			String[] inputDuration = inputTime.split(":");
			
			int hours = Integer.parseInt(inputDuration[0]);
			int minutes = Integer.parseInt(inputDuration[1]);
			
			duration += (hours * 60) + minutes;
		}
		int hours = duration / 60;
		int minutes = duration % 60;
		
		System.out.printf("%d:%02d\n", hours, minutes);
	}
}
