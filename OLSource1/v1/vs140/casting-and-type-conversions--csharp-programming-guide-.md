---
title: "Casting and Type Conversions (C# Programming Guide)"
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
  - "type conversion [C#]"
  - "data type conversion [C#]"
  - "numeric conversions [C#]"
  - "conversions [C#], type"
  - "casting [C#]"
  - "converting types [C#]"
ms.assetid: 568df58a-d292-4b55-93ba-601578722878
caps.latest.revision: 56
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Casting and Type Conversions (C# Programming Guide)
Because C# is statically-typed at compile time, after a variable is declared, it cannot be declared again or used to store values of another type unless that type is convertible to the variable's type. For example, there is no conversion from an integer to any arbitrary string. Therefore, after you declare `i` as an integer, you cannot assign the string "Hello" to it, as is shown in the following code.  
  
```c#  
int i;  
i = "Hello"; // Error: "Cannot implicitly convert type 'string' to 'int'"  
```  
  
 However, you might sometimes need to copy a value into a variable or method parameter of another type. For example, you might have an integer variable that you need to pass to a method whose parameter is typed as `double`. Or you might need to assign a class variable to a variable of an interface type. These kinds of operations are called *type conversions*. In C#, you can perform the following kinds of conversions:  
  
-   **Implicit conversions**: No special syntax is required because the conversion is type safe and no data will be lost. Examples include conversions from smaller to larger integral types, and conversions from derived classes to base classes.  
  
-   **Explicit conversions (casts)**: Explicit conversions require a cast operator. Casting is required when information might be lost in the conversion, or when the conversion might not succeed for other reasons.  Typical examples include numeric conversion to a type that has less precision or a smaller range, and conversion of a base-class instance to a derived class.  
  
-   **User-defined conversions**: User-defined conversions are performed by special methods that you can define to enable explicit and implicit conversions between custom types that do not have a base class–derived class relationship. For more information, see [Conversion Operators (C# Programming Guide)](../vs140/conversion-operators--csharp-programming-guide-.md).  
  
-   **Conversions with helper classes**: To convert between non-compatible types, such as integers and \<xref:System.DateTime*?displayProperty=fullName> objects, or hexadecimal strings and byte arrays, you can use the \<xref:System.BitConverter*?displayProperty=fullName> class, the \<xref:System.Convert*?displayProperty=fullName> class, and the `Parse` methods of the built-in numeric types, such as \<xref:System.Int32.Parse*?displayProperty=fullName>. For more information, see [How to: Convert a Byte Array to an int (C# Programming Guide)](../vs140/how-to--convert-a-byte-array-to-an-int--csharp-programming-guide-.md), [How to: Convert a string to an int (C# Programming Guide)](../vs140/how-to--convert-a-string-to-a-number--csharp-programming-guide-.md), and [How to: Convert Between Hex Strings and Numeric Types (C# Programming Guide)](../vs140/how-to--convert-between-hexadecimal-strings-and-numeric-types--csharp-programming-guide-.md).  
  
## Implicit Conversions  
 For built-in numeric types, an implicit conversion can be made when the value to be stored can fit into the variable without being truncated or rounded off. For example, a variable of type [long](../vs140/long--csharp-reference-.md) (8 byte integer) can store any value that an [int](../vs140/int--csharp-reference-.md) (4 bytes on a 32-bit computer) can store. In the following example, the compiler implicitly converts the value on the right to a type `long` before assigning it to `bigNum`.  
  
 [!code[csProgGuideTypes#34](../vs140/codesnippet/CSharp/casting-and-type-conversions--csharp-programming-guide-_1.cs)]  
  
 For a complete list of all implicit numeric conversions, see [Implicit Numeric Conversions Table (C# Reference)](../vs140/implicit-numeric-conversions-table--csharp-reference-.md).  
  
 For reference types, an implicit conversion always exists from a class to any one of its direct or indirect base classes or interfaces. No special syntax is necessary because a derived class always contains all the members of a base class.  
  
```  
Derived d = new Derived();  
Base b = d; // Always OK.  
```  
  
## Explicit Conversions  
 However, if a conversion cannot be made without a risk of losing information, the compiler requires that you perform an explicit conversion, which is called a *cast*. A cast is a way of explicitly informing the compiler that you intend to make the conversion and that you are aware that data loss might occur. To perform a cast, specify the type that you are casting to in parentheses in front of the value or variable to be converted. The following program casts a [double](../vs140/double--csharp-reference-.md) to an [int](../vs140/int--csharp-reference-.md). The program will not compile without the cast.  
  
 [!code[csProgGuideTypes#2](../vs140/codesnippet/CSharp/casting-and-type-conversions--csharp-programming-guide-_2.cs)]  
  
 For a list of the explicit numeric conversions that are allowed, see [Explicit Numeric Conversions Table (C# Reference)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md).  
  
 For reference types, an explicit cast is required if you need to convert from a base type to a derived type:  
  
```c#  
// Create a new derived type.  
Giraffe g = new Giraffe();  
  
// Implicit conversion to base type is safe.  
Animal a = g;  
  
// Explicit conversion is required to cast back  
// to derived type. Note: This will compile but will  
// throw an exception at run time if the right-side  
// object is not in fact a Giraffe.  
Giraffe g2 = (Giraffe) a;  
```  
  
 A cast operation between reference types does not change the run-time type of the underlying object; it only changes the type of the value that is being used as a reference to that object. For more information, see [Polymorphism (C# Programming Guide)](../vs140/polymorphism--csharp-programming-guide-.md).  
  
## Type Conversion Exceptions at Run Time  
 In some reference type conversions, the compiler cannot determine whether a cast will be valid. It is possible for a cast operation that compiles correctly to fail at run time. As shown in the following example, a type cast that fails at run time will cause an \<xref:System.InvalidCastException*> to be thrown.  
  
 [!code[csProgGuideTypes#41](../vs140/codesnippet/CSharp/casting-and-type-conversions--csharp-programming-guide-_3.cs)]  
  
 C# provides the [is](../vs140/is--csharp-reference-.md) and [as](../vs140/as--csharp-reference-.md) operators to enable you to test for compatibility before actually performing a cast. For more information, see [How to: Safely Cast With is and as Operator (C# Programming Guide)](../vs140/how-to--safely-cast-by-using-as-and-is-operators--csharp-programming-guide-.md).  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## Featured Book Chapter  
 [More About Variables](http://go.microsoft.com/fwlink/?LinkId=221230) in [Beginning Visual C# 2010](http://go.microsoft.com/fwlink/?LinkId=221214)  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Data Types](../vs140/types--csharp-programming-guide-.md)   
 [() Operator](../vs140/---operator--csharp-reference-.md)   
 [explicit (C# Reference)](../vs140/explicit--csharp-reference-.md)   
 [implicit](../vs140/implicit--csharp-reference-.md)   
 [Conversion Operators (C# Programming Guide)](../vs140/conversion-operators--csharp-programming-guide-.md)   
 [Generalized Type Conversion](assetId:///49253ae6-7657-4810-82ab-1176a6feeada)   
 [Exported Type Conversion](assetId:///1dfe55f4-07a2-4b61-aabf-a8cf65783a6b)   
 [How to: Convert a string to an int (C# Programming Guide)](../vs140/how-to--convert-a-string-to-a-number--csharp-programming-guide-.md)