---
title: "__sidt"
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
  - "__sidt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sidt instruction"
  - "__sidt intrinsic"
ms.assetid: 01e83d14-6e63-4dea-8f64-5a0339d69641
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __sidt
**Microsoft Specific**  
  
 Stores the value of the interrupt descriptor table register (IDTR) in the specified memory location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the memory location where the IDTR is stored.|  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function is equivalent to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> machine instruction. For more information, search for the document, "Intel Architecture Software Developer's Manual, Volume 2: Instruction Set Reference," at the [Intel Corporation](http://go.microsoft.com/fwlink/?LinkId=127) site.  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)   
 [__lidt](../vs140/__lidt.md)