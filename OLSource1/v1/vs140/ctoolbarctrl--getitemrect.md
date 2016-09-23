---
title: "CToolBarCtrl::GetItemRect"
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
  - CToolBarCtrl::GetItemRect
  - CToolBarCtrl.GetItemRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemRect method [MFC]
ms.assetid: b12755b6-ecb5-440f-ba9d-52e824199235
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::GetItemRect
Retrieves the bounding rectangle of a button in a toolbar control.  
  
## Syntax  
  
```  
  
      BOOL GetItemRect(  
   int nIndex,  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Zero-based index of the button for which to retrieve information.  
  
 `lpRect`  
 Address of a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure or a [CRect](../vs140/crect-class.md) object that receives the coordinates of the bounding rectangle.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This function does not retrieve the bounding rectangle for buttons whose state is set to `TBSTATE_HIDDEN`.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetButton](../vs140/ctoolbarctrl--getbutton.md)   
 [CToolBarCtrl::GetButtonCount](../vs140/ctoolbarctrl--getbuttoncount.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetButtonSize](../vs140/ctoolbarctrl--setbuttonsize.md)   
 [CToolBarCtrl::SetBitmapSize](../vs140/ctoolbarctrl--setbitmapsize.md)