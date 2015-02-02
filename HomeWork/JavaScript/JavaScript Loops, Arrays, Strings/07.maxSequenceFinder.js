function findMaxSequence(value) {
    var maxSequence = [];
    var numbers = [value[0]];
    for (var i = 1; i < value.length; i++) {
        if (value[i] > value[i - 1]) {
            numbers.push(value[i]);
            if (numbers.length >= maxSequence.length) {
                maxSequence = numbers;
            }
        } else {
            numbers = [value[i]];
        }
    }
    return maxSequence.length != 0 ? maxSequence : "no";
}
console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));