using System;

class Program
{
  static void Main(string[] args)
  {
    {
      do
      {
        string dna = Console.ReadLine();
        if (IsValidSequence(dna))
        {
          Console.WriteLine("Current half DNA sequence : {0}", dna);
          if (OptionSelect("Do you want to replicate it ? (Y/N) : "))
          {
            dna = ReplicateSeqeunce(dna);
            Console.WriteLine("Replicated half DNA sequence : {0}", dna);
          }
        }
        else
        {
          Console.WriteLine("That half DNA sequence is invalid.");
        }
      } while (OptionSelect("Do you want to process another sequence ? (Y/N) : "));
    }

    static bool OptionSelect(string repeatWord)
    {
      while (true)
      {
        Console.Write(repeatWord);
        string text = Console.ReadLine();
        if (text == "Y") { return true; }
        if (text == "N") { return false; }
        Console.WriteLine("Please input Y or N.");
      }
    }

    static bool IsValidSequence(string halfDNASequence)
    {
      foreach (char nucleotide in halfDNASequence)
      {
        if (!"ATCG".Contains(nucleotide))
        {
          return false;
        }
      }
      return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
      string result = "";
      foreach (char nucleotide in halfDNASequence)
      {
        result += "TAGC"["ATCG".IndexOf(nucleotide)];
      }
      return result;
    }
  }
}