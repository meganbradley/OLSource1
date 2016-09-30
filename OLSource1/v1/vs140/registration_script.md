---
title: "registration_script"
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
  - "vc-attr.registration_script"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "registration_script attribute"
ms.assetid: 786f8072-9187-4163-a979-7a604dd4c888
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# registration_script
Executes the specified custom registration script.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *script*  
 The full path to a custom registration script (.rgs) file. A value of **none**, such as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, indicates that the coclass has no registration requirements.  
  
## Remarks  
 The **registration_script** C++ attribute executes the custom registration script specified by **script**. If this attribute is not specified, a standard .rgs file (containing information for registering the component) is used. For more information on .rgs files, see [The ATL Registry Component (Registrar)](../vs140/atl-registry-component--registrar-.md).  
  
 This attribute requires that the [coclass](../vs140/coclass.md), [progid](../vs140/progid.md), or [vi_progid](../vs140/vi_progid.md) attribute (or another attribute that implies one of these) also be applied to the same element.  
  
## Example  
 The following code specifies that the component has a registry script called cpp_attr_ref_registration_script.rgs.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|One or more of the following: **coclass**, **progid**, or **vi_progid**.|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [COM Attributes](../vs140/com-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [rdx](../vs140/rdx.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)