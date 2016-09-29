---
title: "ON_PROPNOTIFY_REFLECT"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ON_PROPNOTIFY_REFLECT"
  - "AFXDISP/ON_PROPNOTIFY_REFLECT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_PROPNOTIFY_REFLECT macro"
ms.assetid: 177ac889-52ed-49ab-adfd-d02b9c4347dc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_PROPNOTIFY_REFLECT
The `ON_PROPNOTIFY_REFLECT` macro, when used in the event sink map of an OLE control's wrapper class, receives property notifications sent by the control before they are handled by the control's container.  
  
## Syntax  
  
```  
  
ON_PROPNOTIFY_REFLECT(  
theClass  
,   
dispid  
,   
pfnRequest  
,   
pfnChanged  
 )  
  
```  
  
#### Parameters  
 `theClass`  
 The class to which this event sink map belongs.  
  
 `dispid`  
 The dispatch ID of the property involved in the notification.  
  
 `pfnRequest`  
 Pointer to a member function that handles the **OnRequestEdit** notification for this property. This function should have a **BOOL** return type and a **BOOL\*** parameter. This function should set the parameter to **TRUE** to allow the property to change and **FALSE** to disallow. The function should return **TRUE** to indicate the notification was handled; otherwise **FALSE**.  
  
 `pfnChanged`  
 Pointer to a member function that handles the **OnChanged** notification for this property. The function should have a **BOOL** return type and no parameters. The function should return **TRUE** to indicate the notification was handled; otherwise **FALSE**.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_EVENT_REFLECT](../vs140/on_event_reflect.md)   
 [ON_PROPNOTIFY](../vs140/on_propnotify.md)