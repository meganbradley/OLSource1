---
title: "CMFCBaseTabCtrl::ShowTab"
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
  - "CMFCBaseTabCtrl::ShowTab"
  - "CMFCBaseTabCtrl.ShowTab"
  - "ShowTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowTab method"
ms.assetid: 5abcee0d-1930-43cc-894b-917d69a6381b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::ShowTab
Shows or hides the specified tab.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the tab that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> will show or hide.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to show the tab.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to immediately recalculate the window layout.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether to select the tab specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> only applies if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is successful, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> will send the message AFX_WM_CHANGE_ACTIVE_TAB to the parent of the tab window.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)