---
title: "Compiler Error CS0756"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0756"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0756"
ms.assetid: 847b20b0-bbf0-43a2-8728-4b54cb3d9cd6
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0756
A partial method may not have multiple defining declarations.  
  
 The defining declaration of a partial method is the part that specifies the method signature, but not the implementation (method body). A partial method must have exactly one defining declaration for each unique signature. Each overloaded version of a partial method must have its own defining declaration.  
  
### To correct this error  
  
1.  Remove all except one defining declaration for the partial method.  
  
## Example  
  
```  
// cs0756.cs  
using System;  
  
    public partial class C  
    {  
        partial void Part();  
        partial void Part(); // CS0756  
        public static int Main()  
        {  
            return 1;  
        }  
    }  
```  
  
## See Also  
 [Partial Classes and Methods (C# Programming Guide)](../vs140/partial-classes-and-methods--csharp-programming-guide-.md)