---
title: "CSplitterWnd::ActivateNext"
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
  - "CSplitterWnd::ActivateNext"
  - "ActivateNext"
  - "CSplitterWnd.ActivateNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Next splitter window"
  - "CSplitterWnd class, overridables"
  - "splitter windows, overridables"
  - "ActivateNext method"
ms.assetid: 60a61ccd-3a08-47f6-91b3-8abd0f7af14d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::ActivateNext
Called by the framework to perform the Next Pane or Previous Pane command.  
  
## Syntax  
  
```  
  
      virtual void ActivateNext(  
   BOOL bPrev = FALSE   
);  
```  
  
#### Parameters  
 `bPrev`  
 Indicates which window to activate. **TRUE** for previous; **FALSE** for next.  
  
## Remarks  
 This member function is a high level command that is used by the [CView](../vs140/cview-class.md) class to delegate to the `CSplitterWnd` implementation.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView Class](../vs140/cview-class.md)   
 [CSplitterWnd::CanActivateNext](../vs140/csplitterwnd--canactivatenext.md)   
 [CSplitterWnd::SetActivePane](../vs140/csplitterwnd--setactivepane.md)