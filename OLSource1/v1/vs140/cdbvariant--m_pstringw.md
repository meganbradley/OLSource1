---
title: "CDBVariant::m_pstringW"
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
  - CDBVAriant::m_pstringW
  - m_pstringW
  - CDBVariant.m_pstringW
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_pstringW
ms.assetid: 3c44e212-f2ba-4c58-a60f-00b0a84ead69
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDBVariant::m_pstringW
Stores a pointer to a wide [CString](../vs140/cstringt-class.md) object.  
  
## Remarks  
 The **m_pstringW** data member belongs to a union. Before accessing **m_pstringW**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If `m_dwType` is set to **DBVT_WSTRING**, then **m_pstringW** contains a valid pointer; otherwise, accessing **m_pstringW** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)