---
title: "CMFCRibbonEdit::SetWidth"
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
  - CMFCRibbonEdit.SetWidth
  - SetWidth
  - CMFCRibbonEdit::SetWidth
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetWidth method
ms.assetid: 68d6b024-05d8-4e8c-aab9-11a0058dcaba
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonEdit::SetWidth
Sets the width of the text box for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
## Syntax  
  
```  
void SetWidth(  
    int nWidth,  
    BOOL bInFloatyMode = FALSE   
);  
```  
  
#### Parameters  
 [in] `nWidth`  
 The width, in pixels, of the text box.  
  
 `bInFloatyMode`  
 `TRUE` to set the width for floating mode; `FALSE` to set the width for regular mode.  
  
## Remarks  
 The [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control has two widths depending on its display mode: floating mode and regular mode.  
  
## Requirements  
 **Header:** afxRibbonEdit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)