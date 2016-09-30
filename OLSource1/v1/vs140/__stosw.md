---
title: "__stosw"
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
  - "__stosw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stosw instruction"
  - "__stosw intrinsic"
  - "rep stosw instruction"
ms.assetid: 7620fd1d-dba5-40e3-8e07-01aa68895133
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __stosw
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
 The length of the block of words to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86, [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)]|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The result is that the word <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is written into a block of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> words in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> string.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0 128 128 0**   
## END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)