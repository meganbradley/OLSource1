---
title: "CMFCVisualManager::OnFillSplitterBackground"
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
  - "CMFCVisualManager::OnFillSplitterBackground"
  - "OnFillSplitterBackground"
  - "CMFCVisualManager.OnFillSplitterBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillSplitterBackground method"
ms.assetid: 344f8e7a-c64d-4e04-b1ce-5ee17a84198e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillSplitterBackground
The framework calls this method when it fills the background of a splitter window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an instance of the [CSplitterWndEx Class](../vs140/csplitterwndex-class.md). The framework fills the background for this splitter window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the splitter window.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a splitter window.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSplitterWndEx Class](../vs140/csplitterwndex-class.md)