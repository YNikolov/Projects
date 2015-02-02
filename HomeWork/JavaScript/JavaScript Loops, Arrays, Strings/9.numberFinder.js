function findMostFreqNum(numbers) {
    var maxCounter = 0;
    for (var i = 0; i < numbers.length; i++) {
        var counter = 1;
        for (var j = 0; j < numbers.length; j++) {
            if (j !== i && numbers[i] === numbers[j]) {
                counter++;
            }
            if (counter > maxCounter) {
                maxCounter = counter;
                var result = numbers[i];
            }
        }
    }
    console.log("%s (%s times)", result, maxCounter);
}
findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);