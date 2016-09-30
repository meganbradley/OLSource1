---
title: "CToolBarCtrl::GetButton"
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
  - "CToolBarCtrl::GetButton"
  - "CToolBarCtrl.GetButton"
  - "GetButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButton method"
ms.assetid: e2808bd8-fb89-4069-83a9-79ce374dfcb4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetButton
Retrieves information about the specified button in a toolbar control.  
  
## Syntax  
  
```  
  
      BOOL GetButton(  
   int nIndex,  
   LPTBBUTTON lpButton   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Zero-based index of the button for which to retrieve information.  
  
 `lpButton`  
 Address of the `TBBUTTON` structure that is to receive a copy of the button information. See [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md) for information about the `TBBUTTON` structure.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)   
 [CToolBarCtrl::GetButtonCount](../vs140/ctoolbarctrl--getbuttoncount.md)   
 [CToolBarCtrl::GetItemRect](../vs140/ctoolbarctrl--getitemrect.md)   
 [CToolBarCtrl::CommandToIndex](../vs140/ctoolbarctrl--commandtoindex.md)   
 [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md)   
 [CToolBarCtrl::InsertButton](../vs140/ctoolbarctrl--insertbutton.md)