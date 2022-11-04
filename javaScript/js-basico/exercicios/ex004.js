function queroLucrar(valor){
    let bicicleta = (valor * 100) / 60
    let lucro = bicicleta + (bicicleta * 0.25)
    return lucro
}

console.log(queroLucrar(300))