---
title: "Compiler Error CS0664"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS0664
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0664
ms.assetid: 60fe15a7-db22-414f-a7b8-fac79dad22b4
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0664
Literal of type double cannot be implicitly converted to type 'type'; use an 'suffix' suffix to create a literal of this type  
  
 An assignment could not be completed; use a suffix to correct the instruction. The documentation for each type identifies the corresponding suffix for the type. For more information on conversions, see [Casting and Type Conversions (C# Programming Guide)](../vs140/casting-and-type-conversions--csharp-programming-guide-.md).  
  
 The following sample generates CS0664:  
  
```c#  
// CS0664.cs  
class Example  
{  
    static void Main()  
    {  
        decimal d1 = 1.0;   // CS0664, because 1.0 is interpreted  
                            // as a double.  
  
        // Try the following line instead.  
        decimal d2 = 1.0M;  // The M tells the compiler that 1.0 is a  
                            // decimal.  
        Console.WriteLine(d2);  
    }  
}  
```  
  
## See Also  
 [Type Conversion Tables](assetId:///0ea65c59-85eb-4a52-94ca-c36d3bd13058)