function findPalindromes(input) {
    var palindromes = [];
    var text = input.toLowerCase().match(/\w+/g);
    for (var i = 0; i < text.length; i++) {
        var current = text[i];
        var isPalindrome = true;
        for (var j = 0; j < current.length; j++) {
            if (current[j] !== current[current.length - 1 - j]) {
                isPalindrome = false;
            }
        }
        if (isPalindrome) {
            palindromes.push(current);
        }
    }
    return palindromes;
}
console.log(findPalindromes('There is a man, his name was Bob.'));
