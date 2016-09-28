---
title: "CSnapInPropertyPageImpl::SetModified"
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
  - "ATL::CSnapInPropertyPageImpl::SetModified"
  - "CSnapInPropertyPageImpl::SetModified"
  - "ATL.CSnapInPropertyPageImpl.SetModified"
  - "CSnapInPropertyPageImpl.SetModified"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetModified method"
ms.assetid: a3f758dd-b02e-44d3-ac20-29ea3aa18cb6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInPropertyPageImpl::SetModified
Call this member function to enable or disable the **Apply Now** button, based on whether the settings in the property page should be applied to the appropriate external object.  
  
## Syntax  
  
```  
  
      void SetModified(  
   BOOL bChanged = TRUE   
);  
```  
  
#### Parameters  
 `bChanged`  
 [in] **TRUE** to indicate that the property page settings have been modified since the last time they were applied; **FALSE** to indicate that the property page settings have been applied, or should be ignored.  
  
## Remarks  
 The property sheet keeps track of which pages are "dirty," that is, property pages for which you have called **SetModified( TRUE )**. The **Apply Now** button will always be enabled if you call **SetModified( TRUE )** for one of the pages. The **Apply Now** button will be disabled when you call **SetModified( FALSE )** for one of the pages, but only if none of the other pages is "dirty."  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInPropertyPageImpl Class](../vs140/csnapinpropertypageimpl-class.md)