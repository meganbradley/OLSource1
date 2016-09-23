---
title: "CSimpleStringT::GetManager"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CSimpleStringT.GetManager
  - CSimpleStringT::GetManager
  - CSimpleStringT<BaseType>::GetManager
  - ATL::CSimpleStringT::GetManager
  - ATL::CSimpleStringT<BaseType>::GetManager
  - CSimpleStringT.GetManager
  - GetManager
  - ATL.CSimpleStringT<BaseType>.GetManager
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetManager method
ms.assetid: 3348dcf2-fd92-4838-a15b-474e136880a4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleStringT::GetManager
Retrieves the memory manager of the `CSimpleStringT` object.  
  
## Syntax  
  
```  
  
IAtlStringMgr* GetManager( ) const throw( );  
  
```  
  
## Return Value  
 A pointer to the memory manager for the `CSimpleStringT` object.  
  
## Remarks  
 Call this method to retrieve the memory manager used by the `CSimpleStringT` object. For more information on memory managers and string objects, see [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::SetManager](../vs140/csimplestringt--setmanager.md)