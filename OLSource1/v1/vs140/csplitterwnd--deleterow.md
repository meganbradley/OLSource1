---
title: "CSplitterWnd::DeleteRow"
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
  - "CSplitterWnd::DeleteRow"
  - "CSplitterWnd.DeleteRow"
  - "DeleteRow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "splitter window rows, deleting"
  - "CSplitterWnd class, overridables"
  - "DeleteRow method"
  - "splitter window rows"
  - "splitter windows, overridables"
ms.assetid: 4a2d0157-09ce-4a9e-bd5a-e9321e61d62d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::DeleteRow
Deletes a row from the splitter window.  
  
## Syntax  
  
```  
  
      virtual void DeleteRow(  
   int rowDelete   
);  
```  
  
#### Parameters  
 *rowDelete*  
 Specifies the row to be deleted.  
  
## Remarks  
 This member function is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](../vs140/csplitterwnd--createview.md), to implement more advanced dynamic splitters.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::DeleteColumn](../vs140/csplitterwnd--deletecolumn.md)   
 [CSplitterWnd::CreateView](../vs140/csplitterwnd--createview.md)   
 [CSplitterWnd::DeleteView](../vs140/csplitterwnd--deleteview.md)