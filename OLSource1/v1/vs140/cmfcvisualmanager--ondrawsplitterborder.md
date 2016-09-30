---
title: "CMFCVisualManager::OnDrawSplitterBorder"
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
  - "CMFCVisualManager.OnDrawSplitterBorder"
  - "OnDrawSplitterBorder"
  - "CMFCVisualManager::OnDrawSplitterBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawSplitterBorder method"
ms.assetid: b40b7a7d-3fda-49b6-8d76-7459a6c8b485
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawSplitterBorder
The framework calls this method when it draws the border around an instance of the [CSplitterWndEx Class](../vs140/csplitterwndex-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a splitter window. The framework draws the border for this window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the splitter window.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the border for a splitter window.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWndEx Class](../vs140/csplitterwndex-class.md)