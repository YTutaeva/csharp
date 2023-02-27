// Задача 62: Заполните спирально массив 4 на 4.

Console.Clear();

 void SpiralFulfilling()
 {
    int n = 4;
    int[,] Array = new int[n, n];
    int row = 0;
    int col = 0;
    int MovingX = 1;
    int MovingY = 0;
    int DirectionChanges = 0;
    int visits = n;
    
    for (int i = 0; i < Array.Length; i++)
    {
        Array[row, col] = i + 1;
        if (--visits == 0)
        {
            visits = n * (DirectionChanges % 2) + n * ((DirectionChanges + 1) % 2) - (DirectionChanges / 2 - 1) - 2;
            int temp = MovingX;
            MovingX = -MovingY;
            MovingY = temp;
            DirectionChanges++;
        }
            col += MovingX;
            row += MovingY;
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("  " + Array[i, j] + "  ");
        }
            Console.WriteLine();
    }
}

SpiralFulfilling();