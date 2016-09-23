---
title: "DISP_FUNCTION"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - DISP_FUNCTION
  - AFXDISP/DISP_FUNCTION
dev_langs: 
  - C++
helpviewer_keywords: 
  - DISP_FUNCTION macro
ms.assetid: 8a1c666b-304b-4641-ab20-4f1a6d3c2d2e
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DISP_FUNCTION
Defines an OLE automation function in a dispatch map.  
  
## Syntax  
  
```  
  
DISP_FUNCTION(  
theClass  
,   
pszName  
,   
pfnMember  
,   
vtRetVal  
,   
vtsParams )  
```  
  
#### Parameters  
 `theClass`  
 Name of the class.  
  
 `pszName`  
 External name of the function.  
  
 `pfnMember`  
 Name of the member function.  
  
 `vtRetVal`  
 A value specifying the function's return type.  
  
 `vtsParams`  
 A space-separated list of one or more constants specifying the function's parameter list.  
  
## Remarks  
 The `vtRetVal` argument is of type **VARTYPE**. The following possible values for this argument are taken from the `VARENUM` enumeration:  
  
|Symbol|Return type|  
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
  
 The `vtsParams` argument is a space-separated list of values from the **VTS_** constants. One or more of these values separated by spaces (not commas) specifies the function's parameter list. For example,  
  
 [!code[NVC_MFCAutomation#14](../vs140/codesnippet/CPP/disp_function_1.cpp)]
  
  
 specifies a list containing a short integer followed by a pointer to a short integer.  
  
 The **VTS_** constants and their meanings are as follows:  
  
|Symbol|Parameter type|  
|------------|--------------------|  
|**VTS_I2**|`Short`|  
|**VTS_I4**|`Long`|  
|**VTS_R4**|**Float**|  
|**VTS_R8**|`Double`|  
|**VTS_CY**|**const CY** or **CY\***|  
|**VTS_DATE**|**DATE**|  
|**VTS_BSTR**|`LPCSTR`|  
|**VTS_DISPATCH**|`LPDISPATCH`|  
|**VTS_SCODE**|`SCODE`|  
|**VTS_BOOL**|**BOOL**|  
|**VTS_VARIANT**|**const VARIANT\*** or **VARIANT&**|  
|**VTS_UNKNOWN**|`LPUNKNOWN`|  
|**VTS_PI2**|**short\***|  
|**VTS_PI4**|**long\***|  
|**VTS_PR4**|**float\***|  
|**VTS_PR8**|**double\***|  
|**VTS_PCY**|**CY\***|  
|**VTS_PDATE**|**DATE\***|  
|**VTS_PBSTR**|**BSTR\***|  
|**VTS_PDISPATCH**|**LPDISPATCH\***|  
|**VTS_PSCODE**|**SCODE\***|  
|**VTS_PBOOL**|**BOOL\***|  
|**VTS_PVARIANT**|**VARIANT\***|  
|**VTS_PUNKNOWN**|**LPUNKNOWN\***|  
|**VTS_NONE**|No parameters|  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [DECLARE_DISPATCH_MAP](../vs140/declare_dispatch_map.md)   
 [DISP_PROPERTY](../vs140/disp_property.md)   
 [DISP_PROPERTY_EX](../vs140/disp_property_ex.md)   
 [BEGIN_DISPATCH_MAP](../vs140/begin_dispatch_map.md)   
 [END_DISPATCH_MAP](../vs140/end_dispatch_map.md)