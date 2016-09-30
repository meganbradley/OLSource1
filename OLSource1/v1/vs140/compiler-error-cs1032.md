---
title: "Compiler Error CS1032"
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
  - "CS1032"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1032"
ms.assetid: fe318a6c-4403-4b9b-b3d8-753ec31c00ff
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1032
Cannot define/undefine preprocessor symbols after first token in file  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [preprocessor directives](../vs140/csharp-preprocessor-directives.md) must be used at the beginning of a program, before any other keywords, such as those used in the namespace declaration.  
  
 The following sample generates CS1032:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>