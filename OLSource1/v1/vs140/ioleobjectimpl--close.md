---
title: "IOleObjectImpl::Close"
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
  - ATL::IOleObjectImpl::Close
  - IOleObjectImpl::Close
  - ATL.IOleObjectImpl.Close
  - ATL.IOleObjectImpl<T>.Close
  - IOleObjectImpl<T>::Close
  - IOleObjectImpl<T>.Close
  - IOleObjectImpl.Close
  - ATL::IOleObjectImpl<T>::Close
dev_langs: 
  - C++
helpviewer_keywords: 
  - Close method
ms.assetid: 0fe14103-925f-4472-886f-9796150ca4b5
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IOleObjectImpl::Close
Changes the control state from running to loaded.  
  
## Syntax  
  
```  
  
      STDMETHOD(Close)(  
   DWORD dwSaveOption   
);  
```  
  
## Remarks  
 Deactivates the control and destroys the control window if it exists. If the control class data member [CComControlBase::m_bRequiresSave](../vs140/ccomcontrolbase--m_brequiressave.md) is **TRUE** and the `dwSaveOption` parameter is either `OLECLOSE_SAVEIFDIRTY` or `OLECLOSE_PROMPTSAVE`, the control properties are saved before closing.  
  
 The pointers held in the control class data members [CComControlBase::m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md) and [CComControlBase::m_spAdviseSink](../vs140/ccomcontrolbase--m_spadvisesink.md) are released, and the data members [CComControlBase::m_bNegotiatedWnd](../vs140/ccomcontrolbase--m_bnegotiatedwnd.md), [CComControlBase::m_bWndless](../vs140/ccomcontrolbase--m_bwndless.md), and [CComControlBase::m_bInPlaceSiteEx](../vs140/ccomcontrolbase--m_binplacesiteex.md) are set to **FALSE**.  
  
 See [IOleObject::Close](http://msdn.microsoft.com/library/windows/desktop/ms683922) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)