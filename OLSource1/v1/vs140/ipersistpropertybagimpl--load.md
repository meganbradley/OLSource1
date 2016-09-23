---
title: "IPersistPropertyBagImpl::Load"
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
  - IPersistPropertyBagImpl.Load
  - ATL.IPersistPropertyBagImpl.Load
  - ATL::IPersistPropertyBagImpl<T>::Load
  - ATL.IPersistPropertyBagImpl<T>.Load
  - IPersistPropertyBagImpl::Load
  - IPersistPropertyBagImpl<T>::Load
  - ATL::IPersistPropertyBagImpl::Load
dev_langs: 
  - C++
helpviewer_keywords: 
  - Load method
ms.assetid: 4068f041-ff11-4b4d-977d-bdcf35cd4a51
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IPersistPropertyBagImpl::Load
Loads the object's properties from a client-supplied property bag.  
  
## Syntax  
  
```  
  
      STDMETHOD(Load)(  
   LPPROPERTYBAG pPropBag,  
   LPERRORLOG pErrorLog   
);  
```  
  
## Remarks  
 ATL uses the object's property map to retrieve this information.  
  
 See [IPersistPropertyBag::Load](https://msdn.microsoft.com/en-us/library/aa768206.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IPersistPropertyBagImpl Class](../vs140/ipersistpropertybagimpl-class.md)   
 [BEGIN_PROP_MAP](../vs140/begin_prop_map.md)   
 [IPersistPropertyBagImpl::Save](../vs140/ipersistpropertybagimpl--save.md)   
 [IPropertyBag](https://msdn.microsoft.com/en-us/library/aa768196.aspx)   
 [IErrorLog](https://msdn.microsoft.com/en-us/library/aa768231.aspx)