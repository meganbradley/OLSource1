---
title: "CDBVariant::m_pstring"
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
  - "CDBVariant::m_pstring"
  - "m_pstring"
  - "CDBVariant.m_pstring"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pstring"
ms.assetid: 5d6d591f-9146-4654-b3b8-8358563c4f60
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_pstring
Stores a pointer to an object of type [CString](../vs140/cstringt-class.md).  
  
## Remarks  
 The **m_pstring** data member belongs to a union. Before accessing **m_pstring**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is set to **DBVT_STRING**, then **m_pstring** contains a valid pointer; otherwise, accessing **m_pstring** will produce unreliable results.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)