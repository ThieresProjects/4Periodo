# Lista 2
> ATIVIDADE 1

Questão 1: Front-End: O Front-End tende-se a ter como foco a construção da experiência do usuário, a parte visual de uma aplicação, a forma com que ele vai se comporta diretamente ao uso do usuário. Alguns exemplos de ferramentas usadas no front-end são JavaScript, React, HTML/CSS etc. Back-End: O back-end tem como foco a construção interna da aplicação, como se fosse a “massa do bolo”, funções internas, tratamento de dados, conexão com o banco, uso interno de api’s , tudo é levado em conta e utilizado para a melhor performance do sistema. Alguns exemplos de ferramentas usadas no back-end são: C#, C++, Python, PHP entre outros

Questão 2: A) Controller é o responsável por atender as requisições de acordo com as rotas. O controller nada mais é que uma classe, porém, com características específicas que devem seguir um padrão de funcionamento, padrão esse obtido por herança através da classe abstrata ControllerBase. Todo controller possui ações, essas ações são baseadas nos verbos do protocolo http (GET, POST, PUT, ...).

B) Devido a necessidade de um Model no método POST para receber os dados necessários para cadastrar na requisição.

C) É uma solução popular para descrever, projetar, documentar e testar APIs de forma padronizada e interativa. A especificação do Swagger é escrita em formato JSON ou YAML, e permite aos desenvolvedores descrever detalhadamente os recursos, endpoints, parâmetros, respostas, autenticação e outros aspectos da API de maneira clara e legível.

Questão 3: A) POST B) DELETE C) GET D) GET E) PUT F) POST

Questão 4: OK(): OK ou Código 200 é retornado quando a operação foi um sucesso, ou seja, deu certo. BadRequest: BadRequest ou código 400 é quando a operação não foi um sucesso e ou tiveram informações que faltaram, de toda a forma, uma falha. NotFound: NotFound ou código 404 é quando os dados necessário para completar a operação não foram encontrados e/ou não existem.

Questão 5: https:// Significa que sua API está usando o protocolo HTTP com criptografia minhaapi.com.br é o nome do domínio onde sua api está sendo hospedada. /api/vendas é o local/ subdiretório onde ela está localizada, basicamente o local específico.

============================================================================================ ATIVIDADE 2

QUESTÃO 1 – 1 – Com a inserção de informações inválidas ou mal formatadas no sistema o risco na qualidade dos dados armazenados e o risco de erros e inconsistências nos sistemas são altos, para prevenir isso a validação da Integridade dos Dados é de extrema importância; 2 – Quando os dados são validados desde o início e sua estruturação é feita de forma correta, a sua manutenção se torna mais fácil e rápida de se fazer; 3 – A validação de dados é de suma importância para a prevenção de erros lógicos que podem ocorrer quando dados inválidos são usados são inseridos incorretamente no sistema

QUESTÃO 2 Cenário 1 – A) NOME: Não pode ser um número. Deve ter ao menos 2 Caracteres e não pode ter mais de 30 caracteres. Abreviações são permitidas (Caso não siga os parâmetros, uma mensagem será gerada)

B) CPF: Deve ter 11 caracteres. Deve variar entre os números 0 e 9. (Caso não siga os parâmetros, uma mensagem será gerada)

C) DATA DE NASCIMENTO – Pode ser datada de antes de 1910 e nem depois do Ano atual. Deve ser digitada no padrão dd/mm/yyyy (Dia/Mês/Ano). (Caso não siga os parâmetros, uma mensagem será gerada)

D) EMAIL - Deve conter ao menos um @. Deve conter ao menos 1 caracteres antes do @.

E) TELEFONE/CELULAR – Deve ser mantido no padrão {+** (DDD) *****-****}, onde * é um número de 0 a 9. O número não pode ter menos que 10 caracteres (Código De País ao menos 1, DDD ao menos 2 e 9 caracteres do telefone/celular). (Caso não siga os parâmetros, uma mensagem será gerada)

