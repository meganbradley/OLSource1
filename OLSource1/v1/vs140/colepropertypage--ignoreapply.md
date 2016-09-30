---
title: "COlePropertyPage::IgnoreApply"
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
  - "IgnoreApply"
  - "COlePropertyPage.IgnoreApply"
  - "COlePropertyPage::IgnoreApply"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IgnoreApply method"
ms.assetid: 43078cae-7a9b-4f0b-a8c7-d0f6c9d2ad1b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertyPage::IgnoreApply
Determines which controls do not enable the Apply button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 ID of the control to be ignored.  
  
## Remarks  
 The property page's Apply button is enabled only when values of property page controls have been changed. Use this function to specify controls that do not cause the Apply button to be enabled when their values change.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COlePropertyPage Class](../vs140/colepropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePropertyPage::GetControlStatus](../vs140/colepropertypage--getcontrolstatus.md)