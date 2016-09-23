---
title: "Compiler Warning (level 1) C4618"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C4618
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4618
ms.assetid: 6ff10d0a-6d5b-4373-8196-1d57bb6b1611
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4618
pragma parameters included an empty string; pragma ignored  
  
 A null string was given as an argument to a **#pragma**.  
  
 The pragma was processed without the argument.  
  
 The following sample generates C4618:  
  
```  
// C4618.cpp  
// compile with: /W1 /LD  
#pragma code_seg("")   // C4618  
```