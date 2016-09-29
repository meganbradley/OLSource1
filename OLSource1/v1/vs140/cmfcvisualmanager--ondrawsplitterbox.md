---
title: "CMFCVisualManager::OnDrawSplitterBox"
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
  - "OnDrawSplitterBox"
  - "CMFCVisualManager::OnDrawSplitterBox"
  - "CMFCVisualManager.OnDrawSplitterBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawSplitterBox method"
ms.assetid: ab6dc60d-46ef-4138-b4f3-58b910e6a089
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawSplitterBox
The framework calls this method when it draws the drag box for an instance of the [CSplitterWndEx Class](../vs140/csplitterwndex-class.md). The drag box appears when the user selects the splitter bar and changes the dimensions of the child windows.  
  
## Syntax  
  
```  
virtual void OnDrawSplitterBox(  
   CDC* pDC,  
   CSplitterWndEx* pSplitterWnd,  
   CRect& rect  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pSplitterWnd`  
 A pointer to a splitter window. The framework draws the box for this splitter window.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the splitter window.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the drag box for a splitter window.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWndEx Class](../vs140/csplitterwndex-class.md)