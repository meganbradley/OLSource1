---
title: "__writefsbyte, __writefsdword, __writefsqword, __writefsword"
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
  - "__writefsword"
  - "__writefsbyte"
  - "__writefsqword"
  - "__writefsdword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "writefsbyte intrinsic"
  - "__writefsword intrinsic"
  - "writefsqword intrinsic"
  - "writefsdword intrinsic"
  - "__writefsdword intrinsic"
  - "__writefsqword intrinsic"
  - "__writefsbyte intrinsic"
  - "writefsword intrinsic"
ms.assetid: 23ac6e8e-bc91-4e90-a4c6-da02993637ad
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __writefsbyte, __writefsdword, __writefsqword, __writefsword
**Microsoft Specific**  
  
 Write memory to a location specified by an offset relative to the beginning of the FS segment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The offset from the beginning of FS to write to.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to write.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86|  
  
 **Header file** \<intrin.h>  
  
## Remarks  
 These routines are available only as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [__readfsbyte, \__readfsdword, \__readfsqword, \__readfsword](../vs140/__readfsbyte--__readfsdword--__readfsqword--__readfsword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)