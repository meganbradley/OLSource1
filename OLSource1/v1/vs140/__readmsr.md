---
title: "__readmsr"
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
  - "__readmsr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Read Model Specific Register"
  - "rdmsr instruction"
  - "__readmsr intrinsic"
ms.assetid: 7ab1f8e8-72cb-4ce4-817d-3e728a3c9716
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __readmsr
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instruction, which reads the model-specific register specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and returns its value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The model specific register to read.  
  
## Return Value  
 The value in the specified register.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This function is only available in kernel mode, and the routine is only available as an intrinsic.  
  
 For more information, see the AMD documentation.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)