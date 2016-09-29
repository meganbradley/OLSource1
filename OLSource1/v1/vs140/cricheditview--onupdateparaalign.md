---
title: "CRichEditView::OnUpdateParaAlign"
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
  - "CRichEditView::OnUpdateParaAlign"
  - "CRichEditView.OnUpdateParaAlign"
  - "OnUpdateParaAlign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, operations"
  - "OnUpdateParaAlign method"
  - "PFA_LEFT"
  - "PFA_CENTER"
  - "PFA_RIGHT"
ms.assetid: 9e7d4ded-7790-44a7-85ef-9402636de145
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::OnUpdateParaAlign
The framework calls this function to update the command UI for paragraph effect commands.  
  
## Syntax  
  
```  
  
      void OnUpdateParaAlign(  
   CCmdUI* pCmdUI,  
   WORD wAlign   
);  
```  
  
#### Parameters  
 `pCmdUI`  
 Pointer to a [CCmdUI](../vs140/ccmdui-class.md) object.  
  
 `wAlign`  
 The paragraph alignment to check. One of the following values:  
  
-   `PFA_LEFT` Align the paragraphs with the left margin.  
  
-   `PFA_RIGHT` Align the paragraphs with the right margin.  
  
-   `PFA_CENTER` Center the paragraphs between the margins.  
  
## Example  
 [!code[NVC_MFCDocView#159](../vs140/codesnippet/CPP/cricheditview--onupdateparaalign_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditView::GetParaFormatSelection](../vs140/cricheditview--getparaformatselection.md)   
 [CRichEditView::OnParaAlign](../vs140/cricheditview--onparaalign.md)   
 [CRichEditView::SetParaFormat](../vs140/cricheditview--setparaformat.md)