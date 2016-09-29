---
title: "CDaoRecordset::SetBookmark"
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
  - "SetBookmark"
  - "CDaoRecordset.SetBookmark"
  - "CDaoRecordset::SetBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, setting bookmarks"
  - "recordsets, setting bookmarks"
  - "SetBookmark method"
ms.assetid: d25d4142-da63-4801-9d21-211d05fc35a4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetBookmark
Call this member function to position the recordset on the record containing the specified bookmark.  
  
## Syntax  
  
```  
  
      void SetBookmark(  
   COleVariant varBookmark   
);  
```  
  
#### Parameters  
 `varBookmark`  
 A [COleVariant](../vs140/colevariant-class.md) object containing the bookmark value for a specific record.  
  
## Remarks  
 When a recordset object is created or opened, each of its records already has a unique bookmark. You can retrieve the bookmark for the current record by calling `GetBookmark` and saving the value to a `COleVariant` object. You can later return to that record by calling `SetBookmark` using the saved bookmark value.  
  
> [!NOTE]
>  Calling [Requery](../vs140/cdaorecordset--requery.md) changes DAO bookmarks.  
  
 Note that if you are not creating a UNICODE recordset, the `COleVariant` object must be explicitly declared ANSI. This can be done by using the [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)**(** `lpszSrc`**,** `vtSrc` **)** form of constructor with `vtSrc` set to `VT_BSTRT` (ANSI) or by using the **COleVariant** function [SetString](../vs140/colevariant--setstring.md)**(** `lpszSrc`**,** `vtSrc` **)** with `vtSrc` set to `VT_BSTRT`.  
  
 For related information, see the topics "Bookmark Property" and Bookmarkable Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetBookmark](../vs140/cdaorecordset--getbookmark.md)