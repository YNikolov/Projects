//function findNthDigit(arr) {
//    var number = arr[1].toString().replace(/[-.]/g,'');
//    var position = arr[0];
//
//    var num = number[number.length - (position - 1)];
//    for(var i = number.length; i > position; i--) {
//
//    }
//    console.log(number);
//}
//findNthDigit([2,-55])
//findNthDigit([6, 923456])
function findNthDigit(arr) {
    var num = arr[1].toString().replace('.','').replace('-','');
    if (num.length < arr[0]) {
        return "The number doesn't have " + arr[0] + " digits";
    }
    num = Number(num);
    for (var i = 0; i < arr[0] - 1; i++) {
        num = Math.floor(num / 10);
    }
    return num % 10;
}
console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([6, 888.88]));