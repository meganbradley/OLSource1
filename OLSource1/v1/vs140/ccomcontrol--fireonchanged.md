---
title: "CComControl::FireOnChanged"
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
  - "ATL::CComControl::FireOnChanged"
  - "FireOnChanged"
  - "CComControl.FireOnChanged"
  - "CComControl::FireOnChanged"
  - "ATL.CComControl.FireOnChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireOnChanged method"
ms.assetid: 94db6bed-246c-4205-a362-82cda3ba1e1a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControl::FireOnChanged
Notifies the container's sink that a control property has changed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dispID*  
 [in] Identifier of the property that has changed.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 If your control class derives from [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638), this method calls [CFirePropNotifyEvent::FireOnChanged](../vs140/cfirepropnotifyevent--fireonchanged.md) to notify all connected <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interfaces that the specified control property has changed. If your control class does not derive from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 This method is safe to call even if your control doesn't support connection points.  
  
## Example  
 [!code[NVC_ATL_COM#17](../vs140/codesnippet/CPP/ccomcontrol--fireonchanged_1.cpp)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [CComControl::FireOnRequestEdit](../vs140/ccomcontrol--fireonrequestedit.md)