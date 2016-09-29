---
title: "COleControlSite::InvokeHelperV"
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
  - "InvokeHelperV"
  - "COleControlSite::InvokeHelperV"
  - "COleControlSite.InvokeHelperV"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, overridables"
  - "InvokeHelperV method"
ms.assetid: 55a164c6-7ef6-41ee-bd46-71f726167431
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::InvokeHelperV
Invokes the method or property specified by `dwDispID`, in the context specified by `wFlags`.  
  
## Syntax  
  
```  
  
      virtual void InvokeHelperV(  
   DISPID dwDispID,  
   WORD wFlags,  
   VARTYPE vtRet,  
   void* pvRet,  
   const BYTE* pbParamInfo,  
   va_list argList   
);  
```  
  
#### Parameters  
 `dwDispID`  
 Identifies the dispatch ID of the property or method, found on the control's `IDispatch` interface, to be invoked.  
  
 `wFlags`  
 Flags describing the context of the call to IDispatch::Invoke.  
  
 `vtRet`  
 Specifies the type of the return value. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 `pvRet`  
 Address of the variable that will receive the property value or return value. It must match the type specified by `vtRet`.  
  
 `pbParamInfo`  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following `pbParamInfo`. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 `argList`  
 Pointer to a variable argument list.  
  
## Remarks  
 The `pbParamInfo` parameter specifies the types of the parameters passed to the method or property. Extra parameters for the method or property being invoked can be passed using the *va_list* parameter.  
  
 Typically, this function is called by `COleControlSite::InvokeHelper`.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)