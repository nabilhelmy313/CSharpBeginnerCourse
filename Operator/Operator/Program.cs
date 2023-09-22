/*

+(Addition): Adds two operands.
- (Subtraction): Subtracts the right operand from the left operand.
* (Multiplication): Multiplies two operands.
/ (Division): Divides the left operand by the right operand.
% (Modulus): Returns the remainder of the division of the left operand by the right 

*/

int a = 10;
int b = 5;
int sum = a + b; // result is 15
int sub = a - b; // result is 15
int multi = a * b; // result is 15
int div = a / b; // result is 15
int mod = a % b; // result is 15
Console.WriteLine($"sum {a} + {b} = {sum}");
Console.WriteLine($"sub {a} - {b} = {sub}");
Console.WriteLine($"multi {a} x {b} = {multi}");
Console.WriteLine($"div {a} / {b} = {div}");
Console.WriteLine($"mod {a} % {b} = {mod}");
/*
 == (Equality): Compares if two operands are equal.
!= (Inequality): Compares if two operands are not equal.
< (Less than): Checks if the left operand is less than the right operand.
> (Greater than): Checks if the left operand is greater than the right operand.
<= (Less than or equal to): Checks if the left operand is less than or equal to the right operand.
>= (Greater than or equal to): Checks if the left operand is greater than or equal to the right operand.
*/
int x = 10;
int y = 5;
bool isEqual = x == y; // isEqual is false
Console.WriteLine($"is equal {isEqual}");
/*
 && (Logical AND): Returns true if both operands are true.
|| (Logical OR): Returns true if at least one of the operands is true.
! (Logical NOT): Returns the opposite of the operand's value.
 */
bool isTrue = true;
bool isFalse = false;
bool boolResult= isTrue && isFalse; // result is false
Console.WriteLine($"is {boolResult}");

/*
 = (Assignment): Assigns the value of the right operand to the left operand.
+= (Addition Assignment): Adds the right operand to the left operand and assigns the result to the left operand.
-= (Subtraction Assignment): Subtracts the right operand from the left operand and assigns the result to the left operand.
*= (Multiplication Assignment): Multiplies the left operand by the right operand and assigns the result to the left operand.
/= (Division Assignment): Divides the left operand by the right operand and assigns the result to the left operand.
 */
int num = 10;
num += 5; // num is now 15
Console.WriteLine($"the Result is {num}");

Console.ReadKey();