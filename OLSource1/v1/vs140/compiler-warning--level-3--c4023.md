---
title: "Compiler Warning (level 3) C4023"
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
  - "C4023"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4023"
ms.assetid: 615d5374-d7c1-42eb-acfd-917c053270c8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4023
'symbol' : based pointer passed to unprototyped function : parameter number  
  
 Passing a based pointer to an unprototyped function causes the pointer to be normalized, with unpredictable results.  
  
 This warning may be fixed if you use prototype functions that are passed based pointers.