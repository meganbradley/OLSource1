---
title: "Compiler Warning (level 1) CS3016"
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
  - "CS3016"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3016"
ms.assetid: b2ae721d-13ab-4e9d-a288-741d7825defe
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3016
Arrays as attribute arguments is not CLS-compliant  
  
 It is not compliant with the Common Language Specification (CLS) to pass an array to an attribute. For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3016:  
  
```  
// CS3016.cs  
  
using System;  
  
[assembly : CLSCompliant(true)]  
[C(new int[] {1, 2})]   // CS3016  
// try the following line instead  
// [C()]  
class C : Attribute  
{  
    public C()  
    {  
    }  
  
    public C(int[] a)  
    {  
    }  
  
    public static void Main ()  
    {  
    }  
}  
```