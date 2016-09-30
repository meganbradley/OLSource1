---
title: "export"
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
  - "vc-attr.export"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "export attribute"
ms.assetid: 70b3e848-fad6-4e09-8c72-be60ca72a4df
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# export
Causes a data structure to be placed in the .idl file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **export** C++ attribute causes a data structure to be placed in the .idl file and to then be available in the type library in a binary-compatible format that makes it available for use with any language.  
  
 You cannot apply the **export** attribute to a class even if the class only has public members (the equivalent of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
 If you export unnamed <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>s or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>s, they will be given names that begin with **__unnamed***x*, where *x* is a sequential number.  
  
 The typedefs valid for export are base types, structs, unions, enums, or type identifiers.  See [typedef](http://msdn.microsoft.com/library/windows/desktop/aa367287) for more information.  
  
## Example  
 The following code shows how to use the **export** attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**union**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [Compiler Attributes](../vs140/compiler-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)