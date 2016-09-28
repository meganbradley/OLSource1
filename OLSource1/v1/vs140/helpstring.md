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
author: ""
ms.author: ""
manager: ""
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
 See the example for [defaultvalue](../vs140/defaultvalue.md) for an example of how to use **helpstring**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|`interface`, `typedef`, **class**, method, property|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Interface Attributes](../vs140/interface-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Method Attributes](../vs140/method-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [helpfile](../vs140/helpfile.md)   
 [helpcontext](../vs140/helpcontext.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)