---
title: "Compiler Error CS1018"
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
  - "CS1018"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1018"
ms.assetid: f6dc7f6a-57fd-4c9e-8699-add3218af983
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1018
Keyword 'this' or 'base' expected  
  
 The compiler encountered an incomplete constructor declaration.  
  
## Example  
 The following example generates CS1018, and suggests several ways to resolve the error:  
  
```  
// CS1018.cs  
public class C  
{  
}  
  
public class a : C  
{  
    public a(int i)  
    {  
    }  
  
    public a () :   // CS1018  
    // possible resolutions:  
    // public a () resolves by removing the colon  
    // public a () : base() calls C's default constructor  
    // public a () : this(1) calls the assignment constructor of class a  
    {  
    }  
  
    public static int Main()  
    {  
        return 1;  
    }  
}  
```