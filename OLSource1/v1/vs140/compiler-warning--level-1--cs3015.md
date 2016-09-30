---
title: "Compiler Warning (level 1) CS3015"
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
  - "CS3015"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3015"
ms.assetid: 58182215-0c2f-4497-8baf-ffb29f18d6c7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3015
'method signature' has no accessible constructors which use only CLS-compliant types  
  
 To be compliant with the Common Language Specification (CLS), the argument list of an attribute class cannot contain an array. For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following sample generates C3015.  
  
```  
// CS3015.cs  
// compile with: /target:library  
using System;  
  
[assembly:CLSCompliant(true)]  
public class MyAttribute : Attribute  
{  
   public MyAttribute(int[] ai) {}   // CS3015  
   // try the following line instead  
   // public MyAttribute(int ai) {}  
}  
```