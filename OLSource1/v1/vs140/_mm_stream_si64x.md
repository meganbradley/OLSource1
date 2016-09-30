---
title: "_mm_stream_si64x"
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
  - "_mm_stream_si64x"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "movnti instruction"
  - "_mm_stream_si64x intrinsic"
ms.assetid: 114c2cd0-085f-41aa-846e-87bdd56c9ee7
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mm_stream_si64x
**Microsoft Specific**  
  
 Generates the MOVNTI instruction. Writes the data in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to a memory location specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, without polluting the caches.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the location to write the source data to.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The data to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0 ffffffffffff 0 0**   
## END Microsoft Specific  
  
## See Also  
 [Cache Support for Streaming SIMD Extensions 2 Integer Operations](assetId:///a9c9b42f-de9e-4374-aeb6-5f65bfb669b6)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)