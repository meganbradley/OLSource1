---
title: "last_is"
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
  - "vc-attr.last_is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "last_is attribute"
ms.assetid: 9e045ac0-fa38-4249-af55-67bde5d0a58c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# last_is
Specifies the index of the last array element to be transmitted.  
  
## Syntax  
  
```  
  
      [ last_is(  
   "expression"  
) ]  
```  
  
#### Parameters  
 *expression*  
 One or more C-language expressions. Empty argument slots are allowed.  
  
## Remarks  
 The **last_is** C++ attribute has the same functionality as the [last_is](http://msdn.microsoft.com/library/windows/desktop/aa367066) MIDL attribute.  
  
## Example  
 See [first_is](../vs140/first_is.md) for an example of how to specify a section of an array.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Field in `struct` or **union**, interface parameter, interface method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Parameter Attributes](../vs140/parameter-attributes.md)   
 [first_is](../vs140/first_is.md)   
 [max_is](../vs140/max_is.md)   
 [length_is](../vs140/length_is.md)   
 [size_is](../vs140/size_is.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)