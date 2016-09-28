---
title: "IOleObjectImpl::DoVerb"
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
  - "ATL::IOleObjectImpl::DoVerb"
  - "ATL.IOleObjectImpl.DoVerb"
  - "IOleObjectImpl<T>::DoVerb"
  - "ATL.IOleObjectImpl<T>.DoVerb"
  - "DoVerb"
  - "ATL::IOleObjectImpl<T>::DoVerb"
  - "IOleObjectImpl::DoVerb"
  - "IOleObjectImpl.DoVerb"
  - "IOleObjectImpl<T>.DoVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoVerb method"
ms.assetid: 9176fbda-13c1-485d-8d10-fc3475b56e2a
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::DoVerb
Tells the control to perform one of its enumerated actions.  
  
## Syntax  
  
```  
  
      STDMETHOD(DoVerb)(  
   LONG iVerb,  
   LPMSG /* pMsg */,  
   IOleClientSite* pActiveSite,  
   LONG /* lindex */,  
   HWND hwndParent,  
   LPCRECT lprcPosRect   
);  
```  
  
## Remarks  
 Depending on the value of `iVerb`, one of the ATL `DoVerb` helper functions is called as follows:  
  
|*iVerb* Value|DoVerb helper function called|  
|-------------------|-----------------------------------|  
|**OLEIVERB_DISCARDUNDOSTATE**|[DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md)|  
|`OLEIVERB_HIDE`|[DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md)|  
|**OLEIVERB_INPLACEACTIVATE**|[DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md)|  
|`OLEIVERB_OPEN`|[DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md)|  
|`OLEIVERB_PRIMARY`|[DoVerbPrimary](../vs140/ioleobjectimpl--doverbprimary.md)|  
|**OLEIVERB_PROPERTIES**|[CComControlBase::DoVerbProperties](../vs140/ccomcontrolbase--doverbproperties.md)|  
|`OLEIVERB_SHOW`|[DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md)|  
|`OLEIVERB_UIACTIVATE`|[DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md)|  
  
 See [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObject::EnumVerbs](http://msdn.microsoft.com/library/windows/desktop/ms692781)