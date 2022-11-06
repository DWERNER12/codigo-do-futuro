function conversorMoeda(real) {
    let cotacaoDolar = 5.04
    let valorDolar = real / cotacaoDolar
    return valorDolar.toFixed(2)
}
console.log(conversorMoeda(50))