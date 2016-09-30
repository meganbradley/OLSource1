---
title: "CMFCBaseTabCtrl::InsertTab"
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
  - "CMFCBaseTabCtrl::InsertTab"
  - "InsertTab"
  - "CMFCBaseTabCtrl.InsertTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertTab method"
ms.assetid: 0d1c6692-16a8-42b4-8239-6c652f7310de
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::InsertTab
Inserts a tab into the tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the window that this method adds as a new tab.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A string that contains the label for the new tab.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The zero-based index of the new tab.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An image ID from the image list. The tab control uses this image as the icon for the new tab.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether the new tab is detachable.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The resource ID for the label.  
  
## Remarks  
 If the object indicated by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md) and if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the framework creates a special wrapper for the new tab. By default, the wrapper is an instance of the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). Use the [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](../vs140/cmfcbasetabctrl--setdockingbarwrapperrtc.md) method to create a different wrapper class. Any custom wrapper class needs to be derived from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md)   
 [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](../vs140/cmfcbasetabctrl--setdockingbarwrapperrtc.md)