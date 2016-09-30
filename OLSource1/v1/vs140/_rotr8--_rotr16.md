---
title: "_rotr8, _rotr16"
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
  - "_rotr16"
  - "_rotr8"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_rotr8 intrinsic"
  - "_rotr16 intrinsic"
ms.assetid: dfbd2c82-82b4-427a-ad52-51609027ebff
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _rotr8, _rotr16
**Microsoft Specific**  
  
 Rotate the input values to the right to the least significant bit (LSB) by a specified number of bit positions.  
  
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
 Unlike a right-shift operation, when executing a right rotation, the low order bits that fall off the low end are moved into the high order bit positions.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Rotating 0x41 right by 0 bits gives 0x41**  
**Rotating 0x41 right by 1 bits gives 0xa0**  
**Rotating 0x41 right by 2 bits gives 0x50**  
**Rotating 0x41 right by 3 bits gives 0x28**  
**Rotating 0x41 right by 4 bits gives 0x14**  
**Rotating 0x41 right by 5 bits gives 0xa**  
**Rotating 0x41 right by 6 bits gives 0x5**  
**Rotating 0x41 right by 7 bits gives 0x82**  
**Rotating unsigned short 0x12 right by 10 bits gives 0x480**   
## END Microsoft Specific  
  
## See Also  
 [_rotl8, _rotl16](../vs140/_rotl8--_rotl16.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)