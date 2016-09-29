---
title: "CDBVariant::m_dblVal"
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
  - "CDBVariant::m_dblVal"
  - "m_dblVal"
  - "CDBVariant.m_dblVal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dblVal"
ms.assetid: 6da6cb88-1313-45a4-a661-b3fa3279b378
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_dblVal
Stores a value of type **double**.  
  
## Remarks  
 The **m_dblVal** data member belongs to a union. Before accessing **m_dblVal**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If `m_dwType` is set to **DBVT_DOUBLE**, then **m_dblVal** contains a valid value; otherwise, accessing **m_dblVal** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)