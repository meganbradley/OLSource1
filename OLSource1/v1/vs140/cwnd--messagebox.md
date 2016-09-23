---
title: "CWnd::MessageBox"
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
  - CWnd::MessageBox
  - CWnd.MessageBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - MessageBox method
  - alerts [C++]
  - CWnd class, alert functions
  - Alert message box
  - alerts [C++], message boxes
ms.assetid: b1da4bb3-6f44-44ff-ab72-50de84bfbf59
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::MessageBox
Creates and displays a window that contains an application-supplied message and caption, plus a combination of the predefined icons and pushbuttons described in the [Message-Box Styles](../vs140/message-box-styles.md) list.  
  
## Syntax  
  
```  
  
      int MessageBox(  
   LPCTSTR lpszText,  
   LPCTSTR lpszCaption = NULL,  
   UINT nType = MB_OK   
);  
```  
  
#### Parameters  
 `lpszText`  
 Points to a `CString` object or null-terminated string containing the message to be displayed.  
  
 `lpszCaption`  
 Points to a `CString` object or null-terminated string to be used for the message-box caption. If `lpszCaption` is **NULL**, the default caption "Error" is used.  
  
 `nType`  
 Specifies the contents and behavior of the message box.  
  
## Return Value  
 This method utilizes the [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) function as defined in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This method returns the result of calling this function.  
  
## Remarks  
 Use the global function [AfxMessageBox](../vs140/afxmessagebox.md) instead of this member function to implement a message box in your application.  
  
 The following shows the various system icons that can be used in a message box:  
  
|||  
|-|-|  
|![Stop &#40;x&#41; icon](../vs140/media/vc364f1.gif "vc364F1")|**MB_ICONHAND**, **MB_ICONSTOP**, and **MB_ICONERROR**|  
|![Help &#40;?&#41; icon](../vs140/media/vc364f2.gif "vc364F2")|**MB_ICONQUESTION**|  
|![Important &#40;&#33;&#41; icon](../vs140/media/vc364f3.gif "vc364F3")|**MB_ICONEXCLAMATION** and **MB_ICONWARNING**|  
|![Information &#40;i&#41; icon](../vs140/media/vc364f4.gif "vc364F4")|**MB_ICONASTERISK** and **MB_ICONINFORMATION**|  
  
## Example  
 [!code[NVC_MFCWindowing#104](../vs140/codesnippet/CPP/cwnd--messagebox_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505)   
 [AfxMessageBox](../vs140/afxmessagebox.md)