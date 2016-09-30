---
title: "Compiler Error C3037"
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
  - "C3037"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3037"
ms.assetid: 9ba8a890-d3c7-4cce-93c5-d358e2bfad28
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3037
'var' : variable in 'reduction' clause must be shared in enclosing context  
  
 A variable specified in a [reduction](../vs140/reduction.md) clause may not be private to each thread in the context.  
  
 The following sample generates C3037:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>