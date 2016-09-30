---
title: "Compiler Warning (level 4) C4960"
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
  - "C4960"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4960"
ms.assetid: 3b4ed286-9e8d-46f1-af0c-00ba669693a9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4960
'function' is too big to be profiled  
  
 When using [/LTCG:PGOPTIMIZE](../vs140/-ltcg--link-time-code-generation-.md), the compiler detected an input module with a function larger than 65,535 instructions. Such a large function is not available for profile-guided optimizations.  
  
 To resolve this warning, reduce the size of the function.