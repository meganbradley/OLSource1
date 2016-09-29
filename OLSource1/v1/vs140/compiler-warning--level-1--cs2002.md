---
title: "Compiler Warning (level 1) CS2002"
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
  - "CS2002"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS2002"
ms.assetid: 4acd054e-d3fe-4be6-a660-53a0a5e8c6a4
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS2002
Source file 'file' specified multiple times  
  
 A source file name was passed to the compiler more than once. You can only specify a file once to the compiler to build an output file.  
  
 This warning cannot be suppressed by the [/nowarn](../vs140/-nowarn--csharp-compiler-options-.md) option.  
  
 The following sample generates CS2002:  
  
```  
// CS2002.cs  
// compile with: CS2002.cs  
public class A  
{  
public static void Main(){}  
}  
```  
  
 To generate the error, compile the example with the command line:  
  
```  
csc CS2002.cs CS2002.cs  
```