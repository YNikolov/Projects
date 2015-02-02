function checkDigit(value) {
	var isThree = Math.floor((value / 100) % 10) == 3;
	return isThree;
}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));