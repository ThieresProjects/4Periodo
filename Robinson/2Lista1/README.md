# Lista de Exercicios do 2º bimestre

Select (*) 

1 - SELECT * FROM Funcionario
2 - SELECT CPF, Nome FROM Funcionario

3 - SELECT * 
        FROM Funcionario 
        WHERE 1=1 
            AND Sexo = 'f'

4 - SELECT * 
        FROM Funcionario 
        WHERE 1=1 
            AND Sexo = 'm'

5 - SELECT * 
        FROM Dependente 
        WHERE 1=1 
            AND Sexo = 'm'

6 - SELECT * 
        FROM Funcionario 
        WHERE 1=1 
            AND Nome LIKE 'M%'

7 - SELECT * 
        FROM Dependente 
        WHERE 1=1 
            AND Nome LIKE 'P%'

8 - SELECT * 
        FROM Funcionario 
        WHERE 1=1 
            AND Nome LIKE '%Cruz%'

9 - SELECT * 
        FROM Dependente 
        WHERE 1=1 
            AND Nome LIKE 'Cruz%'

Ãgregação

10 - SELECT * 
        FROM Projeto AS p
        INNER JOIN TrabalhaProjeto AS tp
            ON p.ProjetoID = tp.ProjetoID 
        WHERE 1=1
            AND MIN(tp.QtdeHoras)

11 - SELECT 
            p.Nome,
            AVG( TIMESTAMPDIFF( MINUTE, MIN(tp.QtdeHoras), MAX(tp.QtdeHoras) ) / 60 ) AS duracao_media
        FROM Projeto AS p
        INNER JOIN TrabalhaProjeto AS tp
            ON p.ProjetoID = tp.ProjetoID 
        GROUP BY p.Nome;

12 - SELECT
            Sexo,
            COUNT(1)
        FROM Funcionario
        GROUP BY Sexo;

TOP

13 - SELECT TOP(2)
        FROM Funcionario
        ORDER BY DataNascimento

14 - SELECT TOP(3)
        FROM Funcionario
        ORDER BY DataNascimento DESC

