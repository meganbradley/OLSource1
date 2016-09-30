---
title: "_bittest, _bittest64"
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
  - "_bittest64"
  - "_bittest_cpp"
  - "_bittest64_cpp"
  - "_bittest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_bittest intrinsic"
  - "_bittest64 intrinsic"
  - "bt instruction"
ms.assetid: 15e62afb-abea-4ee7-a6b1-13efa2034937
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bittest, _bittest64
**Microsoft Specific**  
  
 Generates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instruction, which examines the bit in position <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of address <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and returns the value of that bit.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the memory to examine.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The bit position to test.  
  
## Return Value  
 The bit at the position specified.  
  
## Requirements  
  
|Intrinsic|Architecture|Header|  
|---------------|------------------|------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86, ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|ARM, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|\<intrin.h>|  
  
## Remarks  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Number: 78002**  
**Binary representation:**  
**0000000000000010011000010110010**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)