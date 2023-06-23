/*Вам предстоит разработать систему управления умным домом, 
 * которая должна реагировать на различные события в доме и выполнять соответствующие действия. 
 * В доме есть различные устройства, такие как датчики движения, термостаты, светильники и т. д.

Ваша задача состоит в следующем:

Создайте классы для каждого типа устройства в доме. 
Например, классы MotionSensor, Thermostat, Light и т. д. 
Каждый класс должен иметь свои свойства и методы, относящиеся к данному типу устройства.

Создайте событие с именем MotionDetectedEvent, которое будет генерироваться при 
обнаружении движения с помощью датчика движения. Событие должно предоставлять информацию о 
местоположении, времени и других деталях, связанных с обнаруженным движением.

В классе SmartHomeSystem создайте метод RegisterMotionSensor, который будет принимать в качестве параметра 
объект типа MotionSensor и регистрировать его в системе.

Создайте метод HandleMotionDetected, который будет вызываться при возникновении события MotionDetectedEvent. 
Этот метод должен принимать параметр типа EventArgs или наследника от EventArgs 
и выполнять соответствующие действия, например, включать свет или записывать видео.

В классе SmartHomeSystem создайте метод StartMonitoring, который будет запускать мониторинг движения. 
Этот метод должен включать все зарегистрированные датчики движения 
и обрабатывать событие MotionDetectedEvent, вызывая метод HandleMotionDetected.

Реализуйте метод Main, в котором создайте объект класса SmartHomeSystem, зарегистрируйте 
несколько объектов MotionSensor с помощью метода RegisterMotionSensor и запустите мониторинг 
с помощью метода StartMonitoring.*/

/*Вам предстоит разработать систему управления умным домом, 
 * которая должна реагировать на различные события в доме и выполнять соответствующие действия. 
 * В доме есть различные устройства, такие как датчики движения, термостаты, светильники и т. д.

Ваша задача состоит в следующем:

Создайте классы для каждого типа устройства в доме. 
Например, классы MotionSensor, Thermostat, Light и т. д. 
Каждый класс должен иметь свои свойства и методы, относящиеся к данному типу устройства.

Создайте событие с именем MotionDetectedEvent, которое будет генерироваться при 
обнаружении движения с помощью датчика движения. Событие должно предоставлять информацию о 
местоположении, времени и других деталях, связанных с обнаруженным движением.

В классе SmartHomeSystem создайте метод RegisterMotionSensor, который будет принимать в качестве параметра 
объект типа MotionSensor и регистрировать его в системе.

Создайте метод HandleMotionDetected, который будет вызываться при возникновении события MotionDetectedEvent. 
Этот метод должен принимать параметр типа EventArgs или наследника от EventArgs 
и выполнять соответствующие действия, например, включать свет или записывать видео.

В классе SmartHomeSystem создайте метод StartMonitoring, который будет запускать мониторинг движения. 
Этот метод должен включать все зарегистрированные датчики движения 
и обрабатывать событие MotionDetectedEvent, вызывая метод HandleMotionDetected.

Реализуйте метод Main, в котором создайте объект класса SmartHomeSystem, зарегистрируйте 
несколько объектов MotionSensor с помощью метода RegisterMotionSensor и запустите мониторинг 
с помощью метода StartMonitoring.*/


