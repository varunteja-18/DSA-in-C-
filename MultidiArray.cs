using System;
class MultidiArray {
  static int[,] matrix = new int[3,3];
  static void Main() {
    int Choice;
    do{
        Console.WriteLine("---2D Array Menu---");
        Console.WriteLine("1. Create");
        Console.WriteLine("2. Read");
        Console.WriteLine("3. Update");
        Console.WriteLine("4. Delete");
        Console.WriteLine("5. Exit");
        Console.WriteLine();
        Console.WriteLine("Enter Your Choice:");
        Choice = Convert.ToInt32(Console.ReadLine());
        
        switch(Choice)
        {
            case 1: CreateMatrix();
            break;
            case 2: ReadMatrix();
            break;
            case 3: UpdateMatrix();
            break;
            case 4: DeleteMatrix();
            break;
            case 5:Console.WriteLine("Exiting.....");
            break;
            default:Console.WriteLine("Invalid Choice");
            break;
        }
    }while(Choice != 5);
  }
  static void CreateMatrix()
  {
      Console.WriteLine("Enter Values for 3x3 matrix:");
      for(int i = 0; i < 3; i++)
      {
          for(int j = 0; j < 3; j++)
          {
              Console.Write($"Enter Value at [{i}{j}]:");
              matrix[i,j] = Convert.ToInt32(Console.ReadLine());
          }
      }
      Console.WriteLine("Matrix Created.");
  }
  static void ReadMatrix()
  {
      Console.WriteLine("Matrix Contents:");
      for(int i = 0; i < 3; i++)
      {
          for(int j = 0; j < 3; j++)
          {
              Console.Write(matrix[i,j]+"\t");
          }
          Console.WriteLine();
      }
      Console.WriteLine();
  }
  static void UpdateMatrix()
  {
      Console.WriteLine("Enter row [0-2]:");
      int row = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter Col [0-2]:");
      int col = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter Value:");
      int value = Convert.ToInt32(Console.ReadLine());
      
      if(row >= 0 && row <= 3 && col >= 0 && col <= 3)
      {
          matrix[row,col]=value;
          Console.WriteLine("Value Updated");
      }
      else{
          Console.WriteLine("Invalid Row or Column");
      }
  }
  static void DeleteMatrix()
  {
      Console.WriteLine("Enter row [0-2]:");
      int row = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter Col [0-2]:");
      int col = Convert.ToInt32(Console.ReadLine());
      
      if(row >= 0 && row <= 3 && col >= 0 && col <= 3)
      {
          matrix[row,col]=0;
          Console.WriteLine("Value Deleted (set to 0).");
      }
      else{
          Console.WriteLine("Invalid Row or Column");
      }
  }
  
}
