---
title: "COM Attributes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "attributes [C++], reference topics"
  - "attributes [COM]"
  - "COM, attributes"
ms.assetid: 52a5dd70-e8be-4bba-afd6-daf90fe689a0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM Attributes
The COM attributes inject code to support numerous areas of COM development and .NET Framework common language runtime development. These areas range from custom interface implementation and support of existing interfaces to supporting stock properties, methods, and events. In addition, support can be found for composite and ActiveX control implementation.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[aggregatable](../VS_csharp/aggregatable.md)|Indicates that a control can be aggregated by another control.|  
|[aggregates](../VS_csharp/aggregates.md)|Indicates that a control aggregates the target class.|  
|[coclass](../VS_csharp/coclass.md)|Creates a COM object, which can implement a COM interface.|  
|[com_interface_entry](../VS_csharp/com_interface_entry--c---.md)|Adds an interface entry to a COM map.|  
|[implements_category](../VS_csharp/implements_category.md)|Specifies implemented component categories for the class.|  
|[progid](../VS_csharp/progid.md)|Defines the ProgID for a control.|  
|[rdx](../VS_csharp/rdx.md)|Creates or modifies a registry key.|  
|[registration_script](../VS_csharp/registration_script.md)|Executes the specified registration script.|  
|[requires_category](../VS_csharp/requires_category.md)|Specifies required component categories for the class.|  
|[support_error_info](../VS_csharp/support_error_info.md)|Supports error reporting for the target object.|  
|[synchronize](../VS_csharp/synchronize.md)|Synchronizes access to a method.|  
|[threading](../VS_csharp/threading--c---.md)|Specifies the threading model for a COM object.|  
|[vi_progid](../VS_csharp/vi_progid.md)|Defines a version-independent ProgID for a control.|  
  
## See Also  
 [Attributes by Group](../VS_csharp/attributes-by-group.md)