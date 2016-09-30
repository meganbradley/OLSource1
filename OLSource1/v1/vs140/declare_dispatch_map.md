---
title: "DECLARE_DISPATCH_MAP"
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
  - "AFXWIN/DECLARE_DISPATCH_MAP"
  - "DECLARE_DISPATCH_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_DISPATCH_MAP macro"
ms.assetid: 97d35151-77c9-4db9-b190-9e08b71b2a71
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_DISPATCH_MAP
If a `CCmdTarget`-derived class in your program supports OLE Automation, that class must provide a dispatch map to expose its methods and properties.  
  
## Syntax  
  
```  
  
DECLARE_DISPATCH_MAP( )  
```  
  
## Remarks  
 Use the `DECLARE_DISPATCH_MAP` macro at the end of your class declaration. Then, in the .CPP file that defines the member functions for the class, use the `BEGIN_DISPATCH_MAP` macro. Then include macro entries for each of your class's exposed methods and properties (`DISP_FUNCTION`, `DISP_PROPERTY`, and so on). Finally, use the `END_DISPATCH_MAP` macro.  
  
> [!NOTE]
>  If you declare any members after `DECLARE_DISPATCH_MAP`, you must specify a new access type (**public**, `private`, or `protected`) for them.  
  
 The Application Wizard and code wizards assist in creating Automation classes and in maintaining dispatch maps. For more information on dispatch maps, see [Automation Servers](../vs140/automation-servers.md).  
  
## Example  
 [!code[NVC_MFCAutomation#10](../vs140/codesnippet/CPP/declare_dispatch_map_1.h)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [BEGIN_DISPATCH_MAP](../vs140/begin_dispatch_map.md)   
 [END_DISPATCH_MAP](../vs140/end_dispatch_map.md)   
 [DISP_FUNCTION](../vs140/disp_function.md)   
 [DISP_PROPERTY](../vs140/disp_property.md)   
 [DISP_PROPERTY_EX](../vs140/disp_property_ex.md)   
 [DISP_DEFVALUE](../vs140/disp_defvalue.md)