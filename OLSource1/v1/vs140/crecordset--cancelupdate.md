---
title: "CRecordset::CancelUpdate"
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
  - "CRecordset.CancelUpdate"
  - "CRecordset::CancelUpdate"
  - "CancelUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CancelUpdate method"
  - "canceling updates"
  - "recordsets, updating"
ms.assetid: 359d54d3-cc7f-4571-83a4-0c61e9c83164
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::CancelUpdate
Cancels any pending updates, caused by an [Edit](../vs140/crecordset--edit.md) or [AddNew](../vs140/crecordset--addnew.md) operation, before [Update](../vs140/crecordset--update.md) is called.  
  
## Syntax  
  
```  
  
void CancelUpdate( );  
  
```  
  
## Remarks  
  
> [!NOTE]
>  This member function is not applicable on recordsets that are using bulk row fetching, since such recordsets cannot call **Edit**, `AddNew`, or **Update**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 If automatic dirty field checking is enabled, `CancelUpdate` will restore the member variables to the values they had before **Edit** or `AddNew` was called; otherwise, any value changes will remain. By default, automatic field checking is enabled when the recordset is opened. To disable it, you must specify the **CRecordset::noDirtyFieldCheck** in the `dwOptions` parameter of the [Open](../vs140/crecordset--open.md) member function.  
  
 For more information about updating data, see the article [Recordset: Adding, Updating, and Deleting Records (ODBC)](../vs140/recordset--adding--updating--and-deleting-records--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::AddNew](../vs140/crecordset--addnew.md)   
 [CRecordset::Edit](../vs140/crecordset--edit.md)   
 [CRecordset::Update](../vs140/crecordset--update.md)