---
title: "__readcr2"
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
  - "__readcr2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__readcr2 intrinsic"
ms.assetid: d02c97d8-1953-46e7-a79e-a781e2c5bf27
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __readcr2
**Microsoft Specific**  
  
 Reads the CR2 register and returns its value.  
  
## Syntax  
  
```  
unsigned __int64 __readcr2(void);  
```  
  
## Return Value  
 The value in the CR2 register.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`__readcr2`|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** <intrin.h>  
  
## Remarks  
 This intrinsic is only available in kernel mode, and the routine is only available as an intrinsic.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)