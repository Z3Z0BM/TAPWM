function exibeMensagensNaOrdem(mensagem, callback)
    {
        console.log(mensagem);
        callback();
    }

//Executando
exibeMensagensNaOrdem('Essa é a primeira mensagem exibina na ordem', function()
{
    console.log('Essa é a segunda mendagem exibida na ordem');
});