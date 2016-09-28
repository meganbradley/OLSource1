---
title: "DISP_DEFVALUE"
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
  - "DISP_DEFVALUE"
  - "AFXDISP/DISP_DEFVALUE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISP_DEFVALUE macro"
ms.assetid: 05c64560-b5f7-44d9-8dc5-06a6b281b424
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DISP_DEFVALUE
Makes an existing property the default value of an object.  
  
## Syntax  
  
```  
  
DISP_DEFVALUE(  
theClass  
,   
pszName )  
```  
  
#### Parameters  
 `theClass`  
 Name of the class.  
  
 `pszName`  
 External name of the property that represents the "value" of the object.  
  
## Remarks  
 Using a default value can make programming your automation object simpler for Visual Basic applications.  
  
 The "default value" of your object is the property that is retrieved or set when a reference to an object does not specify a property or member function.  
  
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