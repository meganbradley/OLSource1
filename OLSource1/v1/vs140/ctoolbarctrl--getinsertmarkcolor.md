---
title: "CToolBarCtrl::GetInsertMarkColor"
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
  - CToolBarCtrl.GetInsertMarkColor
  - CToolBarCtrl::GetInsertMarkColor
  - GetInsertMarkColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetInsertMarkColor method
ms.assetid: 613726b0-ac12-4bdc-bb56-d2deadbfb5cf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::GetInsertMarkColor
Retrieves the color used to draw the insertion mark for the toolbar.  
  
## Syntax  
  
```  
  
COLORREF GetInsertMarkColor( ) const;  
  
```  
  
## Return Value  
 A **COLORREF** value that contains the current insertion mark color.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_GETINSERTMARKCOLOR](http://msdn.microsoft.com/library/windows/desktop/bb787339), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetInsertMarkColor](../vs140/ctoolbarctrl--setinsertmarkcolor.md)