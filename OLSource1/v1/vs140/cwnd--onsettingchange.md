---
title: "CWnd::OnSettingChange"
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
  - "CWnd.OnSettingChange"
  - "CWnd::OnSettingChange"
  - "OnSettingChange"
  - "WM_SETTINGCHANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SETTINGCHANGE"
  - "OnSettingChange method"
ms.assetid: 91392ea8-e411-4660-a77b-7488db5fa060
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSettingChange
The framework calls `OnSettingChange` for all top-level windows when the Win32 SystemParametersInfo function changes a system-wide setting.  
  
## Syntax  
  
```  
  
      afx_msg void OnSettingChange(  
   UINT uFlags,  
   LPCTSTR lpszSection   
);  
```  
  
#### Parameters  
 `uFlags`  
 When the system sends the message as a result of a **SystemParametersInfo** call, this parameter is a flag that indicates the system parameter that was changed. For a list of values, see [SystemParametersInfo](http://msdn.microsoft.com/library/windows/desktop/ms724947) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. When an application sends the message, this parameter must be 0.  
  
 `lpszSection`  
 Points to a string that specifies the name of the section that has changed. (The string does not include the square brackets that enclose the section name.)  
  
## Remarks  
 An application should send the message to all top-level windows when it makes changes to system parameters, and Windows will send the message if the user changes settings via the Control Panel.  
  
 The **ON_WM_SETTINGCHANGE** message is similar to the **ON_WM_WININICHANGE** message, with the following difference:  
  
-   Use **ON_WM_SETTINGCHANGE** when running Windows NT 4.0 or newer, or under Windows 95/98.  
  
-   Use **ON_WININICHANGE** when running Windows NT 3.51 or older. This message is now obsolete.  
  
 You should have only one of these macros in your message map. To write a program that works for both Windows 95/98 and Windows NT 4.0, write a handler for **ON_WM_SETTINGCHANGE**. Under Windows NT 3.51, your handler will be called by `OnSettingChange` and `uFlags` and will always be zero.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [WM_SETTINGCHANGE](http://msdn.microsoft.com/library/windows/desktop/ms725497)   
 [CWnd::OnWinIniChange](../vs140/cwnd--onwininichange.md)