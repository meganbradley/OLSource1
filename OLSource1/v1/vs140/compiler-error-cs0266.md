---
title: "Compiler Error CS0266"
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
  - "CS0266"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0266"
ms.assetid: 6cca5d6a-f3e0-482a-af25-af73bfe3e303
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0266
Cannot implicitly convert type 'type1' to 'type2'. An explicit conversion exists (are you missing a cast?)  
  
 This error occurs when your code tries to convert between two types that cannot be implicitly converted, but where an explicit conversion is available. For more information, see [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md).  
  
 The following code shows examples that generate CS0266.  
  
```c#  
// CS0266.cs  
class MyClass  
{  
    public static void Main()  
    {  
        // You cannot implicitly convert a double to an integer.  
        double d = 3.2;  
  
        // The following line causes compiler error CS0266.  
        int i1 = d;  
  
        // However, you can resolve the error by using an explicit conversion.  
        int i2 = (int)d;  
  
        // You cannot implicitly convert an object to a class type.  
        object obj = "MyString";  
  
        // The following assignment statement causes error CS0266.  
        MyClass myClass = obj;    
  
        // You can resolve the error by using an explicit conversion.  
        MyClass c = ( MyClass )obj;  
  
        // You cannot implicitly convert a base class object to a derived class type.  
        MyClass mc = new MyClass();  
        DerivedClass dc = new DerivedClass();  
  
        // The following line causes compiler error CS0266.  
        dc = mc;  
  
        // You can resolve the error by using an explicit conversion.  
        dc = (DerivedClass)mc;  
    }  
}  
  
class DerivedClass : MyClass  
{  
}  
  
```