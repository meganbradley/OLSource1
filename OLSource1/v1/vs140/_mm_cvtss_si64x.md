---
title: "_mm_cvtss_si64x"
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
  - "_mm_cvtss_si64x"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cvtss2si intrinsic"
  - "_mm_cvtss_si64x intrinsic"
ms.assetid: c279aff2-ee29-4271-8829-3ec691bf7718
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_cvtss_si64x
**Microsoft Specific**  
  
 Generates the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] extended version of the Convert Scalar Single Precision Floating Point Number to 64-bit Integer (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure containing floating point-values.  
  
## Return Value  
 A 64-bit integer, the result of the conversion of the first floating-point value to an integer.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The first element of the structure value is converted to an integer and returned. The rounding control bits in MXCSR are used to determine the rounding behavior. The default rounding mode is round to nearest, rounding to the even number if the decimal part is 0.5. Because the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure represents an XMM register, this intrinsic takes a value from the XMM register and writes it to system memory.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **101**   
## END Microsoft Specific  
  
## See Also  
 [__m128d](../vs140/__m128d.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)