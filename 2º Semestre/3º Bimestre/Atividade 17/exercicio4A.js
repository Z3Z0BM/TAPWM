//Função para imprimir a primeira parte
function Parte1()
{
    for(let i = 1; i <= 10 ; i++)
    {
        console.log("   Primeira Parte: " + i);
    }
}

setTimeout(Parte1, 2000); //Para atrasar
const fs = require('fs');
fs.readFile('file.txt', (err, data) =>
{
    if(err) throw err;
    const registros = data.toString().split('\n');
    registros.forEach((registro, index) =>
    {
    console.log("   segunda parte: " + index + " " + registro);
    });
});