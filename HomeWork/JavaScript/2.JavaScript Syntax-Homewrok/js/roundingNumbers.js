function roundNumber(value) {
    var mRound = Math.round(value);
    var mFloor = Math.floor(value);
    return mFloor + "\n" + mRound;
}
console.log(roundNumber(22.7));
console.log(roundNumber(12.3));
console.log(roundNumber(58.7));