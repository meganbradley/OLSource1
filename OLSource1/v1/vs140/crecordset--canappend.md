---
title: "CRecordset::CanAppend"
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
  - "CRecordset.CanAppend"
  - "CRecordset::CanAppend"
  - "CanAppend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAppend method"
ms.assetid: 4c055286-dd80-4088-9e22-8872c0fafa2e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::CanAppend
Determines whether the previously opened recordset allows you to add new records.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset allows adding new records; otherwise 0. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will return 0 if you opened the recordset as read-only.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::AddNew](../vs140/crecordset--addnew.md)   
 [CRecordset::Requery](../vs140/crecordset--requery.md)