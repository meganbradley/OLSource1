---
title: "Compiler Error CS1541"
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
  - "CS1541"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1541"
ms.assetid: db3350fe-6432-4617-8b4a-64bc6cdf83f8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1541
Invalid reference option: 'symbol' — cannot reference directories  
  
 The compiler detected an attempt to specify a directory rather than a specific file. For example, when you use the [/reference](../vs140/-reference--csharp-compiler-options-.md) compiler option, you must specify a file; it is not possible to specify a directory.  
  
 For example, passing `/reference:c:\` to the compiler would generate CS1541.