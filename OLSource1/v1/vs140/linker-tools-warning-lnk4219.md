---
title: "Linker Tools Warning LNK4219"
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
  - LNK4219
dev_langs: 
  - C++
helpviewer_keywords: 
  - LNK4219
ms.assetid: 363fedf4-b10c-4985-811a-55a9fba688d6
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Tools Warning LNK4219
fixup name fixup overflow. Target 'target symbol name' is out of range, inserting thunk  
  
 The linker inserted a thunk in a situation where the address or offset was unable to fit in the given instruction because the target symbol is too far away from the instruction's location.  
  
 You may want to reorder the image (using the [/ORDER](../vs140/-order--put-functions-in-order-.md) option, for example) to avoid the extra level of indirection.