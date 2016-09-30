---
title: "AfxIsMemoryBlock"
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
  - "AFX/AfxIsMemoryBlock"
  - "AfxIsMemoryBlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxIsMemoryBlock function"
ms.assetid: 2273be29-8955-4859-9711-21d6cbff893b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxIsMemoryBlock
Tests a memory address to make sure it represents a currently active memory block that was allocated by the diagnostic version of **new**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the block of memory to be tested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the length of the memory block in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a **long** integer that will be filled in with the memory block's allocation sequence number, or zero if it does not represent a currently active memory block.  
  
## Return Value  
 Nonzero if the memory block is currently allocated and the length is correct; otherwise 0.  
  
## Remarks  
 It also checks the specified size against the original allocated size. If the function returns nonzero, the allocation sequence number is returned in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This number represents the order in which the block was allocated relative to all other **new** allocations.  
  
## Example  
 [!code[NVC_MFC_Utilities#27](../vs140/codesnippet/CPP/afxismemoryblock_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxIsValidAddress](../vs140/afxisvalidaddress.md)