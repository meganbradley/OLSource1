---
title: "CDaoWorkspace::BeginTrans"
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
  - "CDaoWorkspace::BeginTrans"
  - "CDaoWorkspace.BeginTrans"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), transactions"
  - "transactions, initiation"
  - "beginning transactions"
  - "BeginTrans method"
ms.assetid: 9bb6acb5-7935-438c-b0e9-ccb6b06269bb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::BeginTrans
Call this member function to initiate a transaction.  
  
## Syntax  
  
```  
  
void BeginTrans( );  
  
```  
  
## Remarks  
 After you call **BeginTrans**, updates you make to your data or database structure take effect when you commit the transaction. Because the workspace defines a single transaction space, the transaction applies to all open databases in the workspace. There are two ways to complete the transaction:  
  
-   Call the [CommitTrans](../vs140/cdaoworkspace--committrans.md) member function to commit the transaction and save changes to the data source.  
  
-   Or call the [Rollback](../vs140/cdaoworkspace--rollback.md) member function to cancel the transaction.  
  
 Closing the workspace object or a database object while a transaction is pending rolls back all pending transactions.  
  
 If you need to isolate transactions on one ODBC data source from those on another ODBC data source, see the [SetIsolateODBCTrans](../vs140/cdaoworkspace--setisolateodbctrans.md) member function.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::GetIsolateODBCTrans](../vs140/cdaoworkspace--getisolateodbctrans.md)   
 [CDaoWorkspace::CommitTrans](../vs140/cdaoworkspace--committrans.md)   
 [CDaoWorkspace::Rollback](../vs140/cdaoworkspace--rollback.md)