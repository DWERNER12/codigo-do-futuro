const livros = require('./database')

// pegar input do usuario
const input = require('readline-sync')
const entradaInicial = input.question('Deseja buscar em livro? S/N')

if(entradaInicial.toLocaleUpperCase() === 'S'){
    console.log('Esses são os autores disponiveis: ')
    console.log('George R. R. Martin', '/J. R. R. Tolkien')
    
    const entradaAutor = input.question('Qual autor você escolhe: ')

    const retorno = livros.filter(livros => livros.autor === entradaAutor)

    console.table(retorno)
}else{
    const livrosOrdenados = livros.sort((a,b) => a.paginas - b.paginas)
    console.log('Esses são todos os livros disponiveis: ')
    console.table(livrosOrdenados)
}