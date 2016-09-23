---
title: "CMFCVisualManagerOffice2003::OnDrawOutlookPageButtonBorder"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnDrawOutlookPageButtonBorder
  - CMFCVisualManagerOffice2003::OnDrawOutlookPageButtonBorder
  - CMFCVisualManagerOffice2003.OnDrawOutlookPageButtonBorder
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawOutlookPageButtonBorder method
ms.assetid: accfd7ee-2eed-46d7-85c5-f72f30dd4222
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::OnDrawOutlookPageButtonBorder
Called by the framework when it draws the border of an Outlook page button.  
  
## Syntax  
  
```  
virtual void OnDrawOutlookPageButtonBorder(  
   CDC* pDC,  
   CRect& rectBtn,  
   BOOL bIsHighlighted,  
   BOOL bIsPressed  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectBtn`  
 A rectangle that specifies the boundary of the Outlook page button.  
  
 [in] `bIsHighlighted`  
 A Boolean that specifies whether the button is highlighted.  
  
 [in] `bIsPressed`  
 A Boolean that specifies whether the button is pressed.  
  
## Remarks  
 Override this method in a custom visual manager to change the appearance of the Outlook page button.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)