---
title: "Compiler Error CS0019"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0019"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0019"
ms.assetid: 5a25be41-535b-4850-a230-9a385e01fd20
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0019
Operator 'operator' cannot be applied to operands of type 'type' and 'type'  
  
 A binary operator is applied to data types that do not support it. For example, you cannot use the [&#124;&#124;](../vs140/---operator--csharp-reference-.md) operator on strings, you cannot use [+](../vs140/--operator--csharp-reference-.md) , [-](../vs140/--operator--csharp-reference-2.md) , [\<](../vs140/--operator--csharp-reference-.md) , or [>](../vs140/--operator--csharp-reference-.md) operators on [bool](../vs140/bool--csharp-reference-.md) variables, and you cannot use the [==](../vs140/==-operator--csharp-reference-.md) operator with a `struct` type unless the type explicitly overloads that operator.  
  
 If you encounter this error with a class type, it is because the class does not overload the operator. For more information, see [Overloadable Operators (C# Programming Guide)](../vs140/overloadable-operators--csharp-programming-guide-.md).  
  
## Example  
 In the following example, CS0019 is generated in two places because [bool](../vs140/bool--csharp-reference-.md) in C# is not convertible to [int](../vs140/int--csharp-reference-.md). CS0019 also is generated when the subtraction operator is applied to a string. The addition operator (+) can be used with string operands because that operator is overloaded by the `String` class to perform string concatenation.  
  
```  
static void Main()  
{  
    bool result = true;  
    if (result > 0) //CS0019  
    {  
        // Do something.  
    }  
  
    int i = 1;  
    // You cannot compare an integer and a boolean value.  
    if (i == true) //CS0019  
    {  
        //Do something...  
    }  
  
    // The following use of == causes no error. It is the comparison of  
    // an integer and a boolean value that causes the error in the   
    // previous if statement.  
    if (result == true)  
    {  
        //Do something...  
    }  
  
    string s = "Just try to subtract me.";  
    float f = 100 - s; // CS0019  
}  
  
```  
  
## Example  
 In the following example, conditional logic must be specified outside the \<xref:System.Diagnostics.ConditionalAttribute*>. You can pass only one predefined symbol to the \<xref:System.Diagnostics.ConditionalAttribute*>.  
  
 The following sample generates CS0019.  
  
```  
// CS0019_a.cs  
// compile with: /target:library  
using System.Diagnostics;  
public class MyClass  
{  
   [ConditionalAttribute("DEBUG" || "TRACE")]   // CS0019  
   public void TestMethod() {}  
  
   // OK  
   [ConditionalAttribute("DEBUG"), ConditionalAttribute("TRACE")]  
   public void TestMethod2() {}  
}  
  
```  
  
## See Also  
 [Operators (C# Programmers Reference)](../vs140/operators--csharp-programming-guide-.md)   
 [Implicit Numeric Conversions Table (C# Reference)](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)