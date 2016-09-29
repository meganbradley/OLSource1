---
title: "CPrintInfo::m_bPreview"
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
  - "CPrintInfo::m_bPreview"
  - "CPrintInfo.m_bPreview"
  - "m_bPreview"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintInfo structure, data members"
  - "m_bPreview"
ms.assetid: 593a86eb-170e-4bb6-8e3d-7b08093174df
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::m_bPreview
Contains a flag indicating whether the document is being previewed.  
  
## Remarks  
 This is set by the framework depending on which command the user executed. The Print dialog box is not displayed for a print-preview job. The **m_bPreview** member is a public variable of type **BOOL**.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::DoPreparePrinting](../vs140/cview--doprepareprinting.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)