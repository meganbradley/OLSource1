---
title: "CToolBarCtrl::PressButton"
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
  - "CToolBarCtrl.PressButton"
  - "CToolBarCtrl::PressButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PressButton method"
ms.assetid: 19d4f70d-b49a-43e2-8640-6c417f7f85da
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::PressButton
Presses or releases the specified button in a toolbar control.  
  
## Syntax  
  
```  
  
      BOOL PressButton(  
   int nID,  
   BOOL bPress = TRUE   
);  
```  
  
#### Parameters  
 [in] `nID`  
 Command identifier of the button to press or release.  
  
 [in] `bPress`  
 `true` to press the specified button; `false` to release the specified button. The default value is `true`.  
  
## Return Value  
 `true` if the method is successful; otherwise, `false`.  
  
## Remarks  
 If you want to change more than one button state, consider calling [SetState](../vs140/ctoolbarctrl--setstate.md) instead.  
  
 This method sends the [TB_PRESSBUTTON](http://msdn.microsoft.com/library/windows/desktop/bb787389) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::IsButtonPressed](../vs140/ctoolbarctrl--isbuttonpressed.md)   
 [CToolBarCtrl::EnableButton](../vs140/ctoolbarctrl--enablebutton.md)   
 [CToolBarCtrl::CheckButton](../vs140/ctoolbarctrl--checkbutton.md)   
 [CToolBarCtrl::HideButton](../vs140/ctoolbarctrl--hidebutton.md)   
 [CToolBarCtrl::Indeterminate](../vs140/ctoolbarctrl--indeterminate.md)   
 [CToolBarCtrl::GetState](../vs140/ctoolbarctrl--getstate.md)   
 [CToolBarCtrl::SetState](../vs140/ctoolbarctrl--setstate.md)