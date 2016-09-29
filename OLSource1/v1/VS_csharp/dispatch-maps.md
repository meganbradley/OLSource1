---
title: "Dispatch Maps"
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
  - "vc.mfc.macros.maps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dispatch maps. macros"
  - "dispatch maps"
  - "dispatch map macros"
ms.assetid: bef9d08b-ad35-4c3a-99d8-04150c7c04e2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dispatch Maps
OLE Automation provides ways to call methods and to access properties across applications. The mechanism supplied by the Microsoft Foundation Class Library for dispatching these requests is the "dispatch map," which designates the internal and external names of object functions and properties, as well as the data types of the properties themselves and of function arguments.  
  
### Dispatch Maps  
  
|||  
|-|-|  
|[DECLARE_DISPATCH_MAP](../VS_csharp/declare_dispatch_map.md)|Declares that a dispatch map will be used to expose a class's methods and properties (must be used in the class declaration).|  
|[BEGIN_DISPATCH_MAP](../VS_csharp/begin_dispatch_map.md)|Starts the definition of a dispatch map.|  
|[END_DISPATCH_MAP](../VS_csharp/end_dispatch_map.md)|Ends the definition of a dispatch map.|  
|[DISP_FUNCTION](../VS_csharp/disp_function.md)|Used in a dispatch map to define an OLE automation function.|  
|[DISP_PROPERTY](../VS_csharp/disp_property.md)|Defines an OLE automation property.|  
|[DISP_PROPERTY_EX](../VS_csharp/disp_property_ex.md)|Defines an OLE automation property and names the Get and Set functions.|  
|[DISP_PROPERTY_NOTIFY](../VS_csharp/disp_property_notify.md)|Defines an OLE automation property with notification.|  
|[DISP_PROPERTY_PARAM](../VS_csharp/disp_property_param.md)|Defines an OLE automation property that takes parameters and names the Get and Set functions.|  
|[DISP_DEFVALUE](../VS_csharp/disp_defvalue.md)|Makes an existing property the default value of an object.|  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)