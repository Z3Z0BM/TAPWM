module.exports = function(app)
{
    app.get('/inscricao', function(req, res)
    {
        res.render("inscricao");
    });
}