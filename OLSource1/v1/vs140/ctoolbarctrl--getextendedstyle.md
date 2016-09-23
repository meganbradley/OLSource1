---
title: "CToolBarCtrl::GetExtendedStyle"
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
  - CToolBarCtrl::GetExtendedStyle
  - CToolBarCtrl.GetExtendedStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - CToolBarCtrl class, attributes
  - GetExtendedStyle method
ms.assetid: af2f850d-9d3c-4066-8861-9f29551e6bdc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::GetExtendedStyle
Retrieves the extended styles for a toolbar control.  
  
## Syntax  
  
```  
  
DWORD GetExtendedStyle( ) const;  
  
```  
  
## Return Value  
 A `DWORD` that represents the extended styles currently in use for the toolbar control. For a list of styles, see [Toolbar Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760430), in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb787331), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetExtendedStyle](../vs140/ctoolbarctrl--setextendedstyle.md)