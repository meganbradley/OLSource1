---
title: "__readpmc"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - __readpmc
dev_langs: 
  - C++
helpviewer_keywords: 
  - Read Performance Monitoring Counters instruction
  - __readpmc intrinsic
  - rdpmc instruction
ms.assetid: 14ed45a6-28b6-4635-8437-a597c04b43d4
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# __readpmc
**Microsoft Specific**  
  
 Generates the `rdpmc` instruction, which reads the performance monitoring counter specified by `counter`.  
  
## Syntax  
  
```  
unsigned __int64 __readpmc(   
   unsigned long counter   
);  
```  
  
#### Parameters  
 [in] `counter`  
 The performance counter to read.  
  
## Return Value  
 The value of the specified performance counter.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`__readpmc`|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** <intrin.h>  
  
## Remarks  
 This intrinsic is available in kernel mode only, and the routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)