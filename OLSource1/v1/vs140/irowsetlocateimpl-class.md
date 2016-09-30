---
title: "IRowsetLocateImpl Class"
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
  - "IRowsetLocateImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "providers, bookmarks"
  - "IRowsetLocateImpl class"
  - "bookmarks, OLE DB"
ms.assetid: a8aa3149-7ce8-4976-a680-2da193fd3234
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetLocateImpl Class
Implements the OLE DB [IRowsetLocate](https://msdn.microsoft.com/en-us/library/ms721190.aspx) interface, which fetches arbitrary rows from a rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A class derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A class derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The storage unit for the **HROW**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The storage unit for all row handles held by the provider.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type of the bookmark, such as a LONG or a string. Ordinary bookmarks must have a length of at least two bytes. (Single-byte length is reserved for the OLE DB [standard bookmarks](https://msdn.microsoft.com/en-us/library/ms712954.aspx)**DBBMK_FIRST**, **DBBMK_LAST**, and **DBBMK_INVALID**.)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The mapping mechanism for maintaining bookmark-to-data relationships.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The storage unit for all row handles held by the bookmark.  
  
## Members  
  
### Interface Methods  
  
|||  
|-|-|  
|[Compare](../vs140/irowsetlocateimpl--compare.md)|Compares two bookmarks.|  
|[GetRowsAt](../vs140/irowsetlocateimpl--getrowsat.md)|Fetches rows starting with the row specified by an offset from a bookmark.|  
|[GetRowsByBookmark](../vs140/irowsetlocateimpl--getrowsbybookmark.md)|Fetches the rows that match the specified bookmarks.|  
|[Hash](../vs140/irowsetlocateimpl--hash.md)|Returns hash values for the specified bookmarks.|  
  
### Data Members  
  
|||  
|-|-|  
|[m_rgBookmarks](../vs140/irowsetlocateimpl--m_rgbookmarks.md)|An array of bookmarks.|  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the OLE DB Templates implementation of the [IRowsetLocate](https://msdn.microsoft.com/en-us/library/ms721190.aspx) interface. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is used to fetch arbitrary rows from a rowset. A rowset that does not implement this interface is a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> rowset. When <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is present on a rowset, column 0 is the bookmark for the rows; reading this column will obtain a bookmark value that can be used to reposition to the same row.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is used to implement bookmark support in providers. Bookmarks are placeholders (indices on a rowset) that enable the consumer to return quickly to a row, allowing high-speed access to data. The provider determines what bookmarks can uniquely identify a row. Using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> methods, you can compare bookmarks, fetch rows by offset, fetch rows by bookmark, and return hash values for bookmarks.  
  
 To support OLE DB bookmarks in a rowset, make the rowset inherit from this class.  
  
 For information on implementing bookmark support, see [Provider Support for Bookmarks](../vs140/provider-support-for-bookmarks.md) in the *Visual C++ Programmer's Guide* and [Bookmarks](https://msdn.microsoft.com/en-us/library/ms709728.aspx) in the *OLE DB Programmer's Reference* in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header**: atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [IRowsetLocate:IRowset](https://msdn.microsoft.com/en-us/library/ms721190.aspx)   
 [Provider Support for Bookmarks](../vs140/provider-support-for-bookmarks.md)   
 [Bookmarks](https://msdn.microsoft.com/en-us/library/ms709728.aspx)