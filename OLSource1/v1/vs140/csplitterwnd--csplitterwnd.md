---
title: "CSplitterWnd::CSplitterWnd"
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
  - "CSplitterWnd.CSplitterWnd"
  - "CSplitterWnd::CSplitterWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSplitterWnd class, constructor"
  - "splitter windows, constructing"
  - "CSplitterWnd class, construction"
ms.assetid: 8c5618f1-e97b-4128-aa6a-9b4810086004
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSplitterWnd::CSplitterWnd
Call to construct a `CSplitterWnd` object.  
  
## Syntax  
  
```  
  
CSplitterWnd( );  
```  
  
## Remarks  
 Construct a `CSplitterWnd` object in two steps. First, call the constructor, which creates the `CSplitterWnd` object, and then call the [Create](../vs140/csplitterwnd--create.md) member function, which creates the splitter window and attaches it to the `CSplitterWnd` object.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CSplitterWnd Class](../vs140/csplitterwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWnd::Create](../vs140/csplitterwnd--create.md)