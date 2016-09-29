---
title: "Compiler Warning (level 1) CS3003"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS3003"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3003"
ms.assetid: 1845508d-e97f-4bef-b94c-9f14cfc8bdb3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3003
Type of 'variable' is not CLS-compliant  
  
 A [public](../vs140/public--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), or `protected internal` variable must be of a type that is compliant with the Common Language Specification (CLS). For more information on CLS Compliance, see [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3003:  
  
```  
// CS3003.cs  
  
[assembly:System.CLSCompliant(true)]  
public class a  
{  
    public ushort a1;   // CS3003, public variable  
    public static void Main()  
    {  
    }  
}  
```