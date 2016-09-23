---
title: "CMFCRibbonBaseElement::OnDrawOnList"
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
  - CMFCRibbonBaseElement::OnDrawOnList
  - OnDrawOnList
  - CMFCRibbonBaseElement.OnDrawOnList
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawOnList method
ms.assetid: f7007478-7172-49ef-85ad-2ec18e636988
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonBaseElement::OnDrawOnList
Called by the framework to draw the ribbon element in a commands list box.  
  
## Syntax  
  
```  
virtual void OnDrawOnList(  
   CDC* pDC,  
   CString strText,  
   int nTextOffset,  
   CRect rect,  
   BOOL bIsSelected,  
   BOOL bHighlighted  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context for the ribbon element.  
  
 [in] `strText`  
 The display text.  
  
 [in] `nTextOffset`  
 Distance, in pixels, from the left side of the list box to the display text.  
  
 [in] `rect`  
 The display rectangle for the ribbon element.  
  
 [in] `bIsSelected`  
 This parameter is not used.  
  
 [in] `bHighlighted`  
 This parameter is not used.  
  
## Remarks  
 The commands list box displays ribbon elements to enable users to customize the quick access toolbar.  
  
## Requirements  
 **Header:** afxbaseribbonelement.h  
  
## See Also  
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)