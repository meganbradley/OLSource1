---
title: "Compiler Error CS0763"
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
  - "CS0763"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0763"
ms.assetid: 940870ba-1250-4365-acaa-7f968ee96c5b
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0763
Both partial method declarations must be static or neither may be static.  
  
 A partial method declaration cannot have one part static and the other part not static.  
  
### To correct this error  
  
1.  Make both parts either static or non-static.  
  
## Example  
 The following code generates CS0763:  
  
```  
// cs0763.cs  
using System;  
  
    public partial class C  
    {  
        static partial void Part();  
        partial void Part() // CS0763  
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
 [static (C# Reference)](../vs140/static--csharp-reference-.md)