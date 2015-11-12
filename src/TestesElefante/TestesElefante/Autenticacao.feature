#language: pt-br

Funcionalidade: Autenticação Estudante
	Entrar no sistema como estudante

Cenário: Informar nome de professor inválido
	Dado nome "asdfasdf"
	Quando clicar no botão "Entrar"
	Então deve mostrar mensagem "Usuário não perdido."

