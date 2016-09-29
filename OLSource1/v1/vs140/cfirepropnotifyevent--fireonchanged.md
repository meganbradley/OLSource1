---
title: "CFirePropNotifyEvent::FireOnChanged"
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
  - "CFirePropNotifyEvent.FireOnChanged"
  - "ATL::CFirePropNotifyEvent::FireOnChanged"
  - "FireOnChanged"
  - "ATL.CFirePropNotifyEvent.FireOnChanged"
  - "CFirePropNotifyEvent::FireOnChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireOnChanged method"
ms.assetid: 578a8476-ad39-4417-9cfa-e4bd2116d5be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFirePropNotifyEvent::FireOnChanged
Notifies all connected [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interfaces (on every connection point of the object) that the specified object property has changed.  
  
## Syntax  
  
```  
  
      static HRESULT FireOnChanged(  
   IUnknown* pUnk,  
   DISPID dispID   
);  
```  
  
#### Parameters  
 *pUnk*  
 [in] Pointer to the **IUnknown** of the object sending the notification.  
  
 *dispID*  
 [in] Identifier of the property that has changed.  
  
## Return Value  
 One of the standard `HRESULT` values.  
  
## Remarks  
 This function is safe to call even if your control does not support connection points.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CFirePropNotifyEvent Class](../vs140/cfirepropnotifyevent-class.md)   
 [CFirePropNotifyEvent::FireOnRequestEdit](../vs140/cfirepropnotifyevent--fireonrequestedit.md)   
 [CComControl::FireOnChanged](../vs140/ccomcontrol--fireonchanged.md)