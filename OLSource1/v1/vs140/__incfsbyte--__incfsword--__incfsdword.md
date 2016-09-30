---
title: "__incfsbyte, __incfsword, __incfsdword"
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
  - "__incfsword"
  - "__incfsbyte_cpp"
  - "__incfsbyte"
  - "__incfsdword"
  - "__incfsword_cpp"
  - "__incfsdword_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__incfsword intrinsic"
  - "__incfsdword intrinsic"
  - "__incfsbyte intrinsic"
ms.assetid: 820457fb-e35e-42d3-bcb6-725da3281c64
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __incfsbyte, __incfsword, __incfsdword
**Microsoft Specific**  
  
 Add one to the value at a memory location specified by an offset relative to the beginning of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> segment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The offset from the beginning of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86|  
  
## Remarks  
 These intrinsics are only available in kernel mode, and the routines are only available as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [__addfsbyte, \__addfsword, \__adfsdword](../vs140/__addfsbyte--__addfsword--__addfsdword.md)   
 [__readfsbyte, \__readfsdword, \__readfsqword, \__readfsword](../vs140/__readfsbyte--__readfsdword--__readfsqword--__readfsword.md)   
 [__writefsbyte, \__writefsdword, \__writefsqword, \__writefsword](../vs140/__writefsbyte--__writefsdword--__writefsqword--__writefsword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)