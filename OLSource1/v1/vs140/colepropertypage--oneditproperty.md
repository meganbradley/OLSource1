---
title: "COlePropertyPage::OnEditProperty"
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
  - "OnEditProperty"
  - "COlePropertyPage.OnEditProperty"
  - "COlePropertyPage::OnEditProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEditProperty method"
ms.assetid: e3f1145b-272f-48e0-b910-7baa2348a5ef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertyPage::OnEditProperty
The framework calls this function when a specific property is to be edited.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Dispatch ID of the property being edited.  
  
## Return Value  
 The default implementation returns **FALSE**. Overrides of this function should return **TRUE**.  
  
## Remarks  
 You can override it to set the focus to the appropriate control on the page. The default implementation does nothing and returns **FALSE**.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COlePropertyPage Class](../vs140/colepropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)