---
title: "CMFCBaseTabCtrl::CreateWrapper"
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
  - "CMFCBaseTabCtrl::CreateWrapper"
  - "CreateWrapper"
  - "CMFCBaseTabCtrl.CreateWrapper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateWrapper method"
ms.assetid: 65dab10e-70f8-4dee-9568-d41df47b4474
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::CreateWrapper
Creates a wrapper for a frame window that is derived from the [CWnd Class](../vs140/cwnd-class.md) but is not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the frame window that is wrapped.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that contains the label for the window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the window is detachable.  
  
## Return Value  
 A pointer to wrapper derived from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> successfully creates a wrapper class for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the method fails, it retruns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 A tabbed window can dock any object derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. However, in order for a [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md) object to be dockable, each object on the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must be detachable. Therefore, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> automatically wraps any objects that are not derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 By default, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> creates instances of the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). To change the wrapper's default class, call [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](../vs140/cmfcbasetabctrl--setdockingbarwrapperrtc.md).  
  
 If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, this method will not create a wrapper. Instead, it will fail and return <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](../vs140/cmfcbasetabctrl--setdockingbarwrapperrtc.md)   
 [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md)