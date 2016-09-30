---
title: "CDBVariant::m_chVal"
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
  - "CDBVariant.m_chVal"
  - "CDBVariant::m_chVal"
  - "m_chVal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_chVal"
ms.assetid: 01cef6ae-4f84-412b-9a8e-6cf9da0568a7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_chVal
Stores a value of type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
## Remarks  
 The **m_chVal** data member belongs to a union. Before accessing **m_chVal**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is set to **DBVT_UCHAR**, then **m_chVal** contains a valid value; otherwise, accessing **m_chVal** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)