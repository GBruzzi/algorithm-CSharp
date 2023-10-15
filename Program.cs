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


crudInt();