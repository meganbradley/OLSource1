---
title: "Overloadable Operators (C# Programming Guide)"
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
  - "C# language, operator overloading"
  - "operator overloading [C#]"
ms.assetid: 390d9d01-79fc-40ab-9ed3-0bf448da1b6a
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overloadable Operators (C# Programming Guide)
C# allows user-defined types to overload operators by defining static member functions using the [operator](../vs140/operator--csharp-reference-2.md) keyword. Not all operators can be overloaded, however, and others have restrictions, as listed in this table:  
  
|Operators|Overloadability|  
|---------------|---------------------|  
|[+](../vs140/--operator--csharp-reference-.md), [-](../vs140/--operator--csharp-reference-2.md), [!](../vs140/!-operator--csharp-reference-.md), [~](../vs140/~-operator--csharp-reference-.md), [++](../vs140/---operator--csharp-reference-.md), [--](../vs140/---operator--csharp-reference-.md), [true](../vs140/true--csharp-reference-.md), [false](../vs140/false--csharp-reference-.md)|These unary operators can be overloaded.|  
|[+](../vs140/--operator--csharp-reference-.md), [-](../vs140/--operator--csharp-reference-2.md), [*](../vs140/--operator--csharp-reference-.md), [/](../vs140/--operator--csharp-reference-1.md), [%](../vs140/--operator--csharp-reference-.md), [&](../vs140/--operator--csharp-reference-.md), [&#124;](../vs140/--operator--csharp-reference-.md), [^](../vs140/^-operator--csharp-reference-.md), [<<](../vs140/---operator--csharp-reference-.md), [>>](../vs140/---operator--csharp-reference-.md)|These binary operators can be overloaded.|  
|[==](../vs140/==-operator--csharp-reference-.md), [!=](../vs140/!=-operator--csharp-reference-.md), [<](../vs140/--operator--csharp-reference-.md), [>](../vs140/--operator--csharp-reference-.md), [<=](../vs140/-=-operator--csharp-reference-.md), [>=](../vs140/-=-operator--csharp-reference-.md)|The comparison operators can be overloaded (but see the note that follows this table).|  
|[&&](../vs140/---operator--csharp-reference-.md), [&#124;&#124;](../vs140/---operator--csharp-reference-.md)|The conditional logical operators cannot be overloaded, but they are evaluated using `&` and `&#124;`, which can be overloaded.|  
|[&#91;&#93;](../vs140/operator--csharp-reference-1.md)|The array indexing operator cannot be overloaded, but you can define indexers.|  
|[(T)x](../vs140/---operator--csharp-reference-.md)|The cast operator cannot be overloaded, but you can define new conversion operators (see [explicit](../vs140/explicit--csharp-reference-.md) and [implicit](../vs140/implicit--csharp-reference-.md)).|  
|[+=](../vs140/-=-operator--csharp-reference-.md), [-=](../vs140/-=-operator--csharp-reference-2.md), [*=](../vs140/-=-operator--csharp-reference-.md), [/=](../vs140/-=-operator--csharp-reference-1.md), [%=](../vs140/-=-operator--csharp-reference-.md), [&=](../vs140/-=-operator--csharp-reference-.md), [&#124;=](../vs140/-=-operator--csharp-reference-.md), [^=](../vs140/^=-operator--csharp-reference-.md), [<<=](../vs140/--=-operator--csharp-reference-.md), [>>=](../vs140/--=-operator--csharp-reference-.md)|Assignment operators cannot be overloaded, but `+=`, for example, is evaluated using `+`, which can be overloaded.|  
|[=](../vs140/=-operator--csharp-reference-.md), [.](../vs140/.-operator--csharp-reference-.md), [?:](../vs140/---operator--csharp-reference-.md), [??](../vs140/---operator--csharp-reference-.md), [->](../vs140/---operator--csharp-reference-.md), [=>](../vs140/=--operator--csharp-reference-.md), [f(x)](../vs140/---operator--csharp-reference-.md), [as](../vs140/as--csharp-reference-.md), [checked](../vs140/checked--csharp-reference-.md), [unchecked](../vs140/unchecked--csharp-reference-.md), [default](../vs140/default-keyword-in-generic-code--csharp-programming-guide-.md), [delegate](../vs140/anonymous-methods--csharp-programming-guide-.md), [is](../vs140/is--csharp-reference-.md), [new](../vs140/new--csharp-reference-.md), [sizeof](../vs140/sizeof--csharp-reference-.md), [typeof](../vs140/typeof--csharp-reference-.md)|These operators cannot be overloaded.|  
  
> [!NOTE]
>  The comparison operators, if overloaded, must be overloaded in pairs; that is, if `==` is overloaded, `!=` must also be overloaded. The reverse is also true, and similar for `<` and `>`, and for `<=` and `>=`.  
  
 To overload an operator on a custom class requires creating a method on the class with the correct signature. The method must be named "operator X" where X is the name or symbol of the operator being overloaded. Unary operators have one parameter, and binary operators have two parameters. In each case, one parameter must be the same type as the class or struct that declares the operator.  
  
```c#  
public static Complex operator +(Complex c1, Complex c2)  
    {  
        Return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);  
    }  
  
```  
  
 It is common to have definitions that simply return immediately with the result of an expression.  There is a syntax shortcut using `=>` for these situations.  
  
```c#  
public static Complex operator +(Complex c1, Complex c2) =>  
        new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);  
  
    // Override ToString() to display a complex number   
    // in the traditional format:  
    public override string ToString() => $"{this.real} + {this.imaginary}";  
  
```  
  
 For more information, see [How To: Use Operator Overloading to Create a Complex Number Class (C#)](../vs140/how-to--use-operator-overloading-to-create-a-complex-number-class--csharp-programming-guide-.md).  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Statements, Expressions, and Operators (Visual C#)](../vs140/statements--expressions--and-operators--csharp-programming-guide-.md)   
 [Operators (Visual C#)](../vs140/operators--csharp-programming-guide-.md)   
 [C# Operators](../vs140/csharp-operators.md)   
 [Why are overloaded operators always static in C#?](http://go.microsoft.com/fwlink/?LinkId=112383)