---
title: "CControlBar::OnUpdateCmdUI"
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
  - CControlBar.OnUpdateCmdUI
  - CControlBar::OnUpdateCmdUI
  - OnUpdateCmdUI
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnUpdateCmdUI method
  - CControlBar class, overridables
ms.assetid: 0d7a5a01-626c-40ba-9766-858b3313dc44
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CControlBar::OnUpdateCmdUI
This member function is called by the framework to update the status of the toolbar or status bar.  
  
## Syntax  
  
```  
  
      virtual void OnUpdateCmdUI(  
   CFrameWnd* pTarget,  
   BOOL bDisableIfNoHndler   
) = 0;  
```  
  
#### Parameters  
 `pTarget`  
 Points to the main frame window of the application. This pointer is used for routing update messages.  
  
 `bDisableIfNoHndler`  
 Flag that indicates whether a control that has no update handler should be automatically displayed as disabled.  
  
## Remarks  
 To update an individual button or pane, use the `ON_UPDATE_COMMAND_UI` macro in your message map to set an update handler appropriately. See [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md) for more information about using this macro.  
  
 `OnUpdateCmdUI` is called by the framework when the application is idle. The frame window to be updated must be a child window, at least indirectly, of a visible frame window. `OnUpdateCmdUI` is an advanced overridable.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ON_UPDATE_COMMAND_UI](../vs140/on_update_command_ui.md)   
 [TN031: Control Bars](../vs140/tn031--control-bars.md)