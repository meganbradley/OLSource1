---
title: "CDaoRecordset::CancelUpdate"
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
  - "CDaoRecordset::CancelUpdate"
  - "CancelUpdate"
  - "CDaoRecordset.CancelUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO recordsets, updating"
  - "DAO recordsets"
  - "CDaoRecordset class, canceling updates"
  - "CancelUpdate method"
  - "recordsets, updating"
ms.assetid: ca37a873-1156-4bea-8da5-2aa0a53a615b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::CancelUpdate
The `CancelUpdate` member function cancels any pending updates due to an [Edit](../vs140/cdaorecordset--edit.md) or [AddNew](../vs140/cdaorecordset--addnew.md) operation.  
  
## Syntax  
  
```  
  
virtual void CancelUpdate( );  
  
```  
  
## Remarks  
 For example, if an application calls the **Edit** or `AddNew` member function and has not called [Update](../vs140/cdaorecordset--update.md), `CancelUpdate` cancels any changes made after **Edit** or `AddNew` was called.  
  
> [!NOTE]
>  If records are double-buffered (that is, automatic field checking is enabled), calling `CancelUpdate` will restore the member variables to the values they had before `AddNew` or **Edit** was called.  
  
 If there is no **Edit** or `AddNew` operation pending, `CancelUpdate` causes MFC to throw an exception. Call the [GetEditMode](../vs140/cdaorecordset--geteditmode.md) member function to determine if there is a pending operation that can be canceled.  
  
 For related information, see the topic "CancelUpdate Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::AddNew](../vs140/cdaorecordset--addnew.md)   
 [CDaoRecordset::Delete](../vs140/cdaorecordset--delete.md)   
 [CDaoRecordset::Edit](../vs140/cdaorecordset--edit.md)   
 [CDaoRecordset::Update](../vs140/cdaorecordset--update.md)   
 [CDaoRecordset::CanTransact](../vs140/cdaorecordset--cantransact.md)