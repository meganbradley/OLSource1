---
title: "IPropertyPageImpl::GetPageInfo"
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
  - "IPropertyPageImpl.GetPageInfo"
  - "IPropertyPageImpl::GetPageInfo"
  - "GetPageInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPageInfo method"
ms.assetid: da86a81f-cf0e-4292-9811-bec7dc32faa9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPropertyPageImpl::GetPageInfo
Fills the *pPageInfo* structure with information contained in the data members.  
  
## Syntax  
  
```  
  
      HRESULT GetPageInfo(  
   PROPPAGEINFO* pPageInfo   
);  
```  
  
## Remarks  
 `GetPageInfo` loads the string resources associated with [m_dwDocString](../VS_csharp/ipropertypageimpl--m_dwdocstring.md), [m_dwHelpFile](../VS_csharp/ipropertypageimpl--m_dwhelpfile.md), and [m_dwTitle](../VS_csharp/ipropertypageimpl--m_dwtitle.md).  
  
 See [IPropertyPage::GetPageInfo](http://msdn.microsoft.com/library/windows/desktop/ms680714) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IPropertyPageImpl Class](../VS_csharp/ipropertypageimpl-class.md)   
 [IPropertyPageImpl::m_dwHelpContext](../VS_csharp/ipropertypageimpl--m_dwhelpcontext.md)   
 [IPropertyPageImpl::m_size](../VS_csharp/ipropertypageimpl--m_size.md)   
 [PROPPAGEINFO](http://msdn.microsoft.com/library/windows/desktop/ms680584)