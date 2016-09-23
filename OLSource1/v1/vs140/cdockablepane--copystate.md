---
title: "CDockablePane::CopyState"
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
  - CopyState
  - CDockablePane::CopyState
  - CDockablePane.CopyState
dev_langs: 
  - C++
helpviewer_keywords: 
  - CopyState method
ms.assetid: 0c327a03-0232-41a3-8483-8c5f2b328c05
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::CopyState
Copies the state of a dockable pane.  
  
## Syntax  
  
```  
virtual void CopyState(  
   CDockablePane* pOrgBar  
);  
```  
  
#### Parameters  
 [in] `pOrgBar`  
 A pointer to a dockable pane.  
  
## Remarks  
 `CDockablePane::CopyState` copies the state of `pOrgBar` to the current pane by calling the following methods:  
  
-   [CPane::CopyState](../vs140/cpane--copystate.md)  
  
-   [CDockablePane::GetAHRestoredRect](../vs140/cdockablepane--getahrestoredrect.md)  
  
-   [CDockablePane::GetAHSlideMode](../vs140/cdockablepane--getahslidemode.md)  
  
-   [CDockablePane::GetLastPercentInPaneContainer](../vs140/cdockablepane--getlastpercentinpanecontainer.md)  
  
-   [CDockablePane::IsAutohideAllEnabled](../vs140/cdockablepane--isautohideallenabled.md)  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)