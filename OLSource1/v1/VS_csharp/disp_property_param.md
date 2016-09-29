---
title: "DISP_PROPERTY_PARAM"
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
  - "DISP_PROPERTY_PARAM"
  - "AFXDISP/DISP_PROPERTY_PARAM"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISP_PROPERTY_PARAM macro"
ms.assetid: 2047db26-7f98-4194-a1de-d2eccf7e5681
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DISP_PROPERTY_PARAM
Defines a property accessed with separate **Get** and `Set` member functions.  
  
## Syntax  
  
```  
  
DISP_PROPERTY_PARAM(  
theClass  
,   
pszExternalName  
,   
pfnGet  
,   
pfnSet  
,   
vtPropType  
,   
vtsParams  
 )  
  
```  
  
#### Parameters  
 `theClass`  
 Name of the class.  
  
 *pszExternalName*  
 External name of the property.  
  
 `pfnGet`  
 Name of the member function used to get the property.  
  
 `pfnSet`  
 Name of the member function used to set the property.  
  
 `vtPropType`  
 A value specifying the property's type.  
  
 `vtsParams`  
 A string of space-separated **VTS_** variant parameter types, one for each parameter.  
  
## Remarks  
 Unlike the `DISP_PROPERTY_EX` macro, this macro allows you to specify a parameter list for the property. This is useful for implementing properties that are indexed or parameterized.  
  
## Example  
 Consider the following declaration of get and set member functions that allow the user to request a specific row and column when accessing the property:  
  
 [!code[NVC_MFCActiveXControl#9](../VS_csharp/codesnippet/CPP/disp_property_param_1.h)]  
  
 These correspond to the following `DISP_PROPERTY_PARAM` macro in the control dispatch map:  
  
 [!code[NVC_MFCActiveXControl#10](../VS_csharp/codesnippet/CPP/disp_property_param_2.cpp)]  
  
 As another example, consider the following get and set member functions:  
  
 [!code[NVC_MFCActiveXControl#11](../VS_csharp/codesnippet/CPP/disp_property_param_3.h)]  
  
 These correspond to the following `DISP_PROPERTY_PARAM` macro in the control dispatch map:  
  
 [!code[NVC_MFCActiveXControl#12](../VS_csharp/codesnippet/CPP/disp_property_param_4.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [Dispatch Maps](../VS_csharp/dispatch-maps.md)   
 [DISP_PROPERTY_EX](../VS_csharp/disp_property_ex.md)