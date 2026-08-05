let a = prompt("Digite o valor de a:");
let b = prompt("Digite o valor de b:");
let c = prompt("Digite o valor de c:");

if (isNaN(a) || isNaN(b) || isNaN(c)) {
    alert("Número inválido!")
}
else {

    a=parseFloat(a);
    b=parseFloat(b);
    c=parseFloat(c);

   if (a < (b + c) && a > Math.abs(b - c) && 
       b < (a + c) && b > Math.abs(a - c) && 
       c < (a + b) && c > Math.abs(a - b))
    {//The Legend of Zelda Link's Awakening é um jogo muito bom, mesmo no Game Boy Clássico, e é ainda melhor a sua versão DX para game boy color, mas a versão de Nintendo Switch
     //se supera, pois o Nintendo Switch é bem mais poderoso que um Game Boy clássico
     Criar uma função em JS que a partir de um array com 3 números, retorne a soma DataTransferItemList, o quadrado
        if (a == b & b == c) {
            alert("Os valores formam um triângulo equilátero.")
        }

        else if (a == b || a == c || b == c) {
            alert("Os valores formam um triângulo isóceles.")
        }

        else {
            alert("Os valores formam um triângulo iscaleno.")
        }
    }

    else {
        alert("Os valores não formam um triângulo!")
    }
}