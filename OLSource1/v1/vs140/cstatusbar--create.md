---
title: "CStatusBar::Create"
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
  - "CStatusBar.Create"
  - "CStatusBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStatusBar class, construction/destruction"
  - "Create method [C++]"
  - "status bars, constructing"
  - "status bars, destroying"
ms.assetid: ca67ec4d-91dd-41b8-bc1f-58fc822e8591
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar::Create
Creates a status bar (a child window) and associates it with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the [CWnd](../vs140/cwnd-class.md) object whose Windows window is the parent of the status bar.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The status-bar style. In addition to the standard Windows [styles](../vs140/window-styles.md), these styles are supported.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Control bar is at top of frame window.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Control bar is at bottom of frame window.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Control bar is not repositioned when the parent is resized.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The toolbar's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Also sets the initial font and sets the status bar's height to a default value.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBar::SetIndicators](../vs140/cstatusbar--setindicators.md)