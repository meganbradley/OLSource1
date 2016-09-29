---
title: "CMFCVisualManagerOffice2003::OnHighlightRarelyUsedMenuItems"
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
  - "CMFCVisualManagerOffice2003.OnHighlightRarelyUsedMenuItems"
  - "OnHighlightRarelyUsedMenuItems"
  - "CMFCVisualManagerOffice2003::OnHighlightRarelyUsedMenuItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHighlightRarelyUsedMenuItems method"
ms.assetid: 82e4dcf9-2ef0-46ab-a1bd-f2820ea4c4e1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnHighlightRarelyUsedMenuItems
The framework calls this method when it draws a highlighted menu command.  
  
## Syntax  
  
```  
virtual void OnHighlightRarelyUsedMenuItems(  
   CDC* pDC,  
   CRect rectRarelyUsed  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectRarelyUsed`  
 A rectangle that specifies the boundaries of the highlighted command.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of highlighted menu commands.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)