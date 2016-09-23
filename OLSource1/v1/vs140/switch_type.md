---
title: "switch_type"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - vc-attr.switch_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - switch_type attribute
ms.assetid: e24544dc-b3bc-48ae-b249-f967db49271e
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# switch_type
Identifies the type of the variable used as the union discriminant.  
  
## Syntax  
  
```  
  
[switch_type(  
type  
}]  
  
```  
  
#### Parameters  
 `type`  
 The switch type, can be an integer, character, Boolean, or enumeration type.  
  
## Remarks  
 The **switch_type** C++ attribute has the same functionality as the [switch_type](http://msdn.microsoft.com/library/windows/desktop/aa367276) MIDL attribute.  
  
 C++ attributes do not support [encapsulated unions](http://msdn.microsoft.com/library/windows/desktop/aa366811). [Nonencapsulated unions](http://msdn.microsoft.com/library/windows/desktop/aa367119) are supported only in the following form:  
  
```  
// cpp_attr_ref_switch_type.cpp  
// compile with: /LD  
#include <windows.h>  
[module(name="MyLibrary")];  
[ export ]  
struct SizedValue2 {  
   [switch_type("char"), switch_is(kind)] union {  
      [case(1), string]  
         wchar_t* wval;  
      [default, string]  
         char* val;  
   };  
   char kind;  
};  
```  
  
## Example  
 See the [case](../vs140/case--c---.md) example for a sample use of **switch_type**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|`typedef`|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [export](../vs140/export.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)