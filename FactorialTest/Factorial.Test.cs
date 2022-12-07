using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace FactorialTest
{
    public class Factorial
    {


        [Fact]
        public void CalcularFactorialCero()
        {
            //Arrange 
            factorialservices servicios = new factorialservices();

            //Act 
            int result = servicios.calcularFactorial(0);
            

            //Assert
            Assert.Equal(1,result);


        }


        [Fact]
        public void CalcularFactorialFive()
        {
            factorialservices services = new factorialservices();

            int result = services.calcularFactorial(5);

            Assert.Equal(120,result);


        }
    }
}
