module.exports = function(app)
{
    app.get('/jogos', function(req, res)
    {
        res.render("evento/jogos");
    });
}