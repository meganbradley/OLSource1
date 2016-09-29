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
|**OLEIVERB_DISCARDUNDOSTATE**|[DoVerbDiscardUndo](../VS_csharp/ioleobjectimpl--doverbdiscardundo.md)|  
|`OLEIVERB_HIDE`|[DoVerbHide](../VS_csharp/ioleobjectimpl--doverbhide.md)|  
|**OLEIVERB_INPLACEACTIVATE**|[DoVerbInPlaceActivate](../VS_csharp/ioleobjectimpl--doverbinplaceactivate.md)|  
|`OLEIVERB_OPEN`|[DoVerbOpen](../VS_csharp/ioleobjectimpl--doverbopen.md)|  
|`OLEIVERB_PRIMARY`|[DoVerbPrimary](../VS_csharp/ioleobjectimpl--doverbprimary.md)|  
|**OLEIVERB_PROPERTIES**|[CComControlBase::DoVerbProperties](../Topic/CComControlBase::DoVerbProperties.md)|  
|`OLEIVERB_SHOW`|[DoVerbShow](../VS_csharp/ioleobjectimpl--doverbshow.md)|  
|`OLEIVERB_UIACTIVATE`|[DoVerbUIActivate](../VS_csharp/ioleobjectimpl--doverbuiactivate.md)|  
  
 See [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [IOleObject::EnumVerbs](http://msdn.microsoft.com/library/windows/desktop/ms692781)