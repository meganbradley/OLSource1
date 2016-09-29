---
title: "COlePropertyPage::OnSetPageSite"
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
  - "COlePropertyPage::OnSetPageSite"
  - "COlePropertyPage.OnSetPageSite"
  - "OnSetPageSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetPageSite method"
ms.assetid: 4f6a4dc6-b55c-46ee-bbb9-c09866e95ca0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertyPage::OnSetPageSite
The framework calls this function when the property frame provides the property page's page site.  
  
## Syntax  
  
```  
  
virtual void OnSetPageSite( );  
```  
  
## Remarks  
 The default implementation loads the page's caption and attempts to determine the page's size from the dialog resource. Override this function if your property page requires any further action; your override should call the base-class implementation.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COlePropertyPage Class](../vs140/colepropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePropertyPage::GetPageSite](../vs140/colepropertypage--getpagesite.md)