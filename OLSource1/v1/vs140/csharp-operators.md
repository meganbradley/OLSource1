---
title: "C# Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cs.operators"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "boolean operators [C#]"
  - "expressions [C#], operators"
  - "logical operators [C#]"
  - "operators [C#]"
  - "Visual C#, operators"
  - "indirection operators [C#]"
  - "assignment operators [C#]"
  - "shift operators [C#]"
  - "relational operators [C#]"
  - "bitwise operators [C#]"
  - "address operators [C#]"
  - "keywords [C#], operators"
  - "arithmetic operators [C#]"
ms.assetid: 0301e31f-22ad-49af-ac3c-d5eae7f0ac43
caps.latest.revision: 42
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C# Operators
C# provides many operators, which are symbols that specify which operations (math, indexing, function call, etc.) to perform in an expression.  You can [overload](../vs140/overloadable-operators--csharp-programming-guide-.md) many operators to change their meaning when applied to a user-defined type.  
  
 Operations on integral types (such as `==`, `!=`, `<`, `>`, `&`, `|`) are generally allowed on enumeration (`enum`) types.  
  
 The sections lists the C# operators starting with the highest precedence to the lowest.  The operators within each section share the same precedence level.  
  
## Primary Operators  
 These are the highest precedence operators.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [x.y](../vs140/.-operator--csharp-reference-.md) – member access.  
  
 [x?.y](../vs140/null-conditional-operators--csharp-and-visual-basic-.md) – null conditional member access.  Returns null if the left hand operand is null.  
  
 [f(x)](../vs140/---operator--csharp-reference-.md) – function invocation.  
  
 [a&#91;x&#93;](../vs140/operator--csharp-reference-1.md) – aggregate object indexing.  
  
 [a?&#91;x&#93;](../vs140/null-conditional-operators--csharp-and-visual-basic-.md) – null conditional indexing.  Returns null if the left hand operand is null.  
  
 [x++](../vs140/---operator--csharp-reference-.md) – postfix increment.  Returns the value of x and then updates the storage location with the value of x that is one greater (typically adds the integer 1).  
  
 [x--](../vs140/---operator--csharp-reference-.md) –  postfix decrement.  Returns the value of x and then updates the storage location with the value of x that is one less (typically subtracts the integer 1).  
  
 [New](../vs140/new-operator--csharp-reference-.md) – type instantiation.  
  
 [Typeof](../vs140/typeof--csharp-reference-.md) – returns the System.Type object representing the operand.  
  
 [Checked](../vs140/checked--csharp-reference-.md) – enables overflow checking for integer operations.  
  
 [Unchecked](../vs140/unchecked--csharp-reference-.md) – disables overflow checking for integer operations.  This is the default compiler behavior.  
  
 [default(T)](../vs140/default-keyword-in-generic-code--csharp-programming-guide-.md) – returns the default initialized value of type T, null for reference types, zero for numeric types, and zero/null filled in members for struct types.  
  
 [Delegate](../vs140/anonymous-methods--csharp-programming-guide-.md) – declares and returns a delegate instance.  
  
 [Sizeof](../vs140/sizeof--csharp-reference-.md) – returns the size in bytes of the type operand.  
  
 [->](../vs140/---operator--csharp-reference-.md) – pointer dereferencing combined with member access.  
  
## Unary Operators  
 These operators have higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [+x](../vs140/--operator--csharp-reference-.md) – returns the value of x.  
  
 [-x](../vs140/--operator--csharp-reference-2.md) – numeric negation.  
  
 [!x](../vs140/!-operator--csharp-reference-.md) – logical negation.  
  
 [~x](../vs140/~-operator--csharp-reference-.md) – bitwise complement.  
  
 [++x](../vs140/---operator--csharp-reference-.md) – prefix increment.  Returns the value of x after updating the storage location with the value of x that is one greater (typically adds the integer 1).  
  
 [--x](../vs140/---operator--csharp-reference-.md) – prefix decrement.  Returns the value of x after updating the storage location with the value of x that is one less (typically adds the integer 1).  
  
 [(T)x](../vs140/---operator--csharp-reference-.md) – type casting.  
  
 [Await](../vs140/await--csharp-reference-.md) – awaits a `Task`.  
  
 [&x](../vs140/--operator--csharp-reference-.md) – address of.  
  
 [*x](../vs140/--operator--csharp-reference-.md) – dereferencing.  
  
## Multiplicative Operators  
 These operators have higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [x * y](../vs140/--operator--csharp-reference-.md) – multiplication.  
  
 [x / y](../vs140/--operator--csharp-reference-1.md) – division.  If the operands are integers, the result is an integer truncated toward zero (for example, `-7 / 2 is -3`).  
  
 [x % y](../vs140/--operator--csharp-reference-.md) – modulus.  If the operands are integers, this returns the remainder of dividing x by y.  If `q = x / y` and `r = x % y`, then `x = q * y + r`.  
  
## Additive Operators  
 These operators have higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [x + y](../vs140/--operator--csharp-reference-.md) – addition.  
  
 [x – y](../vs140/--operator--csharp-reference-2.md) – subtraction.  
  
## Shift Operators  
 These operators have higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [x <<  y](../vs140/---operator--csharp-reference-.md) – shift bits left and fill with zero on the right.  
  
 [x >> y](../vs140/---operator--csharp-reference-.md) – shift bits right.  If the left operand is `int` or `long`, then left bits are filled with the sign bit.  If the left operand is `uint` or `ulong`, then left bits are filled with zero.  
  
## Relational and Type-testing Operators  
 These operators have higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [x < y](../vs140/--operator--csharp-reference-.md) – less than (true if x is less than y).  
  
 [x > y](../vs140/--operator--csharp-reference-.md) – greater than (true if x is greater than y).  
  
 [x <= y](../vs140/-=-operator--csharp-reference-.md) – less than or equal to.  
  
 [x >= y](../vs140/-=-operator--csharp-reference-.md) – greater than or equal to.  
  
 [Is](../vs140/is--csharp-reference-.md) – type compatibility.  Returns true if the evaluated left operand can be cast to the type specified in the right operand (a static type).  
  
 [As](../vs140/as--csharp-reference-.md) – type conversion.  Returns the left operand cast to the type specified by the right operand (a static type), but `as` returns `null` where `(T)x` would throw an exception.  
  
## Equality Operators  
 These operators have higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [x == y](../vs140/==-operator--csharp-reference-.md) – equality.  By default, for reference types other than `string`, this returns reference equality (identity test).  However, types can overload `==`, so if your intent is to test identity, it is best to use the `ReferenceEquals` method on `object`.  
  
 [x != y](../vs140/!=-operator--csharp-reference-.md) – not equal.  See comment for `==`.  If a type overloads `==`, then it must overload `!=`.  
  
## Logical AND Operator  
 This operator has higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operator to go the details page with examples.  
  
 [x & y](../vs140/--operator--csharp-reference-.md) – logical or bitwise AND.  Use with integer types and `enum` types is generally allowed.  
  
## Logical XOR Operator  
 This operator has higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operator to go the details page with examples.  
  
 [x ^ y](../vs140/^-operator--csharp-reference-.md) – logical or bitwise XOR.  You can generally use this with integer types and `enum` types.  
  
## Logical OR Operator  
 This operator has higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operator to go the details page with examples.  
  
 [x &#124; y](../vs140/--operator--csharp-reference-.md) – logical or bitwise OR.  Use with integer types and `enum` types is generally allowed.  
  
## Conditional AND Operator  
 This operator has higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operator to go the details page with examples.  
  
 [x && y](../vs140/---operator--csharp-reference-.md) – logical AND.  If the first operand is false, then C# does not evaluate the second operand.  
  
## Conditional OR Operator  
 This operator has higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operator to go the details page with examples.  
  
 [x &#124;&#124; y](../vs140/---operator--csharp-reference-.md) – logical OR.  If the first operand is true, then C# does not evaluate the second operand.  
  
## Null-coalescing Operator  
 This operator has higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operator to go the details page with examples.  
  
 [x ?? y](../vs140/---operator--csharp-reference-.md) – returns `x` if it is non-`null`; otherwise, returns `y`.  
  
## Conditional Operator  
 This operator has higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operator to go the details page with examples.  
  
 [t ? x : y](../vs140/---operator--csharp-reference-.md) – if test `t` is true, then evaluate and return `x`; otherwise, evaluate and return `y`.  
  
## Assignment and Lambda Operators  
 These operators have higher precedence than the next section and lower precedence than the previous section.  NOTE, you can click on the operators to go the detailed pages with examples.  
  
 [x = y](../vs140/=-operator--csharp-reference-.md) – assignment.  
  
 [x += y](../vs140/-=-operator--csharp-reference-.md) – increment.  Add the value of `y` to the value of `x`, store the result in `x`, and return the new value.  If `x` designates an `event`, then `y` must be an appropriate function that C# adds as an event handler.  
  
 [x -= y](../vs140/-=-operator--csharp-reference-2.md) – decrement.  Subtract the value of `y` from the value of `x`, store the result in `x`, and return the new value.  If `x` designates an `event`, then `y` must be an appropriate function that C# removes as an event handler  
  
 [x *= y](../vs140/-=-operator--csharp-reference-.md) – multiplication assignment.  Multiply the value of `y` to the value of `x`, store the result in `x`, and return the new value.  
  
 [x /= y](../vs140/-=-operator--csharp-reference-1.md) – division assignment.  Divide the value of `x` by the value of `y`, store the result in `x`, and return the new value.  
  
 [x %= y](../vs140/-=-operator--csharp-reference-.md) – modulus assignment.  Divide the value of `x` by the value of `y`, store the remainder in `x`, and return the new value.  
  
 [x &= y](../vs140/-=-operator--csharp-reference-.md) – AND assignment.  AND the value of `y` with the value of `x`, store the result in `x`, and return the new value.  
  
 [x &#124;= y](../vs140/-=-operator--csharp-reference-.md) – OR assignment.  OR the value of `y` with the value of `x`, store the result in `x`, and return the new value.  
  
 [x ^= y](../vs140/^=-operator--csharp-reference-.md) – XOR assignment.  XOR the value of `y` with the value of `x`, store the result in `x`, and return the new value.  
  
 [x <<= y](../vs140/--=-operator--csharp-reference-.md) – left-shift assignment.  Shift the value of `x` left by `y` places, store the result in `x`, and return the new value.  
  
 [x >>= y](../vs140/--=-operator--csharp-reference-.md) – right-shift assignment.  Shift the value of `x` right by `y` places, store the result in `x`, and return the new value.  
  
 [=>](../vs140/=--operator--csharp-reference-.md) – lambda declaration.  
  
## Arithmetic Overflow  
 The arithmetic operators ([+](../vs140/--operator--csharp-reference-.md), [-](../vs140/--operator--csharp-reference-2.md), [*](../vs140/--operator--csharp-reference-.md), [/](../vs140/--operator--csharp-reference-1.md)) can produce results that are outside the range of possible values for the numeric type involved. You should refer to the section on a particular operator for details, but in general:  
  
-   Integer arithmetic overflow either throws an <xref:System.OverflowException*> or discards the most significant bits of the result. Integer division by zero always throws a `DivideByZeroException`.  
  
-   Floating-point arithmetic overflow or division by zero never throws an exception, because floating-point types are based on IEEE 754 and so have provisions for representing infinity and NaN (Not a Number).  
  
-   [Decimal](../vs140/decimal--csharp-reference-.md) arithmetic overflow always throws an <xref:System.OverflowException*>. Decimal division by zero always throws a <xref:System.DivideByZeroException*>.  
  
 When integer overflow occurs, what happens depends on the execution context, which can be [checked or unchecked](../vs140/checked-and-unchecked--csharp-reference-.md). In a checked context, an <xref:System.OverflowException*> is thrown. In an unchecked context, the most significant bits of the result are discarded and execution continues. Thus, C# gives you the choice of handling or ignoring overflow.  
  
 In addition to the arithmetic operators, integral-type to integral-type casts can cause overflow, for example, casting a [long](../vs140/long--csharp-reference-.md) to an [int](../vs140/int--csharp-reference-.md), and are subject to checked or unchecked execution. However, bitwise operators and shift operators never cause overflow.  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Visual C#](../vs140/csharp.md)   
 [Overloadable Operators](../vs140/overloadable-operators--csharp-programming-guide-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)