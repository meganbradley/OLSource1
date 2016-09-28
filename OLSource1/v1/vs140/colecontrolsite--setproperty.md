---
title: "COleControlSite::SetProperty"
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
  - "COleControlSite.SetProperty"
  - "COleControlSite::SetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProperty method"
  - "COleControlSite class, overridables"
ms.assetid: 8882ee42-02b0-481b-a88c-c843f357cb42
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::SetProperty
Sets the control property specified by `dwDispID`.  
  
## Syntax  
  
```  
  
      virtual void AFX_CDECL SetProperty(  
   DISPID dwDispID,  
   VARTYPE vtProp,  
   ...   
);  
```  
  
#### Parameters  
 `dwDispID`  
 Identifies the dispatch ID of the property or method, found on the control's `IDispatch` interface, to be set.  
  
 `vtProp`  
 Specifies the type of property to be set. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 *...*  
 A single parameter of the type specified by `vtProp`.  
  
## Remarks  
 If `SetProperty` encounters an error, an exception is thrown.  
  
 The type of exception is determined by the return value of the attempt to set the property or method. If the return value is `DISP_E_EXCEPTION`, a **COleDispatchExcpetion** is thrown; otherwise a `COleException`.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite::SetPropertyV](../vs140/colecontrolsite--setpropertyv.md)