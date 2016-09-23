---
title: "Compiler Error CS0766"
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
  - CS0766
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0766
ms.assetid: 4574e30b-3e76-42cd-90e8-31c72126a08c
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0766
Partial methods must have a void return type.  
  
 A partial method cannot return a value. Its return type must be void.  
  
### To correct this error  
  
1.  Give the partial method a void return type, or else convert the method to a regular (not partial) method.  
  
## Example  
 The following example generates CS0766:  
  
```  
// cs0766.cs  
using System;  
  
    public partial class C  
    {  
        partial int Part(); // CS0766  
  
        // Typically the implementing declaration  
        // is contained in a separate file.  
        partial int Part() //CS0766  
        {  
        }  
  
        public static int Main()  
        {  
            return 1;  
        }  
  
    }  
```  
  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)