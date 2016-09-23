---
title: "CToolBarCtrl::GetHotItem"
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
  - CToolBarCtrl.GetHotItem
  - CToolBarCtrl::GetHotItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - CToolBarCtrl class, attributes
  - GetHotItem method
ms.assetid: 9bf1a576-f197-4f00-aa35-fda6af51c9da
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::GetHotItem
Retrieves the index of the hot item in a toolbar.  
  
## Syntax  
  
```  
  
int GetHotItem( ) const;  
  
```  
  
## Return Value  
 The zero-based index of the hot item in a toolbar.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETHOTITEM](http://msdn.microsoft.com/library/windows/desktop/bb787336), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetHotItem](../vs140/ctoolbarctrl--sethotitem.md)