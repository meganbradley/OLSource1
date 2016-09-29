---
title: "CRichEditView::m_nWordWrap"
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
  - "CRichEditView.m_nWordWrap"
  - "WrapNone"
  - "WrapToTargetDevice"
  - "m_nWordWrap"
  - "CRichEditView::m_nWordWrap"
  - "WrapToWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nWordWrap"
  - "WrapToWindow"
  - "CRichEditView class, data members"
  - "WrapNone"
  - "WrapToTargetDevice"
ms.assetid: 723d0042-6e6d-4fa4-90d6-9aced891099d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::m_nWordWrap
Indicates the type of word wrap for this rich edit view.  
  
## Syntax  
  
```  
  
int m_nWordWrap;  
  
```  
  
## Remarks  
 One of the following values:  
  
-   `WrapNone` Indicates no automatic word wrapping.  
  
-   `WrapToWindow` Indicates word wrapping based on the width of the window.  
  
-   `WrapToTargetDevice` Indicates word wrapping based on the characteristics of the target device.  
  
## Example  
 See the example for [CRichEditView::WrapChanged](../vs140/cricheditview--wrapchanged.md).  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::WrapChanged](../vs140/cricheditview--wrapchanged.md)