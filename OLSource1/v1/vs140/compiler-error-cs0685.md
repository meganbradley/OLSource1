---
title: "Compiler Error CS0685"
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
  - CS0685
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0685
ms.assetid: 20d7c6cf-a388-430f-b22b-232536912491
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0685
Conditional member 'member' cannot have an out parameter  
  
 When using the <xref:System.Diagnostics.ConditionalAttribute?qualifyHint=False> attribute on a method, that method may not have an out parameter. This is because the value of the variable used for the out parameter would not be defined in the case that the method call is compiled to nothing. To avoid this error, remove the out parameter from the conditional method declaration, or don't use the Conditional Attribute.  
  
## Example  
 The following sample generates CS0685:  
  
```  
// CS0685.cs  
using System.Diagnostics;  
  
class C  
{  
    [Conditional("DEBUG")]  
    void trace(out int i)  // CS0685  
    {  
        i = 1;  
    }  
}  
```