---
title: "CComControl::MessageBox"
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
  - CComControl.MessageBox
  - CComControl::MessageBox
  - ATL::CComControl::MessageBox
  - ATL.CComControl.MessageBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - MessageBox method
ms.assetid: 53dbcfec-4086-4557-8bd6-69273b504d17
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControl::MessageBox
Call this method to create, display, and operate a message box.  
  
## Syntax  
  
```  
  
      int MessageBox(  
   LPCTSTR lpszText,  
   LPCTSTR lpszCaption = _T(""),  
   UINT nType = MB_OK  
);  
```  
  
#### Parameters  
 `lpszText`  
 The text to be displayed in the message box.  
  
 `lpszCaption`  
 The dialog box title. If NULL (the default), the title "Error" is used.  
  
 `nType`  
 Specifies the contents and behavior of the dialog box. See the [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) entry in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] documentation for a list of the different message boxes available. The default provides a simple **OK** button.  
  
## Return Value  
 Returns an integer value specifying one of the menu-item values listed under [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] documentation.  
  
## Remarks  
 `MessageBox` is useful both during development and as an easy way to display an error or warning message to the user.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)