void Main()
{
    SmartHomeSystem smartHomeSystem = new SmartHomeSystem();


    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("\t\t\t     Проверка датчиков движения");
        Console.WriteLine("\t\t\t            Коридор - 1");
        Console.WriteLine("\t\t\t            Гостинная - 2");
        Console.WriteLine("\t\t\t            Кухня - 3");
        Console.WriteLine("\t\t\t            Ванная - 4");
        Console.WriteLine("\t\t\t            Спальня - 5");
        Console.WriteLine("\t\t\t            Детская - 6");
        Console.WriteLine("\t\t\t            Гараж - 7");
        Console.WriteLine("\t\t\t       Выход из программы - 8");
        Console.WriteLine();
        Console.Write("\t\t\tВыберите комнату для проверки датчика: ");
        Console.WriteLine();

        int key;

        while (!int.TryParse(Console.ReadLine(), out key))
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t     Проверка датчиков движения");
            Console.WriteLine("\t\t\t            Коридор - 1");
            Console.WriteLine("\t\t\t            Гостинная - 2");
            Console.WriteLine("\t\t\t            Кухня - 3");
            Console.WriteLine("\t\t\t            Ванная - 4");
            Console.WriteLine("\t\t\t            Спальня - 5");
            Console.WriteLine("\t\t\t            Детская - 6");
            Console.WriteLine("\t\t\t            Гараж - 7");
            Console.WriteLine("\t\t\t       Выход из программы - 8");
            Console.WriteLine();
            Console.Write("\t\t\tВыберите комнату для проверки датчика: ");
            Console.WriteLine();
        }

        if (key == 1)
        {
            smartHomeSystem.motionSensors.Clear();
            Console.WriteLine();
            Console.Write("\t\t\tВведите значение температуры для комнаты: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("\t\t\tВыберите яркость освещения: ");
            Console.WriteLine("\t\t\t     Слабая - 1");
            Console.WriteLine("\t\t\t     Обычная - 2");
            Console.WriteLine("\t\t\t     Большая - 3");
            Console.WriteLine();


            int key_two;
            while (!int.TryParse(Console.ReadLine(), out key_two))
            {
                Console.WriteLine();
                Console.Write("\t\t\tВведите значение температуры для комнаты: ");
                temperature = Console.ReadLine();
                Console.WriteLine("\t\t\tВыберите яркость освещения: ");
                Console.WriteLine("\t\t\t     Слабая - 1");
                Console.WriteLine("\t\t\t     Обычная - 2");
                Console.WriteLine("\t\t\t     Большая - 3");
                Console.WriteLine();
            }

            if (key_two == 1)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Коридор");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("слабая");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 2)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Коридор");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("обычная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 3)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Коридор");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("сильная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }


        }

        if (key == 2)
        {
            smartHomeSystem.motionSensors.Clear();
            Console.WriteLine();
            Console.Write("\t\t\tВведите значение температуры для комнаты: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("\t\t\tВыберите яркость освещения: ");
            Console.WriteLine("\t\t\t     Слабая - 1");
            Console.WriteLine("\t\t\t     Обычная - 2");
            Console.WriteLine("\t\t\t     Большая - 3");
            Console.WriteLine();


            int key_two;
            while (!int.TryParse(Console.ReadLine(), out key_two))
            {
                Console.WriteLine();
                Console.Write("\t\t\tВведите значение температуры для комнаты: ");
                temperature = Console.ReadLine();
                Console.WriteLine("\t\t\tВыберите яркость освещения: ");
                Console.WriteLine("\t\t\t     Слабая - 1");
                Console.WriteLine("\t\t\t     Обычная - 2");
                Console.WriteLine("\t\t\t     Большая - 3");
                Console.WriteLine();
            }

            if (key_two == 1)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Гостинная");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("слабая");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 2)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Гостинная");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("обычная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 3)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Гостинная");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("сильная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

        }

        if (key == 3)
        {
            smartHomeSystem.motionSensors.Clear();
            Console.WriteLine();
            Console.Write("\t\t\tВведите значение температуры для комнаты: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("\t\t\tВыберите яркость освещения: ");
            Console.WriteLine("\t\t\t     Слабая - 1");
            Console.WriteLine("\t\t\t     Обычная - 2");
            Console.WriteLine("\t\t\t     Большая - 3");
            Console.WriteLine();


            int key_two;
            while (!int.TryParse(Console.ReadLine(), out key_two))
            {
                Console.WriteLine();
                Console.Write("\t\t\tВведите значение температуры для комнаты: ");
                temperature = Console.ReadLine();
                Console.WriteLine("\t\t\tВыберите яркость освещения: ");
                Console.WriteLine("\t\t\t     Слабая - 1");
                Console.WriteLine("\t\t\t     Обычная - 2");
                Console.WriteLine("\t\t\t     Большая - 3");
                Console.WriteLine();
            }

            if (key_two == 1)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Кухня");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("слабая");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 2)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Кухня");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("обычная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 3)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Кухня");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("сильная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

        }

        if (key == 4)
        {
            smartHomeSystem.motionSensors.Clear();
            Console.WriteLine();
            Console.Write("\t\t\tВведите значение температуры для комнаты: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("\t\t\tВыберите яркость освещения: ");
            Console.WriteLine("\t\t\t     Слабая - 1");
            Console.WriteLine("\t\t\t     Обычная - 2");
            Console.WriteLine("\t\t\t     Большая - 3");
            Console.WriteLine();


            int key_two;
            while (!int.TryParse(Console.ReadLine(), out key_two))
            {
                Console.WriteLine();
                Console.Write("\t\t\tВведите значение температуры для комнаты: ");
                temperature = Console.ReadLine();
                Console.WriteLine("\t\t\tВыберите яркость освещения: ");
                Console.WriteLine("\t\t\t     Слабая - 1");
                Console.WriteLine("\t\t\t     Обычная - 2");
                Console.WriteLine("\t\t\t     Большая - 3");
                Console.WriteLine();
            }

            if (key_two == 1)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Ванная");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("слабая");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 2)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Ванная");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("обычная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 3)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Ванная");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("сильная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

        }

        if (key == 5)
        {
            smartHomeSystem.motionSensors.Clear();
            Console.WriteLine();
            Console.Write("\t\t\tВведите значение температуры для комнаты: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("\t\t\tВыберите яркость освещения: ");
            Console.WriteLine("\t\t\t     Слабая - 1");
            Console.WriteLine("\t\t\t     Обычная - 2");
            Console.WriteLine("\t\t\t     Большая - 3");
            Console.WriteLine();


            int key_two;
            while (!int.TryParse(Console.ReadLine(), out key_two))
            {
                Console.WriteLine();
                Console.Write("\t\t\tВведите значение температуры для комнаты: ");
                temperature = Console.ReadLine();
                Console.WriteLine("\t\t\tВыберите яркость освещения: ");
                Console.WriteLine("\t\t\t     Слабая - 1");
                Console.WriteLine("\t\t\t     Обычная - 2");
                Console.WriteLine("\t\t\t     Большая - 3");
                Console.WriteLine();
            }

            if (key_two == 1)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Спальня");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("слабая");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 2)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Спальня");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("обычная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 3)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Спальня");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("сильная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

        }

        if (key == 6)
        {
            smartHomeSystem.motionSensors.Clear();
            Console.WriteLine();
            Console.Write("\t\t\tВведите значение температуры для комнаты: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("\t\t\tВыберите яркость освещения: ");
            Console.WriteLine("\t\t\t     Слабая - 1");
            Console.WriteLine("\t\t\t     Обычная - 2");
            Console.WriteLine("\t\t\t     Большая - 3");
            Console.WriteLine();


            int key_two;
            while (!int.TryParse(Console.ReadLine(), out key_two))
            {
                Console.WriteLine();
                Console.Write("\t\t\tВведите значение температуры для комнаты: ");
                temperature = Console.ReadLine();
                Console.WriteLine("\t\t\tВыберите яркость освещения: ");
                Console.WriteLine("\t\t\t     Слабая - 1");
                Console.WriteLine("\t\t\t     Обычная - 2");
                Console.WriteLine("\t\t\t     Большая - 3");
                Console.WriteLine();
            }

            if (key_two == 1)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Детская");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("слабая");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 2)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Детская");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("обычная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 3)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Детская");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("сильная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

        }

        if (key == 7)
        {
            smartHomeSystem.motionSensors.Clear();
            Console.WriteLine();
            Console.Write("\t\t\tВведите значение температуры для комнаты: ");
            string temperature = Console.ReadLine();
            Console.WriteLine("\t\t\tВыберите яркость освещения: ");
            Console.WriteLine("\t\t\t     Слабая - 1");
            Console.WriteLine("\t\t\t     Обычная - 2");
            Console.WriteLine("\t\t\t     Большая - 3");
            Console.WriteLine();


            int key_two;
            while (!int.TryParse(Console.ReadLine(), out key_two))
            {
                Console.WriteLine();
                Console.Write("\t\t\tВведите значение температуры для комнаты: ");
                temperature = Console.ReadLine();
                Console.WriteLine("\t\t\tВыберите яркость освещения: ");
                Console.WriteLine("\t\t\t     Слабая - 1");
                Console.WriteLine("\t\t\t     Обычная - 2");
                Console.WriteLine("\t\t\t     Большая - 3");
                Console.WriteLine();
            }

            if (key_two == 1)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Гараж");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("слабая");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 2)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Гараж");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("обычная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }

            if (key_two == 3)
            {
                Console.WriteLine();
                MotionSensor motion_sensor = new MotionSensor("Гараж");
                smartHomeSystem.RegisterMotionSensor(motion_sensor);
                smartHomeSystem.StartMonitoring();
                Termostat termostat = new Termostat(temperature);
                Ligth ligth = new Ligth("сильная");
                termostat.TermostatInfo();
                ligth.LigthInfo();
                Console.WriteLine();
            }
        }

        if (key == 8)
        {
            Console.WriteLine("\t\t\tВыполняется выход...");
            Environment.Exit(0);
        }
    }

}

Main();


abstract class Device
{
    public string Name { get; set; }

    public Device(string name)
    {
        Name = name;
    }
}

class MotionSensor : Device
{
    public event EventHandler<MotionDetectedEventArgs> MotionDetectedEvent;

    public MotionSensor(string name) : base(name)
    {

    }

    public void DetectedMotion()
    {
        OnMotionDetected(new MotionDetectedEventArgs(Name, DateTime.Now));
    }

    protected virtual void OnMotionDetected(MotionDetectedEventArgs e)
    {
        MotionDetectedEvent?.Invoke(this, e);
    }
}

class MotionDetectedEventArgs : EventArgs
{
    public string Location { get; }
    public DateTime Time { get; }

    public MotionDetectedEventArgs(string location, DateTime time)
    {
        Location = location;
        Time = time;
    }
}



class Termostat
{
    public string Temperature { get; }

    public Termostat(string temperature)
    {
        Temperature = temperature;
    }

    public void TermostatInfo()
    {

        Console.WriteLine($"\t\t\tТермостат активиорван. Текущая температура: {Temperature}");

    }

}

class Ligth
{
    public string Ligth_Level { get; }

    public Ligth(string ligth_level)
    {
        Ligth_Level = ligth_level;
    }
    public void LigthInfo()
    {

        Console.WriteLine("\t\t\tОсвещение комнаты активировано.");
        Console.WriteLine($"\t\t\tУровень яркости: {Ligth_Level}");

    }
}


class SmartHomeSystem
{
    public List<MotionSensor> motionSensors = new List<MotionSensor>();
    public void RegisterMotionSensor(MotionSensor motionSensor)
    {
        motionSensors.Add(motionSensor);
    }

    public void HandleMotionDetected(object sender, MotionDetectedEventArgs motion)
    {

        Console.WriteLine($"\t\t\tДатчик обнаружил движение. Время: {motion.Time}. Место: {motion.Location}");


    }

    public void StartMonitoring()
    {
        foreach (var motionSensor in motionSensors)
        {
            motionSensor.MotionDetectedEvent += HandleMotionDetected;
        }

        foreach (var motionSensor in motionSensors)
        {
            motionSensor.DetectedMotion();
        }
    }
}




