---
title: "pointer_default"
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
  - "vc-attr.pointer_default"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pointer_default attribute"
ms.assetid: 2d0c7bbc-a1e8-4337-9e54-e304523e2735
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pointer_default
Specifies the default pointer attribute for all pointers, except top-level pointers that appear in parameter lists.  
  
## Syntax  
  
```  
  
      [ pointer_default(  
   value  
) ]  
```  
  
#### Parameters  
 *value*  
 A value that describes the pointer type: **ptr**, `ref`, or **unique**.  
  
## Remarks  
 The **pointer_default** C++ attribute has the same functionality as the [pointer_default](http://msdn.microsoft.com/library/windows/desktop/aa367141) MIDL attribute.  
  
## Example  
 See the example for [defaultvalue](../VS_csharp/defaultvalue.md) for a sample use of **pointer_default**.  
  
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
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)