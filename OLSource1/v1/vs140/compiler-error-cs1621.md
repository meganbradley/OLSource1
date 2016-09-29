---
title: "Compiler Error CS1621"
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
  - "CS1621"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1621"
ms.assetid: 11b4fb94-0dd7-4484-99aa-e06eacc6a658
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1621
The yield statement cannot be used inside an anonymous method or lambda expression  
  
 The yield statement cannot be in an anonymous method block in an iterator.  
  
## Example  
 The following sample generates CS1621:  
  
```  
// CS1621.cs  
  
using System.Collections;  
  
delegate object MyDelegate();  
  
class C : IEnumerable  
{  
    public IEnumerator GetEnumerator()  
    {  
        MyDelegate d = delegate  
        {  
            yield return this; // CS1621  
            return this;  
        };  
        d();  
        // Try this instead:  
        // MyDelegate d = delegate { return this; };  
        // yield return d();  
    }  
  
    public static void Main()  
    {  
    }  
}  
```  
  
## See Also  
 [Iterators (C# Programming Guide)](../vs140/iterators--csharp-and-visual-basic-.md)   
 [yield](../vs140/yield--csharp-reference-.md)   
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)   
 [Anonymous Methods (C# Programming Guide)](../vs140/anonymous-methods--csharp-programming-guide-.md)