---
title: "Compiler Error CS1946"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1946"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1946"
ms.assetid: 4ccef263-1ae8-4065-ab46-25d14a38e24e
caps.latest.revision: 7
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Compiler Error CS1946
An anonymous method expression cannot be converted to an expression tree.  
  
 An anonymous method represents a set of statements but an expression tree must not contain a statement. Therefore an anonymous method cannot be represented by an expression tree.  
  
### To correct this error  
  
1.  Change the anonymous method to a lambda expression.  
  
## Example  
 The following example generates CS1946:  
  
```  
// cs1946.cs  
using System;  
    using System.Linq.Expressions;  
  
    public delegate void D();  
  
    class Test  
    {  
        static void Main()  
        {  
            Expression<D> tree = delegate() { }; //CS1946  
            // Try using a lambda expression instead.  
            // Expression<D> tree = (x) => x + 1;  
        }  
    }  
```  
  
## See Also  
 [Anonymous Methods](../VS_csharp/anonymous-methods--csharp-programming-guide-.md)   
 [Expression Trees](../Topic/Expression%20Trees%20\(C%23%20and%20Visual%20Basic\).md)