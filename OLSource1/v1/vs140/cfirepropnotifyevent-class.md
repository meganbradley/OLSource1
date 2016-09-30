---
title: "CFirePropNotifyEvent Class"
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
  - "CFirePropNotifyEvent"
  - "ATL::CFirePropNotifyEvent"
  - "ATL.CFirePropNotifyEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sinks, notifying of ATL events"
  - "CFirePropNotifyEvent class"
  - "connection points [C++], notifying of events"
ms.assetid: eb7a563e-6bce-4cdf-8d20-8c6a5307781b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFirePropNotifyEvent Class
This class provides methods for notifying the container's sink regarding control property changes.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFirePropNotifyEvent::FireOnChanged](../vs140/cfirepropnotifyevent--fireonchanged.md)|(Static) Notifies the container's sink that a control property has changed.|  
|[CFirePropNotifyEvent::FireOnRequestEdit](../vs140/cfirepropnotifyevent--fireonrequestedit.md)|(Static) Notifies the container's sink that a control property is about to change.|  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has two methods that notify the container's sink that a control property has changed or is about to change.  
  
 If the class implementing your control is derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> methods are invoked when you call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If your control class is not derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, calls to these functions return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 For more information about creating controls, see the [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="cfirepropnotifyevent__fireonchanged">\</a>  CFirePropNotifyEvent::FireOnChanged  
 Notifies all connected [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interfaces (on every connection point of the object) that the specified object property has changed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pUnk*  
 [in] Pointer to the **IUnknown** of the object sending the notification.  
  
 *dispID*  
 [in] Identifier of the property that has changed.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> values.  
  
### Remarks  
 This function is safe to call even if your control does not support connection points.  
  
##  \<a name="cfirepropnotifyevent__fireonrequestedit">\</a>  CFirePropNotifyEvent::FireOnRequestEdit  
 Notifies all connected [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) interfaces (on every connection point of the object) that the specified object property is about to change.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *pUnk*  
 [in] Pointer to the **IUnknown** of the object sending the notification.  
  
 *dispID*  
 [in] Identifier of the property about to change.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> values.  
  
### Remarks  
 This function is safe to call even if your control does not support connection points.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)