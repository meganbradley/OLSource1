---
title: "CPane::FloatPane"
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
  - FloatPane
  - CPane::FloatPane
  - CPane.FloatPane
dev_langs: 
  - C++
helpviewer_keywords: 
  - FloatPane method
ms.assetid: e706dedc-b7d6-4034-8372-f973b322ebb7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPane::FloatPane
Floats the pane.  
  
## Syntax  
  
```  
virtual BOOL FloatPane(  
    CRect rectFloat,  
    AFX_DOCK_METHOD dockMethod = DM_UNKNOWN,  
    bool bShow = true  
);  
```  
  
#### Parameters  
 [in] `rectFloat`  
 Specifies the location, in screen coordinates, to position the pane when it is floated.  
  
 [in] `dockMethod`  
 Specifies the docking method to use when the pane is floated. For a list of possible values, see [CPane::DockPane](../vs140/cpane--dockpane.md).  
  
 [in] `bShow`  
 `TRUE` to show the pane when floated; otherwise, `FALSE`.  
  
## Return Value  
 `TRUE` if the pane was floated successfully or if the pane cannot be floated because [CBasePane::CanFloat](../vs140/cbasepane--canfloat.md) returns `FALSE`; otherwise, `FALSE`.  
  
## Remarks  
 Call this method to float the pane at the position that is specified by the `rectFloat` parameter. This method automatically creates a parent mini-frame window for the pane.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::CreateDefaultMiniframe](../vs140/cpane--createdefaultminiframe.md)   
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)