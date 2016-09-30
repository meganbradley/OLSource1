---
title: "dual"
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
  - "vc-attr.dual"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dual attribute"
ms.assetid: 5d4a9069-d819-42cd-ba56-bbcda17157d9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# dual
Places an interface in the .idl file as a dual interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When the **dual** C++ attribute precedes an interface, it causes the interface to be placed inside the library block in the generated .idl file.  
  
## Example  
 The following code is an attribute block that uses **dual** before an interface definition:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|**dispinterface**|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Attributes by Usage](../vs140/attributes-by-usage.md)   
 [custom](../vs140/custom--c---.md)   
 [dispinterface](../vs140/dispinterface.md)   
 [object](../vs140/object--c---.md)   
 [__interface](../vs140/__interface.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)