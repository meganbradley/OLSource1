---
title: "CRecordset::Cancel"
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
  - "CRecordset::Cancel"
  - "Cancel"
  - "CRecordset.Cancel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Cancel method"
ms.assetid: fb817bca-7dc4-449a-b608-bf70d9ff7a9a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::Cancel
Requests that the data source cancel either an asynchronous operation in progress or a process from a second thread.  
  
## Syntax  
  
```  
  
void Cancel( );  
```  
  
## Remarks  
 Note that the MFC ODBC classes no longer use asynchronous processing; to perform an asychronous operation, you must directly call the ODBC API function **SQLSetConnectOption**. For more information, see the topic "Executing Functions Asynchronously" in the *ODBC SDK Programmer's Guide*.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)