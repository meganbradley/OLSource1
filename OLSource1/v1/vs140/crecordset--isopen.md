---
title: "CRecordset::IsOpen"
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
  - "CRecordset.IsOpen"
  - "CRecordset::IsOpen"
  - "IsOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open state, recordsets"
  - "IsOpen method"
ms.assetid: 5c672129-2f5f-4711-952d-f81dfea7afb8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::IsOpen
Determines if the recordset is already open.  
  
## Syntax  
  
```  
  
BOOL IsOpen( ) const;  
```  
  
## Return Value  
 Nonzero if the recordset object's [Open](../vs140/crecordset--open.md) or [Requery](../vs140/crecordset--requery.md) member function has previously been called and the recordset has not been closed; otherwise 0.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)