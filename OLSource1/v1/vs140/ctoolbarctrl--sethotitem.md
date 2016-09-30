---
title: "CToolBarCtrl::SetHotItem"
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
  - "CToolBarCtrl.SetHotItem"
  - "CToolBarCtrl::SetHotItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolBarCtrl class, attributes"
  - "SetHotItem method"
ms.assetid: 53cbad57-3c98-4e2d-8e45-d12727612d66
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetHotItem
Sets the hot item in a toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nHot*  
 The zero-based index number of the item that will be made hot. If this value is -1, none of the items will be hot.  
  
## Return Value  
 The index of the previous hot item, or -1 if there was no hot item.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_SETHOTITEM](http://msdn.microsoft.com/library/windows/desktop/bb787431), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetHotItem](../vs140/ctoolbarctrl--gethotitem.md)