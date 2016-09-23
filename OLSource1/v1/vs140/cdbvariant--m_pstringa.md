---
title: "CDBVariant::m_pstringA"
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
  - m_pstringA
  - CDBVariant.m_pstringA
  - CDBVAriant::m_pstringA
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_pstringA
ms.assetid: d6c95e70-5e03-40f3-8bac-658b1973e904
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDBVariant::m_pstringA
Stores a pointer to an ASCII [CString](../vs140/cstringt-class.md) object.  
  
## Remarks  
 The **m_pstringA** data member belongs to a union. Before accessing **m_pstringA**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If `m_dwType` is set to **DBVT_ASTRING**, then **m_pstringA** contains a valid pointer; otherwise, accessing **m_pstringA** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)