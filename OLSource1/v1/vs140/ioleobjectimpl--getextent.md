---
title: "IOleObjectImpl::GetExtent"
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
  - "IOleObjectImpl.GetExtent"
  - "IOleObjectImpl<T>.GetExtent"
  - "ATL::IOleObjectImpl::GetExtent"
  - "ATL.IOleObjectImpl.GetExtent"
  - "IOleObjectImpl::GetExtent"
  - "ATL::IOleObjectImpl<T>::GetExtent"
  - "IOleObjectImpl<T>::GetExtent"
  - "GetExtent"
  - "ATL.IOleObjectImpl<T>.GetExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtent method"
ms.assetid: fd207e1d-a8f1-4169-ae6d-b11591211bc4
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::GetExtent
Retrieves a running control's display size in HIMETRIC units (0.01 millimeter per unit).  
  
## Syntax  
  
```  
  
      STDMETHOD(GetExtent)(  
   DWORD dwDrawAspect,  
   SIZEL* psizel   
);  
```  
  
## Remarks  
 The size is stored in the control class data member [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md).  
  
 See [IOleObject::GetExtent](http://msdn.microsoft.com/library/windows/desktop/ms692325) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::SetExtent](../vs140/ioleobjectimpl--setextent.md)