---
title: "helpfile"
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
  - "vc-attr.helpfile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "helpfile attribute"
ms.assetid: d75161c1-1363-4019-ae09-e7e3b8a3971e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# helpfile
Sets the name of the Help file for a type library.  
  
## Syntax  
  
```  
  
      [ helpfile(  
   "filename"  
) ]  
```  
  
#### Parameters  
 *filename*  
 The name of the file that contains the help topics.  
  
## Remarks  
 The **helpfile** C++ attribute has the same functionality as the [helpfile](http://msdn.microsoft.com/library/windows/desktop/aa366853) MIDL attribute.  
  
## Example  
 See the example for [module](../VS_csharp/module--c---.md) for an example of how to use **helpfile**.  
  
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
 [helpcontext](../VS_csharp/helpcontext.md)   
 [helpstring](../VS_csharp/helpstring.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)