---
title: "Compiler Error CS1552"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1552"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1552"
ms.assetid: 647af14d-249e-4f69-80a8-2c0d77fbb244
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1552
Array type specifier, [], must appear before parameter name  
  
 The position of the array type specifier is after the variable name in the array declaration.  
  
## Example  
 The following sample generates CS1552:  
  
```  
// CS1552.cs  
public class C  
{  
    public static void Main(string args[])   // CS1552  
    // try the following line instead  
    // public static void Main(string [] args)  
    {  
    }  
}  
```