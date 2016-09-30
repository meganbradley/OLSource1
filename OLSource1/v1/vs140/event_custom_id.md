---
title: "EVENT_CUSTOM_ID"
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
  - "EVENT_CUSTOM_ID"
  - "AFXCTL/EVENT_CUSTOM_ID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EVENT_CUSTOM_ID macro"
ms.assetid: f4bd97d8-b6b8-4aa7-9a9b-7888b071e224
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EVENT_CUSTOM_ID
Defines an event firing function for a custom event belonging to the dispatch ID specified by `dispid`.  
  
## Syntax  
  
```  
  
EVENT_CUSTOM_ID(  
pszName  
,   
dispid  
,   
pfnFire  
,   
vtsParams )  
```  
  
#### Parameters  
 `pszName`  
 The name of the event.  
  
 `dispid`  
 The dispatch ID used by the control when firing the event.  
  
 `pfnFire`  
 The name of the event firing function.  
  
 `vtsParams`  
 A variable list of parameters passed to the control container when the event is fired.  
  
## Remarks  
 The `vtsParams` argument is a space-separated list of values from the **VTS_** constants. One or more of these values separated by spaces, not commas, specifies the function's parameter list. For example:  
  
 [!code[NVC_MFCActiveXControl#13](../vs140/codesnippet/CPP/event_custom_id_1.cpp)]  
  
 specifies a list containing a 32-bit integer representing an RGB color value, followed by a pointer to the **IFontDisp** interface of an OLE font object.  
  
 For a list of the **VTS_** constants, see [EVENT_CUSTOM](../vs140/event_custom.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [EVENT_CUSTOM](../vs140/event_custom.md)   
 [Variant Parameter Type Constants](../vs140/variant-parameter-type-constants.md)