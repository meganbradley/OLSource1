---
title: "CDBVariant::m_lVal"
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
  - "m_lVal"
  - "CDBVariant::m_lVal"
  - "CDBVariant.m_lVal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_lVal"
ms.assetid: b3ab3645-aeea-4a71-9a2f-610a18a75c5a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_lVal
Stores a value of type **long**.  
  
## Remarks  
 The **m_lVal** data member belongs to a union. Before accessing **m_lVal**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is set to **DBVT_LONG**, then **m_lVal** contains a valid value; otherwise, accessing **m_lVal** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)