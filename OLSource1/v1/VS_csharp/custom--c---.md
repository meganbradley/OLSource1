---
title: "custom (C++)"
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
  - "vc-attr.custom"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "custom attributes, defining"
ms.assetid: 3abac928-4d55-4ea6-8cf6-8427a4ad79f1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# custom (C++)
Defines metadata for an object in the type library.  
  
## Syntax  
  
```  
  
      [ custom(  
   uuid,   
   value  
) ];  
```  
  
#### Parameters  
 *uuid*  
 A unique ID.  
  
 *value*  
 A value that can be put into a variant.  
  
## Remarks  
 The **custom** C++ attribute will cause information to be placed into the type library. You will need a tool that reads the custom value from type library.  
  
 The **custom** attribute has the same functionality as the [custom](http://msdn.microsoft.com/library/windows/desktop/aa366766) MIDL attribute.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Non-COM `interface`, **class**, `enum`s, `idl_module` methods, interface members, interface parameters, `typedef`s, **union**s, `struct`s|  
|**Repeatable**|Yes|  
|**Required attributes**|**coclass** (when used on class)|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../VS_csharp/idl-attributes.md)   
 [Stand-Alone Attributes](../VS_csharp/stand-alone-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../VS_csharp/typedef--enum--union--and-struct-attributes.md)   
 [Parameter Attributes](../VS_csharp/parameter-attributes.md)   
 [Method Attributes](../VS_csharp/method-attributes.md)   
 [Class Attributes](../VS_csharp/class-attributes.md)   
 [Interface Attributes](../VS_csharp/interface-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)