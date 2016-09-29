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
 See the example for [module](../vs140/module--c---.md) for an example of how to use **helpfile**.  
  
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
 [helpcontext](../vs140/helpcontext.md)   
 [helpstring](../vs140/helpstring.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)