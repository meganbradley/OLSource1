---
title: "Compiler Warning (level 3) C4197"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4197"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4197"
ms.assetid: f766feef-82b0-4d81-8a65-33628c7db196
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4197
'type' : top-level volatile in cast is ignored  
  
 The compiler detected a cast to an r-value type which is qualified with [volatile](../vs140/volatile--c---.md), or a cast of an r-value type to some type that is qualified with volatile. According to the C standard (6.5.3), properties associated with qualified types are meaningful only for l-value expressions.  
  
 The following sample generates C4197:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>