---
title: "CMFCRibbonEdit::OnDrawOnList"
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
  - CMFCRibbonEdit::OnDrawOnList
  - CMFCRibbonEdit.OnDrawOnList
  - OnDrawOnList
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawOnList method
ms.assetid: 55334176-8d9c-4b23-98a4-fd808c1f56e5
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonEdit::OnDrawOnList
Called by the framework to draw the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control in a commands list box.  
  
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
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] `strText`  
 The display text[](../vs140/cmfcribbonedit-class.md "CMFCRibbonEdit Class").  
  
 [in] `nTextOffset`  
 Distance, in pixels, from the left side of the list box to the display text.  
  
 [in] `rect`  
 The display rectangle for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] `bIsSelected`  
 This parameter is not used.  
  
 [in] `bHighlighted`  
 This parameter is not used.  
  
## Remarks  
 The commands list box displays ribbon controls to enable users to customize the quick access toolbar.  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)