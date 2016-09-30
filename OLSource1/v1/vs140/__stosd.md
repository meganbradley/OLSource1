---
title: "__stosd"
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
  - "__stosd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stosd instruction"
  - "rep stosd instruction"
  - "__stosd intrinsic"
ms.assetid: 03104247-1cea-49f6-b6f8-287917bf5680
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __stosd
**Microsoft Specific**  
  
 Generates a store string instruction (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The destination of the operation.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The data to store.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The length of the block of doublewords to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The result is that the doubleword <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is written into a block of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> doublewords at the memory location pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0 99999 99999 0**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)