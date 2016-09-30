---
title: "__addfsbyte, __addfsword, __addfsdword"
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
  - "__addfsbyte_cpp"
  - "__addfsdword"
  - "__addfsword_cpp"
  - "__addfsbyte"
  - "__addfsword"
  - "__addfsdword_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__addfsdword intrinsic"
  - "__addfsword intrinsic"
  - "__addfsbyte intrinsic"
ms.assetid: 706c70df-6b52-4401-9268-2977ed8ad715
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __addfsbyte, __addfsword, __addfsdword
**Microsoft Specific**  
  
 Add a value to a memory location specified by an offset relative to the beginning of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> segment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The offset from the beginning of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value to add to the memory location.  
  
## Requirements  
  
|Intrinsic|Architecture|  
|---------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|x86|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|x86|  
  
## Remarks  
 These routines are available only as intrinsics.  
  
## END Microsoft Specific  
  
## See Also  
 [__incfsbyte, \__incfsword, \__incfsdword](../vs140/__incfsbyte--__incfsword--__incfsdword.md)   
 [__readfsbyte, \__readfsdword, \__readfsqword, \__readfsword](../vs140/__readfsbyte--__readfsdword--__readfsqword--__readfsword.md)   
 [__writefsbyte, \__writefsdword, \__writefsqword, \__writefsword](../vs140/__writefsbyte--__writefsdword--__writefsqword--__writefsword.md)   
 [Compiler Intrinsics](../vs140/compiler-intrinsics.md)