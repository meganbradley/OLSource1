---
title: "CSimpleStringT::SetManager"
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
  - "ATL.CSimpleStringT<BaseType>.SetManager"
  - "ATL::CSimpleStringT::SetManager"
  - "SetManager"
  - "CSimpleStringT.SetManager"
  - "CSimpleStringT<BaseType>::SetManager"
  - "ATL.CSimpleStringT.SetManager"
  - "CSimpleStringT::SetManager"
  - "ATL::CSimpleStringT<BaseType>::SetManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetManager method"
ms.assetid: c3042934-59d3-4485-bf1c-16fbf36f37e2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::SetManager
Specifies the memory manager of the `CSimpleStringT` object.  
  
## Syntax  
  
```  
  
      void SetManager(  
   IAtlStringMgr* pStringMgr  
);  
```  
  
#### Parameters  
 `pStringMgr`  
 A pointer to the new memory manager.  
  
## Remarks  
 Call this method to specify a new memory manager used by the `CSimpleStringT` object. For more information on memory managers and string objects, see [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::SetManager`.  
  
 [!code[NVC_ATLMFC_Utilities#89](../vs140/codesnippet/CPP/csimplestringt--setmanager_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetManager](../vs140/csimplestringt--getmanager.md)