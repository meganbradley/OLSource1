---
title: "CPrintInfo::m_bDirect"
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
  - "CPrintInfo::m_bDirect"
  - "m_bDirect"
  - "CPrintInfo.m_bDirect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintInfo structure, data members"
  - "m_bDirect"
ms.assetid: ee103d88-d5d7-42f1-a275-e35d1397f1c3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::m_bDirect
The framework sets this member to **TRUE** if the Print dialog box will be bypassed for direct printing; **FALSE** otherwise.  
  
## Remarks  
 The Print dialog is normally bypassed when you print from the shell or when printing is done using the command ID **ID_FILE_PRINT_DIRECT**.  
  
 You normally don't change this member, but if you do change it, change it before you call [CView::DoPreparePrinting](../vs140/cview--doprepareprinting.md) in your override of [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::DoPreparePrinting](../vs140/cview--doprepareprinting.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)