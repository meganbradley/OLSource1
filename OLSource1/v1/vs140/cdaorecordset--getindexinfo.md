---
title: "CDaoRecordset::GetIndexInfo"
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
  - "GetIndexInfo"
  - "CDaoRecordset::GetIndexInfo"
  - "CDaoRecordset.GetIndexInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, getting index information"
  - "GetIndexInfo method"
  - "recordsets, getting index information"
ms.assetid: b6ea9b44-5255-4887-bfa2-08829e4848aa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetIndexInfo
Call this member function to obtain various kinds of information about an index defined in the base table underlying a recordset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index in the table's Indexes collection, for lookup by numerical position.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Options that specify which information about the index to retrieve. The available options are listed here along with what they cause the function to return. For best performance, retrieve only the level of information you need:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (Default) Name, Field Info, Fields  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Primary information, plus: Primary, Unique, Clustered, IgnoreNulls, Required, Foreign  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Primary and secondary information, plus: Distinct Count  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the name of the index object, for lookup by name.  
  
## Remarks  
 One version of the function lets you look up a index by its position in the collection. The other version lets you look up an index by name.  
  
 For a description of the information returned, see the [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. When you request information at one level, you get information for any prior levels as well.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetFieldCount](../vs140/cdaorecordset--getfieldcount.md)   
 [CDaoRecordset::GetFieldInfo](../vs140/cdaorecordset--getfieldinfo.md)   
 [CDaoRecordset::GetIndexCount](../vs140/cdaorecordset--getindexcount.md)   
 [CDaoRecordset::GetLastModifiedBookmark](../vs140/cdaorecordset--getlastmodifiedbookmark.md)