---
title: "Linker Tools Error LNK1166"
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
  - LNK1166
dev_langs: 
  - C++
helpviewer_keywords: 
  - LNK1166
ms.assetid: d69548a8-0efb-44e1-90b7-b27636a4b575
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Tools Error LNK1166
cannot adjust code at offset=offset, va=value  
  
 LINK was unable to pad the code as required.  
  
 Certain instructions are not allowed to cross page boundaries on some processors. LINK attempts to add pads to correct this situation. In this case, LINK could not work around the problem.