---
title: "CRecordset::SetBookmark"
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
  - "CRecordset.SetBookmark"
  - "SetBookmark"
  - "CRecordset::SetBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, bookmarks"
  - "SetBookmark method"
  - "recordsets, navigating"
ms.assetid: d8f2d1a2-2e4a-4300-901c-dccefae7ac4b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::SetBookmark
Positions the recordset on the record containing the specified bookmark.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a [CDBVariant](../vs140/cdbvariant-class.md) object containing the bookmark value for a specific record.  
  
## Remarks  
 To determine if bookmarks are supported on the recordset, call [CanBookmark](../vs140/crecordset--canbookmark.md). To make bookmarks available if they are supported, you must set the **CRecordset::useBookmarks** option in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of the [Open](../vs140/crecordset--open.md) member function.  
  
> [!NOTE]
>  If bookmarks are unsupported or unavailable, calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will result in an exception being thrown. Bookmarks are not supported on forward-only recordsets.  
  
 To first retrieve the bookmark for the current record, call [GetBookmark](../vs140/crecordset--getbookmark.md), which saves the bookmark value to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. Later, you can return to that record by calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> using the saved bookmark value.  
  
> [!NOTE]
>  After certain recordset operations, you should check the bookmark persistence before calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For example, if you retrieve a bookmark with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and then call **Requery**, the bookmark may no longer be valid. Call [CDatabase::GetBookmarkPersistence](../vs140/cdatabase--getbookmarkpersistence.md) to check whether you can safely call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 For more information about bookmarks and recordset navigation, see the articles [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md) and [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::CanBookmark](../vs140/crecordset--canbookmark.md)   
 [CRecordset::GetBookmark](../vs140/crecordset--getbookmark.md)   
 [CRecordset::SetAbsolutePosition](../vs140/crecordset--setabsoluteposition.md)   
 [CDatabase::GetBookmarkPersistence](../vs140/cdatabase--getbookmarkpersistence.md)