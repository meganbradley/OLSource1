---
title: "CDialog::InitModalIndirect"
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
  - "InitModalIndirect"
  - "CDialog::InitModalIndirect"
  - "CDialog.InitModalIndirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialog class, initialization"
  - "InitModalIndirect method"
ms.assetid: c1fb27e1-c16a-45b1-bfa8-2be307c057aa
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::InitModalIndirect
Call this member function to initialize a modal dialog object using a dialog-box template that you construct in memory.  
  
## Syntax  
  
```  
  
      BOOL InitModalIndirect(  
   LPCDLGTEMPLATE lpDialogTemplate,  
   CWnd* pParentWnd = NULL,  
   void* lpDialogInit = NULL  
);  
   BOOL InitModalIndirect(  
   HGLOBAL hDialogTemplate,  
   CWnd* pParentWnd = NULL  
);  
```  
  
#### Parameters  
 `lpDialogTemplate`  
 Points to memory that contains a dialog-box template used to create the dialog box. This template is in the form of a [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) structure and control information, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `hDialogTemplate`  
 Contains a handle to global memory containing a dialog-box template. This template is in the form of a **DLGTEMPLATE** structure and data for each control in the dialog box.  
  
 `pParentWnd`  
 Points to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 `lpDialogInit`  
 Points to a **DLGINIT** resource.  
  
## Return Value  
 Nonzero if the dialog object was created and initialized successfully; otherwise 0.  
  
## Remarks  
 To create a modal dialog box indirectly, first allocate a global block of memory and fill it with the dialog box template. Then call the empty `CDialog` constructor to construct the dialog-box object. Next, call `InitModalIndirect` to store your handle to the in-memory dialog-box template. The Windows dialog box is created and displayed later, when the [DoModal](../vs140/cdialog--domodal.md) member function is called.  
  
 Dialog boxes that contain ActiveX controls require additional information provided in a **DLGINIT** resource. For more information, see Knowledge Base article Q231591, " HOWTO: Use a Dialog Template to Create a MFC Dialog with an ActiveX Control." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com](http://support.microsoft.com/).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DialogBoxIndirect](http://msdn.microsoft.com/library/windows/desktop/ms645457)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md)   
 [CDialog::CDialog](../vs140/cdialog--cdialog.md)