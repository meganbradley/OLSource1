---
title: "CMFCToolBarButton::IsDrawImage"
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
  - "CMFCToolBarButton.IsDrawImage"
  - "IsDrawImage"
  - "CMFCToolBarButton::IsDrawImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDrawImage method"
ms.assetid: 670d3ad8-66b7-40bf-9761-ea641c907c58
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsDrawImage
Determines whether an image is displayed on the button.  
  
## Syntax  
  
```  
BOOL IsDrawImage() const;  
```  
  
## Return Value  
 Nonzero if an image is displayed on the button; otherwise 0.  
  
## Remarks  
 This method returns `FALSE` if the toolbar button has no associated image ([CMFCToolBarButton::GetImage](../vs140/cmfctoolbarbutton--getimage.md) returns -1) or if [CMFCToolBarButton::m_bImage](../vs140/cmfctoolbarbutton--m_bimage.md) is set to `FALSE`.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::GetImage](../vs140/cmfctoolbarbutton--getimage.md)   
 [CMFCToolBarButton::m_bImage](../vs140/cmfctoolbarbutton--m_bimage.md)