---
title: "CDaoRecordset::Update"
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
  - "CDaoRecordset::Update"
  - "CDaoRecordset.Update"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, updating"
  - "Update method"
  - "recordsets, updating"
ms.assetid: ef404fd0-0241-4e02-88f2-2aae08ef64ea
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::Update
Call this member function after a call to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or **Edit** member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This call is required to complete the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or **Edit** operation.  
  
 Both <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and **Edit** prepare an edit buffer in which the added or edited data is placed for saving to the data source. **Update** saves the data. Only those fields marked or detected as changed are updated.  
  
 If the data source supports transactions, you can make the **Update** call (and its corresponding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or **Edit** call) part of a transaction.  
  
> [!CAUTION]
>  If you call **Update** without first calling either <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or **Edit**, **Update** throws a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If you call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or **Edit**, you must call **Update** before you call [MoveNext](../vs140/cdaorecordset--movenext.md) or close either the recordset or the data source connection. Otherwise, your changes are lost without notification.  
  
 When the recordset object is pessimistically locked in a multiuser environment, the record remains locked from the time **Edit** is used until the updating is complete. If the recordset is optimistically locked, the record is locked and compared with the pre-edited record just before it is updated in the database. If the record has changed since you called **Edit**, the **Update** operation fails and MFC throws an exception. You can change the locking mode with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Optimistic locking is always used on external database formats, such as ODBC and installable ISAM.  
  
 For related information, see the topics "AddNew Method", "CancelUpdate Method", "Delete Method", "LastModified Property", "Update Method", and "EditMode Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::AddNew](../vs140/cdaorecordset--addnew.md)   
 [CDaoRecordset::CancelUpdate](../vs140/cdaorecordset--cancelupdate.md)   
 [CDaoRecordset::Delete](../vs140/cdaorecordset--delete.md)   
 [CDaoRecordset::Edit](../vs140/cdaorecordset--edit.md)   
 [CDaoRecordset::CanTransact](../vs140/cdaorecordset--cantransact.md)