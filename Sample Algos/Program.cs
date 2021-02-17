using System;


namespace Sample_Algos
{
    class Program
    {
        public static int[] SwapPositions(int[] sequence, int i) //Swap the positions of two consecutive elements in an array
        {
            int temp = sequence[i];
            sequence[i] = sequence[i+1];
            sequence[i+1] = temp;            
            return sequence;
        }
        public static int GenerateLength() //Generate a random integer between 2 - 40 to use as the length of our array
        {
            
            System.Random random = new System.Random();
            return random.Next(2, 40);
        }
        public static int[] CreateArray(int length) //Creates an array
        {
            int[] sequence = new int[length];
            for(int i = 0; i < sequence.GetLength(0); i++)
            {   
                sequence[i] = i + 1;
            }
            return sequence;
        }
        public static int[] BubbleSort(int[] sequence) //Bubble sorts an array from largest to smallest
        {
            bool isSorted = false;
            while(isSorted == false)
            {
                int counter = 0; //counts the amount of times 2 numbers swap to determine whether the sorting is completed by informing 'isSorted'

                for(int i = 0; i < sequence.Length; i++)
                {   
                    if(i != sequence.Length - 1){ //Prevents exception errors with [i+1]
                        if(sequence[i] < sequence[i+1])
                        {
                            sequence = SwapPositions(sequence, i);
                            counter++;                                 
                        }                        
                    }
                }
                if(counter == 0)  //Have their been any swaps this round?
                {
                    isSorted = true; 
                }
            }
            return sequence;
        }
        public static int[] BubbleSortFaster(int[] sequence) //Bubble sorts an array from largest to smallest
        {
             bool isSorted = false;
            while(isSorted == false)
            {
                int counter = 0; //counts the amount of times 2 numbers swap to determine whether the sorting is completed by informing 'isSorted'

                for(int i = 0; i < sequence.Length; i++)
                {   
                    if(i != sequence.Length - 1){ //Prevents exception errors with [i+1]
                        if(sequence[i] < sequence[i+1])
                        {
                            sequence = SwapPositions(sequence, i);
                            counter++;                                 
                        }                        
                    }
                }
                if(counter == 0)  //Have their been any swaps this round?
                {
                    isSorted = true; 
                }
            }
            return sequence;
        }
        
        public static int[] SortPair(int[] sequence)
        {
            if(sequence[1] > sequence[0])
            {
                sequence = SwapPositions(sequence, 0);
            }
            return sequence;
        }

        public static int[] CopyArraySection(int[] sequence, int length, int index)
        {
            int sl = sequence.Length;
            int[] sequence2 = new int[length];
            int sl2 = sequence2.Length;
            if(index == 0)
            {
                for(int i = 0; i < sl2; i++)
                {
                    sequence2[i] = sequence[i];
                }
                
            }
            else
            {
                for(int i = 0; i < sl2; i++)
                {
                    sequence2[sl + i] = sequence[sl + i];
                }
            }
            return sequence2;
        }

        public static int[][] SplitArray(int[] sequence)
        {
            int sl = sequence.Length;
            int[][] splitArrays = new int[2][];

            splitArrays[0] = new int[sl/2];
            splitArrays[0] = CopyArraySection(sequence, sl/2, 0);

            splitArrays[1] = new int[sl - sl/2];
            splitArrays[1] = CopyArraySection(sequence, sl - sl/2, 1);
            
            return splitArrays;
        }
        public static int[] MergeSort(int[] sequence)
        {
            bool isSorted = false;
            //int counter = 0; //Counts the amount of the times the array is broken down
            //int firstRow = (sequence.Length/4);

            for(int i = 4; i <= sequence.Length/2;)
                if (sequence.Length < 2)
                {
                    sequence = SortPair(sequence);
                }
                if (sequence.Length > 2 )
                {
                    for(int j = 0; j < )
                    SplitArray()
                }




            return sequence;
        }
        static void Main(string[] args)
        {
            
            int [] sequence = CreateArray(GenerateLength());
            
            for(int i = 0; i < sequence.GetLength(0); i++)
                {   
                    //Console.WriteLine(sequence[i]);
                    //Console.WriteLine(BubbleSort(sequence)[i]);
                    Console.WriteLine(BubbleSortFaster(sequence)[i]);
                }       

        }
    }
}
