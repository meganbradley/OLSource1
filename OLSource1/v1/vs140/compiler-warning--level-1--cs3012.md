---
title: "Compiler Warning (level 1) CS3012"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS3012"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3012"
ms.assetid: 1f7555b4-61e4-4821-85c9-586301df4c5c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3012
You cannot specify the CLSCompliant attribute on a module that differs from the CLSCompliant attribute on the assembly  
  
 In order for a module to be compliant with the Common Language Specification (CLS) through `[module:System.CLCSompliant(true)]`, it must be built with the [/target:module](../vs140/-target-module--csharp-compiler-options-.md) compiler option. For more information on the CLS, see [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example, when built without `/target:module`, generates CS3012:  
  
```  
// CS3012.cs  
// compile with: /W:1  
  
[module:System.CLSCompliant(true)]   // CS3012  
public class C  
{  
    public static void Main()  
    {  
    }  
}  
```