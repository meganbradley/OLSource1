---
title: "IAtlStringMgr::Free"
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
  - "IAtlStringMgr.Free"
  - "IAtlStringMgr::Free"
  - "ATL.IAtlStringMgr.Free"
  - "ATL::IAtlStringMgr::Free"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Free method"
ms.assetid: 7e806d9f-b2dc-4208-99a1-223f2393c786
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAtlStringMgr::Free
Frees a string data structure.  
  
## Syntax  
  
```  
  
      void Free(  
   CStringData* pData   
) throw( );  
```  
  
#### Parameters  
 `pData`  
 A pointer to the memory block to be freed.  
  
## Remarks  
 Frees the specified memory block previously allocated by [Allocate](../vs140/iatlstringmgr--allocate.md) or [Reallocate](../vs140/iatlmemmgr--reallocate.md).  
  
> [!NOTE]
>  For usage examples, see [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [IAtlStringMgr Class](../vs140/iatlstringmgr-class.md)   
 [IAtlStringMgr::Free](../vs140/iatlstringmgr--free.md)