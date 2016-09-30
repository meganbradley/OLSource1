---
title: "CBulkRowset::MoveToBookmark"
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
  - "CBulkRowset<TAccessor>::MoveToBookmark"
  - "CBulkRowset.MoveToBookmark"
  - "MoveToBookmark"
  - "ATL.CBulkRowset.MoveToBookmark"
  - "CBulkRowset::MoveToBookmark"
  - "ATL::CBulkRowset<TAccessor>::MoveToBookmark"
  - "ATL::CBulkRowset::MoveToBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveToBookmark method"
ms.assetid: 76aab025-819e-4ecd-ae0a-d8d3fb2d2099
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBulkRowset::MoveToBookmark
Fetches the row marked by a bookmark or the row at a specified offset (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) from that bookmark.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A bookmark marking the location from which you want to fetch data.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number count of rows from the bookmark to the target row. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is zero, the first row fetched is the bookmarked row. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 1, the first row fetched is the row after the bookmarked row. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is –1, the first row fetched is the row before the bookmarked row.  
  
## Return Value  
 See [IRowset::GetData](https://msdn.microsoft.com/en-us/library/ms716988.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CBulkRowset Class](../vs140/cbulkrowset-class.md)