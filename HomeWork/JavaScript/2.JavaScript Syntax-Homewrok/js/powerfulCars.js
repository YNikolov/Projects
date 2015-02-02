function convertKWtoHP(carsKW) {
    var carsHP = (carsKW / 0.746).toFixed(2);
    return carsHP;
}    
console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));   