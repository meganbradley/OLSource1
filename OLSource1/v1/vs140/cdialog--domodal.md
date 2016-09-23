---
title: "CDialog::DoModal"
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
  - CDialog.DoModal
  - CDialog::DoModal
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDialog class, operations
  - DoModal method
ms.assetid: da4e2889-2903-4971-b086-86f9a2a3d965
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDialog::DoModal
Call this member function to invoke the modal dialog box and return the dialog-box result when done.  
  
## Syntax  
  
```  
  
virtual INT_PTR DoModal( );  
```  
  
## Return Value  
 An `int` value that specifies the value of the `nResult` parameter that was passed to the [CDialog::EndDialog](../vs140/cdialog--enddialog.md) member function, which is used to close the dialog box. The return value is –1 if the function could not create the dialog box, or **IDABORT** if some other error occurred, in which case the [Output window](../vs140/output-window.md) will contain error information from [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 This member function handles all interaction with the user while the dialog box is active. This is what makes the dialog box modal; that is, the user cannot interact with other windows until the dialog box is closed.  
  
 If the user clicks one of the pushbuttons in the dialog box, such as OK or Cancel, a message-handler member function, such as [OnOK](../vs140/cdialog--onok.md) or [OnCancel](../vs140/cdialog--oncancel.md), is called to attempt to close the dialog box. The default `OnOK` member function will validate and update the dialog-box data and close the dialog box with result **IDOK**, and the default `OnCancel` member function will close the dialog box with result **IDCANCEL** without validating or updating the dialog-box data. You can override these message-handler functions to alter their behavior.  
  
> [!NOTE]
>  `PreTranslateMessage` is now called for modal dialog box message processing.  
  
## Example  
 [!code[NVC_MFCControlLadenDialog#63](../vs140/codesnippet/CPP/cdialog--domodal_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DialogBox](http://msdn.microsoft.com/library/windows/desktop/ms645452)   
 [CWnd::IsDialogMessage](../vs140/cwnd--isdialogmessage.md)