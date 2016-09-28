---
title: "CSplitterWnd::DoKeyboardSplit"
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
  - "CSplitterWnd::DoKeyboardSplit"
  - "DoKeyboardSplit"
  - "CSplitterWnd.DoKeyboardSplit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoKeyboardSplit method"
  - "CSplitterWnd class, overridables"
  - "splitting windows with the keyboard"
  - "splitter windows, split command"
ms.assetid: 6735e721-171b-4211-b478-96a1ab19b507
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::DoKeyboardSplit
Performs the keyboard split command, usually "Window Split."  
  
## Syntax  
  
```  
  
virtual BOOL DoKeyboardSplit( );  
  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function is a high level command that is used by the [CView](../vs140/cview-class.md) class to delegate to the `CSplitterWnd` implementation.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView Class](../vs140/cview-class.md)