---
title: "_bittestandset, _bittestandset64"
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
  - "_bittestandset_cpp"
  - "_bittestandset64_cpp"
  - "_bittestandset64"
  - "_bittestandset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bts instruction"
  - "_bittestandset intrinsic"
  - "_bittestandset64 intrinsic"
ms.assetid: 6d6c8670-fea0-4c1c-9aad-2bb842715203
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bittestandset, _bittestandset64
**Microsoft Specific**  
  
 Generate an instruction which examines bit <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the address <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, returns its current value, and sets the bit to 1.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in, out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the memory to examine.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The bit position to test.  
  
## Return Value  
 The bit at the position specified.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|[!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Flags: 0x2**  
**Flags: 0x6**  
**Flags: 0xe**  
**Flags: 0x6**  
**Flags: 0x4**  
**Flags: 0x0**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)