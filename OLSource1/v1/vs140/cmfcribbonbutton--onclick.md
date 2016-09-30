---
title: "CMFCRibbonButton::OnClick"
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
  - "OnClick"
  - "CMFCRibbonButton.OnClick"
  - "CMFCRibbonButton::OnClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClick method"
ms.assetid: ce30c6aa-2715-433c-898c-262a47a7c206
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::OnClick
Called by the framework when the user clicks the button.  
  
## Syntax  
  
```  
virtual void OnClick(  
   CPoint point   
);  
```  
  
#### Parameters  
 [in] `point`  
 Specifies the position of the mouse click.  
  
## Remarks  
 Override this method in a derived class if you want to handle this event.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)