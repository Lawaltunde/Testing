namespace Testing.MathLibTest;

using System.Data;
using Testing.MathLib;

[TestClass]
public class Calculator_Divide
{
    [TestMethod]
    public void calculator_Divide_Method_Receives_A_Number_And_One_Then_Returns_Number(){
        Calculator calculator = new Calculator();
        var ret = calculator.Divide(1, 1);
        Assert.AreEqual(1, ret);
    }

    [TestMethod]

    [DataRow(3,3,1)]
    [DataRow(2,2,1)]
    public void calculator_Divide_Method_Receives_Two_Of_Same_Number_And_Then_Returns_One(double left, double right, double expected){
        Calculator calculator = new Calculator();
        var ret = calculator.Divide((decimal)left, (decimal)right);
        //Assert.AreEqual(1, ret);
        Assert.AreEqual((decimal)expected, ret);
    }

    [TestMethod]
    public void calculator_Divide_Method_A_Number_And_Zero_Then_Return_Exception(){
        Calculator calculator = new Calculator();
        Assert.ThrowsException<DivideByZeroException>(()=> calculator.Divide(5,0));
    }
}