---
title: "CBasePane::SetWindowPos"
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
  - "CBasePane::SetWindowPos"
  - "SetWindowPos"
  - "CBasePane.SetWindowPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowPos"
  - "CBasePane.SetWindowPos"
  - "CBasePane::SetWindowPos"
ms.assetid: 28c23155-6660-4d70-8912-4c59d52a3390
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::SetWindowPos
Changes the size, position, and Z-order of a pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that comes before this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object in the Z-order. For more information, see [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md).  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the position of the left side of the window.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the position of the top of the window.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the width of the window.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the height of the window.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies size and position options. For more information, see [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md).  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Handle to a structure that contains size and position information for one or more windows.  
  
## Return Value  
 A handle to an updated deferred window position structure, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, this method calls [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md). If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is non-<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, this method calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)