---
title: "CRecordset::CanTransact"
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
  - "CRecordset::CanTransact"
  - "CanTransact"
  - "CRecordset.CanTransact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanTransact method"
ms.assetid: 3d8285af-9e99-4fda-a154-511771702052
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::CanTransact
Determines whether the recordset allows transactions.  
  
## Syntax  
  
```  
  
BOOL CanTransact( ) const;  
```  
  
## Return Value  
 Nonzero if the recordset allows transactions; otherwise 0.  
  
## Remarks  
 For more information, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::BeginTrans](../vs140/cdatabase--begintrans.md)   
 [CDatabase::CommitTrans](../vs140/cdatabase--committrans.md)   
 [CDatabase::Rollback](../vs140/cdatabase--rollback.md)