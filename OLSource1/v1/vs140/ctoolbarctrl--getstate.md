---
title: "CToolBarCtrl::GetState"
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
  - "CToolBarCtrl::GetState"
  - "CToolBarCtrl.GetState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetState method"
ms.assetid: 39b93533-b17e-4385-b5d9-eedd4f0efb93
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetState
Retrieves information about the state of the specified button in a toolbar control, such as whether it is enabled, pressed, or checked.  
  
## Syntax  
  
```  
  
      int GetState(  
   int nID   
) const;  
```  
  
#### Parameters  
 `nID`  
 Command identifier of the button for which to retrieve information.  
  
## Return Value  
 The button state information if successful or – 1 otherwise. The button state information can be a combination of the values listed in [CToolBarCtrl::AddButtons](../vs140/ctoolbarctrl--addbuttons.md).  
  
## Remarks  
 This function is especially handy if you want to retrieve more than one of the button states. To just retrieve one state, use one of the following member functions: [IsButtonEnabled](../vs140/ctoolbarctrl--isbuttonenabled.md), [IsButtonChecked](../vs140/ctoolbarctrl--isbuttonchecked.md), [IsButtonPressed](../vs140/ctoolbarctrl--isbuttonpressed.md), [IsButtonHidden](../vs140/ctoolbarctrl--isbuttonhidden.md), or [IsButtonIndeterminate](../vs140/ctoolbarctrl--isbuttonindeterminate.md). However, the `GetState` member function is the only way to detect the `TBSTATE_WRAP` button state.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)   
 [CToolBarCtrl::GetItemRect](../vs140/ctoolbarctrl--getitemrect.md)   
 [CToolBarCtrl::IsButtonEnabled](../vs140/ctoolbarctrl--isbuttonenabled.md)   
 [CToolBarCtrl::IsButtonChecked](../vs140/ctoolbarctrl--isbuttonchecked.md)   
 [CToolBarCtrl::IsButtonPressed](../vs140/ctoolbarctrl--isbuttonpressed.md)   
 [CToolBarCtrl::IsButtonHidden](../vs140/ctoolbarctrl--isbuttonhidden.md)   
 [CToolBarCtrl::IsButtonIndeterminate](../vs140/ctoolbarctrl--isbuttonindeterminate.md)