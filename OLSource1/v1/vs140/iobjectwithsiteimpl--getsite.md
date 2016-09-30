---
title: "IObjectWithSiteImpl::GetSite"
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
  - "IObjectWithSiteImpl.GetSite"
  - "GetSite"
  - "ATL::IObjectWithSiteImpl::GetSite"
  - "ATL.IObjectWithSiteImpl<T>.GetSite"
  - "IObjectWithSiteImpl<T>::GetSite"
  - "IObjectWithSiteImpl::GetSite"
  - "ATL::IObjectWithSiteImpl<T>::GetSite"
  - "ATL.IObjectWithSiteImpl.GetSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSite method"
ms.assetid: c9c50b41-22b0-4f54-8cab-36dc8cca5824
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObjectWithSiteImpl::GetSite
Queries the site for a pointer to the interface identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the site supports this interface, the pointer is returned via <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is set to **NULL**.  
  
 See [IObjectWithSite::GetSite](http://msdn.microsoft.com/library/windows/desktop/ms694452) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IObjectWithSiteImpl Class](../vs140/iobjectwithsiteimpl-class.md)   
 [IObjectWithSiteImpl::SetSite](../vs140/iobjectwithsiteimpl--setsite.md)