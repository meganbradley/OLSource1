---
title: "Compiler Warning (level 1) CS3001"
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
  - CS3001
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS3001
ms.assetid: c4f3e247-5e47-4182-b415-c573fb1a152f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) CS3001
Argument type 'type' is not CLS-compliant  
  
 A [public](../vs140/public--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), or `protected``internal` method must accept a parameter whose type is compliant with the Common Language Specification (CLS). For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3001:  
  
```  
// CS3001.cs  
  
[assembly:System.CLSCompliant(true)]  
public class a  
{  
    public void bad(ushort i)   // CS3001  
    {  
    }  
  
    private void OK(ushort i)   // OK, private method  
    {  
    }  
  
    public static void Main()  
    {  
    }  
}  
```