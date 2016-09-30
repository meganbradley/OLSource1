---
title: "CDaoRecordset::CanAppend"
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
  - "CDaoRecordset.CanAppend"
  - "CanAppend"
  - "CDaoRecordset::CanAppend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, appending records"
  - "DAO recordsets, adding records"
  - "CanAppend method"
  - "recordsets, adding records"
ms.assetid: 030c9eb5-0f01-4120-acaa-0823ea1c2791
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::CanAppend
Call this member function to determine whether the previously opened recordset allows you to add new records by calling the [AddNew](../vs140/cdaorecordset--addnew.md) member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset allows adding new records; otherwise 0. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will return 0 if you opened the recordset as read-only.  
  
## Remarks  
 For related information, see the topic "Append Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::CanBookmark](../vs140/cdaorecordset--canbookmark.md)   
 [CDaoRecordset::CanRestart](../vs140/cdaorecordset--canrestart.md)   
 [CDaoRecordset::CanScroll](../vs140/cdaorecordset--canscroll.md)   
 [CDaoRecordset::CanTransact](../vs140/cdaorecordset--cantransact.md)   
 [CDaoRecordset::CanUpdate](../vs140/cdaorecordset--canupdate.md)