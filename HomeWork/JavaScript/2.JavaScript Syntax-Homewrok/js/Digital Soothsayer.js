function soothsayer(number, prLanguages, cities, car){
	var prLanguagesRandom = Math.floor(Math.random() * prLanguages.length),
		citiesRandom = Math.floor(Math.random() * cities.length),
	    carsRandom = Math.floor(Math.random() * car.length),
	    numbersRandom = Math.floor(Math.random() * number.length),
	    result = [number[numbersRandom], prLanguages[prLanguagesRandom], cities[citiesRandom], car[carsRandom]];
	 
	 console.log('You will work %s years on %s.\nYou will live in %s and drive %s.' , result[0], result[1], result[2], result[3]);

}
soothsayer([3, 5, 2, 7, 9], ['Java', 'Python', 'C#', 'JavaScript', 'Ruby'], ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'], ['BMW', 'Audi', 'Lada', 'Skoda', 'Opel']);
