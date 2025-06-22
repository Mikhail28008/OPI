
let years = {
    secondsInMinute: 60,
    minutesInHour: 60,
    hoursInDay: 24,
    daysInYear: 365,
    myAgeInYears: 55,
    myAgeInSeconds: null 
}

years.myAgeInSeconds = years.myAgeInYears * years.daysInYear *years.hoursInDay * years.minutesInHour * years.secondsInMinute

console.log (`Возраст в секундах: ${years.myAgeInSeconds}`);
//Не так сложно было реализовать как вспомнить как считать правильно