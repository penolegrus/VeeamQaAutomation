using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace VeeamTask1
{
    class CheckTime
    {   
        //Название выбранного процесса
        private string processName;        
        //Все процессы
        private Process[] processes;
        //Время допустимой жизни (в минутах)
        private byte aliveTime;
        //Интервал проверки (в минутах)
        private byte checkTime;
        

        public CheckTime(string processName = "notepad", string aliveTime = "1", string checkTime = "1")
        {
            this.processName = processName;

            bool convertResult1 = Byte.TryParse(aliveTime, out this.aliveTime);
            bool convertResult2 = Byte.TryParse(checkTime, out this.checkTime);

            if (convertResult1 && convertResult2)
            {               
                Console.WriteLine("Наблюдение началось " + DateTime.Now);
                Console.WriteLine("Процесс завершится через " + aliveTime + " минут");
                this.Watch();
            }
            else
            {
                Console.WriteLine("Процесс не найден");                
            }
        }
        
        //Наблюдение
        private void Watch()
        {
            try
            {
                processes = Process.GetProcessesByName(this.processName);
                if (processes.Length == 0)
                    Console.WriteLine("Процесс не найден");                    
                byte watchingMinutes = 0;
                while (processes.Length != 0)
                {
                    if (watchingMinutes >= this.aliveTime)
                    {
                        this.Kill();
                        Console.WriteLine("Процесс завершен");                       
                        break;
                    }

                    Thread.Sleep(60000 * this.checkTime);
                    watchingMinutes++;
                    Console.WriteLine("Процесс в работе уже {0} из {1} минут.",
                        watchingMinutes, this.aliveTime);                  
                    processes = Process.GetProcessesByName(this.processName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка " + ex.Message);               
            }
            finally
            {
                Console.WriteLine("Конец");             
            }
        }

        //Убийство процесса
        private void Kill()
        {
            foreach (Process item in this.processes)
            {
                item.Kill();
            }
        }
    }
}
