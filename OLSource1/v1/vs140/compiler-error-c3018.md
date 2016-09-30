---
title: "Compiler Error C3018"
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
  - "C3018"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3018"
ms.assetid: 685be45f-f116-43a8-a88d-05ab6616e2f1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3018
'var1' : OpenMP 'for' test or increment must use index variable 'var2'  
  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> loop in an OpenMP statement must use the same variable for its test and increment as it uses for its index.  
  
 The following sample generates C3018:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>