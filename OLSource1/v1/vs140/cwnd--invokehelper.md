---
title: "CWnd::InvokeHelper"
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
  - "CWnd.InvokeHelper"
  - "CWnd::InvokeHelper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InvokeHelper method"
ms.assetid: 1a4dcbfc-9e22-4c58-afc4-b46e425d4278
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::InvokeHelper
Call this member function to invoke the ActiveX Control method or property specified by `dwDispID`, in the context specified by `wFlags`.  
  
## Syntax  
  
```  
  
      void AFX_CDECL InvokeHelper(  
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
 Identifies the method or property to be invoked.  
  
 `wFlags`  
 Flags describing the context of the call to **IDispatch::Invoke**.  
  
 `vtRet`  
 Specifies the type of the return value. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 `pvRet`  
 Address of the variable that will that will receive the property value or return value. It must match the type specified by `vtRet`.  
  
 `pbParamInfo`  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following `pbParamInfo`. For possible values, see the Remarks section for `COleDispatchDriver::InvokeHelper`.  
  
 *...*  
 Variable List of parameters, of types specified in `pbParamInfo`.  
  
## Remarks  
 The `pbParamInfo` parameter specifies the types of the parameters passed to the method or property. The variable list of arguments is represented by *...* in the syntax declaration.  
  
 This function converts the parameters to **VARIANTARG** values, then invokes the **IDispatch::Invoke** method on the ActiveX control. If the call to **IDispatch::Invoke** fails, this function will throw an exception. If the `SCODE` (status code) returned by **IDispatch::Invoke** is `DISP_E_EXCEPTION`, this function throws a [COleException](../vs140/coleexception-class.md) object, otherwise it throws a [COleDispatchException](../vs140/coledispatchexception-class.md).  
  
> [!NOTE]
>  This function should be called only on a `CWnd` object that represents an ActiveX control.  
  
 For more information about using this member function with ActiveX Control Containers, see the article [ActiveX Control Containers: Programming ActiveX Controls in an ActiveX Control Container](../vs140/activex-control-containers--programming-activex-controls-in-an-activex-control-container.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetProperty](../vs140/cwnd--getproperty.md)   
 [CWnd::SetProperty](../vs140/cwnd--setproperty.md)   
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [CWnd::CreateControl](../vs140/cwnd--createcontrol.md)