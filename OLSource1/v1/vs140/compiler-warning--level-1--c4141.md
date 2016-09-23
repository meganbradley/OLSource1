---
title: "Compiler Warning (level 1) C4141"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C4141
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4141
ms.assetid: 6ce8c058-7f4c-41cf-93e7-90a466744656
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4141
'modifier' : used more than once  
  
## Example  
  
```  
// C4141.cpp  
// compile with: /W1 /LD  
inline inline void func ();   // C4141  
```