F) SENHA - Deve conter ao menos 8 caracteres. Sendo ao menos, uma letra maiúscula, uma letra minúscula e um número. (Caso não siga os parâmetros, uma mensagem será gerada)

G) CEP - Deve ter 9 caracteres. Deve ser um CEP valido. Deve ser caracteres de 0 a 9. Deve estar de acordo com as informações digitadas no campo endereço

Cenário 2 – A) NOME: Não pode ser um número. Deve ter ao menos 2 Caracteres e não pode ter mais de 30 caracteres. Abreviações são permitidas (Caso não siga os parâmetros, uma mensagem será gerada)

B) CARGA HORARIA: Não pode ser um número menor que 0. Deve seguir o padrão (H:M), onde H é a hora onde pode variar de 0 a 24 e M pode variar de 0 a 59. Deve ser número inteiro. (Caso não siga os parâmetros, uma mensagem será gerada)

C) OBJETIVO: Deve ser uma descrição de ao menos 5 caracteres e não pode conter somente números ou símbolos. (Caso não siga os parâmetros, uma mensagem será gerada)

D) EMENTA: Deve ser uma descrição de ao menos 5 caracteres e não pode conter somente números ou símbolos. (Caso não siga os parâmetros, uma mensagem será gerada)

E) SEMESTRE: Deve ser digitado um número de 0 a 12 onde segura pelo padrão (Nº Período), onde N é o número. Não pode ser menor que 0, deve ser um número inteiro. (Caso não siga os parâmetros, uma mensagem será gerada)

F) ANO: Deve ser de 0 a 6. Seguindo um padrão de (Nº Ano) onde N é um número inteiro. (Caso não siga os parâmetros, uma mensagem será gerada)

G) NOME DO PROFESSOR: Não pode ser um número. Deve ter ao menos 2 Caracteres e não pode ter mais de 30 caracteres. Abreviações são permitidas (Caso não siga os parâmetros, uma mensagem será gerada)

QUESTÃO 3 –

IF/ELSE:

Diferenças: A validação com If/Else envolve a criação de blocos de código condicionais que verificam os dados de entrada e aplicam lógica para determinar se os dados são válidos. É uma abordagem mais programática, na qual o desenvolvedor escreve código específico para cada validação. Vantagens: Maior flexibilidade: É possível criar lógica de validação personalizada para casos complexos. Controle total: Os desenvolvedores têm controle total sobre como as validações são executadas e podem personalizá-las de acordo com as necessidades específicas do projeto. Desvantagens: Código repetitivo: Pode levar à duplicação de código, já que a validação deve ser implementada manualmente em diferentes partes do código. Manutenção mais complexa: À medida que a lógica de validação se torna mais complexa, o código pode se tornar difícil de manter e depurar.

DataAnnotation:

Diferenças: Os DataAnnotations são atributos que são aplicados a propriedades das classes de modelo. Eles descrevem regras de validação diretamente no modelo de dados. A validação é definida por meio de atributos de metadados, que são então processados automaticamente pelo framework. Vantagens: Redução de código: A validação é declarativa e é definida diretamente nas classes de modelo, eliminando a necessidade de escrever código adicional. Facilidade de manutenção: Como as regras de validação estão centralizadas nos modelos de dados, as atualizações são mais fáceis de gerenciar. Integração com ferramentas: Frameworks como o ASP.NET MVC podem usar esses atributos para gerar automaticamente mensagens de erro e validações do lado do cliente. Desvantagens: Menos flexibilidade: Nem todas as regras de validação podem ser expressas facilmente com DataAnnotations. Para validações complexas, pode ser necessário recorrer a soluções personalizadas. Acoplamento: A validação está diretamente vinculada ao modelo de dados, o que pode ser uma desvantagem em cenários onde a validação precisa ser aplicada de maneira mais genérica.

QUESTÃO 4 – Acontece que por padrão ao usar o DataAnnotation, o .net faz um filtro (action filter) que automaticamente valida a requisição e vê que não a atendeu, devido a invalidades.

