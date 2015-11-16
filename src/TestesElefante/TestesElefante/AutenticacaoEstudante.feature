#language: pt-br

Funcionalidade: Autenticação Estudante
	Entrar no sistema como estudante

Cenário: Informar nome de professor válido e selecionar turma
	Dado professor "Valecy"
	Quando clicar no botão "Entrar"
	E selecionar a turma 101
	E selecionar o aluno "Carlos Alberto"
	E informar a senha "aa"
	Quando clicar no botão "Entrar"
	Então devem entrar na biblioteca do estudante