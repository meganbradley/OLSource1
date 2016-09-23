---
title: "CDaoWorkspace::Rollback"
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
  - Rollback
  - CDaoWorkspace.Rollback
  - CDaoWorkspace::Rollback
dev_langs: 
  - C++
helpviewer_keywords: 
  - workspaces [C++], rolling back transactions
  - DAO [C++], transactions
  - transactions [C++], rolling back
  - Rollback method, DAO workspace
  - Rollback method
ms.assetid: 664d521b-e0b8-4bab-a234-621199055c50
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoWorkspace::Rollback
Call this member function to end the current transaction and restore all databases in the workspace to their condition before the transaction was begun.  
  
## Syntax  
  
```  
  
void Rollback( );  
  
```  
  
## Remarks  
  
> [!CAUTION]
>  Within one workspace object, transactions are always global to the workspace and are not limited to only one database or recordset. If you perform operations on more than one database or recordset within a workspace transaction, **Rollback** restores all operations on all of those databases and recordsets.  
  
 If you close a workspace object without saving or rolling back any pending transactions, the transactions are automatically rolled back. If you call [CommitTrans](../vs140/cdaoworkspace--committrans.md) or **Rollback** without first calling [BeginTrans](../vs140/cdaoworkspace--begintrans.md), an error occurs.  
  
> [!NOTE]
>  When you begin a transaction, the database engine records its operations in a file kept in the directory specified by the TEMP environment variable on the workstation. If the transaction log file exhausts the available storage on your TEMP drive, the database engine will cause MFC to throw a `CDaoException` (DAO error 2004). At this point, if you call **CommitTrans**, an indeterminate number of operations are committed but the remaining uncompleted operations are lost, and the operation has to be restarted. Calling **Rollback** releases the transaction log and rolls back all operations in the transaction.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)