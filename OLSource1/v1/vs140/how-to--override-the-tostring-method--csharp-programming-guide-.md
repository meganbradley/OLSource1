---
title: "How to: Override the ToString Method (C# Programming Guide)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - ToString method, overriding in C#
  - inheritance [C#], overriding OnPaint and ToString
ms.assetid: 8016db69-1f19-420c-8e17-98e8bebb7749
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Override the ToString Method (C# Programming Guide)
Every class or struct in C# implicitly inherits the <xref:System.Object?qualifyHint=False> class. Therefore, every object in C# gets the <xref:System.Object.ToString?qualifyHint=False> method, which returns a string representation of that object. For example, all variables of type `int` have a `ToString` method, which enables them to return their contents as a string:  
  
 [!code[csProgGuideInheritance#37](../vs140/codesnippet/CSharp/how-to--override-the-tostring-method--csharp-programming-guide-_1.cs)]
  
  
 When you create a custom class or struct, you should override the <xref:System.Object.ToString?qualifyHint=False> method in order to provide information about your type to client code.  
  
 For information about how to use format strings and other types of custom formatting with the `ToString` method, see [Formatting Types](assetId:///0d1364da-5b30-4d42-8e6b-03378343343f).  
  
> [!IMPORTANT]
>  When you decide what information to provide through this method, consider whether your class or struct will ever be used by untrusted code. Be careful to ensure that you do not provide any information that could be exploited by malicious code.  
  
### To override the ToString method in your class or struct  
  
1.  Declare a `ToString` method with the following modifiers and return type:  
  
    ```c#  
    public override string ToString(){}  
    ```  
  
2.  Implement the method so that it returns a string.  
  
     The following example returns the name of the class in addition to the data specific to a particular instance of the class.  
  
     [!code[csProgGuideInheritance#36](../vs140/codesnippet/CSharp/how-to--override-the-tostring-method--csharp-programming-guide-_2.cs)]
  
  
     You can test the `ToString` method as shown in the following code example:  
  
     [!code[csProgGuideInheritance#38](../vs140/codesnippet/CSharp/how-to--override-the-tostring-method--csharp-programming-guide-_3.cs)]
  
  
## See Also  
 <xref:System.IFormattable?qualifyHint=False>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)   
 [Strings (C# Programming Guide)](../vs140/strings--csharp-programming-guide-.md)   
 [string (C# Reference)](../vs140/string--csharp-reference-.md)   
 [new (C# Programmer's Reference)](../vs140/new--csharp-reference-.md)   
 [override (C# Programmer's Reference)](../vs140/override--csharp-reference-.md)   
 [virtual (C# Programmer's Reference)](../vs140/virtual--csharp-reference-.md)   
 [Formatting Types](assetId:///0d1364da-5b30-4d42-8e6b-03378343343f)