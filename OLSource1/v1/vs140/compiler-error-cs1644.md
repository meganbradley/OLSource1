---
title: "Compiler Error CS1644"
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
  - "CS1644"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1644"
ms.assetid: f51e2064-29e1-4a22-bbe3-577fa52df6bc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1644
Feature 'feature' is not part of the standardized ISO C# language specification, and may not be accepted by other compilers  
  
 This error occurs if you specified the [/langversion](../vs140/-langversion--csharp-compiler-options-.md) option ISO-1 and the code you are compiling uses features that are not part of the ISO 1.0 standard. To resolve this error, do not use any of the C# 2.0 compiler features such as generics or anonymous methods with the ISO-1 compatibility option.  
  
 The following sample generates CS1644:  
  
```  
// CS1644.cs  
// compile with: /langversion:ISO-1 /target:library  
class C<T> {}   // CS1644  
```