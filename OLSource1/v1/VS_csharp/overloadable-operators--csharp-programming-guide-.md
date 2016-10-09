---
title: "Overloadable Operators (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 18
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Overloadable Operators (C# Programming Guide)
C# allows user-defined types to overload operators by defining static member functions using the [operator](../VS_csharp/operator--csharp-reference-2.md) keyword. Not all operators can be overloaded, however, and others have restrictions, as listed in this table:  
  
|Operators|Overloadability|  
|---------------|---------------------|  
|[+](../VS_csharp/--operator--csharp-reference-.md), [-](../VS_csharp/--operator--csharp-reference-2.md), [!](../VS_csharp/!-operator--csharp-reference-.md), [~](../VS_csharp/~-operator--csharp-reference-.md), [++](../VS_csharp/---operator--csharp-reference-.md), [--](../VS_csharp/---operator--csharp-reference-.md), [true](../VS_csharp/true--csharp-reference-.md), [false](../VS_csharp/false--csharp-reference-.md)|These unary operators can be overloaded.|  
|[+](../VS_csharp/--operator--csharp-reference-.md), [-](../VS_csharp/--operator--csharp-reference-2.md), [*](../VS_csharp/--operator--csharp-reference-.md), [/](../VS_csharp/--operator--csharp-reference-1.md), [%](../VS_csharp/--operator--csharp-reference-.md), [&](../VS_csharp/--operator--csharp-reference-.md), [&#124;](../VS_csharp/--operator--csharp-reference-.md), [^](../VS_csharp/^-operator--csharp-reference-.md), [<\<](../VS_csharp/---operator--csharp-reference-.md), [>>](../VS_csharp/---operator--csharp-reference-.md)|These binary operators can be overloaded.|  
|[==](../VS_csharp/==-operator--csharp-reference-.md), [!=](../VS_csharp/!=-operator--csharp-reference-.md), [\<](../VS_csharp/--operator--csharp-reference-.md), [>](../VS_csharp/--operator--csharp-reference-.md), [\<=](../VS_csharp/-=-operator--csharp-reference-.md), [>=](../VS_csharp/-=-operator--csharp-reference-.md)|The comparison operators can be overloaded (but see the note that follows this table).|  
|[&&](../VS_csharp/---operator--csharp-reference-.md), [&#124;&#124;](../VS_csharp/---operator--csharp-reference-.md)|The conditional logical operators cannot be overloaded, but they are evaluated using `&` and `&#124;`, which can be overloaded.|  
|[&#91;&#93;](../VS_csharp/operator--csharp-reference-1.md)|The array indexing operator cannot be overloaded, but you can define indexers.|  
|[(T)x](../VS_csharp/---operator--csharp-reference-.md)|The cast operator cannot be overloaded, but you can define new conversion operators (see [explicit](../VS_csharp/explicit--csharp-reference-.md) and [implicit](../VS_csharp/implicit--csharp-reference-.md)).|  
|[+=](../VS_csharp/-=-operator--csharp-reference-.md), [-=](../VS_csharp/-=-operator--csharp-reference-2.md), [*=](../VS_csharp/-=-operator--csharp-reference-.md), [/=](../VS_csharp/-=-operator--csharp-reference-1.md), [%=](../VS_csharp/-=-operator--csharp-reference-.md), [&=](../VS_csharp/-=-operator--csharp-reference-.md), [&#124;=](../VS_csharp/-=-operator--csharp-reference-.md), [^=](../VS_csharp/^=-operator--csharp-reference-.md), [<\<=](../VS_csharp/--=-operator--csharp-reference-.md), [>>=](../VS_csharp/--=-operator--csharp-reference-.md)|Assignment operators cannot be overloaded, but `+=`, for example, is evaluated using `+`, which can be overloaded.|  
|[=](../VS_csharp/=-operator--csharp-reference-.md), [.](../VS_csharp/.-operator--csharp-reference-.md), [?:](../VS_csharp/---operator--csharp-reference-.md), [??](../VS_csharp/---operator--csharp-reference-.md), [->](../VS_csharp/---operator--csharp-reference-.md), [=>](../VS_csharp/=--operator--csharp-reference-.md), [f(x)](../VS_csharp/---operator--csharp-reference-.md), [as](../VS_csharp/as--csharp-reference-.md), [checked](../VS_csharp/checked--csharp-reference-.md), [unchecked](../VS_csharp/unchecked--csharp-reference-.md), [default](../VS_csharp/default-keyword-in-generic-code--csharp-programming-guide-.md), [delegate](../VS_csharp/anonymous-methods--csharp-programming-guide-.md), [is](../VS_csharp/is--csharp-reference-.md), [new](../VS_csharp/new--csharp-reference-.md), [sizeof](../VS_csharp/sizeof--csharp-reference-.md), [typeof](../VS_csharp/typeof--csharp-reference-.md)|These operators cannot be overloaded.|  
  
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
  
 For more information, see [How to: Use Operator Overloading to Create a Complex Number Class](../VS_csharp/how-to--use-operator-overloading-to-create-a-complex-number-class--csharp-programming-guide-.md).  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Statements, Expressions, and Operators](../VS_csharp/statements--expressions--and-operators--csharp-programming-guide-.md)   
 [Operators](../VS_csharp/operators--csharp-programming-guide-.md)   
 [C# Operators](../VS_csharp/csharp-operators.md)   
 [Why are overloaded operators always static in C#?](http://go.microsoft.com/fwlink/?LinkId=112383)