---
title: "CDialogImpl::DoModal"
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
  - "CDialogImpl::DoModal"
  - "CDialogImpl.DoModal"
  - "ATL::CDialogImpl::DoModal"
  - "ATL.CDialogImpl.DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
ms.assetid: 6f31f4c6-eac4-4e00-a2f3-5175b2a6fe1f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogImpl::DoModal
Creates a modal dialog box.  
  
## Syntax  
  
```  
  
      INT_PTR DoModal(  
   HWND hWndParent = ::GetActiveWindow( ),   
   LPARAM dwInitParam = NULL   
);  
```  
  
#### Parameters  
 `hWndParent`  
 [in] The handle to the owner window. The default value is the return value of the [GetActiveWindow](http://msdn.microsoft.com/library/windows/desktop/ms646292) Win32 function.  
  
 `dwInitParam`  
 [in] Specifies the value to pass to the dialog box in the **lParam** parameter of the **WM_INITDIALOG** message.  
  
## Return Value  
 If successful, the value of the `nRetCode` parameter specified in the call to [EndDialog](../vs140/cdialogimpl--enddialog.md). Otherwise, -1.  
  
## Remarks  
 This dialog box is automatically attached to the `CDialogImpl` object.  
  
 To create a modeless dialog box, call [Create](../vs140/cdialogimpl--create.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDialogImpl Class](../vs140/cdialogimpl-class.md)   
 [CWindow::m_hWnd](../vs140/cwindow--m_hwnd.md)   
 [CDialogImpl::EndDialog](../vs140/cdialogimpl--enddialog.md)