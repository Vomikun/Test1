using System;
using System.IO;
using System.Diagnostics;


public class Test

{
   
  public static void Main()

  {
      
    // создаем процесс cmd.exe с параметрами "ipconfig /all"

    ProcessStartInfo psiOpt = new ProcessStartInfo(@"cmd.exe", @"/C ipconfig /all");
     
    // скрываем окно запущенного процесса

    psiOpt.WindowStyle = ProcessWindowStyle.Hidden;
     
    psiOpt.RedirectStandardOutput = true;
      
    psiOpt.UseShellExecute = false;
        
    psiOpt.CreateNoWindow = true;
        
    // запускаем процесс

    Process procCommand = Process.Start(psiOpt);
        
    // получаем ответ запущенного процесса

    StreamReader srIncoming = procCommand.StandardOutput;
        
    // выводим результат

    Console.WriteLine(srIncoming.ReadToEnd());
        
    // закрываем процесс

    procCommand.WaitForExit();
       
    Console.ReadKey();
        
  }
    
}
