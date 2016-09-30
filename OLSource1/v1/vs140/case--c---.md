---
title: "case (C++)"
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
  - "vc-attr.case"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "case attribute"
ms.assetid: 6fb883c3-0526-4932-a901-b4564dcaeb7d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# case (C++)
Used with the [switch_type](../vs140/switch_type.md) attribute in a **union**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *value*  
 A possible input value for which you want to provide processing. The type of **value** can be one of the following types:  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
-   **boolean**  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 or an identifier of such a type.  
  
## Remarks  
 The **case** C++ attribute has the same functionality as the **case** MIDL attribute. This attribute is only used with the [switch_type](../vs140/switch_type.md) attribute.  
  
## Example  
 The following code shows a use of the **case** attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Member of a **class** or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)