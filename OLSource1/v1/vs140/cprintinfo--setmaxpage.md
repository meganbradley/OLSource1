---
title: "CPrintInfo::SetMaxPage"
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
  - "SetMaxPage"
  - "CPrintInfo.SetMaxPage"
  - "CPrintInfo::SetMaxPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMaxPage method"
  - "CPrintInfo structure, attributes"
ms.assetid: 5d230ef9-7806-436c-84ec-f0c45a0c1725
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::SetMaxPage
Call this function to specify the number of the last page of the document.  
  
## Syntax  
  
```  
  
      void SetMaxPage(  
   UINT nMaxPage   
);  
```  
  
#### Parameters  
 *nMaxPage*  
 Number of the last page of the document.  
  
## Remarks  
 This value is stored in the `CPrintDialog` object referenced by the `m_pPD` member. If the length of the document is known before it is printed, call this function from your override of `CView::OnPreparePrinting`. If the length of the document depends on a setting specified by the user in the Print dialog box, call this function from your override of `CView::OnBeginPrinting`. If the length of the document is not known until it is printed, use the `m_bContinuePrinting` member to control the print loop.  
  
## Example  
 See the example for [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::m_bContinuePrinting](../vs140/cprintinfo--m_bcontinueprinting.md)   
 [CPrintInfo::m_nCurPage](../vs140/cprintinfo--m_ncurpage.md)   
 [CPrintInfo::m_pPD](../vs140/cprintinfo--m_ppd.md)   
 [CPrintInfo::GetMinPage](../vs140/cprintinfo--getminpage.md)   
 [CPrintInfo::GetToPage](../vs140/cprintinfo--gettopage.md)   
 [CPrintInfo::SetMinPage](../vs140/cprintinfo--setminpage.md)   
 [CView::OnBeginPrinting](../vs140/cview--onbeginprinting.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)