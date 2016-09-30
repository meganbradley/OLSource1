---
title: "CRecordset::CanBookmark"
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
  - "CRecordset::CanBookmark"
  - "CRecordset.CanBookmark"
  - "CanBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, bookmarks"
  - "CanBookmark method"
ms.assetid: 214e4025-83e2-4e52-aacd-37662a9942ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::CanBookmark
Determines whether the recordset allows you to mark records using bookmarks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset supports bookmarks; otherwise 0.  
  
## Remarks  
 This function is independent of the **CRecordset::useBookmarks** option in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter of the [Open](../vs140/crecordset--open.md) member function. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> indicates whether the given ODBC driver and cursor type support bookmarks. **CRecordset::useBookmarks** indicates whether bookmarks will be available, provided they are supported.  
  
> [!NOTE]
>  Bookmarks are not supported on forward-only recordsets.  
  
 For more information about bookmarks and recordset navigation, see the articles [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md) and [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::GetBookmark](../vs140/crecordset--getbookmark.md)   
 [CRecordset::SetBookmark](../vs140/crecordset--setbookmark.md)