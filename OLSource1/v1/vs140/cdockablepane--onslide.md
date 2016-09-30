---
title: "CDockablePane::OnSlide"
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
  - "OnSlide"
  - "CDockablePane::OnSlide"
  - "CDockablePane.OnSlide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSlide method"
ms.assetid: 921cc771-6259-4a03-a4b4-4778b0b7b750
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::OnSlide
Called by the framework to animate the pane when it is in autohide mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to show the pane; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to hide the pane.  
  
## Remarks  
 Override this method in a derived class to implement custom autohide effects.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)