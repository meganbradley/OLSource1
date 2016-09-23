---
title: "Compiler Warning (level 1) CS3010"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS3010
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS3010
ms.assetid: d57bd750-df15-4e6a-9579-66de8b276b7e
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) CS3010
'member': CLS-compliant interfaces must have only CLS-compliant members  
  
 In an assembly marked with `[assembly:CLCSompliant(true)]`, an interface contains a member marked with `[CLCSompliant(false)]`. Remove one of the Common Language Specification (CLS) compliance attributes. For more information about CLS Compliance, see [<PAVE OVER\> Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3010:  
  
```  
// CS3010.cs  
  
using System;  
  
[assembly:CLSCompliant(true)]  
public interface I  
{  
    [CLSCompliant(false)]  
    int M();   // CS3010  
}  
  
public class C : I  
{  
    public int M()  
    {  
        return 1;  
    }  
  
    public static void Main()  
    {  
    }  
}  
```