---
title: "_disable"
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
  - "_disable_cpp"
  - "_disable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_disable intrinsic"
  - "rsm instruction"
  - "disable intrinsic"
ms.assetid: 52da3df9-815c-4524-9839-6d1742cff5c6
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _disable
**Microsoft Specific**  
  
 Disables interrupts.  
  
## Syntax  
  
```  
void _disable(void);  
```  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`_disable`|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** <intrin.h>  
  
## Remarks  
 `_disable` instructs the processor to clear the interrupt flag. On x86 systems, this function generates the Clear Interrupt Flag (`cli`) instruction.  
  
 This function is only available in kernel mode. If used in user mode, a Privileged Instruction exception is thrown at run time.  
  
 On ARM platforms, this routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)