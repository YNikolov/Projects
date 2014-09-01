import java.util.ArrayList;
import java.util.Scanner;

public class _9CombineListsOfLetters {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		ArrayList<Character> firstList = new ArrayList<Character>();
		ArrayList<Character> secondList = new ArrayList<Character>();
		ArrayList<Character> combineLists = new ArrayList<Character>();

		for (char ch : input.nextLine().toCharArray()) {
			firstList.add(ch);
		}

		for (char ch : input.nextLine().toCharArray()) {
			secondList.add(ch);
		}
		combineLists.addAll(firstList);

		for (int i = 0; i < secondList.size(); i++) {
			if (firstList.contains(secondList.get(i))) {
				continue;
			} else {

				combineLists.add(' ');
				combineLists.add(secondList.get(i));
			}
		}

		for (int i = 0; i < combineLists.size(); i++) {
			System.out.print(combineLists.get(i));
		}
	} 
}