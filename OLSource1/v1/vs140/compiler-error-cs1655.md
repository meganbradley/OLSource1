---
title: "Compiler Error CS1655"
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
  - "CS1655"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1655"
ms.assetid: 041e9daa-c026-494f-b086-0db9a23c969b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1655
Cannot pass fields of 'variable' as a ref or out argument because it is a 'readonly variable type'  
  
 This error occurs if you are attempting to pass a member of a [foreach](../vs140/foreach--in--csharp-reference-.md) variable, a [using](../vs140/using-statement--csharp-reference-.md) variable, or a [fixed](../vs140/fixed-statement--csharp-reference-.md) variable to a function as a ref or out argument. Because these variables are considered read-only in these contexts, this is not allowed.  
  
 The following sample generates CS1655:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>