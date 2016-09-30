---
title: "_mm_cvtsi64x_ss"
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
  - "_mm_cvtsi64x_ss"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cvtsi2ss instruction"
  - "_mm_cvtsi64x_ss intrinsic"
ms.assetid: 01e5d321-c18a-46fd-a6f6-324364514e1f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_cvtsi64x_ss
**Microsoft Specific**  
  
 Generates the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] extended version of the Convert 64-Bit Integer to Scalar Single-Precision Floating-Point Value (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure containing four single-precision floating-point values.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A 64-bit integer to be converted into a floating-point value.  
  
## Return Value  
 An <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure whose first floating-point value is the result of the conversion. The other three values are copied unchanged from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|x64|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure represents an XMM register, so this intrinsic allows the value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> from system memory to be moved into an XMM register.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **54.000000 0.000000 0.000000 0.000000**   
## END Microsoft Specific  
  
## See Also  
 [__m128](../vs140/__m128.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)