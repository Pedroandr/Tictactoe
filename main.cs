using System;
using System.Collections.Generic;

class Program {
  public static int turn = 0;
  static List<string> places = new List<string>{"1","2","3","4","5","6","7","8","9"};
  
  public static string PrintBoard(){
    Console.Clear();
    string board = ($"{places[0]}|{places[1]}|{places[2]} \n-----\n{places[3]}|{places[4]}|{places[5]} \n-----\n{places[6]}|{places[7]}|{places[8]}");
    return board;
    }
  public static String playerSymbol(){
    if (turn == 0){
      turn++;
      return "X";
    }
    else{
      turn--;
      return "0";
      }
  }
  public static void Replace(string place){
    places.Remove(place);
    places.Insert(int.Parse(place)-1, playerSymbol());
  }
  
  public static void Main (string[] args) {
    Console.WriteLine(PrintBoard());
    
  }
}