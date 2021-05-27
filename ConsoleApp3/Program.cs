using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program{
        static void Main(){
            while (true){
                int rowAmount = 0;
                rowAmount = Int32.Parse(Console.ReadLine());
                bool decodingError = false;
                List<string> encoding = new List<string>();
                if (rowAmount == 0 ){                  
                    break;
                }
                for (int i = 0; i < rowAmount; i++){
                    encoding.Add(Console.ReadLine());   
                }                
                foreach (var item in encoding){
                    string[] temp = item.Split(' ');
                    string firstChar = temp[0];
                    string print = "";
                    for (int i = 1; i < temp.Length; i++){
                        int runtimes = Int32.Parse(temp[i]);
                        if (firstChar == "#"){
                            for (int j = 0; j < runtimes; j++){
                                print += "#";
                            }
                            firstChar = ".";
                        }
                        else{
                            for (int j = 0; j < runtimes; j++){
                                print += ".";
                            }
                            firstChar = "#";
                        }  
                    }
                    Console.WriteLine(print);
                }
                List<int> len = new List<int>();
                foreach (var item in encoding){
                    int sum = 0;
                    string encodingToSplit = item.Substring(1);
                    encodingToSplit = encodingToSplit.Substring(1);
                    string[] temp = encodingToSplit.Split(' ');
                    foreach (var num in temp){
                        sum = sum + Int32.Parse(num);
                    }
                    len.Add(sum); 
                }
                foreach (var num in len){
                    if (len[0] != num){
                        decodingError = true;
                    }
                }
                if (decodingError){
                    Console.WriteLine("Error decoding image");
                }
                Console.WriteLine();  
            }
        }
    }
}
