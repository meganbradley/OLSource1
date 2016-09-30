---
title: "CMFCToolBarButton::OnCalculateSize"
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
  - "OnCalculateSize"
  - "CMFCToolBarButton.OnCalculateSize"
  - "CMFCToolBarButton::OnCalculateSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCalculateSize method"
ms.assetid: 5c0a14b0-5fd5-4679-86a6-fde061caf6dd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnCalculateSize
Called by the framework to calculate the size of the button for the specified device context and docking state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The default size of the button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. This parameter is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the toolbar is docked horizontally or is floating, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the toolbar is docked vertically.  
  
## Return Value  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure that contains the dimensions of the button, in pixels.  
  
## Remarks  
 The framework calls this method to determine the size of the toolbar button for the specified device context and dock state.  
  
 The default implementation considers the text and image sizes (if they are displayed), the text and image positions (the text below or at the right-hand side of the image), and the toolbar dock state.  
  
 Override this method if you want to provide the size of a non-standard button (for example, an edit box button).  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)