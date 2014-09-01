function findMinAndMax(value){
    var minNum = Math.min.apply(null, value),
        maxNum = Math.max.apply(null,value);
    //if ( max){};
	// if (min)
	return 'Min -> ' + minNum + '\n' + 'Max -> ' + maxNum;
}
console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));

console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));
