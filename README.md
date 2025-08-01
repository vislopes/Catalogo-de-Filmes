🎬 Catálogo de Filmes (C# + OMDb API)
Projeto de console em C# para buscar, listar e gerenciar filmes usando a OMDb API. Prática de integração com APIs, manipulação de JSON, LINQ e menus no terminal.

🚀 Funcionalidades
🔎 Buscar filmes pelo título na OMDb API
📄 Listar filmes buscados
🔍 Filtrar e ordenar filmes por título, gênero, ano e avaliação IMDb
⭐ Adicionar e remover filmes dos favoritos
💾 Salvar e carregar favoritos em arquivo JSON local
👋 Salvamento automático ao sair do programa

🧠 O que você vai aprender
- Consumir APIs REST com HttpClient em C#
- Manipular exceções com try/catch
- Trabalhar com listas e LINQ para ordenação e filtragem
- Ler e escrever arquivos JSON com System.Text.Json
- Criar menus interativos em linha de comando
- Organizar código em camadas: Modelos, Serviços, Menus, Filtros

🛠 Tecnologias utilizadas
C# (.NET)
HttpClient
System.Text.Json
LINQ
Aplicação de console (CLI)

📁 Estrutura do projeto
Catalogo-de-Filmes/
│
├── FILTROS/
│   ├── LinqFilter.cs
│   └── LinqOrder.cs
│
├── MENUS/
│   ├── MenuBuscarFilme.cs
│   ├── MenuListaFilmesBuscados.cs
│   ├── MenuAdicionarFilmesFavoritos.cs
│   ├── MenuFavoritosSalvos.cs
│   ├── MenuFiltrarFilmes.cs
│   └── MenuSair.cs
│
├── MODELOS/
│   └── Filme.cs
│
├── SERVICOS/
│   ├── FilmeService.cs
│   └── ArquivoService.cs
│
├── Program.cs
└── favoritos.json

📦 Como executar
Clone o repositório:

git clone https://github.com/seu-usuario/catalogo-de-filmes.git
cd catalogo-de-filmes
Obtenha uma chave da OMDb API:
Registre-se grátis em omdbapi.com/apikey.aspx

Configure sua chave no código:
Substitua "SUA_API_KEY" no arquivo FilmeService.cs pela sua chave.

Compile e execute:
dotnet build
dotnet run

📖 Exemplo de uso
=== 🎬 Catálogo de Filmes ===

1 - Buscar filme  
2 - Ver lista de filmes buscados  
3 - Filtrar ou ordenar filmes  
4 - Adicionar filme aos favoritos  
5 - Ver favoritos salvos  
0 - Sair

💾 Persistência
Os favoritos são salvos automaticamente no arquivo favoritos.json para que você não perca seus filmes preferidos ao fechar o programa.

🙋‍♀️ Desenvolvedora
Projeto criado por Vitória dos Santos como parte de estudos em C#, backend e integração com APIs REST.

📄 Licença
Este projeto é de uso livre para fins educacionais.
