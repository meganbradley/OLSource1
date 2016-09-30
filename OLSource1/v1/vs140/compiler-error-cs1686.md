---
title: "Compiler Error CS1686"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1686"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1686"
ms.assetid: 46a9e82b-57f4-416d-8e49-242bfff5433a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1686
Local 'variable' or its members cannot have their address taken and be used inside an anonymous method or lambda expression  
  
 This error is generated when you use a variable, and attempt to take its address, and one of these actions is done inside an anonymous method.  
  
## Example  
 The following sample generates CS1686.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>