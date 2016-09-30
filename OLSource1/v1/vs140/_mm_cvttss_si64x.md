---
title: "_mm_cvttss_si64x"
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
  - "_mm_cvttss_si64x"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_mm_cvttss_si64x intrinsic"
  - "cvttss2si instruction"
ms.assetid: f9a3fd07-5bd8-4758-8744-6315c082cf87
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_cvttss_si64x
**Microsoft Specific**  
  
 Emits the x64 extended version of the Convert with Truncation Single-Precision Floating-Point Number to 64-Bit Integer (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure containing single-precision floating-point values.  
  
## Return Value  
 The result of the conversion of the first floating-point value to a 64-bit integer.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The intrinsic differs from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> only in that inexact conversions are truncated toward zero. Because the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure represents an XMM register, the instruction generated moves data from an XMM register into system memory.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **101**   
## END Microsoft Specific  
  
## See Also  
 [__m128](../vs140/__m128.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)