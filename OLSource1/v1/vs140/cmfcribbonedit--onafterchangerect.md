---
title: "CMFCRibbonEdit::OnAfterChangeRect"
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
  - "CMFCRibbonEdit::OnAfterChangeRect"
  - "OnAfterChangeRect"
  - "CMFCRibbonEdit.OnAfterChangeRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAfterChangeRect method"
ms.assetid: fcb51973-b294-4ac7-927e-e8264dc15ee3
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit::OnAfterChangeRect
Called by the framework when the dimensions of the display rectangle for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control change.  
  
## Syntax  
  
```  
virtual void OnAfterChangeRect(  
   CDC* pDC  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)