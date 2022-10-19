//Manuel Leyva
//10-19-22
//Adding 2 Numbers
//You will be able to add the numbers the user has input 
//Peer Review:

string iChoice = "";

int rNum1, rNum2, wResult;
bool cNum1, cNum2;

do{

    do{
        Console.WriteLine("Let's Add Two Numbers together");
        Console.WriteLine(" Please Enter A Whole Number");
        cNum1 = Int32.TryParse(Console.ReadLine(), out rNum1);
        if(cNum1 == false)
        {
        Console.WriteLine("Thats Not A Number Try Again");
        }

    }while(cNum1 == false);

    do{
        Console.WriteLine("Please Enter A Second Whole Number");
        cNum2 = Int32.TryParse(Console.ReadLine(), out rNum2);
        if(cNum2 == false)
        {
            Console.WriteLine("That's Not A Number Try Again");
        }

    }while(cNum2 == false);

    wResult = rNum1 + rNum2;
    Console.WriteLine(" Your Child is " + wResult);

    do{
        Console.WriteLine("Do you want to continue: Yes or No?");
        iChoice = Console.ReadLine().ToUpper();
        if(iChoice != "YES" && iChoice != "NO")
        {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
        }
    }while (iChoice !="YES" && iChoice != "NO");
}while(iChoice == "YES");
    
