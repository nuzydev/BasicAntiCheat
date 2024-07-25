# Basic_AntiCheat

`Basic_AntiCheat` é um exemplo de projeto em C# que demonstra uma abordagem básica para detectar processos potencialmente indesejados ou maliciosos em execução no sistema. Este projeto é especialmente útil para desenvolvedores que desejam implementar sistemas simples de detecção de cheats ou software não autorizado em seus aplicativos.

## Funcionalidades

- Monitoramento contínuo de processos em execução.
- Atualização periódica da lista de processos.
- Detecção de processos específicos definidos pelo usuário.

## Estrutura do Projeto

```csharp
namespace Basic_AntiCheat
{
    class Program
    {
        private static Thread thread;
        static void Main(string[] args)
        {
            thread = new Thread(ConsoleThread);
            thread.Start();
            Console.ReadLine();
        }

        public static void ConsoleThread()
        {
            while (true)
            {
                ProcessDetection.UpdateProcList();
                ProcessDetection.FindProcess();
                Thread.Sleep(2000);
            }
        }
    }
}
```

## Instalação

1. Clone o repositório:
    ```sh
    git clone https://github.com/nuzydev/Basic_AntiCheat.git
    ```

2. Abra o projeto no seu IDE C# preferido (Visual Studio recomendado).

3. Compile o projeto.

## Uso

1. Execute o programa.
2. O programa irá iniciar uma thread que monitora continuamente os processos em execução.
3. A lista de processos é atualizada a cada 2 segundos.
