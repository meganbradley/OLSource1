---
title: "CMFCToolBarButton::m_bWrap"
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
  - "CMFCToolBarButton.m_bWrap"
  - "m_bWrap"
  - "CMFCToolBarButton::m_bWrap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarButton class, data members"
  - "m_bWrap"
ms.assetid: 5eaf36bc-a31f-419f-a5c3-5d90902c14cd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::m_bWrap
Specifies whether the button next to a separator will be put on the next row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The framework sets this data member to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when the toolbar button does not fit on the current row or when you specify a layout (for example, a specific number of toolbar buttons per row).  
  
 The framework places this button on the next row if this data member is set to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and the toolbar is docked horizontally or floating.  
  
 The default value of this data member is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)