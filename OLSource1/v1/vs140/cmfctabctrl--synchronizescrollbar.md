---
title: "CMFCTabCtrl::SynchronizeScrollBar"
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
  - "CMFCTabCtrl::SynchronizeScrollBar"
  - "CMFCTabCtrl.SynchronizeScrollBar"
  - "SynchronizeScrollBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SynchronizeScrollBar method"
ms.assetid: 6661eeeb-726d-4221-8107-4a8b4171e1e0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::SynchronizeScrollBar
Draws a horizontal scroll bar on a tab control that displays flat tabs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537) structure or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. When this method returns, and if this parameter is not <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the structure contains all the parameters of the scroll bar. The default value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if this method succeeds; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method affects only a tab control that displays flat tabs. The scroll bar influences all the tabs at the same time.  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [SCROLLINFO](http://msdn.microsoft.com/library/windows/desktop/bb787537)   
 [CMFCTabCtrl::ModifyTabStyle](../vs140/cmfctabctrl--modifytabstyle.md)