---
title: "CMFCVisualManagerOffice2003::OnFillCommandsListBackground"
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
  - "CMFCVisualManagerOffice2003.OnFillCommandsListBackground"
  - "OnFillCommandsListBackground"
  - "CMFCVisualManagerOffice2003::OnFillCommandsListBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillCommandsListBackground method"
ms.assetid: 857e525c-9f12-4081-8b68-1a8a5df50045
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnFillCommandsListBackground
The framework calls this method when it fills the background of a toolbar button that belongs to a command list. This command list is part of the customization dialog.  
  
## Syntax  
  
```  
virtual COLORREF OnFillCommandsListBackground(  
   CDC* pDC,  
   CRect rect,  
   BOOL bIsSelected = FALSE  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the button.  
  
 [in] `bIsSelected`  
 A Boolean parameter that indicates whether the button is selected.  
  
## Return Value  
 The text color for the toolbar button.  
  
## Remarks  
 For more information about the customization list, see [CMFCToolBarButton::OnDrawOnCustomizeList](../vs140/cmfctoolbarbutton--ondrawoncustomizelist.md). The default implementation for this method fills the background based on the color scheme of the currently selected skin.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)