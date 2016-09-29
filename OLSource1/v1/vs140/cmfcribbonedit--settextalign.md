---
title: "CMFCRibbonEdit::SetTextAlign"
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
  - "SetTextAlign"
  - "CMFCRibbonEdit::SetTextAlign"
  - "CMFCRibbonEdit.SetTextAlign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTextAlign method"
ms.assetid: caa01f73-930f-4e41-9e0d-514378575736
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit::SetTextAlign
Sets the text alignment of the text box.  
  
## Syntax  
  
```  
void SetTextAlign(  
    int nAlign   
);  
```  
  
#### Parameters  
 [in] `nAlign`  
 A text alignment enumerated value. See the Remarks section for possible values.  
  
## Remarks  
 The parameter `nAlign` is one of the following edit control styles:  
  
-   **ES_LEFT** for left alignment  
  
-   **ES_CENTER** for center alignment  
  
-   **ES_RIGHT** for right alignment  
  
 For more information about these styles, see [Edit Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775464).  
  
## Requirements  
 **Header:** afxRibbonEdit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)