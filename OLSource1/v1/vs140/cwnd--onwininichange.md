---
title: "CWnd::OnWinIniChange"
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
  - "OnWinIniChange"
  - "CWnd.OnWinIniChange"
  - "CWnd::OnWinIniChange"
  - "WM_WININICHANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnWinIniChange method"
  - "WM_WININICHANGE"
ms.assetid: b708093d-7396-433b-9429-d64862d5d6f8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnWinIniChange
The framework calls this member function after a change has been made to the Windows initialization file, WIN.INI.  
  
## Syntax  
  
```  
  
      afx_msg void OnWinIniChange(  
   LPCTSTR lpszSection   
);  
```  
  
#### Parameters  
 `lpszSection`  
 Points to a string that specifies the name of the section that has changed. (The string does not include the square brackets that enclose the section name.)  
  
## Remarks  
 The [SystemParametersInfo](http://msdn.microsoft.com/library/windows/desktop/ms724947) Windows function calls `OnWinIniChange` after an application uses the function to change a setting in the WIN.INI file.  
  
 To send the `WM_WININICHANGE` message to all top-level windows, an application can use the [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950) Windows function with its *hwnd* parameter set to **HWND_BROADCAST**.  
  
 If an application changes many different sections in WIN.INI at the same time, the application should send one `WM_WININICHANGE` message with `lpszSection` set to **NULL**. Otherwise, an application should send `WM_WININICHANGE` each time it makes a change to WIN.INI.  
  
 If an application receives an `OnWinIniChange` call with `lpszSection` set to **NULL**, the application should check all sections in WIN.INI that affect the application.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950)   
 [SystemParametersInfo](http://msdn.microsoft.com/library/windows/desktop/ms724947)   
 [WM_WININICHANGE](http://msdn.microsoft.com/library/windows/desktop/ms725499)