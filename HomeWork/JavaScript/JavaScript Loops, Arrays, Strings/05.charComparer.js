function compareChars(arrOne, arrTwo) {
	var firstArr = arrOne,
		secondArr = arrTwo,
		i,
		areEqual = 'Equal';
    if (arrOne.length !== arrTwo.length) {
        areEqual = 'Not Equal';
    }
	else  {
		for (i = 0; i < arrOne.length; i++) {
            if (arrOne[i] !== arrTwo[i]) {
                areEqual = 'Not Equal';
            }
        }

		}
        console.log(areEqual);
}
compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']);
compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']);
compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']);
