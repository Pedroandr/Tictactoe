using System;
using System.Collections.Generic;

class Program {
  static List<string> places = new List<string>{"1","2","3","4","5","6","7","8","9"};
  
  public static string PrintBoard(){
    Console.Clear();
    string board = ($"{places[0]}|{places[1]}|{places[2]} \n-----\n{places[3]}|{places[4]}|{places[5]} \n-----\n{places[6]}|{places[7]}|{places[8]}");
    return board;
    }
  
  public static void Main (string[] args) {
    Console.WriteLine(PrintBoard());
  }
}