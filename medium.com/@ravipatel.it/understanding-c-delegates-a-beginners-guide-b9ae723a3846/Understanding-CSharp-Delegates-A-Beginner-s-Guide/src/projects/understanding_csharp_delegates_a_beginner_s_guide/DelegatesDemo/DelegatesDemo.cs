var firstOperand = 10;
var secondOperand = 20;
char binaryOperator = '-';

DelegateDemo.Computation addition = (int firstOperand, int secondOperand , char binaryOperator) => {
  return binaryOperator switch {
    '+' => firstOperand + secondOperand,
    '-' => firstOperand - secondOperand,
    '*' => firstOperand * secondOperand,
    '/' => firstOperand / secondOperand,
    '%' => firstOperand % secondOperand,
    _ => 0
  };
};

System.Console.WriteLine($"{Environment.NewLine}Applying the binary operator {binaryOperator} on operands {firstOperand} and {secondOperand} respectively results in {addition(firstOperand, secondOperand, binaryOperator)}");

namespace DelegateDemo
{
  delegate int Computation(int firstOperand, int secondOperand, char binaryOperator);
}
