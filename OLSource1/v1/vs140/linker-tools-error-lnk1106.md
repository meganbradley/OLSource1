---
title: "Linker Tools Error LNK1106"
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
  - LNK1106
dev_langs: 
  - C++
helpviewer_keywords: 
  - LNK1106
ms.assetid: 528f7e65-04be-4966-b8af-9276837c7cda
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Tools Error LNK1106
invalid file or disk full: cannot seek to location  
  
 The tool could not read or write to `location` in a memory-mapped file.  
  
### To fix by checking the following possible causes  
  
1.  Disk full.  
  
     Free up some space and link again.  
  
2.  Trying to link over a network.  
  
     Some networks do not fully support the memory-mapped files used by the linker. Try linking on your local disk.  
  
3.  Bad block on your disk.  
  
     Although the operating system and disk hardware should have detected such an error, you may want to run a disk-checking program.  
  
4.  Out of heap space.  
  
     See [C1060](../vs140/fatal-error-c1060.md) for more information.