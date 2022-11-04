function pesoIdeal(peso, altura){
    let imc = peso / (altura * altura)
    return imc
}
console.log(pesoIdeal(70, 1.75))