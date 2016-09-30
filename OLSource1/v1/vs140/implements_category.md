---
title: "implements_category"
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
  - "vc-attr.implements_category"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "implements_category attribute"
ms.assetid: fb162df3-1ebe-43dc-a084-668d7ef8c03f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# implements_category
Specifies the component categories implemented by the target class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **implements_category**  
 The ID of the implemented category.  
  
## Remarks  
 The **implements_category** C++ attribute specifies the component categories implemented by the target class. This is done by creating a CATEGORY map and adding separate entries specified by the **implements_category** attribute. For more information, see [What are Component Categories and How Do They Work?](http://msdn.microsoft.com/library/windows/desktop/ms694322).  
  
 This attribute requires that the [coclass](../vs140/coclass.md), [progid](../vs140/progid.md), or [vi_progid](../vs140/vi_progid.md) attribute (or another attribute that implies one of these) also be applied to the same element. If any single attribute is used, the other two are automatically applied. For example, if **progid** is applied, **vi_progid** and **coclass** are also applied.  
  
## Example  
 The following code specifies that the following object implements the Control category.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|**Repeatable**|Yes|  
|**Required attributes**|One of the following: **coclass**, **progid**, or **vi_progid**|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [COM Attributes](../vs140/com-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [IMPLEMENTED_CATEGORY](../vs140/implemented_category.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)