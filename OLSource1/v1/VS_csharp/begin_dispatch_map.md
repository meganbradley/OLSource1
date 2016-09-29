---
title: "BEGIN_DISPATCH_MAP"
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
  - "BEGIN_DISPATCH_MAP"
  - "AFXDISP/BEGIN_DISPATCH_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_DISPATCH_MAP macro"
ms.assetid: 49e2651e-d97c-4e17-8d41-7011d8920a15
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_DISPATCH_MAP
Declares the definition of your dispatch map.  
  
## Syntax  
  
```  
  
BEGIN_DISPATCH_MAP(  
theClass  
,   
baseClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the class that owns this dispatch map.  
  
 `baseClass`  
 Specifies the base class name of `theClass`.  
  
## Remarks  
 In the implementation (.cpp) file that defines the member functions for your class, start the dispatch map with the `BEGIN_DISPATCH_MAP` macro, add macro entries for each of your dispatch functions and properties, and complete the dispatch map with the `END_DISPATCH_MAP` macro.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [Dispatch Maps](../VS_csharp/dispatch-maps.md)   
 [DECLARE_DISPATCH_MAP](../VS_csharp/declare_dispatch_map.md)   
 [END_DISPATCH_MAP](../VS_csharp/end_dispatch_map.md)   
 [DISP_FUNCTION](../VS_csharp/disp_function.md)   
 [DISP_PROPERTY](../VS_csharp/disp_property.md)   
 [DISP_PROPERTY_EX](../VS_csharp/disp_property_ex.md)   
 [DISP_DEFVALUE](../VS_csharp/disp_defvalue.md)