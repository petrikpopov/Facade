using System;

namespace Facade_27._03._2023
{

    class Program
    {
        public class Vidocard
        {
            public void Start_WD()
            {
                Console.WriteLine("Запуск видеокарты!!");
            }
            public void Start_Checking_Monitor()
            {
                Console.WriteLine("Проверка связи с монитором.");
            }
            public void Start_RAM_data_output()
            {
                Console.WriteLine("Вывод данных об оперативной памяти.");
            }
            public void Start_display_information_about_drive()
            {
                Console.WriteLine("Вывод информации об устройстве чтения дисков");
            }
            public void Start_dataoutput_about_drive()
            {
                Console.WriteLine("Вывод данных о винчестере.");
            }
            public void End_display_message_monitor()
            {
                Console.WriteLine("Вывод на монитор прощальное сообщение");
            }
           
        }
        public class OC
        {
            public void Start_OC()
            {
                Console.WriteLine("Запуск устройства");
            }
            public void Start_Analiz_OC()
            {
                Console.WriteLine("Aнализ памяти");
            }
            public void END_Clien_OC()
            {
                Console.WriteLine("Oчистка памяти");
            }
            public void End_Analiz_OC()
            {
                Console.WriteLine("Aнализ памяти");
            }
        }
        public class Vinchester
        {
            public void Start_Vinchester()
            {
                Console.WriteLine("Запуск");
            }
            public void Start_sector_check()
            {
                Console.WriteLine("Проверка загрузочного сектора.");
            }
            public void End_Vin()
            {
                Console.WriteLine("Oстановка устройства");
            }
        }
        public class Read_Disk
        {
            public void Start_Disk()
            {
                Console.WriteLine("Запуск");
            }
            public void Strat_check_disk_availability()
            {
                Console.WriteLine("Проверка наличия диска.");
            }
            public void End_return_original_position()
            {
                Console.WriteLine("Возврат в исходную позицию диска");
            }
        }
        public class Bloc_Pit
        {
            public void Start_Pitenie()
            {
                Console.WriteLine("Подача питания");

            }
            public void Strat_power_video_card()
            {
                Console.WriteLine("Подача питания на видеокарту");
            }
            public void Start_power_OC()
            {
                Console.WriteLine("Подача питания на оперативную память");
            }
            public void Start_power_ReadDisk()
            {
                Console.WriteLine("Подача питания на устройство чтения дисков.");

            }
            public void Start_power_vinchester()
            {
                Console.WriteLine("Подача питания на винчестер.");
            }
            public void End_power_VD()
            {
                Console.WriteLine("Прекратить питание видео карты.");
            }
            public void End_power_OC()
            {
                Console.WriteLine("Прекратить питание оперативной памяти");
            }
            public void End_power_readDisk()
            {
                Console.WriteLine("Прекратить питание устройства чтения дисков");
            }
            public void End_power_Vinchester()
            {
                Console.WriteLine("Прекратить питание винчестера");
            }
            public void End_shutdown_BP()
            {
                Console.WriteLine("Выключение");
            }
        }
        public class Datchik
        {
            public void Start_Checkpower()
            {
                Console.WriteLine("Проверка напряжения");
            }
            public void Strat_Check_Temp_in_BP()
            {
                Console.WriteLine("Проверка температуры в блоке питания.");
            }
            public void Start_Check_Temp_in_VD()
            {
                Console.WriteLine("Проверка температуры в видеокарте.");
            }
            public void Start_Check_Temp_in_OC()
            {
                Console.WriteLine("Проверка температуры в OC.");
            }
            public void Start_Check_Temp_in_All_System()
            {
                Console.WriteLine("Проверка температуры всех систем.");
            }
            public void End_Check_Power()
            {
                Console.WriteLine("Проверка напряжения");
            }
        }
        public class Compucter
        {
            public Vidocard vidocard { set; get; }
            public OC oC { set; get; }
            public Vinchester vinchester { set; get; }
            public Read_Disk read {set; get;}
            public Bloc_Pit bloc { set; get; }
            public Datchik datchik { set; get; }

            public Compucter(Vidocard v, OC o, Vinchester V, Read_Disk r, Bloc_Pit BP, Datchik D)
            {
                vidocard = v;
                oC = o;
                vinchester = V;
                read = r;
                bloc = BP;
                datchik = D;

            }

            public void Start_Work()
            {
                bloc.Start_Pitenie();
                datchik.Start_Checkpower();
                datchik.Strat_Check_Temp_in_BP();
                datchik.Start_Check_Temp_in_VD();
                bloc.Strat_power_video_card();
                vidocard.Start_WD();
                vidocard.Start_Checking_Monitor();
                datchik.Start_Check_Temp_in_OC();
                bloc.Start_power_OC();
                oC.Start_OC();
                oC.Start_Analiz_OC();
                vidocard.Start_RAM_data_output();
                bloc.Start_power_ReadDisk();
                read.Start_Disk();
                read.Strat_check_disk_availability();
                vidocard.Start_display_information_about_drive();
                bloc.Start_power_vinchester();
                vinchester.Start_Vinchester();
                vinchester.Start_sector_check();
                vidocard.Start_dataoutput_about_drive();
                datchik.Start_Check_Temp_in_All_System();
            }
            public void End_Work()
            {
                vinchester.End_Vin();
                oC.END_Clien_OC();
                oC.End_Analiz_OC();
                vidocard.End_display_message_monitor();
                read.End_return_original_position();
                bloc.End_power_VD();
                bloc.End_power_OC();
                bloc.End_power_readDisk();
                bloc.End_power_Vinchester();
                datchik.End_Check_Power();
                bloc.End_shutdown_BP();
            }
        }
        public class Create
        {
            public void CreateApplication(Compucter compucter)
            {
                compucter.Start_Work();
                compucter.End_Work();
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Vidocard vidocard = new Vidocard();
            OC oC = new OC();
            Vinchester vinchester = new Vinchester();
            Read_Disk read = new Read_Disk();
            Bloc_Pit bloc = new Bloc_Pit();
            Datchik datchik = new Datchik();

            Compucter compucter = new Compucter(vidocard,oC,vinchester,read,bloc,datchik);
            Create create = new Create();
            create.CreateApplication(compucter);
        }
    }
}
