using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{


    public class Calculator : IAddition
    {
        
        ILogger Logger { get; }
        // Конструктор класса
        public Calculator(ILogger logger) { Logger = logger; }

        // Реализация интерфейса
        public void Addition(string value1, string value2)
        {

            try
            {
                var number1 = Double.Parse(value1);
                var number2 = Double.Parse(value2);
                var anser = (number1 + number2);
                Logger.Anser(anser);
            }
            // Обработка некорректного введенного значения
            catch (FormatException ex)
            {
                Logger.Error("Значение должно содержать только цифры!\nЗнаение не должно быть пустым!\nВ качестве разделителя следует использовать ,!");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }


        }
    }
}
