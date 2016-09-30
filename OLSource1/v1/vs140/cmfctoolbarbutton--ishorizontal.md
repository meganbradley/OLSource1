---
title: "CMFCToolBarButton::IsHorizontal"
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
  - "IsHorizontal"
  - "CMFCToolBarButton::IsHorizontal"
  - "CMFCToolBarButton.IsHorizontal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsHorizontal method"
ms.assetid: 207fc986-a245-483c-a763-6d8741724171
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsHorizontal
Determines whether the button is located on a horizontal toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if a toolbar button is located on a horizontal toolbar; otherwise 0.  
  
## Remarks  
 The framework calls this method to determine the layout of toolbar buttons.  
  
 This method returns the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data member. The default value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> data member is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; it is reset on each call to the [CMFCToolBarButton::OnDraw](../vs140/cmfctoolbarbutton--ondraw.md) method.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnDraw](../vs140/cmfctoolbarbutton--ondraw.md)