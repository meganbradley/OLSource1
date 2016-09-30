---
title: "CToolBarCtrl::HitTest"
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
  - "CToolBarCtrl::HitTest"
  - "CToolBarCtrl.HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolBarCtrl class, operations"
  - "HitTest method [MFC]"
ms.assetid: 49e187af-2c7c-4d0d-b31a-d45f3465ca5e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::HitTest
Determines where a point lies in a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that contains the x-coordinate of the hit test in the **x** member and the y-coordinate of the hit test in the **y** member. The coordinates are relative to the toolbar's client area.  
  
## Return Value  
 An integer value indicating the location of a point on a toolbar. If the value is zero or a positive value, this return value is the zero-based index of the nonseparator item in which the point lies.  
  
 If the return value is negative, the point does not lie within a button. The absolute value of the return value is the index of a separator item or the nearest nonseparator item.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_HITTEST](http://msdn.microsoft.com/library/windows/desktop/bb787360), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)