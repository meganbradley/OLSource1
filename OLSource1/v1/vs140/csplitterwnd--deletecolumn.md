---
title: "CSplitterWnd::DeleteColumn"
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
  - "CSplitterWnd.DeleteColumn"
  - "CSplitterWnd::DeleteColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteColumn method"
  - "splitter window columns"
  - "splitter window columns, deleting"
  - "CSplitterWnd class, overridables"
  - "splitter windows, overridables"
ms.assetid: dcd33ada-1b17-425e-bc74-12ddd1abd298
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::DeleteColumn
Deletes a column from the splitter window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *colDelete*  
 Specifies the column to be deleted.  
  
## Remarks  
 This member function is called by the framework to implement the logic of the dynamic splitter window (that is, if the splitter window has the **SPLS_DYNAMIC_SPLIT** style). It can be customized, along with the virtual function [CreateView](../vs140/csplitterwnd--createview.md), to implement more advanced dynamic splitters.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::DeleteRow](../vs140/csplitterwnd--deleterow.md)   
 [CSplitterWnd::CreateView](../vs140/csplitterwnd--createview.md)   
 [CSplitterWnd::DeleteView](../vs140/csplitterwnd--deleteview.md)