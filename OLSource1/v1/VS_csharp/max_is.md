---
title: "max_is"
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
  - "vc-attr.max_is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_is attribute"
ms.assetid: 7c851f5c-6649-4d77-a792-247c37d8f560
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_is
Designates the maximum value for a valid array index.  
  
## Syntax  
  
```  
  
      [ max_is(  
   "expression"  
) ]  
```  
  
#### Parameters  
 *expression*  
 One or more C-language expressions. Empty argument slots are allowed.  
  
## Remarks  
 The **max_is** C++ attribute has the same functionality as the [max_is](http://msdn.microsoft.com/library/windows/desktop/aa367074) MIDL attribute.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Field in `struct` or **union**, interface parameter, interface method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|**size_is**|  
  
 For more information, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## Example  
 See [first_is](../VS_csharp/first_is.md) for an example of how to specify a section of an array.  
  
## See Also  
 [IDL Attributes](../VS_csharp/idl-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../VS_csharp/typedef--enum--union--and-struct-attributes.md)   
 [Parameter Attributes](../VS_csharp/parameter-attributes.md)   
 [first_is](../VS_csharp/first_is.md)   
 [last_is](../VS_csharp/last_is.md)   
 [length_is](../VS_csharp/length_is.md)   
 [size_is](../VS_csharp/size_is.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)