---
title: "size_is"
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
  - "vc-attr.size_is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_is attribute"
ms.assetid: 70192d09-f6c5-4d52-b3fe-303f8cb10aa5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# size_is
Specify the size of memory allocated for sized pointers, sized pointers to sized pointers, and single- or multidimensional arrays.  
  
## Syntax  
  
```  
  
      [ size_is(  
   "expression"  
) ]  
```  
  
#### Parameters  
 *expression*  
 The size of memory allocated for sized pointers.  
  
## Remarks  
 The **size_is** C++ attribute has the same functionality as the [size_is](http://msdn.microsoft.com/library/windows/desktop/aa367164) MIDL attribute.  
  
## Example  
 See the example for [first_is](../VS_csharp/first_is.md) for a sample of how to specify a section of an array.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Field in `struct` or **union**, interface parameter, interface method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|**max_is**|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../VS_csharp/idl-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../VS_csharp/typedef--enum--union--and-struct-attributes.md)   
 [Parameter Attributes](../VS_csharp/parameter-attributes.md)   
 [first_is](../VS_csharp/first_is.md)   
 [last_is](../VS_csharp/last_is.md)   
 [max_is](../VS_csharp/max_is.md)   
 [length_is](../VS_csharp/length_is.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)