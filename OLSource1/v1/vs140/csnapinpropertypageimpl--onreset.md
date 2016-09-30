---
title: "CSnapInPropertyPageImpl::OnReset"
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
  - "CSnapInPropertyPageImpl::OnReset"
  - "ATL.CSnapInPropertyPageImpl.OnReset"
  - "CSnapInPropertyPageImpl.OnReset"
  - "OnReset"
  - "ATL::CSnapInPropertyPageImpl::OnReset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnReset method"
ms.assetid: 67167d48-a21c-437a-ac29-cb9b77d80349
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInPropertyPageImpl::OnReset
This member function is called when the user clicks the **Cancel** button.  
  
## Syntax  
  
```  
  
void OnReset( );  
  
```  
  
## Remarks  
 When this function is called, changes to all property pages that were made by the user previously clicking the **Apply Now** button are discarded, and the property sheet retains focus.  
  
 Override this member function to specify what action the program takes when the user clicks the **Cancel** button.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInPropertyPageImpl Class](../vs140/csnapinpropertypageimpl-class.md)