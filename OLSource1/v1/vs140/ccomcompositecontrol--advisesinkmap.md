---
title: "CComCompositeControl::AdviseSinkMap"
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
  - "ATL::CComCompositeControl<T>::AdviseSinkMap"
  - "CComCompositeControl<T>::AdviseSinkMap"
  - "ATL.CComCompositeControl.AdviseSinkMap"
  - "CComCompositeControl.AdviseSinkMap"
  - "CComCompositeControl::AdviseSinkMap"
  - "ATL::CComCompositeControl::AdviseSinkMap"
  - "AdviseSinkMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AdviseSinkMap method"
ms.assetid: d23dcac6-76ad-480f-9c5f-900bd9a13682
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCompositeControl::AdviseSinkMap
Call this method to advise or unadvise all controls hosted by the composite control.  
  
## Syntax  
  
```  
  
      HRESULT AdviseSinkMap(  
   bool bAdvise   
);  
```  
  
#### Parameters  
 `bAdvise`  
 True if all controls are to be advised; otherwise false.  
  
## Return Value  
 `S_OK`  
 All controls in the event sink map were connected or disconnected from their event source successfully.  
  
 **E_FAIL**  
 Not all controls in the event sink map could be connected or disconnected from their event source successfully.  
  
 `E_POINTER`  
 This error usually indicates a problem with an entry in the control's event sink map or a problem with a template argument used in an `IDispEventImpl` or `IDispEventSimpleImpl` base class.  
  
 **CONNECT_E_ADVISELIMIT**  
 The connection point has already reached its limit of connections and cannot accept any more.  
  
 **CONNECT_E_CANNOTCONNECT**  
 The sink does not support the interface required by this connection point.  
  
 **CONNECT_E_NOCONNECTION**  
 The cookie value does not represent a valid connection. This error usually indicates a problem with an entry in the control's event sink map or a problem with a template argument used in an `IDispEventImpl` or `IDispEventSimpleImpl` base class.  
  
## Remarks  
 The base implementation of this method searches through the entries in the event sink map. It then advises or unadvises the connection points to the COM objects described by the event sink map's sink entries. This member method also relies on the fact that the derived class inherits from one instance of `IDispEventImpl` for every control in the sink map that is to be advised or unadvised.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCompositeControl Class](../vs140/ccomcompositecontrol-class.md)   
 [IDispEventImpl Class](../vs140/idispeventimpl-class.md)   
 [BEGIN_SINK_MAP](../vs140/begin_sink_map.md)   
 [CComCompositeControl::CreateControlWindow](../vs140/ccomcompositecontrol--createcontrolwindow.md)