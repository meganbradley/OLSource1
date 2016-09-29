---
title: "Compiler Warning (level 1) C4659"
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
  - "C4659"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4659"
ms.assetid: e29ba8db-7917-43f6-8e34-868b752279ae
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4659
\#pragma 'pragma' : use of reserved segment 'segment' has undefined behavior, use #pragma comment(linker, ...)  
  
 The .drectve option was used to pass an option to the linker. Instead use pragma [comment](../vs140/comment--c-c---.md) for passing a linker option.  
  
```  
// C4659.cpp  
// compile with: /W1 /LD  
#pragma code_seg(".drectve")   // C4659  
```