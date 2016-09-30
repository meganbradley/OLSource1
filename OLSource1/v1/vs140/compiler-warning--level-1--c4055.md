---
title: "Compiler Warning (level 1) C4055"
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
  - "C4055"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4055"
ms.assetid: f04b13ca-88a7-4f2b-8065-42e73e5ac353
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4055
'conversion' : from data pointer 'type1' to function pointer 'type2'  
  
 A data pointer is cast (possibly incorrectly) to a function pointer. This is a level 1 warning under /Za and a level 4 warning under /Ze.  
  
 The following sample generates C4055:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Under /Ze, this is a level 4 warning.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>