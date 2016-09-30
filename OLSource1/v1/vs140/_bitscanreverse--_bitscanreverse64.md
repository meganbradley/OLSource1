---
title: "_BitScanReverse, _BitScanReverse64"
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
  - "_BitScanReverse64"
  - "_BitScanReverse_cpp"
  - "_BitScanReverse"
  - "_BitScanReverse64_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bsr instruction"
  - "_BitScanReverse intrinsic"
  - "BitScanReverse intrinsic"
ms.assetid: 2520a207-af8b-4aad-9ae7-831abeadf376
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _BitScanReverse, _BitScanReverse64
**Microsoft Specific**  
  
 Search the mask data from most significant bit (MSB) to least significant bit (LSB) for a set bit (1).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Loaded with the bit position of the first set bit (1) found.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The 32-bit or 64-bit value to search.  
  
## Return Value  
 Nonzero if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> was set, or 0 if no set bits were found.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]||  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)