---
title: "CDBVariant::Clear"
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
  - CDBVariant::Clear
  - CDBVariant.Clear
dev_langs: 
  - C++
helpviewer_keywords: 
  - Clear method
  - CDBVariant class, clearing
ms.assetid: 05ca8d30-ce32-4858-a9b1-66685a22b00f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDBVariant::Clear
Call this member function to clear the `CDBVariant` object.  
  
## Syntax  
  
```  
  
void Clear( );  
  
```  
  
## Remarks  
 If the value of the [m_dwType](../vs140/cdbvariant--m_dwtype.md) data member is **DBVT_DATE**, **DBVT_STRING**, or **DBVT_BINARY**, **Clear** frees the memory associated with the union pointer member. **Clear** sets `m_dwType` to **DBVT_NULL**.  
  
 The `CDBVariant` destructor calls **Clear**.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDBVariant Class](../vs140/cdbvariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDBVariant::m_dwType](../vs140/cdbvariant--m_dwtype.md)