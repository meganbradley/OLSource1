---
title: "CRecordset::GetBookmark"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRecordset.GetBookmark
  - CRecordset::GetBookmark
  - GetBookmark
dev_langs: 
  - C++
helpviewer_keywords: 
  - recordsets, bookmarks
  - recordsets, navigating
  - GetBookmark method
ms.assetid: 14cff7c7-811b-4f93-8d9c-188707322fe6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::GetBookmark
Obtains the bookmark value for the current record.  
  
## Syntax  
  
```  
  
      void GetBookmark(   
   CDBVariant& varBookmark    
);  
```  
  
#### Parameters  
 `varBookmark`  
 A reference to a [CDBVariant](../vs140/cdbvariant-class.md) object representing the bookmark on the current record.  
  
## Remarks  
 To determine if bookmarks are supported on the recordset, call [CanBookmark](../vs140/crecordset--canbookmark.md). To make bookmarks available if they are supported, you must set the **CRecordset::useBookmarks** option in the `dwOptions` parameter of the [Open](../vs140/crecordset--open.md) member function.  
  
> [!NOTE]
>  If bookmarks are unsupported or unavailable, calling `GetBookmark` will result in an exception being thrown. Bookmarks are not supported on forward-only recordsets.  
  
 `GetBookmark` assigns the value of the bookmark for the current record to a `CDBVariant` object. To return to that record at any time after moving to a different record, call [SetBookmark](../vs140/crecordset--setbookmark.md) with the corresponding `CDBVariant` object.  
  
> [!NOTE]
>  After certain recordset operations, bookmarks may no longer be valid. For example, if you call `GetBookmark` followed by **Requery**, you may not be able to return to the record with `SetBookmark`. Call [CDatabase::GetBookmarkPersistence](../vs140/cdatabase--getbookmarkpersistence.md) to check whether you can safely call `SetBookmark`.  
  
 For more information about bookmarks and recordset navigation, see the articles [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md) and [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and `CMemoryException*`.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::CanBookmark](../vs140/crecordset--canbookmark.md)   
 [CRecordset::SetBookmark](../vs140/crecordset--setbookmark.md)   
 [CDatabase::GetBookmarkPersistence](../vs140/cdatabase--getbookmarkpersistence.md)