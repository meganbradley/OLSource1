---
title: "DISP_PROPERTY"
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
  - "AFXDISP/DISP_PROPERTY"
  - "DISP_PROPERTY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISP_PROPERTY macro"
ms.assetid: c002a77d-3a55-42c0-91a2-003f5557c0c7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DISP_PROPERTY
Defines an OLE automation property in a dispatch map.  
  
## Syntax  
  
```  
  
DISP_PROPERTY(  
theClass  
,   
pszName  
,   
memberName  
,   
vtPropType )  
```  
  
#### Parameters  
 `theClass`  
 Name of the class.  
  
 `pszName`  
 External name of the property.  
  
 `memberName`  
 Name of the member variable in which the property is stored.  
  
 `vtPropType`  
 A value specifying the property's type.  
  
## Remarks  
 The `vtPropType` argument is of type **VARTYPE**. Possible values for this argument are taken from the `VARENUM` enumeration:  
  
|Symbol|**Property type**|  
|------------|-----------------------|  
|`VT_I2`|**short**|  
|`VT_I4`|**long**|  
|`VT_R4`|**float**|  
|`VT_R8`|**double**|  
|`VT_CY`|**CY**|  
|`VT_DATE`|**DATE**|  
|`VT_BSTR`|`CString`|  
|**VT_DISPATCH**|`LPDISPATCH`|  
|`VT_ERROR`|`SCODE`|  
|`VT_BOOL`|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|`LPUNKNOWN`|  
  
 When an external client changes the property, the value of the member variable specified by `memberName` changes; there is no notification of the change.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [DECLARE_DISPATCH_MAP](../vs140/declare_dispatch_map.md)   
 [DISP_PROPERTY_EX](../vs140/disp_property_ex.md)   
 [DISP_FUNCTION](../vs140/disp_function.md)   
 [BEGIN_DISPATCH_MAP](../vs140/begin_dispatch_map.md)   
 [END_DISPATCH_MAP](../vs140/end_dispatch_map.md)