---
title: "CRecordset::GetRowStatus"
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
  - "SQL_ROW_UPDATED"
  - "CRecordset::GetRowStatus"
  - "CRecordset.GetRowStatus"
  - "SQL_ROW_ERROR"
  - "SQL_ROW_SUCCESS"
  - "SQL_ROW_DELETED"
  - "SQL_ROW_ADDED"
  - "SQL_ROW_NOROW"
  - "GetRowStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SQL_ROW_ADDED"
  - "SQL_ROW_NOROW"
  - "rowsets, status"
  - "SQL_ROW_ERROR"
  - "SQL_ROW_SUCCESS"
  - "SQL_ROW_DELETED"
  - "GetRowStatus method"
  - "SQL_ROW_UPDATED"
ms.assetid: de62d535-b20a-414d-b551-8abb94dd6d9e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::GetRowStatus
Obtains the status for a row in the current rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The one-based position of a row in the current rowset. This value can range from 1 to the size of the rowset.  
  
## Return Value  
 A status value for the row. For details, see Remarks.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns a value that indicates either any change in status to the row since it was last retrieved from the data source, or that no row corresponding to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> was fetched. The following table lists the possible return values.  
  
|Status value|Description|  
|------------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The row is unchanged.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The row has been updated.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The row has been deleted.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The row has been added.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The row is unretrievable due to an error.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|There is no row that corresponds to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
  
 For more information, see the ODBC API function **SQLExtendedFetch** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::CheckRowsetError](../vs140/crecordset--checkrowseterror.md)   
 [CRecordset::GetRowsFetched](../vs140/crecordset--getrowsfetched.md)   
 [CRecordset::RefreshRowset](../vs140/crecordset--refreshrowset.md)