#language: pt-br

Funcionalidade: Autenticação Estudante
	Entrar no sistema como estudante

Cenário: Informar nome de professor válido e selecionar turma
	Dado nome "Valecy"
	Quando clicar no botão "Entrar"
	E selecionar turma "101"
	Então devem ser exibidos os "alunos da turma"
