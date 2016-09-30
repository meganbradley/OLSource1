---
title: "__movsd"
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
  - "__movsd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rep movsd instruction"
  - "__movsd intrinsic"
  - "movsd instruction"
ms.assetid: eb5cccf3-aa76-47f0-b9fc-eeca38fd943f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __movsd
**Microsoft Specific**  
  
 Generates a Move String (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) instruction.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The destination of the operation.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The source of the operation.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of doublewords to copy.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The result is that the first <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> doublewords pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are copied to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> string.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **950 850 750 650 550 450 350 250 150 50**    
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)