---
title: "Compiler Warning (level 1) CS3002"
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
  - CS3002
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS3002
ms.assetid: 34f19735-76d2-4d78-bd52-45989a86fca4
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) CS3002
Return type of 'method' is not CLS-compliant  
  
 A [public](../vs140/public--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), or `protected``internal` method must return a value whose type is compliant with the Common Language Specification (CLS). For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3002:  
  
```  
// CS3002.cs  
  
[assembly:System.CLSCompliant(true)]  
public class a  
{  
    public ushort bad()   // CS3002, public method  
    {  
        ushort a;  
        a = ushort.MaxValue;  
        return a;  
    }  
  
    private ushort OK()   // OK, private method  
    {  
        ushort a;  
        a = ushort.MaxValue;  
        return a;  
    }  
  
    public static void Main()  
    {  
    }  
}  
```