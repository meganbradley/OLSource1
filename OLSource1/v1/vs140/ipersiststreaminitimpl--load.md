---
title: "IPersistStreamInitImpl::Load"
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
  - ATL.IPersistStreamInitImpl<T>.Load
  - ATL::IPersistStreamInitImpl::Load
  - ATL.IPersistStreamInitImpl.Load
  - IPersistStreamInitImpl<T>::Load
  - IPersistStreamInitImpl.Load
  - ATL::IPersistStreamInitImpl<T>::Load
  - IPersistStreamInitImpl::Load
dev_langs: 
  - C++
helpviewer_keywords: 
  - Load method
ms.assetid: 278e1a18-587c-4147-90fe-0a69aa776c24
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IPersistStreamInitImpl::Load
Loads the object's properties from the specified stream.  
  
## Syntax  
  
```  
  
      STDMETHOD(Load)(  
   LPSTREAM pStm   
);  
```  
  
## Remarks  
 ATL uses the object's property map to retrieve this information.  
  
 See [IPersistStreamInit::Load](http://msdn.microsoft.com/library/windows/desktop/ms680730) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IPersistStreamInitImpl Class](../vs140/ipersiststreaminitimpl-class.md)   
 [BEGIN_PROP_MAP](../vs140/begin_prop_map.md)   
 [IPersistStreamInitImpl::Save](../vs140/ipersiststreaminitimpl--save.md)   
 [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034)