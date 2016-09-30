---
title: "CFrameWnd::SetDockState"
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
  - "SetDockState"
  - "CFrameWnd.SetDockState"
  - "CFrameWnd::SetDockState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDockState method"
  - "CFrameWnd class, initialization"
ms.assetid: af599457-1eb6-4337-86d3-771bd71a4cc3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::SetDockState
Call this member function to apply state information stored in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to the frame window's control bars.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Apply the stored state to the frame window's control bars.  
  
## Remarks  
 To restore a previous state of the control bars, you can load the stored state with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to apply it to the frame window's control bars. The previous state is stored in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::GetDockState](../vs140/cframewnd--getdockstate.md)   
 [CDockState Class](../vs140/cdockstate-class.md)   
 [CDockState::LoadState](../vs140/cdockstate--loadstate.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)