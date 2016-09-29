---
title: "CRichEditView::OnParaAlign"
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
  - "CRichEditView.OnParaAlign"
  - "OnParaAlign"
  - "CRichEditView::OnParaAlign"
  - "PFA_CENTER"
  - "PFA_LEFT"
  - "PFA_RIGHT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnParaAlign method"
  - "PFA_LEFT"
  - "PFA_CENTER"
  - "PFA_RIGHT"
  - "CRichEditView class, overridables"
ms.assetid: fed46c64-d765-49f3-a045-0e4ca51758c3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnParaAlign
Call this function to change the paragraph alignment for the selected paragraphs.  
  
## Syntax  
  
```  
  
      void OnParaAlign(  
   WORD wAlign   
);  
```  
  
#### Parameters  
 `wAlign`  
 Desired paragraph alignment. One of the following values:  
  
-   `PFA_LEFT` Align the paragraphs with the left margin.  
  
-   `PFA_RIGHT` Align the paragraphs with the right margin.  
  
-   `PFA_CENTER` Center the paragraphs between the margins.  
  
## Example  
 [!code[NVC_MFCDocView#156](../vs140/codesnippet/CPP/cricheditview--onparaalign_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::OnUpdateParaAlign](../vs140/cricheditview--onupdateparaalign.md)