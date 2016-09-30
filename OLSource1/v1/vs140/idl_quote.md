---
title: "idl_quote"
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
  - "vc-attr.idl_quote"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "idl_quote attribute"
ms.assetid: a370e1b7-948b-4e67-9a25-58facf24e4c9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# idl_quote
Allows you to use IDL constructs that are not supported in the current version of Visual C++ and have them pass through to the generated .idl file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *text*  
 The attribute name that you intend the Visual C++ compiler to pass through to the generated .idl file without returning a compiler error.  
  
## Remarks  
 If the **idl_quote** C++ attribute is used as a stand-alone attribute (with a semicolon after the closing bracket), then *text* is placed in the merged .idl file as is. If **idl_quote** is used on a symbol, *text* is placed within the attribute block for that symbol.  
  
## Example  
 The following code shows how you could specify an unsupported attribute (using **in**, which is supported) and how to define and use an undefined .idl construct:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This code causes MYFLOT and MYDUB and the *text* entry to be placed in the generated .idl file. The *name* parameter forces *text* to be placed before anything that references *name* in the generated .idl file. The *dependencies* parameter forces the dependency list definitions to be placed before *text* in the generated .idl file.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Anywhere|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Stand-Alone Attributes](../vs140/stand-alone-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)