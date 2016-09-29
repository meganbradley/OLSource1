---
title: "Compiler Warning (level 1) C4612"
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
  - "C4612"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4612"
ms.assetid: 21ac02b2-51cd-4aff-9b70-d543511d5962
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4612
error in include filename  
  
 This warning occurs with **#pragma include_alias** when a filename is incorrect or missing.  
  
 The arguments to the **#pragma include_alias** statement can use the quote from (**"***filename***"**) or angle-bracket form (**<***filename***>**), but both must use the same form.  
  
## Example  
  
```  
// C4612.cpp  
// compile with: /W1 /LD  
#pragma include_alias("StandardIO", <stdio.h>) // C4612  
```