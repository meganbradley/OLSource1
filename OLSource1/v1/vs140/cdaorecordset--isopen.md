---
title: "CDaoRecordset::IsOpen"
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
  - IsOpen
  - CDaoRecordset.IsOpen
  - CDaoRecordset::IsOpen
dev_langs: 
  - C++
helpviewer_keywords: 
  - open state
  - open state, recordsets
  - recordsets, is open
  - IsOpen method
  - CDaoRecordset class, is open
ms.assetid: 69f18194-5b69-48b3-aa88-53c6e8045468
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::IsOpen
Call this member function to determine if the recordset is open.  
  
## Syntax  
  
```  
  
BOOL IsOpen( ) const;  
  
```  
  
## Return Value  
 Nonzero if the recordset object's **Open** or **Requery** member function has previously been called and the recordset has not been closed; otherwise 0.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::Open](../vs140/cdaorecordset--open.md)   
 [CDaoRecordset::Close](../vs140/cdaorecordset--close.md)