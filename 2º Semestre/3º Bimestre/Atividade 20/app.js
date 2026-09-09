let app = require('./app/config/server');

let rotaHome = require('./app/routes/home');
rotaHome(app);

let rotaContato = require('./app/routes/contato');
rotaContato(app);

let rotaInscricao = require('./app/routes/inscricao');
rotaInscricao(app);

let rotaJogos = require('./app/routes/jogos');
rotaJogos(app);

let rotaSobre = require('./app/routes/sobre');
rotaSobre(app);


app.listen(3000, function()
{
    console.log("Servidor iniciado!");
});