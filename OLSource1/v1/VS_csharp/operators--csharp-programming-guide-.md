---
title: "Operators (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "operators [C#]"
  - "C# language, operators"
  - "operators [C#], about operators"
ms.assetid: 214e7b83-1a41-4f7c-9867-64e9c0bab39f
caps.latest.revision: 44
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators (C# Programming Guide)
In C#, an *operator* is a program element that is applied to one or more *operands* in an expression or statement. Operators that take one operand, such as the increment operator (`++`) or `new`, are referred to as *unary* operators. Operators that take two operands, such as arithmetic operators (`+`,`-`,`*`,`/`), are referred to as *binary* operators. One operator, the conditional operator (`?:`), takes three operands and is the sole ternary operator in C#.  
  
 The following C# statement contains a single unary operator and a single operand. The increment operator, `++`, modifies the value of the operand `y`.  
  
 [!code[csProgGuideStatements#5](../VS_csharp/codesnippet/CSharp/operators--csharp-programming-guide-_1.cs)]  
  
 The following C# statement contains two binary operators, each with two operands. The assignment operator, `=`, has the integer variable `y` and the expression `2 + 3` as operands. The expression `2 + 3` itself consists of the addition operator and two operands, `2` and `3`.  
  
 [!code[csProgGuideStatements#6](../VS_csharp/codesnippet/CSharp/operators--csharp-programming-guide-_2.cs)]  
  
## Operators, Evaluation, and Operator Precedence  
 An operand can be a valid expression that is composed of any length of code, and it can comprise any number of sub expressions. In an expression that contains multiple operators, the order in which the operators are applied is determined by *operator precedence*, *associativity*, and parentheses.  
  
 Each operator has a defined precedence. In an expression that contains multiple operators that have different precedence levels, the precedence of the operators determines the order in which the operators are evaluated. For example, the following statement assigns 3 to `n1`.  
  
 `n1 = 11 - 2 * 4;`  
  
 The multiplication is executed first because multiplication takes precedence over subtraction.  
  
 The following table separates the operators into categories based on the type of operation they perform. The categories are listed in order of precedence.  
  
 **Primary Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|x[.](../VS_csharp/.-operator--csharp-reference-.md)y<br /><br /> x?.y|Member access<br /><br /> Conditional member access|  
|f[(x)](../VS_csharp/---operator--csharp-reference-.md)|Method and delegate invocation|  
|a[&#91;x&#93;](../VS_csharp/operator--csharp-reference-1.md)<br /><br /> a?[x]|Array and indexer access<br /><br /> Conditional array and indexer access|  
|x[++](../VS_csharp/---operator--csharp-reference-.md)|Post-increment|  
|x[--](../VS_csharp/---operator--csharp-reference-.md)|Post-decrement|  
|[new](../VS_csharp/new-operator--csharp-reference-.md) T(...)|Object and delegate creation|  
|`new` T(...){...}|Object creation with initializer. See [Object and Collection Initializers (C# Programming Guide)](../VS_csharp/object-and-collection-initializers--csharp-programming-guide-.md).|  
|`new` {...}|Anonymous object initializer. See [Anonymous Types (C# Programming Guide)](../VS_csharp/anonymous-types--csharp-programming-guide-.md).|  
|`new` T[...]|Array creation. See [Arrays (C# Programming Guide)](../VS_csharp/arrays--csharp-programming-guide-.md).|  
|[typeof](../VS_csharp/typeof--csharp-reference-.md)(T)|Obtain System.Type object for T|  
|[checked](../VS_csharp/checked--csharp-reference-.md)(x)|Evaluate expression in checked context|  
|[unchecked](../VS_csharp/unchecked--csharp-reference-.md)(x)|Evaluate expression in unchecked context|  
|[default](../VS_csharp/default--csharp-reference-.md) (T)|Obtain default value of type T|  
|[delegate](../VS_csharp/delegate--csharp-reference-.md) {}|Anonymous function (anonymous method)|  
  
 **Unary Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|[+](../VS_csharp/--operator--csharp-reference-.md)x|Identity|  
|[-](../VS_csharp/--operator--csharp-reference-2.md)x|Negation|  
|[!](../VS_csharp/!-operator--csharp-reference-.md)x|Logical negation|  
|[~](../VS_csharp/~-operator--csharp-reference-.md)x|Bitwise negation|  
|[++](../VS_csharp/---operator--csharp-reference-.md)x|Pre-increment|  
|[--](../VS_csharp/---operator--csharp-reference-.md)x|Pre-decrement|  
|[(T)](../VS_csharp/---operator--csharp-reference-.md)x|Explicitly convert x to type T|  
  
 **Multiplicative Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|[*](../VS_csharp/--operator--csharp-reference-.md)|Multiplication|  
|[/](../VS_csharp/--operator--csharp-reference-1.md)|Division|  
|[%](../VS_csharp/--operator--csharp-reference-.md)|Remainder|  
  
 **Additive Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|x [+](../VS_csharp/--operator--csharp-reference-.md) y|Addition, string concatenation, delegate combination|  
|x [-](../VS_csharp/--operator--csharp-reference-2.md) y|Subtraction, delegate removal|  
  
 **Shift Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|x [<<](../VS_csharp/---operator--csharp-reference-.md) y|Shift left|  
|x [>>](../VS_csharp/---operator--csharp-reference-.md) y|Shift right|  
  
 **Relational and Type Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|x [<](../VS_csharp/--operator--csharp-reference-.md) y|Less than|  
|x [>](../VS_csharp/--operator--csharp-reference-.md) y|Greater than|  
|x [<=](../VS_csharp/-=-operator--csharp-reference-.md) y|Less than or equal|  
|x [>=](../VS_csharp/-=-operator--csharp-reference-.md) y|Greater than or equal|  
|x [is](../VS_csharp/is--csharp-reference-.md) T|Return true if x is a T, false otherwise|  
|x [as](../VS_csharp/as--csharp-reference-.md) T|Return x typed as T, or null if x is not a T|  
  
 **Equality Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|x [==](../VS_csharp/==-operator--csharp-reference-.md) y|Equal|  
|x [!=](../VS_csharp/!=-operator--csharp-reference-.md) y|Not equal|  
  
 **Logical, Conditional, and Null Operators**  
  
|Category|Expression|Description|  
|--------------|----------------|-----------------|  
|Logical AND|x [&](../VS_csharp/--operator--csharp-reference-.md) y|Integer bitwise AND, Boolean logical AND|  
|Logical XOR|x [^](../VS_csharp/^-operator--csharp-reference-.md) y|Integer bitwise XOR, boolean logical XOR|  
|Logical OR|x [&#124;](../VS_csharp/--operator--csharp-reference-.md) y|Integer bitwise OR, boolean logical OR|  
|Conditional AND|x [&&](../VS_csharp/---operator--csharp-reference-.md) y|Evaluates y only if x is true|  
|Conditional OR|x [&#124;&#124;](../VS_csharp/---operator--csharp-reference-.md) y|Evaluates y only if x is false|  
|Null coalescing|x [??](../VS_csharp/---operator--csharp-reference-.md) y|Evaluates to y if x is null, to x otherwise|  
|Conditional|x [?](../VS_csharp/---operator--csharp-reference-.md) y : z|Evaluates to y if x is true, z if x is false|  
  
 **Assignment and Anonymous Operators**  
  
|Expression|Description|  
|----------------|-----------------|  
|[=](../VS_csharp/=-operator--csharp-reference-.md)|Assignment|  
|x op= y|Compound assignment. Supports these operators: [+=](../VS_csharp/-=-operator--csharp-reference-.md), [-=](../VS_csharp/-=-operator--csharp-reference-2.md), [*=](../VS_csharp/-=-operator--csharp-reference-.md), [/=](../VS_csharp/-=-operator--csharp-reference-1.md), [%=](../VS_csharp/-=-operator--csharp-reference-.md), [&=](../VS_csharp/-=-operator--csharp-reference-.md), [&#124;=](../VS_csharp/-=-operator--csharp-reference-.md), [!=](../VS_csharp/!=-operator--csharp-reference-.md), [<<=](../VS_csharp/--=-operator--csharp-reference-.md), [>>=](../VS_csharp/--=-operator--csharp-reference-.md)|  
|(T x) [=>](../VS_csharp/=--operator--csharp-reference-.md) y|Anonymous function (lambda expression)|  
  
## Associativity  
 When two or more operators that have the same precedence are present in an expression, they are evaluated based on associativity. Left-associative operators are evaluated in order from left to right. For example, `x * y / z` is evaluated as `(x * y) / z`. Right-associative operators are evaluated in order from right to left. For example, the assignment operator is right associative. If it were not, the following code would result in an error.  
  
```c#  
int a, b, c;  
c = 1;  
// The following two lines are equivalent.  
a = b = c;  
a = (b = c);  
  
// The following line, which forces left associativity, causes an error.  
//(a = b) = c;  
```  
  
 As another example the ternary operator ([?:](../VS_csharp/---operator--csharp-reference-.md)) is right associative. Most binary operators are left associative.  
  
 Whether the operators in an expression are left associative or right associative, the operands of each expression are evaluated first, from left to right. The following examples illustrate the order of evaluation of operators and operands.  
  
|Statement|Order of evaluation|  
|---------------|-------------------------|  
|`a = b`|a, b, =|  
|`a = b + c`|a, b, c, +, =|  
|`a = b + c * d`|a, b, c, d, *, +, =|  
|`a = b * c + d`|a, b, c, *, d, +, =|  
|`a = b - c + d`|a, b, c, -, d, +, =|  
|`a += b -= c`|a, b, c, -=, +=|  
  
## Adding Parentheses  
 You can change the order imposed by operator precedence and associativity by using parentheses. For example, `2 + 3 * 2` ordinarily evaluates to 8, because multiplicative operators take precedence over additive operators. However, if you write the expression as `(2 + 3) * 2`, the addition is evaluated before the multiplication, and the result is 10. The following examples illustrate the order of evaluation in parenthesized expressions. As in previous examples, the operands are evaluated before the operator is applied.  
  
|Statement|Order of evaluation|  
|---------------|-------------------------|  
|`a = (b + c) * d`|a, b, c, +, d, *, =|  
|`a = b - (c + d)`|a, b, c, d, +, -, =|  
|`a = (b + c) * (d - e)`|a, b, c, +, d, e, -, *, =|  
  
## Operator Overloading  
 You can change the behavior of operators for custom classes and structs. This process is referred to as *operator overloading*. For more information, see [Overloadable Operators](../VS_csharp/overloadable-operators--csharp-programming-guide-.md).  
  
## Related Sections  
 For more information, see [Operator Keywords](../VS_csharp/operator-keywords--csharp-reference-.md) and [C# Operators](../VS_csharp/csharp-operators.md).  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Statements, Expressions, and Operators (Visual C#)](../VS_csharp/statements--expressions--and-operators--csharp-programming-guide-.md)