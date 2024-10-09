/*const valor1 = 10;
const valor2 = 5;

console.log(valor1 + valor2);
console.log(valor1 - valor2);
console.log(valor1 * valor2);
console.log(valor1 / valor2);*/

/*
const nota = 2;

switch(nota) {
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        console.log("Abaixo da média");
        break;
    case 7:
    case 8:
    case 9:
    case 10:
        console.log("Acima da média");
        break;
    default:
        console.log("Na média");
}
*/

/*
const nota = 8

nota > 6 ? console.log("Aprovado") : console.log("Reprovado")
*/
/*
for(let i = 0; i <= 10; i++)
{
    console.log(i)
}
    */
/*
let x = 0
while (x <= 10)
{
    x++
    console.log(x)
}
*/
/*
let x = 0
const valores = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
valores.forEach((valores) =>{
    x++
    console.log(`${valores} - ${x}`)
})
    */
/*
const soma = (x, y) =>  x + y

let resultado = soma (1, 2)
console.log(resultado)
*/

let estadosSigla = 
    [{
        estado: 'São Paulo', //Local 0
        sigla: 'SP'
    },
    {
        estado: 'Bahia', //Local 1
        sigla: 'BH'
    }];

console.log(`Estado: ${estadosSigla[1].estado} \nSigla: ${estadosSigla[1].sigla}`)

estadosSigla.push //Adiciona item a array
    ({
        estado: "Rio de Janeiro", //Local 2
        sigla: "RJ",
    })

console.log(`Estado: ${estadosSigla[2].estado} \nSigla: ${estadosSigla[2].sigla}`)


