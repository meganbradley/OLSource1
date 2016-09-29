---
title: "__nop"
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
  - "__nop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nop instruction"
  - "__nop intrinsic"
ms.assetid: 7a2a938b-87e0-476d-a348-03ea7635b6b9
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __nop
**Microsoft Specific**  
  
 Generates platform-specific machine code that performs no operation.  
  
## Syntax  
  
```  
void __nop();  
```  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|`__nop`|x86, [!INCLUDE[vcprx64](../VS_csharp/includes/vcprx64_md.md)]|  
  
 **Header file** <intrin.h>  
  
## END Microsoft Specific  
  
## Remarks  
 The `__nop` function is equivalent to the `NOP` machine instruction. For more information, search for the document, "Intel Architecture Software Developer's Manual, Volume 2: Instruction Set Reference," at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site.  
  
## See Also  
 [Compiler Intrinsics](../VS_csharp/compiler-intrinsics.md)   
 [__noop](../VS_csharp/__noop.md)