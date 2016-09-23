---
title: "Compiler Warning (level 1) CS3005"
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
  - CS3005
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS3005
ms.assetid: 64b687e3-2dbd-45dd-b6da-81f77eb7d6bd
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) CS3005
Identifier 'identifier' differing only in case is not CLS-compliant  
  
 A [public](../vs140/public--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), or `protected``internal` identifier, which differs from another `public`, `protected`, or `protected``internal` identifier only in the case of one or more letters, is not compliant with the Common Language Specification (CLS). For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3003:  
  
```  
// CS3005.cs  
  
using System;  
  
[assembly:CLSCompliant(true)]  
public class a  
{  
    public static int a1 = 0;  
    public static int A1 = 1;   // CS3005  
  
    public static void Main()  
    {  
        Console.WriteLine(a1);  
        Console.WriteLine(A1);  
    }  
}  
```