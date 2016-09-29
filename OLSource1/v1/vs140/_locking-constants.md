---
title: "_locking Constants"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_LK_RLCK"
  - "_LK_NBLCK"
  - "_LK_LOCK"
  - "_LK_NBRLCK"
  - "_LK_UNLCK"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "LK_UNLCK constant"
  - "LK_NBRLCK constant"
  - "_LK_NBRLCK constant"
  - "_LK_NBLCK constant"
  - "_LK_LOCK constant"
  - "LK_NBLCK constant"
  - "_LK_UNLCK constant"
  - "LK_RLCK constant"
  - "_LK_RLCK constant"
  - "LK_LOCK constant"
ms.assetid: c3dc92c8-60e3-4d29-9f50-5d217627c8ad
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _locking Constants
## Syntax  
  
```  
  
#include <sys/locking.h>  
  
```  
  
## Remarks  
 The *mode* argument in the call to the `_locking` function specifies the locking action to be performed.  
  
 The *mode* argument must be one of the following manifest constants.  
  
 `_LK_LOCK`  
 Locks the specified bytes. If the bytes cannot be locked, the function tries again after 1 second. If, after 10 attempts, the bytes cannot be locked, the function returns an error.  
  
 `_LK_RLCK`  
 Same as `_LK_LOCK`.  
  
 `_LK_NBLCK`  
 Locks the specified bytes. If bytes cannot be locked, the function returns an error.  
  
 `_LK_NBRLCK`  
 Same as `_LK_NBLCK`.  
  
 `_LK_UNLCK`  
 Unlocks the specified bytes. (The bytes must have been previously locked.)  
  
## See Also  
 [_locking](../vs140/_locking.md)   
 [Global Constants](../vs140/global-constants.md)