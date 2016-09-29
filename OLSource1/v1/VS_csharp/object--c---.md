---
title: "object (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "vc-attr.object"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "object attribute"
ms.assetid: f2d3c231-630d-4b4c-bd15-b1c30df362dd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# object (C++)
Identifies a custom interface.  
  
## Syntax  
  
```  
  
[object]  
  
```  
  
## Remarks  
 When preceding an interface definition, the **object** C++ attribute causes the interface to be placed in the .idl file as a custom interface.  
  
 Any interface marked with object must inherit from **IUnknown**. This condition is satisfied if any of the base interfaces inherit from **IUnknown**. If no base interfaces inherit from **IUnknown**, the compiler will cause the interface marked with **object** to derive from **IUnknown**.  
  
## Example  
 See [nonbrowsable](../VS_csharp/nonbrowsable.md) for an example of how to use **object**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|`interface`|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../VS_csharp/idl-attributes.md)   
 [Interface Attributes](../VS_csharp/interface-attributes.md)   
 [dual](../VS_csharp/dual.md)   
 [dispinterface](../VS_csharp/dispinterface.md)   
 [custom](../VS_csharp/custom--c---.md)   
 [__interface](../VS_csharp/__interface.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)