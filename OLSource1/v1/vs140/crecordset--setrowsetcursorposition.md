---
title: "CRecordset::SetRowsetCursorPosition"
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
  - "CRecordset::SetRowsetCursorPosition"
  - "CRecordset.SetRowsetCursorPosition"
  - "SetRowsetCursorPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SQL_LOCK_UNLOCK"
  - "SQL_LOCK_EXCLUSIVE"
  - "rowsets, positioning"
  - "SQL_LOCK_NO_CHANGE"
  - "SetRowsetCursorPosition method"
ms.assetid: dd4bad32-e908-4c22-b96f-5e9a7a988336
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::SetRowsetCursorPosition
Moves the cursor to a row within the current rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The one-based position of a row in the current rowset. This value can range from 1 to the size of the rowset.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Value indicating how to lock the row after it has been refreshed. For details, see Remarks.  
  
## Remarks  
 When implementing bulk row fetching, records are retrieved by rowsets, where the first record in the fetched rowset is the current record. In order to make another record within the rowset the current record, call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For example, you can combine <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with the [GetFieldValue](../vs140/crecordset--getfieldvalue.md) member function to dynamically retrieve the data from any record of your recordset.  
  
 To use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you must have implemented bulk row fetching by specifying the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter in the [Open](../vs140/crecordset--open.md) member function.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> calls the ODBC API function **SQLSetPos**. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter specifies the lock state of the row after **SQLSetPos** has executed. The following table describes the possible values for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>e.  
  
|wLockType|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (the default value)|The driver or data source ensures that the row is in the same locked or unlocked state as it was before <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> was called.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The driver or data source locks the row exclusively. Not all data sources support this type of lock.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The driver or data source unlocks the row. Not all data sources support this type of lock.|  
  
 For more information about **SQLSetPos**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::RefreshRowset](../vs140/crecordset--refreshrowset.md)   
 [CRecordset::SetRowsetSize](../vs140/crecordset--setrowsetsize.md)