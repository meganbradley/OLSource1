---
title: "COleDispatchDriver::InvokeHelper"
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
  - VARENUM
  - COleDispatchDriver.InvokeHelper
  - COleDispatchDriver::InvokeHelper
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleDispatchDriver class, operations
  - InvokeHelper method
  - VARENUM
ms.assetid: fba94ba7-52a4-4c7f-980e-f606d5834403
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDispatchDriver::InvokeHelper
Calls the object method or property specified by `dwDispID`, in the context specified by `wFlags`.  
  
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
 Flags describing the context of the call to **IDispatch::Invoke**. . For a list of possible values, see the `wFlags` parameter in  [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `vtRet`  
 Specifies the type of the return value. For possible values, see the Remarks section.  
  
 `pvRet`  
 Address of the variable that will receive the property value or return value. It must match the type specified by `vtRet`.  
  
 `pbParamInfo`  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following `pbParamInfo`.  
  
 *...*  
 Variable list of parameters, of types specified in `pbParamInfo`.  
  
## Remarks  
 The `pbParamInfo` parameter specifies the types of the parameters passed to the method or property. The variable list of arguments is represented by **...** in the syntax declaration.  
  
 Possible values for the `vtRet` argument are taken from the `VARENUM` enumeration. Possible values are as follows:  
  
|Symbol|Return Type|  
|------------|-----------------|  
|`VT_EMPTY`|`void`|  
|`VT_I2`|**short**|  
|`VT_I4`|**long**|  
|`VT_R4`|**float**|  
|`VT_R8`|**double**|  
|`VT_CY`|**CY**|  
|`VT_DATE`|**DATE**|  
|`VT_BSTR`|`BSTR`|  
|**VT_DISPATCH**|`LPDISPATCH`|  
|`VT_ERROR`|`SCODE`|  
|`VT_BOOL`|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|`LPUNKNOWN`|  
  
 The `pbParamInfo` argument is a space-separated list of **VTS_** constants. One or more of these values, separated by spaces (not commas), specifies the function's parameter list. Possible values are listed with the [EVENT_CUSTOM](../vs140/event_custom.md) macro.  
  
 This function converts the parameters to **VARIANTARG** values, then invokes the [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) method. If the call to `Invoke` fails, this function will throw an exception. If the `SCODE` (status code) returned by **IDispatch::Invoke** is `DISP_E_EXCEPTION`, this function throws a [COleException](../vs140/coleexception-class.md) object; otherwise it throws a [COleDispatchException](../vs140/coledispatchexception-class.md).  
  
 For more information, see [VARIANTARG](assetId:///e305240e-9e11-4006-98cc-26f4932d2118), [Implementing the IDispatch Interface](http://msdn.microsoft.com/library/windows/desktop/ms221037\(v=vs.85\).aspx), [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx), and [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleException Class](../vs140/coleexception-class.md)   
 [COleDispatchException Class](../vs140/coledispatchexception-class.md)