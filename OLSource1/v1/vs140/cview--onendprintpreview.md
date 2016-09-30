---
title: "CView::OnEndPrintPreview"
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
  - "OnEndPrintPreview"
  - "CView.OnEndPrintPreview"
  - "CView::OnEndPrintPreview"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "print preview, ending"
  - "OnEndPrintPreview method"
  - "CView class, overridables"
ms.assetid: ff91a441-89ab-49e7-8ef9-40635a8e23e4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnEndPrintPreview
Called by the framework when the user exits print preview mode.  
  
## Syntax  
  
```  
  
      virtual void OnEndPrintPreview(  
   CDC* pDC,  
   CPrintInfo* pInfo,  
   POINT point,  
   CPreviewView* pView   
);  
```  
  
#### Parameters  
 `pDC`  
 Points to the printer device context.  
  
 `pInfo`  
 Points to a [CPrintInfo](../vs140/cprintinfo-structure.md) structure that describes the current print job.  
  
 `point`  
 Specifies the point on the page that was last displayed in preview mode.  
  
 `pView`  
 Points to the view object used for previewing.  
  
## Remarks  
 The default implementation of this function calls the [OnEndPrinting](../vs140/cview--onendprinting.md) member function and restores the main frame window to the state it was in before print preview began. Override this function to perform special processing when preview mode is terminated. For example, if you want to maintain the user's position in the document when switching from preview mode to normal display mode, you can scroll to the position described by the `point` parameter and the `m_nCurPage` member of the `CPrintInfo` structure that the `pInfo` parameter points to.  
  
 Always call the base class version of `OnEndPrintPreview` from your override, typically at the end of the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [CView::OnEndPrinting](../vs140/cview--onendprinting.md)