---
title: "CRowset::FindNextRow"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL.CRowset.FindNextRow"
  - "CRowset<TAccessor>.FindNextRow"
  - "ATL::CRowset::FindNextRow"
  - "CRowset::FindNextRow"
  - "CRowset<TAccessor>::FindNextRow"
  - "CRowset.FindNextRow"
  - "ATL.CRowset<TAccessor>.FindNextRow"
  - "ATL::CRowset<TAccessor>::FindNextRow"
  - "FindNextRow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindNextRow method"
ms.assetid: 36484df9-3625-4f15-bf69-db73a8d91c55
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowset::FindNextRow
Finds the next matching row after the specified bookmark.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The operation to use in comparing row values. For values, see [IRowsetFind::FindNextRow](https://msdn.microsoft.com/en-us/library/ms723091.aspx).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A pointer to the value to be matched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Indicates the data type of the value part of the buffer. For information about type indicators, see [Data Types](https://msdn.microsoft.com/en-us/library/ms723969.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The length, in bytes, of the consumer data structure allocated for the data value. For details, see the description of **cbMaxLen** in [DBBINDING Structures](https://msdn.microsoft.com/en-us/library/ms716845.aspx) in the *OLE DB Programmer's Reference.*  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The maximum precision used when getting data. Used only if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For more information, see [Conversions involving DBTYPE_NUMERIC or DBTYPE_DECIMAL](https://msdn.microsoft.com/en-us/library/ms719714.aspx) in the *OLE DB Programmer's Reference*.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The scale used when getting data. Used only if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or **DBTYPE_DECIMAL**. For more information, see [Conversions involving DBTYPE_NUMERIC or DBTYPE_DECIMAL](https://msdn.microsoft.com/en-us/library/ms719714.aspx) in the *OLE DB Programmer's Reference*.  
  
 *bSkipCurrent*  
 [in] The number of rows from the bookmark at which to start a search.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] The bookmark for position at which to start a search.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method requires the optional interface **IRowsetFind**, which might not be supported on all providers; if this is the case, the method returns **E_NOINTERFACE**. You must also set **DBPROP_IRowsetFind** to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> before calling **Open** on the table or command containing the rowset.  
  
 For information about using bookmarks in consumers, see [Using Bookmarks](../vs140/using-bookmarks.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)   
 [DBBINDING Structures](https://msdn.microsoft.com/en-us/library/ms716845.aspx)