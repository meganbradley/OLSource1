---
title: "CMFCToolBarButton::OnClickUp"
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
  - "CMFCToolBarButton::OnClickUp"
  - "OnClickUp"
  - "CMFCToolBarButton.OnClickUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClickUp method"
ms.assetid: 6268e9c6-cdbd-48d8-a7a3-b3eb3f279577
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnClickUp
Called by the framework when the user releases the mouse button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 This method returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method when the user releases the toolbar button.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Override this method to return a nonzero value if the button processes the click message.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)