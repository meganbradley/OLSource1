---
title: "_rotl8, _rotl16"
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
  - "_rotl8"
  - "_rotl16"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_rotl8 intrinsic"
  - "_rotl16 intrinsic"
ms.assetid: 8c519ab6-aef9-4f07-a387-daee8408368f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _rotl8, _rotl16
**Microsoft Specific**  
  
 Rotate the input values to the left to the most significant bit (MSB) by a specified number of bit positions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to rotate.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of bits to rotate.  
  
## Return Value  
 The rotated value.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 Unlike a left-shift operation, when executing a left rotation, the high order bits that fall off the high end are moved into the least significant bit positions.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Rotating 0x41 left by 0 bits gives 0x41**  
**Rotating 0x41 left by 1 bits gives 0x82**  
**Rotating 0x41 left by 2 bits gives 0x5**  
**Rotating 0x41 left by 3 bits gives 0xa**  
**Rotating 0x41 left by 4 bits gives 0x14**  
**Rotating 0x41 left by 5 bits gives 0x28**  
**Rotating 0x41 left by 6 bits gives 0x50**  
**Rotating 0x41 left by 7 bits gives 0xa0**  
**Rotating unsigned short 0x12 left by 10 bits gives 0x4800**   
## END Microsoft Specific  
  
## See Also  
 [_rotr8, _rotr16](../vs140/_rotr8--_rotr16.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)