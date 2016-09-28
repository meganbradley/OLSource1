---
title: "CDialog::CreateIndirect"
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
  - "CDialog::CreateIndirect"
  - "CreateIndirect"
  - "CDialog.CreateIndirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialog class, initialization"
  - "CreateIndirect method"
ms.assetid: 9baffca0-6b7a-4db4-9146-13f9f078752b
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::CreateIndirect
Call this member function to create a modeless dialog box from a dialog-box template in memory.  
  
## Syntax  
  
```  
  
      virtual BOOL CreateIndirect(  
   LPCDLGTEMPLATE lpDialogTemplate,  
   CWnd* pParentWnd = NULL,  
   void* lpDialogInit = NULL  
);  
virtual BOOL CreateIndirect(  
   HGLOBAL hDialogTemplate,  
   CWnd* pParentWnd = NULL  
);  
```  
  
#### Parameters  
 `lpDialogTemplate`  
 Points to memory that contains a dialog-box template used to create the dialog box. This template is in the form of a [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) structure and control information, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pParentWnd`  
 Points to the dialog object's parent window object (of type [CWnd](../vs140/cwnd-class.md)). If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 `lpDialogInit`  
 Points to a **DLGINIT** resource.  
  
 `hDialogTemplate`  
 Contains a handle to global memory containing a dialog-box template. This template is in the form of a **DLGTEMPLATE** structure and data for each control in the dialog box.  
  
## Return Value  
 Nonzero if the dialog box was created and initialized successfully; otherwise 0.  
  
## Remarks  
 The `CreateIndirect` member function returns immediately after it creates the dialog box.  
  
 Use the **WS_VISIBLE** style in the dialog-box template if the dialog box should appear when the parent window is created. Otherwise, you must call `ShowWindow` to cause it to appear. For more information on how you can specify other dialog-box styles in the template, see the [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Use the `CWnd::DestroyWindow` function to destroy a dialog box created by the `CreateIndirect` function.  
  
 Dialog boxes that contain ActiveX controls require additional information provided in a **DLGINIT** resource. For more information, see Knowledge Base article Q231591, " HOWTO: Use a Dialog Template to Create a MFC Dialog with an ActiveX Control." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com](http://support.microsoft.com/).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::CDialog](../vs140/cdialog--cdialog.md)   
 [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md)   
 [CDialog::Create](../vs140/cdialog--create.md)   
 [CreateDialogIndirect](http://msdn.microsoft.com/library/windows/desktop/ms645436)