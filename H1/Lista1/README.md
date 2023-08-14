# LISTA 1

Exercicio 1
- Front é a parte visual e de interação da aplicação e back é a parte das funcionalidades que o usuario não vê
  trabalhando mais ainda sim interage por ser entregue no front
- Front End: React.js
- Back End: ASP.NET FRAMEWORK
  
Exercicio 2
- a)
     - Os models são modelos de objetos trasidos nos json para ser apresentados na view
     - Os controller são funções da web que são chamadas na url e retornam uma view para quem chamar a url
     - Os controllers herdam as caracteristas base de um controller e a congurações para se chamado na web
     
- b)
     - Os navegadores pro padrão já executam o metodo GET e os demais methodos como por exemplo o POST são enviados
       atravez do Body do Request o que tambem previne garantindo a segurança das informações
- c) 
     - O swagger é uma ferramenta que auxilia no desenvolmento de API's ajudando a visualizar e ate modificar 

Exercicio 3
- a) POST =>  (POST or PUT)
- b) DELETE
- c) GET
- d) GET
- e) PUT => (PUT or PATCH)
- f) POST => (POST or PUT or PATCH)
- Cada um possui um situação a verificar pois pode ser que queira lançar a nota com apenas gois parametros ou as vezes
  com um objeto inteiro, ou pra confundir recebe um post e faz a alteração o sql podendo haver casos e casos

Exercicio 4
Cada retorno é usado em um codigo status diferente sendo:
- OK() => 200
- BadRequest() => 400
- NotFound() => 404

Exercicio 5
- https:// -> Protocolo de internet com segurança por causa do s
- minhaapi.com.br -> rota do dominio com o br no final indicando estar no brasil e com é padrão
- /api/vendas -> Controller chamador vendas que se for get esta sem parametro ou pode estar levando 
  no body do request com outro protocolo http.
- OBS: api pode ou ser uma pasta no servidor ou como vimos na aula passada pode ser configurada no controller
       independente é sempre bom configurar a  rota seja no controller ou não
