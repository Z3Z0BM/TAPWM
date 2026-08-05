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
    {
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