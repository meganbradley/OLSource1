---
title: "Compiler Warning (level 2) CS0114"
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
  - "CS0114"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0114"
ms.assetid: 9647772b-d581-4620-981e-f9c607d4a1af
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS0114
'function1' hides inherited member 'function2'. To make the current method override that implementation, add the override keyword. Otherwise add the new keyword.  
  
 A declaration in a class conflicts with a declaration in a base class such that the base class member will be hidden.  
  
 For more information, see [base](../vs140/base--csharp-reference-.md).  
  
 The following sample generates CS0114:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>