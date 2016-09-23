---
title: "IRowsetImpl::m_rgRowHandles"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IRowsetImpl::m_rgRowHandles
  - IRowsetImpl.m_rgRowHandles
  - m_rgRowHandles
  - ATL::IRowsetImpl::m_rgRowHandles
  - ATL.IRowsetImpl.m_rgRowHandles
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_rgRowHandles
ms.assetid: d3c2578f-58c4-4301-bf59-cf101a523a95
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IRowsetImpl::m_rgRowHandles
A map of row handles currently contained by the provider in response to `GetNextRows`.  
  
## Syntax  
  
```  
  
MapClass  
 m_rgRowHandles;  
  
```  
  
## Remarks  
 Row handles are removed by calling `ReleaseRows`. See the [IRowsetImpl overview](../vs140/irowsetimpl-class.md) for the definition of *MapClass*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)