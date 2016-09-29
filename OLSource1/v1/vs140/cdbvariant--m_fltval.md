---
title: "CDBVariant::m_fltVal"
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
  - "m_fltVal"
  - "CDBVariant::m_fltVal"
  - "CDBVariant.m_fltVal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_fltVal"
ms.assetid: 8f6ffa6d-1d8f-4606-9c76-11cd7a4b8b11
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_fltVal
Stores a value of type **float**.  
  
## Remarks  
 The **m_fltVal** data member belongs to a union. Before accessing **m_fltVal**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If `m_dwType` is set to **DBVT_SINGLE**, then **m_fltVal** contains a valid value; otherwise, accessing **m_fltVal** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)