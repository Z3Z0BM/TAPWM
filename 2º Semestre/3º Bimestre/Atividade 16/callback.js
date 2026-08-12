const prompt = require('prompt-sync')();
/*
Parênteses indicam que estamos executando a função prompt-sync.
Ao fazer isso, a função retorna um valor, que é uma nova função que pode ser usada para cirar prompts.
*/

function saudacao(nome)
{
    console.log('Bem-vindo ' + nome);
}

function entradaNome(callback)
{
    let nome = prompt('Digite o seu nome: ');
    callback(nome); //Chamando a função callback (saudação)
}

entradaNome(saudacao);