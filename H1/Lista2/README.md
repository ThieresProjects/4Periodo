# Lista 2

Questão 1: Descreva 3 importantes motivos para validarmos os dados em nossa API.
Segurança, Integridade dos Dados e Prevenção de Erros Lógicos


Questão 2: Considere as seguintes entidades, descreva quais as validações você faria e como faria:
a) Cenário 1: Cadastro de cliente com:
Nome: validação de tamanho de string e obrigatório. Utilizaria o data annotation

CPF: validação da receita e obrigatório. Utilizaria um data annotation personalizado

Data Nascimento: validação que verifica idade. Utilizaria o data annotation

Email: validação de formato e verificar se é único. Utilizaria o data annotation

Telefone: validação de formato e verificar se é único. Utilizaria o data annotation

Senha: validação para que a senha contenha alguns critérios.

Cep, Rua, Bairro, Cidade, Estado: verificação de formato e se o lugar existe.


b) Cenário 2: Cadastro de Disciplina:
Nome: validação de tamanho de string e obrigatório. Utilizaria o data annotation

Carga Horária: validação de tipo. Utilizaria o data annotation

Objetivo: validação de tamanho de string. Utilizaria o data annotation

Ementa: validação de tamanho de string. Utilizaria o data annotation

Semestre: validação para verificar se está dentro de uma faixa válida

Ano: validação de tipo. Utilizaria o data annotation

Nome Professor: validação de tamanho de string e obrigatório. Utilizaria o data annotation



Questão 3: Em sala mostramos as validações utilizando inicialmente “o bom e velho if/else”, porém falamos que esse processo pode conter vantagens e desvantagens, por isso, mostramos depois o data annotation. Descreva comparando as duas técnicas apresentando vantagens e desvantagens.
O if/else lhe permite uma flexiblidade maior em relação as validações. Mas como se trata de uma validação manual, quando tiver muitas validações a serem feitas se torna inviável sua utilização

O Data Annotations é simples de usar e diminui a quantidade de códigos a ser utilizado, mas sua flexibilidade não é tão boa, limitando-se a regras simples.



Questão 4: Em sala mostramos que ao usar o data annotation, quando um dado é invalidado, ele não “chamava” a action e já retornava o “error message”. Descreva o que acontecia nesse caso que ele automaticamente já validava e não caia no debug da action?
O .Net consegue realizar um filtro que automaticamente valida os dados de acordo com os tipos dele. Sendo assim, quando estiverem incorretos ele automaticamente já faz uma validação.

