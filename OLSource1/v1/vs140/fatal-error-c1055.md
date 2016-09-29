---
title: "Fatal Error C1055"
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
  - "C1055"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1055"
ms.assetid: a9fb9190-d7eb-4d5f-b1a2-a41e584a28c1
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1055
compiler limit : out of keys  
  
 The source file contains too many symbols. The compiler ran out of hash keys for the symbol table.  
  
### To fix by using the following possible solutions  
  
1.  Split the source file into smaller files.  
  
2.  Eliminate unnecessary header files.  
  
3.  Reuse temporary and global variables instead of creating new ones.