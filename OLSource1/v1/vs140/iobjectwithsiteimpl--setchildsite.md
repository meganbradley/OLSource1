---
title: "IObjectWithSiteImpl::SetChildSite"
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
  - "IObjectWithSiteImpl::SetChildSite"
  - "SetChildSite"
  - "IObjectWithSiteImpl.SetChildSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetChildSite method"
ms.assetid: afe679b4-978a-4cd3-bb91-08bef7218bf4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObjectWithSiteImpl::SetChildSite
Provides the object with the site's **IUnknown** pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pUnkSite*  
 [in] Pointer to the **IUnknown** interface pointer of the site managing this object. If NULL, the object should call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on any existing site at which point the object no longer knows its site.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IObjectWithSiteImpl Class](../vs140/iobjectwithsiteimpl-class.md)   
 [IObjectWithSiteImpl::GetSite](../vs140/iobjectwithsiteimpl--getsite.md)