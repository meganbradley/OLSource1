---
title: "IEnumOnSTLImpl::m_pcollection"
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
  - "IEnumOnSTLImpl::m_pcollection"
  - "m_pcollection"
  - "ATL::IEnumOnSTLImpl::m_pcollection"
  - "IEnumOnSTLImpl.m_pcollection"
  - "ATL.IEnumOnSTLImpl.m_pcollection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pcollection"
ms.assetid: 9352365c-e4f2-40ec-ba76-57f917673131
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IEnumOnSTLImpl::m_pcollection
This member points to the collection that provides the data driving the implementation of the enumerator interface.  
  
## Syntax  
  
```  
  
CollType* m_pcollection;  
  
```  
  
## Remarks  
 This member is initialized by a call to [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IEnumOnSTLImpl Class](../vs140/ienumonstlimpl-class.md)   
 [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md)