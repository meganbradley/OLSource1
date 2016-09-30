---
title: "Compiler Error CS0050"
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
  - "CS0050"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0050"
ms.assetid: dead2d28-f4db-4afe-b8dd-38968625f7c3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0050
Inconsistent accessibility: return type 'type' is less accessible than method 'method'  
  
 The return type and each of the types referenced in the formal parameter list of a method must be at least as accessible as the method itself. For more information, see [Access Modifiers (C# Programmers Reference)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0050 because no accessiblity modifier is supplied for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and its accessibility therefore defaults to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>