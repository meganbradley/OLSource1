---
title: "helpstring"
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
  - "vc-attr.helpstring"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "helpstring attribute [C++]"
ms.assetid: 0401e905-a63e-4fad-98d0-d1efea111966
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# helpstring
Specifies a character string that is used to describe the element to which it applies.  
  
## Syntax  
  
```  
  
      [ helpstring(  
   "string"  
) ]  
```  
  
#### Parameters  
 `string`  
 The text of the help string.  
  
## Remarks  
 The **helpstring** C++ attribute has the same functionality as the [helpstring](http://msdn.microsoft.com/library/windows/desktop/aa366856) MIDL attribute.  
  
## Example  
 See the example for [defaultvalue](../VS_csharp/defaultvalue.md) for an example of how to use **helpstring**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|`interface`, `typedef`, **class**, method, property|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../VS_csharp/idl-attributes.md)   
 [Interface Attributes](../VS_csharp/interface-attributes.md)   
 [Class Attributes](../VS_csharp/class-attributes.md)   
 [Method Attributes](../VS_csharp/method-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../VS_csharp/typedef--enum--union--and-struct-attributes.md)   
 [helpfile](../VS_csharp/helpfile.md)   
 [helpcontext](../VS_csharp/helpcontext.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)