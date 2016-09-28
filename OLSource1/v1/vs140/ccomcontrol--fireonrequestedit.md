---
title: "CComControl::FireOnRequestEdit"
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
  - "CComControl::FireOnRequestEdit"
  - "CComControl.FireOnRequestEdit"
  - "FireOnRequestEdit"
  - "ATL::CComControl::FireOnRequestEdit"
  - "ATL.CComControl.FireOnRequestEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireOnRequestEdit method"
ms.assetid: 13c8d2c7-8c28-4301-bf4e-7a97dc25216b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControl::FireOnRequestEdit
Notifies the container's sink that a control property is about to change and that the object is asking the sink how to proceed.  
  
## Syntax  
  
```  
  
      HRESULT FireOnRequestEdit(  
   DISPID dispID   
);  
```  
  
#### Parameters  
 *dispID*  
 [in] Identifier of the property about to change.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 If your control class derives from [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638), this method calls [CFirePropNotifyEvent::FireOnRequestEdit](../vs140/cfirepropnotifyevent--fireonrequestedit.md) to notify all connected `IPropertyNotifySink` interfaces that the specified control property is about to change. If your control class does not derive from `IPropertyNotifySink`, this method returns `S_OK`.  
  
 This method is safe to call even if your control doesn't support connection points.  
  
## Example  
 [!code[NVC_ATL_COM#18](../vs140/codesnippet/CPP/ccomcontrol--fireonrequestedit_1.cpp)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [CComControl::FireOnChanged](../vs140/ccomcontrol--fireonchanged.md)