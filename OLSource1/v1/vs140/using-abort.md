---
title: "Using abort"
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
  - "Abort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "abort function"
ms.assetid: 3ba39b78-ef74-4a8d-8dee-2d62442de174
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using abort
Calling the [abort](../vs140/abort.md) function causes immediate termination. It bypasses the normal destruction process for initialized global static objects. It also bypasses any special processing that was specified using the `atexit` function.  
  
## See Also  
 [Additional Termination Considerations](../vs140/additional-termination-considerations.md)