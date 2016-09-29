---
title: "CSplitterWnd::IsChildPane"
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
  - "IsChildPane"
  - "CSplitterWnd::IsChildPane"
  - "CSplitterWnd.IsChildPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, operations"
  - "IsChildPane method"
  - "splitter windows, panes"
ms.assetid: 1cdffbed-03f2-41ae-a173-16731c2be4ae
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::IsChildPane
Determines whether `pWnd` is currently a child pane of this splitter window.  
  
## Syntax  
  
```  
  
      BOOL IsChildPane(  
   CWnd* pWnd,  
   int* pRow,  
   int* pCol  
);  
```  
  
#### Parameters  
 `pWnd`  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object to be tested.  
  
 `pRow`  
 A pointer to an `int` in which to store row number.  
  
 `pCol`  
 A pointer to an `int` in which to store a column number.  
  
## Return Value  
 If nonzero, `pWnd` is currently a child pane of this splitter window, and `pRow` and `pCol` are filled in with the position of the pane in the splitter window. If `pWnd` is not a child pane of this splitter window, 0 is returned.  
  
## Remarks  
 In Visual C++ versions prior to 6.0, this function was defined as  
  
 `BOOL IsChildPane(CWnd* pWnd, int& row, int& col);`  
  
 This version is now obsolete and should not be used.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::GetPane](../vs140/csplitterwnd--getpane.md)