---
title: "CMFCMenuBar::SetMaximizeMode"
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
  - "SetMaximizeMode"
  - "CMFCMenuBar.SetMaximizeMode"
  - "CMFCMenuBar::SetMaximizeMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMaximizeMode method"
ms.assetid: 92fcad99-2d44-40a8-9691-65779e6b903c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::SetMaximizeMode
The framework calls this method when a MDI changes its display mode and the menu bar must be updated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean that specifies the mode. See the Remarks section for more information.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the MDI child window that is changing.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean that specifies whether the layout of the menu bar should be recalculated immediately.  
  
## Remarks  
 When an MDI child window is maximized, a menu bar attached to the MDI main frame window displays the system menu and the **Minimize**, **Maximize** and **Close** buttons. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the MDI child window is maximized and the menu bar must incorporate the extra controls. Otherwise, the menu bar returns to its regular state.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)