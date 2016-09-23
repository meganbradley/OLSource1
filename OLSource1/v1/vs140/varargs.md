---
title: "Varargs"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: aac0c54b-0a2d-4a22-b1de-ee41381a3eb1
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Varargs
If parameters are passed via varargs (for example, ellipsis arguments), then essentially the normal parameter passing applies including spilling the fifth and subsequent arguments. It is again the callee's responsibility to dump arguments that have their address taken. For floating-point values only, both the integer and the floating-point register will contain the float value in case the callee expects the value in the integer registers.  
  
## See Also  
 [Calling Convention](../vs140/calling-convention.md)