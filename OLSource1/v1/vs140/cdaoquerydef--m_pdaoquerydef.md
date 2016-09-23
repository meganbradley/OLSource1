---
title: "CDaoQueryDef::m_pDAOQueryDef"
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
  - CDaoQueryDef.m_pDAOQueryDef
  - CDaoQueryDef::m_pDAOQueryDef
  - m_pDAOQueryDef
dev_langs: 
  - C++
helpviewer_keywords: 
  - DAO (Data Access Objects), pointer to querydef objects
  - DAO (Data Access Objects), calling directly
  - CDaoQueryDef class, pointer to OLE interface
  - m_pDAOQueryDef
  - OLE, interface for querydef
  - pointers, to querydef DAO objects
ms.assetid: 0203ecfd-f6fa-43ec-979e-049382deb8b0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoQueryDef::m_pDAOQueryDef
Contains a pointer to the OLE interface for the underlying DAO querydef object.  
  
## Remarks  
 This pointer is provided for completeness and consistency with the other classes. However, because MFC rather fully encapsulates DAO querydefs, you are unlikely to need it. If you do use it, do so cautiously — in particular, do not change the value of the pointer unless you know what you are doing.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)