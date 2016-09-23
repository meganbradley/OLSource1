---
title: "DISP_PROPERTY_EX"
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
  - AFXDISP/DISP_PROPERTY_EX
  - DISP_PROPERTY_EX
dev_langs: 
  - C++
helpviewer_keywords: 
  - DISP_PROPERTY_EX macro
ms.assetid: 7c4749f7-8562-42c4-a8ad-286299bfa4b7
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DISP_PROPERTY_EX
Defines an OLE automation property and name the functions used to get and set the property's value in a dispatch map.  
  
## Syntax  
  
```  
  
DISP_PROPERTY_EX(  
theClass  
,   
pszName  
,   
memberGet  
,   
memberSet  
,   
vtPropType )  
```  
  
#### Parameters  
 `theClass`  
 Name of the class.  
  
 `pszName`  
 External name of the property.  
  
 `memberGet`  
 Name of the member function used to get the property.  
  
 `memberSet`  
 Name of the member function used to set the property.  
  
 `vtPropType`  
 A value specifying the property's type.  
  
## Remarks  
 The `memberGet` and `memberSet` functions have signatures determined by the `vtPropType` argument. The `memberGet` function takes no arguments and returns a value of the type specified by `vtPropType`. The `memberSet` function takes an argument of the type specified by `vtPropType` and returns nothing.  
  
 The `vtPropType` argument is of type **VARTYPE**. Possible values for this argument are taken from the `VARENUM` enumeration. For a list of these values, see the Remarks for the `vtRetVal` parameter in [DISP_FUNCTION](../vs140/disp_function.md). Note that `VT_EMPTY`, listed in the `DISP_FUNCTION` remarks, is not permitted as a property data type.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [DECLARE_DISPATCH_MAP](../vs140/declare_dispatch_map.md)   
 [DISP_PROPERTY](../vs140/disp_property.md)   
 [DISP_FUNCTION](../vs140/disp_function.md)   
 [BEGIN_DISPATCH_MAP](../vs140/begin_dispatch_map.md)   
 [END_DISPATCH_MAP](../vs140/end_dispatch_map.md)