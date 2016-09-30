---
title: "Compiler Warning (level 3) C4723"
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
  - "C4723"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4723"
ms.assetid: 07669d14-3fd8-4a43-94bc-b61c50e58460
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4723
potential divide by 0  
  
 The second operand in a divide operation evaluated to zero at compile time, giving undefined results.  
  
 This warning is issued only when using [/Og](../vs140/-og--global-optimizations-.md) or an optimization option that implies /Og.  
  
 The compiler may have generated the zero operand.