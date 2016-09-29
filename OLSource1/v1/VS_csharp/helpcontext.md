---
title: "helpcontext"
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
  - "vc-attr.helpcontext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "helpcontext attribute"
ms.assetid: 6fbb022d-a4b7-4989-a02f-7f18a9b0ad96
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# helpcontext
Specifies a context ID that lets the user view information about this element in the Help file.  
  
## Syntax  
  
```  
  
      [ helpcontext(  
   id  
) ]  
```  
  
#### Parameters  
 `id`  
 The context ID of the help topic. See [HTML Help: Context-Sensitive Help for Your Programs](../VS_csharp/html-help--context-sensitive-help-for-your-programs.md) for more information on context IDs.  
  
## Remarks  
 The **helpcontext** C++ attribute has the same functionality as the [helpcontext](http://msdn.microsoft.com/library/windows/desktop/aa366851) MIDL attribute.  
  
## Example  
 See the example for [defaultvalue](../VS_csharp/defaultvalue.md) for an example of how to use **helpcontext**.  
  
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
 [helpstring](../VS_csharp/helpstring.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)