﻿/*Вам предстоит разработать систему управления умным домом, 
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
