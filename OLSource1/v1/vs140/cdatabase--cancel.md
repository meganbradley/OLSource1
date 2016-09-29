---
title: "CDatabase::Cancel"
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
  - "Cancel"
  - "CDatabase::Cancel"
  - "CDatabase.Cancel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, database operations"
  - "Cancel method"
ms.assetid: 24013ba7-f4a3-4af0-8d5c-e6d35b92bf10
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::Cancel
Call this member function to request that the data source cancel either an asynchronous operation in progress or a process from a second thread.  
  
## Syntax  
  
```  
  
void Cancel( );  
```  
  
## Remarks  
 Note that the MFC ODBC classes no longer use asynchronous processing; to perform an asychronous operation, you must directly call the ODBC API function [SQLSetConnectOption](https://msdn.microsoft.com/en-us/library/ms713564.aspx). For more information, see [Asynchronous Execution](https://msdn.microsoft.com/en-us/library/ms713563.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)