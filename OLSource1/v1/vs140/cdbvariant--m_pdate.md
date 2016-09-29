---
title: "CDBVariant::m_pdate"
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
  - "CDBVariant.m_pdate"
  - "m_pdate"
  - "CDBVariant::m_pdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pdate"
ms.assetid: 958e745e-20bc-4102-bd8c-7493cf4da1d0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_pdate
Stores a pointer to an object of type **TIMESTAMP_STRUCT**.  
  
## Remarks  
 The **m_pdate** data member belongs to a union. Before accessing **m_pdate**, first check the value of [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md). If `m_dwType` is set to **DBVT_DATE**, then **m_pdate** contains a valid pointer; otherwise, accessing **m_pdate** will produce unreliable results.  
  
 For more information about the **TIMESTAMP_STRUCT** data type, see the topic [C Data Types](https://msdn.microsoft.com/en-us/library/ms714556.aspx) in Appendix D of the *ODBC Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)