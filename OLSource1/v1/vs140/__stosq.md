---
title: "__stosq"
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
  - "__stosq"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rep stosq instruction"
  - "stosq instruction"
  - "__stosq intrinsic"
ms.assetid: 3ea28297-4369-4c2d-bf0c-91fa539ce209
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __stosq
**Microsoft Specific**  
  
 Generates a store string instruction (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The destination of the operation.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The data to store.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The length of the block of quadwords to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|AMD64|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 The result is that the quadword <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is written into a block of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> quadwords in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> string.  
  
 This routine is only available as an intrinsic.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### END Microsoft Specific  
  
## See Also  
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)