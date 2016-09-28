---
title: "Compiler Error C2289"
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
  - "C2289"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2289"
ms.assetid: cb41a29e-1b06-47dc-bfce-8d73bd63a0df
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2289
same type qualifier used more than once  
  
 A type declaration or definition uses a type qualifier (`const`, `volatile`, `signed`, or `unsigned`) more than once, causing an error under ANSI compatibility (**/Za**).  
  
 The following sample generates C2286:  
  
```  
// C2289.cpp  
// compile with: /Za /c  
volatile volatile int i;   // C2289  
volatile int j;   // OK  
```