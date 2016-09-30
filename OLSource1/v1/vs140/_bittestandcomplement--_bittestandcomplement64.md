---
title: "_bittestandcomplement, _bittestandcomplement64"
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
  - "_bittestandcomplement64"
  - "_bittestandcomplement64_cpp"
  - "_bittestandcomplement_cpp"
  - "_bittestandcomplement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "btc instruction"
  - "_bittestandcomplement intrinsic"
  - "_bittestandcomplement64 intrinsic"
ms.assetid: 53fa12dd-835e-4e5d-baec-a431c8678806
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bittestandcomplement, _bittestandcomplement64
**Microsoft Specific**  
  
 Generate an instruction which examines bit <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the address <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, returns its current value, and sets the bit to its complement.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the memory to examine.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The bit position to test.  
  
## Return Value  
 The bit at the position specified.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)