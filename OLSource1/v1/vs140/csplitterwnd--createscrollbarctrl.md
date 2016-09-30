---
title: "CSplitterWnd::CreateScrollBarCtrl"
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
  - "CSplitterWnd::CreateScrollBarCtrl"
  - "CSplitterWnd.CreateScrollBarCtrl"
  - "CreateScrollBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scroll bars, creating"
  - "CSplitterWnd class, overridables"
  - "CreateScrollBarCtrl method"
ms.assetid: 6e71c855-c9d6-4372-a927-155bce4236f2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::CreateScrollBarCtrl
Called by the framework to create a shared scroll bar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the window style.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The child window ID of the window. The ID can be **AFX_IDW_PANE_FIRST** unless the splitter window is nested inside another splitter window.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Override <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to include extra controls next to a scroll bar. The default behavior is to create normal Windows scroll bar controls.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AfxGetInstanceHandle](../vs140/afxgetinstancehandle.md)