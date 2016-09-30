---
title: "CStatusBar::GetStatusBarCtrl"
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
  - "CStatusBar.GetStatusBarCtrl"
  - "GetStatusBarCtrl"
  - "CStatusBar::GetStatusBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStatusBarCtrl method"
  - "status bars, getting information"
  - "CStatusBar class, attributes"
ms.assetid: ecbe1990-7c64-4a90-b563-ab6e8f5a1508
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar::GetStatusBarCtrl
This member function allows direct access to the underlying common control.  
  
## Syntax  
  
```  
  
CStatusBarCtrl& GetStatusBarCtrl( ) const;  
  
```  
  
## Return Value  
 Contains a reference to a [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) object.  
  
## Remarks  
 Use `GetStatusBarCtrl` to take advantage of the functionality of the Windows status-bar common control, and to take advantage of the support [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) provides for status-bar customization. For example, by using the common control, you can specify a style that includes a sizing grip on the status bar, or you can specify a style to have the status bar appear at the top of the parent window's client area.  
  
 For more general information about common controls, See [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)