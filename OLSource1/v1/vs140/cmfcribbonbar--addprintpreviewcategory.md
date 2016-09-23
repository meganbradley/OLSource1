---
title: "CMFCRibbonBar::AddPrintPreviewCategory"
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
  - CMFCRibbonBar::AddPrintPreviewCategory
  - CMFCRibbonBar.AddPrintPreviewCategory
  - AddPrintPreviewCategory
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddPrintPreviewCategory method
ms.assetid: 54aba844-6abe-4730-a41c-52fb83b0a426
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBar::AddPrintPreviewCategory
Creates a print preview category on the ribbon bar.  
  
## Syntax  
  
```  
CMFCRibbonCategory* AddPrintPreviewCategory();  
```  
  
## Return Value  
 A pointer to the new ribbon category if the method was successful; otherwise, `NULL`.  
  
## Remarks  
 This method creates a ribbon category and the controls that it needs in order to provide a print preview.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)