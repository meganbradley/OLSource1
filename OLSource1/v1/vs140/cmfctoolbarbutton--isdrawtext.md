---
title: "CMFCToolBarButton::IsDrawText"
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
  - "CMFCToolBarButton::IsDrawText"
  - "CMFCToolBarButton.IsDrawText"
  - "IsDrawText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDrawText method"
ms.assetid: 5ec5d9b1-9313-4788-996d-0a8e55a59b46
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsDrawText
Determines whether a text label is displayed on the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if a text label is displayed; otherwise 0.  
  
## Remarks  
 This method returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the toolbar button has no associated text label ([CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton--m_strtext.md) is empty) or [CMFCToolBarButton::m_bText](../vs140/cmfctoolbarbutton--m_btext.md) is set to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton--m_strtext.md)   
 [CMFCToolBarButton::m_bText](../vs140/cmfctoolbarbutton--m_btext.md)