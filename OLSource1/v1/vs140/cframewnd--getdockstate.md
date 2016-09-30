---
title: "CFrameWnd::GetDockState"
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
  - "CFrameWnd.GetDockState"
  - "CFrameWnd::GetDockState"
  - "GetDockState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFrameWnd class, initialization"
  - "GetDockState method"
ms.assetid: 23f44f55-c7a4-4e0e-b19e-e76953eff1bc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::GetDockState
Call this member function to store state information about the frame window's control bars in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the current state of the frame window's control bars upon return.  
  
## Remarks  
 You can then write the contents of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to storage using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If you later want to restore the control bars to a previous state, load the state with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, then call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to apply the previous state to the frame window's control bars.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::SetDockState](../vs140/cframewnd--setdockstate.md)   
 [CDockState Class](../vs140/cdockstate-class.md)   
 [CDockState::SaveState](../vs140/cdockstate--savestate.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)