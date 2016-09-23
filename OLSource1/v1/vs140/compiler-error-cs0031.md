---
title: "Compiler Error CS0031"
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
  - CS0031
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0031
ms.assetid: 91f11ae9-9143-41f4-8002-5c38c8ee0651
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0031
Constant value 'value' cannot be converted to a 'type'. (use 'unchecked' syntax to override)  
  
 An attempt was made to assign a value to a variable whose type cannot store the value. For more information, see [Data Types (C# Programmers Reference)](../vs140/types--csharp-programming-guide-.md).  
  
 The following sample generates CS0031 in both checked and unchecked contexts:  
  
```  
// CS0031.cs  
namespace CS0031  
{  
   public class a  
   {  
      public static void Main()  
      {  
         int num = (int)2147483648M; //CS0031  
         // Try using a larger numeric type instead:  
         // long num = (long)2147483648M; //CS0031  
  
         const decimal d = -10M; // Decimal literal  
            unchecked  
            {  
                const byte b = (byte)d; // CS0031  
                // For small values try using a signed byte instead:  
                // const sbyte b = (sbyte)d;  
            }  
      }  
   }  
}  
```  
  
## See Also  
 [unchecked (C# Reference)](../vs140/unchecked--csharp-reference-.md)