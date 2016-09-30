---
title: "__inbyte"
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
  - "__inbyte"
  - "__inbyte_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "in instruction"
  - "__inbyte intrinsic"
ms.assetid: 03b61799-2a08-474d-adc4-2cbf7c81a4d5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __inbyte
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> instruction, returning one byte read from the port specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The port to read from.  
  
## Return Value  
 The byte read from the specified port.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## END Microsoft Specific  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)