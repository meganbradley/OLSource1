---
title: "CMFCToolBarButton::OnGetCustomToolTipText"
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
  - "CMFCToolBarButton::OnGetCustomToolTipText"
  - "OnGetCustomToolTipText"
  - "CMFCToolBarButton.OnGetCustomToolTipText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetCustomToolTipText method"
ms.assetid: 1a3e596e-5ca1-4df2-945c-c7c004d73b37
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnGetCustomToolTipText
Called by the framework to retrieve the custom tooltip text for the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that receives the custom tooltip text.  
  
## Return Value  
 This method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method when it displays the tooltip for the toolbar button. If this method returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the framework uses a default tooltip.  
  
 The default implementation does nothing and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Override this method and return a nonzero value to provide custom tooltip text for the toolbar button.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)