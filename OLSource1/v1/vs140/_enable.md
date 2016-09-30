---
title: "_enable"
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
  - "_enable"
  - "_enable_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enable intrinsic"
  - "_enable intrinsic"
  - "ssm instruction"
ms.assetid: 8bee669b-6bd8-4e25-9383-bb7d57295b4d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _enable
**Microsoft Specific**  
  
 Enables interrupts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instructs the processor to set the interrupt flag. On x86 systems, this function generates the Set Interrupt Flag (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) instruction.  
  
 This function is only available in kernel mode. If used in user mode, a Privileged Instruction exception is thrown.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)