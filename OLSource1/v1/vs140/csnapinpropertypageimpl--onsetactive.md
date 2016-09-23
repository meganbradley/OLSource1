---
title: "CSnapInPropertyPageImpl::OnSetActive"
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
  - ATL::CSnapInPropertyPageImpl::OnSetActive
  - ATL.CSnapInPropertyPageImpl.OnSetActive
  - CSnapInPropertyPageImpl::OnSetActive
  - CSnapInPropertyPageImpl.OnSetActive
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnSetActive method
ms.assetid: fea0c8c5-caef-4131-9b5b-baf06f419aee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSnapInPropertyPageImpl::OnSetActive
This member function is called when the page is chosen by the user and becomes the active page.  
  
## Syntax  
  
```  
  
BOOL OnSetActive( );  
  
```  
  
## Return Value  
 Nonzero if the page was successfully set active; otherwise 0.  
  
## Remarks  
 Override this member function to perform tasks when a page is activated. Your override of this member function should call the default version before any other processing is done.  
  
 The default implementation returns **TRUE**.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInPropertyPageImpl Class](../vs140/csnapinpropertypageimpl-class.md)