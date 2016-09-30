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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _disable
**Microsoft Specific**  
  
 Disables interrupts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instructs the processor to clear the interrupt flag. On x86 systems, this function generates the Clear Interrupt Flag (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) instruction.  
  
 This function is only available in kernel mode. If used in user mode, a Privileged Instruction exception is thrown at run time.  
  
 On ARM platforms, this routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)