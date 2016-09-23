---
title: "CStatusBarCtrl::SetIcon"
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
  - CStatusBarCtrl::SetIcon
  - CStatusBarCtrl.SetIcon
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetIcon method
  - status bars, icons
  - CStatusBarCtrl class, attributes
ms.assetid: df9a888a-dd6d-4747-a9fc-b3c9ae09e2ef
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStatusBarCtrl::SetIcon
Sets the icon for a pane in a status bar.  
  
## Syntax  
  
```  
  
      BOOL SetIcon(  
   int nPane,  
   HICON hIcon   
);  
```  
  
#### Parameters  
 `nPane`  
 The zero-based index of the pane that will receive the icon. If this parameter is -1, the status bar is assumed to be a simple status bar.  
  
 `hIcon`  
 Handle to the icon to be set. If this value is **NULL**, the icon is removed from the part.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [SB_SETICON](http://msdn.microsoft.com/library/windows/desktop/bb760755), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CStatusBarCtrl::SetBkColor](../vs140/cstatusbarctrl--setbkcolor.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)