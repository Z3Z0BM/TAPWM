let eventos = require('events');
//Atribuição da classe EventEmitter a uma variável

let EmissorEventos = eventos.EventEmitter;
//O emissor de eventos, encontra-se na propriedade EventEmitter

let ee = new EmissorEventos();
//Ou criando direto sem a variável intermediária
//let ee = new eventos.EventEmitter();
//Mas da forma anterior é uma boa prática

//É registrado um ouvinte (listener) para o evento 'dados'.
//Quando esse evento acontecer executar a função passada como argumento
ee.on('dados', function(fecha)
{
    console.log(fecha);
});

//Emissão do evento somente uma vez:
ee.emit('dados', 'primeira vez' + Date.now());

//Emissão do evento a cada 500 milissegundos:
setInterval(function()
{
    ee.emit('dados', Date.now());
}, 500);