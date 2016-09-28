---
title: "IPerPropertyBrowsingImpl::MapPropertyToPage"
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
  - "MapPropertyToPage"
  - "ATL::IPerPropertyBrowsingImpl<T>::MapPropertyToPage"
  - "IPerPropertyBrowsingImpl::MapPropertyToPage"
  - "ATL.IPerPropertyBrowsingImpl.MapPropertyToPage"
  - "ATL::IPerPropertyBrowsingImpl::MapPropertyToPage"
  - "IPerPropertyBrowsingImpl.MapPropertyToPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapPropertyToPage method"
ms.assetid: f89e403a-48ee-4edb-8baa-45a5a6c17f07
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IPerPropertyBrowsingImpl::MapPropertyToPage
Retrieves the CLSID of the property page associated with the specified property.  
  
## Syntax  
  
```  
  
      STDMETHOD(MapPropertyToPage)(  
   DISPID dispID,  
   CLSID* pClsid   
);  
```  
  
## Remarks  
 ATL uses the object's property map to obtain this information.  
  
 See [IPerPropertyBrowsing::MapPropertyToPage](http://msdn.microsoft.com/library/windows/desktop/ms694476) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IPerPropertyBrowsingImpl Class](../vs140/iperpropertybrowsingimpl-class.md)   
 [BEGIN_PROP_MAP](../vs140/begin_prop_map.md)