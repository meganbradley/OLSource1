---
title: "Compiler Error CS0173"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - CS0173
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0173
ms.assetid: eb1797ad-bf62-4e2b-8922-bef4aff36954
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0173
Type of conditional expression cannot be determined because there is no implicit conversion between 'class1' and 'class2'  
  
 Conversions between classes are useful when you want objects of different classes to work with the same code. However, two classes that work together cannot have mutual and redundant conversions, or no implicit conversions. The types of `class1` and `class2` are determined independently, and the more general type is selected as the type of the conditional expression. For more information about how types are determined, see [Conditional operator cannot cast implicitly](http://go.microsoft.com/fwlink/?LinkId=213999).  
  
 To resolve CS0173, verify that there is one and only one implicit conversion between `class1` and `class2`, regardless of which direction the conversion is in and regardless of which class the conversion is in. For more information, see [Implicit Numeric Conversions Table (C# Programmer's Reference)](../vs140/implicit-numeric-conversions-table--csharp-reference-.md) and [Conversion Operators (C# Programmer's Reference)](../vs140/conversion-operators--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0173:  
  
```c#  
// CS0173.cs  
public class C {}  
  
public class A   
{  
    //// The following code defines an implicit conversion operator from    
    //// type C to type A.  
    //public static implicit operator A(C c)  
    //{  
    //    A a = new A();  
    //    a = c;  
    //    return a;  
    //}  
}  
  
public class MyClass  
{  
    public static void F(bool b)  
    {  
        A a = new A();  
        C c = new C();  
  
        // The following line causes CS0173 because there is no implicit  
        // conversion from a to c or from c to a.  
        object o = b ? a : c;  
  
        // To resolve the error, you can cast a and c.  
        //object o = b ? (object)a : (object)c;  
  
        // Alternatively, you can add a conversion operator from class C to  
        // class A, or from class A to class C, but not both.  
    }  
  
   public static void Main()  
   {  
      F(true);  
   }  
}  
```  
  
## Example  
 The following code does not produce CS0173 in Visual Studio 2005, but does in later versions.  
  
```c#  
//cs0173_2.cs  
class M  
{  
    static int Main ()  
    {  
        int X = 1;  
        // The following line causes CS0173 in Visual Studio 2005.  
        object o = (X == 0) ? null : null;  
        return -1;  
    }  
}  
```