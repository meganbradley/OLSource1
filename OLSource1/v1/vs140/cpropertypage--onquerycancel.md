---
title: "CPropertyPage::OnQueryCancel"
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
  - CPropertyPage.OnQueryCancel
  - CPropertyPage::OnQueryCancel
  - OnQueryCancel
dev_langs: 
  - C++
helpviewer_keywords: 
  - property page overridables
  - CPropertyPage class, overridables
  - canceling actions on property pages
  - OnQueryCancel method
ms.assetid: db02aaa2-79ad-4ded-b235-8445021da4bc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertyPage::OnQueryCancel
This member function is called by the framework when the user clicks the Cancel button and before the cancel action has taken place.  
  
## Syntax  
  
```  
  
virtual BOOL OnQueryCancel( );  
  
```  
  
## Return Value  
 Returns **FALSE** to prevent the cancel operation or TRUE to allow it.  
  
## Remarks  
 Override this member function to specify an action the program takes when the user clicks the Cancel button.  
  
 The default implementation of `OnQueryCancel` returns **TRUE**.  
  
## Example  
 [!code[NVC_MFCDocView#117](../vs140/codesnippet/CPP/cpropertypage--onquerycancel_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)