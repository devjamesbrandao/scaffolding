<h1 align="center"><strong>Estudos sobre scaffolding com EF Core</strong></h1>

<hr/>

<p align="center">
    <img src="/Img/banco-de-dados.png" alt="Banco de dados modelo" title="Banco de dados modelo">
</p> 

<p align="center">
    <img src="/Img/apos-scaffolding.png" alt="Resultado após o Scaffolding" title="Resultado após o Scaffolding">
</p> 

## Scaffolding com EF Core
> - Você precisa do dotnet cli instalado na sua máquina para esse exemplo
> - Instale o pacote NuGet para Microsoft.EntityFrameworkCore.Design o qual você está scaffolding no projeto
> - Você também precisará instalar um provedor de banco de dados apropriado para o esquema de banco de dados que deseja fazer engenharia reversa. No nosso caso,
o pacote é o Microsoft.EntityFrameworkCore.SqlServer

> Scaffold:
<strong> dotnet ef dbcontext scaffold "Conexao com o banco de dados" Microsoft.EntityFrameworkCore.SqlServer --context Ratinho --table Books --table Categories --table BookCategory --use-database-names --data-annotations --context-dir .\Contexto --output-dir .\Entidades --namespace Meu.Namespace --context-namespace Meu.Namespace.Context -p . </strong>

> Parâmetros:
> - <strong>CONNECTION STRING</strong>: conexão do banco de dados onde o Scaffold será realizado
> - <strong>Microsoft.EntityFrameworkCore.SqlServer</strong>: provider para gerar o mapeamento. Nesse caso, utilizei o pacote do SQL Server, mas poderia ser, por exemplo, do MySQL
> - <strong>--table</strong>: usado para selecionar quais tabelas serão mapeadas pelo Scaffolding
> - <strong>--use-database-names</strong>: os nomes de tabela e coluna são corrigidos para corresponder melhor às convenções de nomenclatura do .NET para tipos e propriedades por padrão. Especificar a opção --use-database-names na CLI do .NET Core desabilitará esse comportamento preservando o máximo possível os nomes de banco de dados originais
> - <strong>--data-annotations</strong>: os tipos de entidade são configurados usando a API fluente por padrão. Especifique --data-annotations (CLI do .NET Core) para usar anotações de dados quando possível
> - <strong>--context</strong>: o nome da classe DbContext com scaffold será o nome do banco de dados sufixado com Context por padrão. Para especificar outro, use --context na CLI do .NET Core
> - <strong>--context-dir .\Contexto --output-dir .\Entidades</strong>: as classes de entidade e uma classe DbContext são agrupadas no diretório raiz do projeto e usam o namespace padrão do projeto. Você pode especificar o diretório em que as classes são scaffolded usando --output-dir, e --context-dir pode ser usado para executar scaffold da classe DbContext em um diretório separado das classes de tipo de entidade
> - <strong>--namespace Meu.Namespace --context-namespace Meu.Namespace.Context</strong>: por padrão, o namespace será o namespace raiz mais os nomes de quaisquer subdiretórios no diretório raiz do projeto. No entanto, você pode substituir o namespace para todas as classes de saída usando --namespace. Você também pode substituir o namespace apenas para a classe DbContext usando --context-namespace
> - <strong>-p</strong>: assembly onde o DbContext está configurado

` 🌐 References`
<p>Engenharia reversa: https://learn.microsoft.com/pt-br/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli</p>

