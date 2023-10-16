using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Threading;


void crudInt()
{
  ArrayList arrayInt = new ArrayList();

  arrayInt.Add(4);
  arrayInt.Add(6);
  arrayInt.Add(500);

  void exibirOpcoes()
  {
    int choice = 0;

    while (choice != 99)
    {
      Console.Clear();
      Console.WriteLine(@"Qual sua opção ?
    1 - Inserir elemento
    2 - Remover elemento
    3 - Listar elementos
    4 - Pesquisar elemento
    5 - Ordenar elementos
    6 - Fazer uma busca binária
    ");

      choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1:
          inserirElemento();
          break;
        case 2:
          removerElemento();
          break;
        case 3:
          listarElementos();
          break;
        case 4:
          pesquisarElemento();
          break;
        case 5:
          ordenarElementos();
          break;
        case 6:
          buscaBinaria();
          break;
        default:
          Console.WriteLine("Opção inválida !");
          Thread.Sleep(2000);
          break;
      }

    }

  }


  void buscaBinaria()
  {
    Console.Clear();

    // duplicar array

    ArrayList sorted = new ArrayList(arrayInt);
    sorted.Sort();
    Console.WriteLine("Qual elemento você deseja realizar uma busca binária ?");
    int o = int.Parse(Console.ReadLine());

    if (arrayInt.Contains(o))
    {
      int pos = sorted.BinarySearch(o);
      Console.WriteLine($"O número {o} foi encontrado na posição {pos} ! ");
    }
    else
    {
      Console.WriteLine($"O número {o} não foi encontrado !! ");
    }

    Thread.Sleep(2000);
    exibirOpcoes();
  }

  void ordenarElementos()
  {
    Console.Clear();
    ArrayList sorted = new ArrayList(arrayInt);
    Console.WriteLine("A lista ordenada do array ficou assim : ");

    sorted.Sort();

    foreach (object o in sorted)
    {
      Console.WriteLine(o);
    }


    Thread.Sleep(2000);
    exibirOpcoes();
  }

  void pesquisarElemento()
  {
    Console.Clear();

    Console.WriteLine("Qual elemento deseja pesquisar ?");
    int o = int.Parse(Console.ReadLine());

    if (arrayInt.Contains(o))
    {
      int pos = arrayInt.IndexOf(o);
      Console.WriteLine($"O número {o} foi encontrado na posição {pos} ! ");
    }
    else
    {
      Console.WriteLine($"O número {o} não foi encontrado !! ");
    }

    Thread.Sleep(2000);
    exibirOpcoes();
  }

  void removerElemento()
  {
    Console.Clear();
    Console.WriteLine("Qual elemento deseja remover ? ");

    int o = int.Parse(Console.ReadLine());

    if (arrayInt.Contains(o))
    {
      arrayInt.Remove(o);
      Console.WriteLine($"O número {o} foi removido ! ");
    }
    else
    {
      Console.WriteLine($"O número {o} não foi encontrado !! ");
    }


    arrayInt.Remove(o);

    Thread.Sleep(2000);
    exibirOpcoes();
  }

  void listarElementos()
  {
    Console.Clear();
    Console.WriteLine("Nesse array, temos os objetos : ");
    foreach (object o in arrayInt)
    {
      Console.WriteLine(o + " ");
    }

    Thread.Sleep(2000);
    exibirOpcoes();
  }

  void inserirElemento()
  {
    Console.Clear();

    Console.WriteLine("Qual elemento você deseja adicionar ?");

    int o = int.Parse(Console.ReadLine());

    arrayInt.Add(o);

    Console.WriteLine("Elemento adicionado com sucesso ! ");

    Thread.Sleep(2000);
    exibirOpcoes();

  }



  exibirOpcoes();


}

void firstQueue()
{
  Console.Clear();
  Queue f = new Queue();

  f.Enqueue(1); f.Enqueue(2); f.Enqueue(3); f.Enqueue(4); f.Enqueue(5);

  foreach (object o in f)
  {
    Console.WriteLine(o);
  }

  f.Dequeue();

  if (f.Contains(1))
  {
    Console.WriteLine("Contem o elemento 1 na fila");
  }
  else
  {
    Console.WriteLine("Não contem o elemento 1 na fila");
  }

  if (f.Contains(5))
  {
    Console.WriteLine("Contem o elemento 5 na fila");
  }
  else
  {
    Console.WriteLine("Não contem o elemento 5 na fila");
  }

  Console.WriteLine($"O próximo objeto a ser removido será o {f.Peek()}");

  f.Enqueue(6); f.Enqueue(7); f.Enqueue(8); f.Enqueue(9); f.Enqueue(10);

  object next = f.Dequeue();
  object next2 = f.Dequeue();

  Console.WriteLine($"Os 2 elementos removidos foram {next} e o {next2}");
  f.Clear();
  Console.WriteLine($"Os elementos que restaram da fila foram :");

  foreach (object o in f)
  {
    Console.WriteLine(o);
  }
}

void firstStack()
{
  Console.Clear();
  Stack p = new Stack();

  p.Push(1); p.Push(2); p.Push(3); p.Push(4); p.Push(5);

  foreach (object o in p)
  {
    Console.WriteLine(o);
  }

  p.Pop();

  if (p.Contains(1))
  {
    Console.WriteLine("Contem o elemento 1 na pilha");
  }
  else
  {
    Console.WriteLine("Não contem o elemento 1 na pilha");
  }

  if (p.Contains(5))
  {
    Console.WriteLine("Contem o elemento 5 na pilha");
  }
  else
  {
    Console.WriteLine("Não contem o elemento 5 na pilha");
  }

  Console.WriteLine($"O próximo objeto a ser removido será o {p.Peek()}");

  p.Push(6); p.Push(7); p.Push(8); p.Push(9); p.Push(10);

  object next = p.Pop();
  object next2 = p.Pop();

  Console.WriteLine($"Os 2 elementos removidos foram {next} e o {next2}");
  p.Clear();
  Console.WriteLine($"Os elementos que restaram da fila foram :");

  foreach (object o in p)
  {
    Console.WriteLine(o);
  }
}
// crudInt();
//firstQueue();
firstStack();