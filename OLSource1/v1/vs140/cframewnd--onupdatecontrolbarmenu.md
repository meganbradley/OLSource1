---
title: "CFrameWnd::OnUpdateControlBarMenu"
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
  - OnUpdateControlBarMenu
  - CFrameWnd.OnUpdateControlBarMenu
  - CFrameWnd::OnUpdateControlBarMenu
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnUpdateControlMenu method
ms.assetid: f3617eda-72f6-4fc8-9314-6b5992348fc9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWnd::OnUpdateControlBarMenu
Called by the framework when the associated menu is updated.  
  
## Syntax  
  
```  
  
      afx_msg void OnUpdateControlBarMenu(  
   CCmdUI* pCmdUI  
);  
```  
  
#### Parameters  
 `pCmdUI`  
 A pointer to a [CCmdUI](../vs140/ccmdui-class.md) object representing the menu that generated the update command. The update handler calls the [Enable](../vs140/ccmdui--enable.md) member function of the `CCmdUI` object through `pCmdUI` to update the user interface.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)