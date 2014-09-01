function checkBrackets(value) {
    var brackets = 0;
    for (var i = 0; i < value.length; i++) {
        if (value[i] === '(') {
            brackets += 1;
        } else if (value[i] === ')') {
            brackets -= 1;
        }
    }
    if (brackets == 0) {
        console.log('corect');
    } else {
        console.log('incorect');
    }
}
checkBrackets('( ( a + b ) / 5 – d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');