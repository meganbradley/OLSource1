---
title: "Compiler Warning (level 4) C4932"
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
  - "C4932"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4932"
ms.assetid: 0b8d88cc-21f6-45cb-a9f5-1795b7db0dfa
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4932
__identifier(identifier) and \__identifier(identifier) are indistinguishable  
  
 The compiler is unable to distinguish between **_finally** and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and **_try** as a parameter passed to [__identifier](../vs140/__identifier--c---cli-.md). You should not attempt to use them both as identifiers in the same program, as it will result in a [C2374](../vs140/compiler-error-c2374.md) error.  
  
 The following sample generates C4932:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>