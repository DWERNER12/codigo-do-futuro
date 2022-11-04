function tabuada(num){
    for(let mult = 1; mult < 11; mult++){
        let res = num * mult
        console.log(`${num} * ${mult} = ${res}`)
        
    }
    return 'Fim'
}
console.log(tabuada(6))