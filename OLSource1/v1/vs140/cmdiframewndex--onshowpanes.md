---
title: "CMDIFrameWndEx::OnShowPanes"
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
  - "CMDIFrameWndEx::OnShowPanes"
  - "OnShowPanes"
  - "CMDIFrameWndEx.OnShowPanes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShowPanes method"
ms.assetid: a6962760-374d-4c30-95f1-56feadeb8bc7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnShowPanes
Called by the framework to show or hide panes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to show panes, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to hide panes.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the state of the panes changes as a result of calling this method, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the panes are already in the state specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For example, if the panes are hidden and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the return value is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation removes the toolbar from the top-level frame window.  
  
 If [CDockingManager::m_bHideDockingBarsInContainerMode](../vs140/cdockingmanager--m_bhidedockingbarsincontainermode.md) is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (the default), all docking panes will be hidden.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)