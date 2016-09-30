---
title: "Record View Code Created by Application Wizard  (MFC Data Access)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "application wizards [C++], record view code"
  - "record views, refreshing controls"
  - "record views, application wizard code"
ms.assetid: 18fd4703-5939-491d-b759-985f767b951f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Record View Code Created by Application Wizard  (MFC Data Access)
The [MFC Application Wizard](../vs140/database-support--mfc-application-wizard.md) overrides the view's `OnInitialUpdate` and `OnGetRecordset` member functions. After the framework creates the frame window, document, and view, it calls `OnInitialUpdate` to initialize the view. `OnInitialUpdate` obtains a pointer to the recordset from the document. A call to the base class [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md) function opens the recordset. The following code shows this process for a `CRecordView` — the code for a `CDaoRecordView` is similar:  
  
```  
void CSectionForm::OnInitialUpdate()  
{  
   m_pSet = &GetDocument()->m_sectionSet;  
   CRecordView::OnInitialUpdate();  
}  
```  
  
 When the recordset opens, it selects records. [CRecordset::Open](../vs140/crecordset--open.md) or [CDaoRecordset::Open](../vs140/cdaorecordset--open.md) makes the first record the current record, and DDX moves data from the recordset's field data members to the corresponding form controls in the view. For more information about RFX, see [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md). For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md). For information about the document/view creation process, see [Using the Classes to Write Applications for Windows](../vs140/using-the-classes-to-write-applications-for-windows.md).  
  
> [!NOTE]
>  You should give your end users the capability to refresh the record view controls from the recordset. Without this capability, if a user changes a control's value to an illegal value, the user can be permanently stuck on the current record. To refresh the controls, you call the `CWnd` member function [UpdateData](../vs140/cwnd--updatedata.md) with a parameter of **FALSE**.  
  
## See Also  
 [Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md)