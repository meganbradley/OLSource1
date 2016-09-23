---
title: "CDockablePane::OnPressButtons"
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
  - CDockablePane::OnPressButtons
  - CDockablePane.OnPressButtons
  - OnPressButtons
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnPressButtons method
ms.assetid: 979f628a-4123-4f87-bfed-e3ac636a1c07
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::OnPressButtons
Called when the user presses a caption button other than the `AFX_HTCLOSE` and `AFX_HTMAXBUTTON` buttons.  
  
## Syntax  
  
```  
virtual void OnPressButtons(  
    UINT nHit  
);  
```  
  
#### Parameters  
 [in] `nHit`  
 This parameter is not used.  
  
## Remarks  
 If you add a custom button to the caption of a dockable pane, override this method to receive notifications when a user presses the button.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)