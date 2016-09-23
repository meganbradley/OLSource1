---
title: "COleControlSite::InvokeHelper"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleControlSite::InvokeHelper
  - COleControlSite.InvokeHelper
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleControlSite class, overridables
  - InvokeHelper method
ms.assetid: 12919494-da80-4a23-95fa-8f9b55616918
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControlSite::InvokeHelper
Invokes the method or property specified by `dwDispID`, in the context specified by `wFlags`.  
  
## Syntax  
  
```  
  
      virtual void AFX_CDECL InvokeHelper(  
   DISPID dwDispID,  
   WORD wFlags,  
   VARTYPE vtRet,  
   void* pvRet,  
   const BYTE* pbParamInfo,  
   ...   
);  
```  
  
#### Parameters  
 `dwDispID`  
 Identifies the dispatch ID of the property or method, found on the control's `IDispatch` interface, to be invoked.  
  
 `wFlags`  
 Flags describing the context of the call to IDispatch::Invoke. For possible `wFlags` values, see `IDispatch::Invoke` in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `vtRet`  
 Specifies the type of the return value. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 `pvRet`  
 Address of the variable that will receive the property value or return value. It must match the type specified by `vtRet`.  
  
 `pbParamInfo`  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following `pbParamInfo`. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 *...*  
 Variable list of parameters, of types specified in `pbParamInfo`.  
  
## Remarks  
 The `pbParamInfo` parameter specifies the types of the parameters passed to the method or property. The variable list of arguments is represented by ... in the syntax declaration.  
  
 This function converts the parameters to **VARIANTARG** values, then invokes the **IDispatch::Invoke** method on the control. If the call to **IDispatch::Invoke** fails, this function will throw an exception. If the status code returned by **IDispatch::Invoke** is `DISP_E_EXCEPTION`, this function throws a **COleDispatchException** object, otherwise it throws a `COleException`.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)