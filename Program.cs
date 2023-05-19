using System;
class Program{
    static void Main (string[] args){

        Console.WriteLine("Plz input a half DNA sequence:");
        string inputDNA;
        string doYouWantToReplicateIt;

        do{
           inputDNA = (Console.ReadLine());

            if(IsValidSequence(inputDNA)){
                
                Console.WriteLine("Current half DNA sequence : {0}", inputDNA);

                    if(checkYorN("Do you want to replicate it ? (Y/N) : " )){
                    
                    inputDNA = ReplicateSeqeunce(inputDNA);
                    
                    Console.WriteLine("Replicated half DNA sequence : {0}", inputDNA);

            }

            }else{
                Console.WriteLine("That half DNA sequence is invalid." );                
            }
            

        }while(checkYorN("Do you want to process another sequence ? (Y/N) : "));
    }

    static bool checkYorN(string answerYorN)
    {
      while (true)
      {
        Console.Write(answerYorN);

        string checkAnswerYorN = Console.ReadLine();

            if (checkAnswerYorN == "Y") { return true; }
            if (checkAnswerYorN == "N") { return false; }

        Console.WriteLine("Please input Y or N.");

      }
    }

    static bool IsValidSequence(string halfDNASequence)
{
	foreach(char nucleotide in halfDNASequence)
	{
    	if(!"ATCG".Contains(nucleotide))
    	{
        	return false;
    	}
	}
	return true;
}
static string ReplicateSeqeunce(string halfDNASequence)
{
	string result = "";
	foreach(char nucleotide in halfDNASequence)
	{
    	result += "TAGC"["ATCG".IndexOf(nucleotide)];
	}
	return result;
}
}