---
title: "CDialogImpl::Create"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDialogImpl.Create
  - ATL.CDialogImpl.Create
  - CDialogImpl::Create
  - ATL::CDialogImpl::Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method [C++]
ms.assetid: 6883f413-ecfb-42d3-ae75-03918ee04917
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDialogImpl::Create
Creates a modeless dialog box.  
  
## Syntax  
  
```  
  
      HWND Create(  
   HWND hWndParent,  
   LPARAM dwInitParam = NULL   
);  
HWND Create(  
   HWND hWndParent,  
   RECT&,  
   LPARAM dwInitParam = NULL   
);  
```  
  
#### Parameters  
 `hWndParent`  
 [in] The handle to the owner window.  
  
 **RECT&**  `rect`  
 [in] A [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the dialog's size and position.  
  
 `dwInitParam`  
 [in] Specifies the value to pass to the dialog box in the **lParam** parameter of the **WM_INITDIALOG** message.  
  
## Return Value  
 The handle to the newly created dialog box.  
  
## Remarks  
 This dialog box is automatically attached to the `CDialogImpl` object. To create a modal dialog box, call [DoModal](../vs140/cdialogimpl--domodal.md). The second override above is used only with [CComControl](../vs140/ccomcontrol-class.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CDialogImpl Class](../vs140/cdialogimpl-class.md)   
 [CWindow::m_hWnd](../vs140/cwindow--m_hwnd.md)