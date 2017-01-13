using System;

namespace MSTest_tests_example.Mocks.Date
{   
    public class ImageManagement
    {
        IFecha fecha;
        public ImageManagement(IFecha fecha)
        {
            this.fecha = fecha;
        }

        public string GetImageForTimeOfDay()
        {
            int currentHour = this.fecha.getFecha();

            if (currentHour > 6 && currentHour < 21)
                return "sun.jpg";
            else
                return "moon.jpg";
        }
    }
}
