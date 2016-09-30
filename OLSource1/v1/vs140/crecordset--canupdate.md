---
title: "CRecordset::CanUpdate"
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
  - "CRecordset::CanUpdate"
  - "CRecordset.CanUpdate"
  - "CanUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanUpdate method"
ms.assetid: 397dbf6d-305c-46f5-96c4-1b9822303557
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::CanUpdate
Determines whether the recordset can be updated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset can be updated; otherwise 0.  
  
## Remarks  
 A recordset might be read-only if the underlying data source is read-only or if you specified **CRecordset::readOnly** in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter when you opened the recordset.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::Open](../vs140/crecordset--open.md)   
 [CRecordset::AddNew](../vs140/crecordset--addnew.md)   
 [CRecordset::Edit](../vs140/crecordset--edit.md)   
 [CRecordset::Delete](../vs140/crecordset--delete.md)   
 [CRecordset::Update](../vs140/crecordset--update.md)