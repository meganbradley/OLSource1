---
title: "CDatabase::GetCursorCommitBehavior"
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
  - "GetCursorCommitBehavior"
  - "SQL_CB_PRESERVE"
  - "SQL_CB_CLOSE"
  - "SQL_CB_DELETE"
  - "CDatabase.GetCursorCommitBehavior"
  - "CDatabase::GetCursorCommitBehavior"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCursorCommitBehavior method"
  - "SQL_CB_PRESERVE"
  - "SQL_CB_CLOSE"
  - "SQL_CB_DELETE"
  - "transactions, cursor preservation"
ms.assetid: 84e516c5-69a9-4d00-8eca-70fdf02fdb0d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::GetCursorCommitBehavior
Call this member function to determine how a [CommitTrans](../vs140/cdatabase--committrans.md) operation affects cursors on open recordset objects.  
  
## Syntax  
  
```  
  
int GetCursorCommitBehavior( ) const;  
  
```  
  
## Return Value  
 A value indicating the effect of transactions on open recordset objects. For details, see Remarks.  
  
## Remarks  
 The following table lists the possible return values for `GetCursorCommitBehavior` and the corresponding effect on the open recordset.  
  
|Return value|Effect on CRecordset objects|  
|------------------|----------------------------------|  
|`SQL_CB_CLOSE`|Call `CRecordset::Requery` immediately following the transaction commit.|  
|`SQL_CB_DELETE`|Call `CRecordset::Close` immediately following the transaction commit.|  
|`SQL_CB_PRESERVE`|Proceed normally with `CRecordset` operations.|  
  
 For more information about this return value, see the ODBC API function **SQLGetInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::GetCursorRollbackBehavior](../vs140/cdatabase--getcursorrollbackbehavior.md)   
 [CDatabase::CanTransact](../vs140/cdatabase--cantransact.md)   
 [CDatabase::BeginTrans](../vs140/cdatabase--begintrans.md)   
 [CDatabase::CommitTrans](../vs140/cdatabase--committrans.md)   
 [CDatabase::Rollback](../vs140/cdatabase--rollback.md)   
 [CRecordset Class](../vs140/crecordset-class.md)