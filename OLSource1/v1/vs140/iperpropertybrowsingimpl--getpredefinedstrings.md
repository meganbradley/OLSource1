---
title: "IPerPropertyBrowsingImpl::GetPredefinedStrings"
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
  - GetPredefinedStrings
  - IPerPropertyBrowsingImpl::GetPredefinedStrings
  - ATL::IPerPropertyBrowsingImpl::GetPredefinedStrings
  - IPerPropertyBrowsingImpl.GetPredefinedStrings
  - ATL.IPerPropertyBrowsingImpl.GetPredefinedStrings
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPredefinedStrings method
ms.assetid: dd483ada-d52e-4e6e-b74d-8925e093960d
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IPerPropertyBrowsingImpl::GetPredefinedStrings
Fills each array with zero items.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetPredefinedStrings)(  
   DISPID dispID,  
   CALPOLESTR* pCaStringsOut,  
   CADWORD* pCaCookiesOut   
);  
```  
  
## Return Value  
 ATL's implementation of [GetPredefinedValue](../vs140/iperpropertybrowsingimpl--getpredefinedvalue.md) returns **E_NOTIMPL**.  
  
## Remarks  
 See [IPerPropertyBrowsing::GetPredefinedStrings](http://msdn.microsoft.com/library/windows/desktop/ms679724) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IPerPropertyBrowsingImpl Class](../vs140/iperpropertybrowsingimpl-class.md)   
 [CADWORD](http://msdn.microsoft.com/library/windows/desktop/ms682383)   
 [CALPOLESTR](http://msdn.microsoft.com/library/windows/desktop/ms686617)