---
title: "CDBVariant::m_dwType"
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
  - "CDBVariant::m_dwType"
  - "m_dwType"
  - "CDBVariant.m_dwType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DBVT_DOUBLE"
  - "DBVT_NULL"
  - "DBVT_STRING"
  - "DBVT_LONG"
  - "DBVT_UBYTE"
  - "DBVT_BINARY"
  - "m_dwType"
  - "DBVT_SHORT"
  - "DBVT_BOOL"
  - "DBVT_SINGLE"
  - "DBVT_DATE"
ms.assetid: b80cce28-9b3a-49ee-875d-0cdb49bf1b2d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBVariant::m_dwType
This data member contains the data type for the value that is currently stored in the `CDBVariant` object's union data member.  
  
## Remarks  
 Before accessing this union, you must check the value of `m_dwType` in order to determine which union data member to access. The following table lists the possible values for `m_dwType` and the corresponding union data member.  
  
|m_dwType|Union data member|  
|---------------|-----------------------|  
|**DBVT_NULL**|No union member is valid for access.|  
|**DBVT_BOOL**|[m_boolVal](../vs140/cdbvariant--m_boolval.md)|  
|**DBVT_UCHAR**|[m_chVal](../vs140/cdbvariant--m_chval.md)|  
|**DBVT_SHORT**|[m_iVal](../vs140/cdbvariant--m_ival.md)|  
|**DBVT_LONG**|[m_lVal](../vs140/cdbvariant--m_lval.md)|  
|**DBVT_SINGLE**|[m_fltVal](../vs140/cdbvariant--m_fltval.md)|  
|**DBVT_DOUBLE**|[m_dblVal](../vs140/cdbvariant--m_dblval.md)|  
|**DBVT_DATE**|[m_pdate](../vs140/cdbvariant--m_pdate.md)|  
|**DBVT_STRING**|[m_pstring](../vs140/cdbvariant--m_pstring.md)|  
|**DBVT_BINARY**|[m_pbinary](../vs140/cdbvariant--m_pbinary.md)|  
|**DBVT_ASTRING**|[m_pstringA](../vs140/cdbvariant--m_pstringa.md)|  
|**DBVT_WSTRING**|[m_pstringW](../vs140/cdbvariant--m_pstringw.md)|  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)