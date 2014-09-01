function printNumbers(n) {
	var numbers = [];

	for (var i = 0; i < n + 1; i++) {
        if(i % 4 !== 0 && i % 5 !== 0){
			numbers.push(i);
		}
	}
       if (numbers.length !== 0) {
            console.log(numbers);
        } else {
            console.log('no');
        }
}
printNumbers(20);
printNumbers(-5);
printNumbers(13);