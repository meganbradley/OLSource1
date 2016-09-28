---
title: "CPropertyPage::SetModified"
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
  - "SetModified"
  - "CPropertyPage::SetModified"
  - "CPropertyPage.SetModified"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertyPage class, operations"
  - "SetModified method"
  - "Apply Now button tracking"
  - "tracking the Apply Now button"
  - "property page operations"
ms.assetid: ba484fb6-968e-4e66-beeb-7a5179d25dd9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::SetModified
Call this member function to enable or disable the Apply Now button, based on whether the settings in the property page should be applied to the appropriate external object.  
  
## Syntax  
  
```  
  
      void SetModified(  
   BOOL bChanged = TRUE   
);  
```  
  
#### Parameters  
 `bChanged`  
 **TRUE** to indicate that the property page settings have been modified since the last time they were applied; **FALSE** to indicate that the property page settings have been applied, or should be ignored.  
  
## Remarks  
 The framework keeps track of which pages are "dirty," that is, property pages for which you have called **SetModified( TRUE )**. The Apply Now button will always be enabled if you call **SetModified( TRUE )** for one of the pages. The Apply Now button will be disabled when you call **SetModified( FALSE )** for one of the pages, but only if none of the other pages is "dirty."  
  
## Example  
 [!code[NVC_MFCDocView#127](../vs140/codesnippet/CPP/cpropertypage--setmodified_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertyPage::CancelToClose](../vs140/cpropertypage--canceltoclose.md)