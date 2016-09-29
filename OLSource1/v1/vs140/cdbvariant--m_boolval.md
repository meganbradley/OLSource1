---
title: "CDBVariant::m_boolVal"
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
  - "CDBVariant.m_boolVal"
  - "CDBVariant::m_boolVal"
  - "m_boolVal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_boolVal"
ms.assetid: 2a609444-e82d-4b57-a929-f2002176ff1e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_boolVal
Stores a value of type **BOOL**.  
  
## Remarks  
 The **m_boolVal** data member belongs to a union. Before accessing **m_boolVal**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If `m_dwType` is set to **DBVT_BOOL**, then **m_boolVal** will contain a valid value; otherwise, accessing **m_boolVal** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)