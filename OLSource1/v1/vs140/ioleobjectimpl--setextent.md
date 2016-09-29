---
title: "IOleObjectImpl::SetExtent"
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
  - "ATL::IOleObjectImpl<T>::SetExtent"
  - "IOleObjectImpl<T>.SetExtent"
  - "IOleObjectImpl::SetExtent"
  - "SetExtent"
  - "ATL.IOleObjectImpl<T>.SetExtent"
  - "ATL::IOleObjectImpl::SetExtent"
  - "IOleObjectImpl<T>::SetExtent"
  - "ATL.IOleObjectImpl.SetExtent"
  - "IOleObjectImpl.SetExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetExtent method"
ms.assetid: a68511b2-1f37-4dac-a86e-6e0a36a31cea
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::SetExtent
Sets the extent of the control's display area.  
  
## Syntax  
  
```  
  
      STDMETHOD(SetExtent)(  
   DWORD dwDrawAspect,  
   SIZEL* psizel   
);  
```  
  
## Remarks  
 Otherwise, `SetExtent` stores the value pointed to by `psizel` in the control class data member [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md). This value is in HIMETRIC units (0.01 millimeter per unit).  
  
 If the control class data member [CComControlBase::m_bResizeNatural](../vs140/ccomcontrolbase--m_bresizenatural.md) is **TRUE**, `SetExtent` also stores the value pointed to by `psizel` in the control class data member [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md).  
  
 If the control class data member [CComControlBase::m_bRecomposeOnResize](../vs140/ccomcontrolbase--m_brecomposeonresize.md) is **TRUE**, `SetExtent` calls `SendOnDataChange` and `SendOnViewChange` to notify all advisory sinks registered with the advise holder that the control size has changed.  
  
 See [IOleObject::SetExtent](http://msdn.microsoft.com/library/windows/desktop/ms694330) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::GetExtent](../vs140/ioleobjectimpl--getextent.md)   
 [CComControlBase::SendOnDataChange](../vs140/ccomcontrolbase--sendondatachange.md)   
 [CComControlBase::SendOnViewChange](../vs140/ccomcontrolbase--sendonviewchange.md)