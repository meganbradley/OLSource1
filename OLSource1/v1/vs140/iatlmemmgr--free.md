---
title: "IAtlMemMgr::Free"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL.IAtlMemMgr.Free"
  - "ATL::IAtlMemMgr::Free"
  - "IAtlMemMgr::Free"
  - "IAtlMemMgr.Free"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Free method"
ms.assetid: 63e3a6ea-7c25-4f84-aa01-2c649129b12c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAtlMemMgr::Free
Call this method to free a block of memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
## Remarks  
 Use this method to free memory obtained by [IAtlMemMgr::Allocate](../vs140/iatlmemmgr--allocate.md) or [IAtlMemMgr::Reallocate](../vs140/iatlmemmgr--reallocate.md).  
  
## Example  
 For an example, see the [IAtlMemMgr Overview](../vs140/iatlmemmgr-class.md).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [IAtlMemMgr Class](../vs140/iatlmemmgr-class.md)