---
title: "Compiler Error CS0834"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0834"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0834"
ms.assetid: f3d26696-eeb4-4ea3-9667-b8f51577567e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0834
A lambda expression must have an expression body to be converted to an expression tree.  
  
 Lambdas that are translated to expression trees must be expression lambdas; statement lambdas and anonymous methods can only be converted to delegate types.  
  
### To correct this error  
  
1.  Remove the statement from the lambda expression.  
  
## Example  
 The following example generates CS0834:  
  
```  
// cs0834.cs  
using System;  
using System.Linq;  
using System.Linq.Expressions;  
  
public class C  
{  
    public static int Main()  
    {  
        Expression<Func<int, int>> e = x => { return x; }; // CS0834  
    }  
}  
  
```