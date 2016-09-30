---
title: "CRecordset::RefreshRowset"
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
  - "SQL_LOCK_NO_CHANGE"
  - "CRecordset.RefreshRowset"
  - "SQL_LOCK_EXCLUSIVE"
  - "SQL_LOCK_UNLOCK"
  - "CRecordset::RefreshRowset"
  - "RefreshRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SQL_LOCK_UNLOCK"
  - "SQL_LOCK_EXCLUSIVE"
  - "SQL_LOCK_NO_CHANGE"
  - "rowsets, refreshing"
  - "RefreshRowset method"
ms.assetid: a66e0331-1509-4af7-a6ec-206a514cc8bb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::RefreshRowset
Updates the data and the status for a row in the current rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The one-based position of a row in the current rowset. This value can range from zero to the size of the rowset.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value indicating how to lock the row after it has been refreshed. For details, see Remarks.  
  
## Remarks  
 If you pass a value of zero for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, then every row in the rowset will be refreshed.  
  
 To use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you must have implemented bulk row fetching by specifying the **CRecordset::useMulitRowFetch** option in the [Open](../vs140/crecordset--open.md) member function.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calls the ODBC API function **SQLSetPos**. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter specifies the lock state of the row after **SQLSetPos** has executed. The following table describes the possible values for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>e.  
  
|wLockType|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (the default value)|The driver or data source ensures that the row is in the same locked or unlocked state as it was before <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> was called.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The driver or data source locks the row exclusively. Not all data sources support this type of lock.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The driver or data source unlocks the row. Not all data sources support this type of lock.|  
  
 For more information about **SQLSetPos**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::SetRowsetCursorPosition](../vs140/crecordset--setrowsetcursorposition.md)   
 [CRecordset::SetRowsetSize](../vs140/crecordset--setrowsetsize.md)