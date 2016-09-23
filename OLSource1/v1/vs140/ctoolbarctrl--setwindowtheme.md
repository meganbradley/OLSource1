---
title: "CToolBarCtrl::SetWindowTheme"
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
  - CToolBarCtrl.SetWindowTheme
  - CToolBarCtrl::SetWindowTheme
  - SetWindowTheme
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetWindowTheme method
ms.assetid: 527c2573-8637-4a5f-9eca-b0ac35f64db3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::SetWindowTheme
Sets the visual style of the `CToolBarCtrl` object.  
  
## Syntax  
  
```  
  
      HRESULT SetWindowTheme(  
   LPCWSTR pszSubAppName  
);  
```  
  
#### Parameters  
 `pszSubAppName`  
 A pointer to a Unicode string that contains the toolbar visual style to set.  
  
## Return Value  
 The return value is not used.  
  
## Remarks  
 This member function emulates the functionality of the [TB_SETWINDOWTHEME](http://msdn.microsoft.com/library/windows/desktop/bb787465) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)