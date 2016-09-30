---
title: "CSplitterWnd::DeleteView"
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
  - "CSplitterWnd::DeleteView"
  - "DeleteView"
  - "CSplitterWnd.DeleteView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "splitter window views"
  - "splitter window views, deleting"
  - "splitter windows, deleting view"
  - "CSplitterWnd class, overridables"
  - "DeleteView method"
ms.assetid: c1ec51ab-1f3d-49e7-98b6-f756e7b7a089
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::DeleteView
Deletes a view from the splitter window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the splitter window row at which to delete the view.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the splitter window column at which to delete the view.  
  
## Remarks  
 If the active view is being deleted, the next view will become active. The default implementation assumes the view will auto delete in [PostNcDestroy](../vs140/cwnd--postncdestroy.md).  
  
 This member function is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](../vs140/csplitterwnd--createview.md), to implement more advanced dynamic splitters.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::PostNcDestroy](../vs140/cwnd--postncdestroy.md)   
 [CSplitterWnd::CreateView](../vs140/csplitterwnd--createview.md)   
 [CSplitterWnd::DeleteColumn](../vs140/csplitterwnd--deletecolumn.md)   
 [CSplitterWnd::DeleteRow](../vs140/csplitterwnd--deleterow.md)