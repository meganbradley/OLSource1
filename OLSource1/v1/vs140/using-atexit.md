---
title: "Using atexit"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "atexit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atexit function"
ms.assetid: d28fda17-c3d4-4af6-ba44-f44886bbb237
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using atexit
With the [atexit](../vs140/atexit.md) function, you can specify an exit-processing function that executes prior to program termination. No global static objects initialized prior to the call to `atexit` are destroyed prior to execution of the exit-processing function.  
  
## See Also  
 [Additional Termination Considerations](../vs140/additional-termination-considerations.md)