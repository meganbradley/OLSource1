---
title: "CMDIChildWnd::GetMDIFrame"
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
  - "GetMDIFrame"
  - "CMDIChildWnd.GetMDIFrame"
  - "CMDIChildWnd::GetMDIFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMDIFrame method"
  - "CMDIChildWnd class, operations"
ms.assetid: 575acb86-4082-4c28-b863-db4b6dafb051
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWnd::GetMDIFrame
Call this function to return the MDI parent frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the MDI parent frame window.  
  
## Remarks  
 The frame returned is two parents removed from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and is the parent of the window of type **MDICLIENT** that manages the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. Call the [GetParent](../vs140/cwnd--getparent.md) member function to return the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object's immediate **MDICLIENT** parent as a temporary <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer.  
  
## Example  
 See the example for [CMDIFrameWnd::MDISetMenu](../vs140/cmdiframewnd--mdisetmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIChildWnd Class](../vs140/cmdichildwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetParent](../vs140/cwnd--getparent.md)