---
title: "Compiler Error CS1945"
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
  - "CS1945"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1945"
ms.assetid: 787f61b0-4767-451c-8c78-8e456b5057eb
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1945
An expression tree may not contain an anonymous method expression.  
  
 Expression trees can only contain expressions. Anonymous methods can only represent statements.  
  
### To correct this error  
  
1.  Do not try to create an expression tree with a statement.  
  
## Example  
 The following code generates CS1945:  
  
```  
// cs1945.cs  
using System;  
using System.Linq.Expressions;  
  
public delegate void D();  
class Test  
{  
    static void Main()  
    {  
        Expression<Func<int, Func<int, bool>>> tree = (x => delegate(int i) { return true; }); // CS1945  
    }  
}  
```  
  
## See Also  
 [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md)   
 [Statements, Expressions, and Operators (C# Programming Guide)](../vs140/statements--expressions--and-operators--csharp-programming-guide-.md)