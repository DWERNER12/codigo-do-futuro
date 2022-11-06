let operacao = "desitar";
let saldo = 100;
switch (operacao) {
  case "depositar":
    let saldoDeposito = saldo + 50;
    console.log(`Você depositou R$ 50,00
            Saldo atual R$ ${saldoDeposito.toFixed(2)}`);
    break;
  case "saque":
    let saldoSaque = saldo - 50;
    console.log(`Você fez um saque de R$50,00
            Saldo atual R$ ${saldoSaque.toFixed(2)}`);
    break;
  case "Consultar Saldo":
    console.log(`Seu saldo é R$ ${saldo.toFixed(2)}`);
    break;
  default:
    console.log(`${operacao} Operação invalida!
            Tente novamente!`);
    
}
