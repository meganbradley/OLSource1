---
title: "Compiler Warning (level 1) CS3006"
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
  - CS3006
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS3006
ms.assetid: efbfd898-e46f-4c3d-91e2-e2da0056b016
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) CS3006
Overloaded method 'method' differing only in ref or out, or in array rank, is not CLS-compliant  
  
 A method does not cannot be overloaded based on the [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameter and still comply with the Common Language Specification (CLS). For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3006. To resolve this warning, comment out the assembly-level attribute or remove one of the method definitions.  
  
```  
// CS3006.cs  
  
using System;  
  
[assembly: CLSCompliant(true)]  
public class MyClass  
{  
    public void f(int i)  
    {  
    }  
  
    public void f(ref int i)   // CS3006  
    {  
    }  
  
    public static void Main()  
    {  
    }  
}  
```