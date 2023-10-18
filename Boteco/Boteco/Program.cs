using System;
using System.Collections.Generic;

class Program {
    public static void Main (string[] args) {
        Console.WriteLine ("Digite seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine ("Digite sua data de nascimento");
        string dtNascimento = Console.ReadLine();
        Console.WriteLine ("Digite quanto você tem de dinheiro");
        float grana = float.Parse(Console.ReadLine());
        Cliente cliente = new Cliente(nome, dtNascimento, grana);
        Boteco boteco = new Boteco();
        

        string opcao = "";
        while(opcao != "0"){
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("===                Opcões do Sistema              ===");
            Console.WriteLine("=====================================================");
            Console.WriteLine("0 - Pagar e sair.");
            Console.WriteLine("1 - Vizualizar cardápio.");
            Console.WriteLine("2 - Comprar alguma coisa.");
            Console.WriteLine("3 - Vizualizar a comanda.");
            Console.WriteLine("=====================================================");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            opcao = Console.ReadLine();

            switch(opcao){
                case "0":
                if(boteco.getTotalConta()>cliente.getCarteira()){
                Console.WriteLine($"Vixi meu patrão, você vai ficar me devendo fiado R$:{boteco.getTotalConta()-cliente.getCarteira()}");
                }else{
                Console.WriteLine($"Pago com sucesso. Você ainda tem R$:{cliente.getCarteira() - boteco.getTotalConta()}");
                }
                return;

                case "1":
                int contador = 1;
                List<Produto> cardapio = boteco.getCardapio();
                Console.WriteLine("=====================================================");
                Console.WriteLine("CARDÁPIO");
                Console.WriteLine("=====================================================");
                foreach(Produto produto in cardapio){
                Console.WriteLine($"{contador} - {produto.getNomeProd()}.....{produto.getPreco()}");
                contador++;
                }
                Console.WriteLine("=====================================================");
                Console.WriteLine("Pressione qualquer tecla para fechar o cardápio.");
                Console.ReadKey();
                break;
                
                
                case "2":
                Console.WriteLine("Digite os números dos produtos do cardápio que você deseja (separados por vírgula):");
                string itens_juntos = Console.ReadLine();
                string[] itens_separados = itens_juntos.Split(',');
                
                foreach (string item in itens_separados) {
                    int item_atual;
                    if (int.TryParse(item, out item_atual) && item_atual >= 1 && item_atual <= boteco.getCardapio().Count) {
                        Produto produtoSelecionado = boteco.getCardapio()[item_atual - 1];
                        if (!cliente.getIsMaiorDeIdade() && produtoSelecionado.getAlcolico()) {
                            Console.WriteLine($"Você não pode comprar o produto {produtoSelecionado.getNomeProd()} pois não tem idade suficiente para o consumo.");
                        } else {
                            boteco.operarComanda(produtoSelecionado);
                            Console.WriteLine($"{produtoSelecionado.getNomeProd()} adicionado à comanda.");
                        }
                    } else {
                        Console.WriteLine($"Produto {item} não encontrado no cardápio.");
                    }
                }
                
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                break;

                case "3":
                Console.Clear();
                Console.WriteLine("=====================================================");
                Console.WriteLine("COMANDA");
                Console.WriteLine("=====================================================");

                foreach (Produto produto in boteco.getComanda()){
                    Console.WriteLine($"Produto: {produto.getNomeProd()}.....{produto.getPreco()}");
                }
                Console.WriteLine("=====================================================");
                Console.WriteLine($"TOTAL:      R${boteco.getTotalConta()}");
                Console.WriteLine("=====================================================");
                Console.WriteLine("Pressione qualquer tecla para fechar o cardápio.");
                Console.ReadKey();
                break;
        
                }
            
            }
        
        
    }
}