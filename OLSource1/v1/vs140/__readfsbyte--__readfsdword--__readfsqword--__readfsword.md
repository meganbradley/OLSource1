---
title: "__readfsbyte, __readfsdword, __readfsqword, __readfsword"
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
  - "__readfsword"
  - "__readfsdword"
  - "__readfsbyte"
  - "__readfsqword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__readfsword intrinsic"
  - "readfsword intrinsic"
  - "__readfsdword intrinsic"
  - "readfsbyte intrinsic"
  - "__readfsbyte intrinsic"
  - "readfsdword intrinsic"
  - "readfsqword intrinsic"
  - "__readfsqword intrinsic"
ms.assetid: f6ee7203-4179-402c-a464-0746c84ce6ac
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __readfsbyte, __readfsdword, __readfsqword, __readfsword
**Microsoft Specific**  
  
 Read memory from a location specified by an offset relative to the beginning of the FS segment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The offset from the beginning of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to read from.  
  
## Return Value  
 The memory contents of the byte, word, doubleword, or quadword (as indicated by the name of the function called) at the location <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 These routines are available only as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [__writefsbyte, \__writefsdword, \__writefsqword, \__writefsword](../vs140/__writefsbyte--__writefsdword--__writefsqword--__writefsword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)