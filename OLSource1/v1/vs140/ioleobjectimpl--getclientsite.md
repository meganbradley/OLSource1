---
title: "IOleObjectImpl::GetClientSite"
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
  - "ATL.IOleObjectImpl.GetClientSite"
  - "IOleObjectImpl<T>::GetClientSite"
  - "ATL::IOleObjectImpl<T>::GetClientSite"
  - "IOleObjectImpl::GetClientSite"
  - "ATL::IOleObjectImpl::GetClientSite"
  - "GetClientSite"
  - "IOleObjectImpl.GetClientSite"
  - "ATL.IOleObjectImpl<T>.GetClientSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClientSite method"
ms.assetid: 9fede395-dfe7-48e2-a8d2-ff339626b705
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::GetClientSite
Puts the pointer in the control class data member [CComControlBase::m_spClientSite](../vs140/ccomcontrolbase--m_spclientsite.md) into *ppClientSite* and increments the reference count on the pointer.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetClientSite)(  
   IOleClientSite** ppClientSite   
);  
```  
  
## Remarks  
 See [IOleObject::GetClientSite](http://msdn.microsoft.com/library/windows/desktop/ms692603) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::SetClientSite](../vs140/ioleobjectimpl--setclientsite.md)