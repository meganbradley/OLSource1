---
title: "CDialog::CDialog"
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
  - "CDialog::CDialog"
  - "CDialog.CDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialog class, construction/destruction"
ms.assetid: 426dcd74-7974-429b-b9d3-eb0b1cf96d5b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::CDialog
To construct a resource-based modal dialog box, call either public form of the constructor.  
  
## Syntax  
  
```  
  
      explicit CDialog(  
   LPCTSTR lpszTemplateName,  
   CWnd* pParentWnd = NULL   
);  
explicit CDialog(  
   UINT nIDTemplate,  
   CWnd* pParentWnd = NULL   
);  
CDialog( );  
```  
  
#### Parameters  
 `lpszTemplateName`  
 Contains a null-terminated string that is the name of a dialog-box template resource.  
  
 `nIDTemplate`  
 Contains the ID number of a dialog-box template resource.  
  
 `pParentWnd`  
 Points to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
## Remarks  
 One form of the constructor provides access to the dialog resource by template name. The other constructor provides access by template ID number, usually with an **IDD_** prefix (for example, IDD_DIALOG1).  
  
 To construct a modal dialog box from a template in memory, first invoke the parameterless, protected constructor and then call `InitModalIndirect`.  
  
 After you construct a modal dialog box with one of the above methods, call `DoModal`.  
  
 To construct a modeless dialog box, use the protected form of the `CDialog` constructor. The constructor is protected because you must derive your own dialog-box class to implement a modeless dialog box. Construction of a modeless dialog box is a two-step process. First call the constructor; then call the **Create** member function to create a resource-based dialog box, or call `CreateIndirect` to create the dialog box from a template in memory.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::Create](../vs140/cdialog--create.md)   
 [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md)   
 [CDialog::InitModalIndirect](../vs140/cdialog--initmodalindirect.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [CreateDialog](http://msdn.microsoft.com/library/windows/desktop/ms645434)