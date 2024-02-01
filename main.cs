using System;

class Program {
  public static void Main (string[] args) {

    int[] unsortedArray = { 14, 7, 3, 10, 25, 8, 16, 2, 19, 5, 12, 18, 1, 6, 11, 22, 9, 4, 17, 13 };

    insertionSort(unsortedArray);

    for (int i = 0; i < unsortedArray.Length; i++) {
      Console.WriteLine(unsortedArray[i]);
    }
    
  }

  public static void insertionSort(int[] array){

    int temp = 0;
    
    for (int i = 0; i < array.Length; i++){

    int j = i;
      
    while (j > 0 && array[j - 1] > array[j]){
        temp = array[j];
        array[j] = array[j - 1];
        array[j - 1] = temp;

        j--;
      }
    }
  }
  
}