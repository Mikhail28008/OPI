let str1 = {
     word1: 'доступ'.length,
     word2: 'морпех'.length,
     word3: 'наледь'.length,
     word4: 'попрек'.length,
     word5: 'рубило'.length,
    lengthWords: null,
    }

str1.lengthWords = str1.word1 + str1.word2 + str1.word3 + str1.word4 + str1.word5
console.log(str1.lengthWords); // Выведет общую длину всех слов
