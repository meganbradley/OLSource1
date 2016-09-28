---
title: "CPropertyPage::OnReset"
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
  - "CPropertyPage.OnReset"
  - "OnReset"
  - "CPropertyPage::OnReset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resetting property pages"
  - "property page overridables"
  - "CPropertyPage class, overridables"
  - "canceling property page actions"
  - "OnReset method"
ms.assetid: 8f1dd48a-2e3d-435d-a98d-47e1e7736af2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::OnReset
This member function is called by the framework when the user chooses the Cancel button.  
  
## Syntax  
  
```  
  
virtual void OnReset( );  
  
```  
  
## Remarks  
 When the framework calls this function, changes to all property pages that were made by the user previously choosing the Apply Now button are discarded, and the property sheet retains focus.  
  
 Override this member function to specify what action the program takes when the user clicks the Cancel button.  
  
 The default implementation of `OnReset` does nothing.  
  
## Example  
 See the example for [CPropertyPage::OnCancel](../vs140/cpropertypage--oncancel.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertyPage::OnCancel](../vs140/cpropertypage--oncancel.md)   
 [CPropertyPage::OnApply](../vs140/cpropertypage--onapply.md)