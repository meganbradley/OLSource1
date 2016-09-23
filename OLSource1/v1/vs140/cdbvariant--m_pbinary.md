---
title: "CDBVariant::m_pbinary"
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
  - m_pbinary
  - CDBVariant.m_pbinary
  - CDBVariant::m_pbinary
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_pbinary
ms.assetid: 604bc983-9967-4ad0-bf74-c64e7f244469
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDBVariant::m_pbinary
Stores a pointer to an object of type [CLongBinary](../vs140/clongbinary-class.md).  
  
## Remarks  
 The **m_pbinary** data member belongs to a union. Before accessing **m_pbinary**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If `m_dwType` is set to **DBVT_BINARY**, then **m_pbinary** contains a valid pointer; otherwise, accessing **m_pbinary** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)