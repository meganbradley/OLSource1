---
title: "CReBarCtrl::SetWindowTheme"
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
  - CReBarCtrl::SetWindowTheme
  - CReBarCtrl.SetWindowTheme
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetWindowTheme method
ms.assetid: 513eff6d-fcc9-4f7c-b466-384b47c5c283
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CReBarCtrl::SetWindowTheme
Sets the visual style of the rebar control.  
  
## Syntax  
  
```  
  
      HRESULT SetWindowTheme(   
   LPCWSTR pszSubAppName    
);  
```  
  
#### Parameters  
 `pszSubAppName`  
 A pointer to a Unicode string that contains the rebar visual style to set.  
  
## Return Value  
 The return value is not used.  
  
## Remarks  
 This member function emulates the functionality of the [RB_SETWINDOWTHEME](http://msdn.microsoft.com/library/windows/desktop/bb774530) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)