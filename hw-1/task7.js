const readline = require('readline').createInterface({
  input: process.stdin,
  output: process.stdout,
});

readline.question('Сосал? ', pidor => {
    const ebal = pidor.trim().toLowerCase();

    if (ebal === "да"){
    console.log('Ай молодец какой');
    }
    else if (ebal === "нет") {
        console.log("Ну так иди отсюда нахуй") 
        readline.close()
        return
    }
  
readline.question('Ебал Липтона?',pidor2 => {
const ebal2 = pidor2.trim().toLowerCase();

if (ebal2 ==="да"){
    console.log("Сразу видно богатыря осеменителя")
} else if (ebal2 === 'нет'){
    console.log("Фу блять, натурал опущенный")
}
    readline.close();
  });
})
