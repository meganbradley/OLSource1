---
title: "com_interface_entry (C++)"
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
  - "vc-attr.com_interface_entry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "com_interface_entry attribute"
ms.assetid: 10368f81-b99b-4a0f-ba4f-a142e6911a5c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# com_interface_entry (C++)
Adds an interface entry into the COM map of the target class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *com_interface_entry*  
 A string containing the actual text of the entry. For a list of possible values, see [COM_INTERFACE_ENTRY Macros](../vs140/com_interface_entry-macros.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> C++ attribute inserts the unabridged contents of a character string into the COM interface map of the target object. If the attribute is applied once to the target object, the entry is inserted into the beginning of the existing interface map. If the attribute is applied repeatedly to the same target object, the entries are inserted at the beginning of the interface map in the order they are received.  
  
 This attribute requires that the [coclass](../vs140/coclass.md), [progid](../vs140/progid.md), or [vi_progid](../vs140/vi_progid.md) attribute (or another attribute that implies one of these) also be applied to the same element. If any single attribute is used, the other two are automatically applied. For example, if **progid** is applied, **vi_progid** and **coclass** are also applied.  
  
 Because the first usage of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> causes the new interface to be inserted at the beginning of the interface map, it must be one of the following COM_INTERFACE_ENTRY types:  
  
-   COM_INTERFACE_ENTRY  
  
-   COM_INTERFACE_ENTRY_IID  
  
-   COM_INTERFACE_ENTRY2  
  
-   COM_INTERFACE_ENTRY2_IID  
  
 Additional usages of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute can use all supported COM_INTERFACE_ENTRY types.  
  
 This restriction is necessary because ATL uses the first entry in the interface map as the identity **IUnknown**; therefore, the entry must be a valid interface. For example, the following code sample is invalid because the first entry in the interface map does not specify an actual COM interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code adds two entries to the existing COM interface map of **CMyBaseClass**. The first is a standard interface, and the second hides the **IDebugTest** interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resulting COM object map for **CMyBaseClass** is as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|**Repeatable**|Yes|  
|**Required attributes**|One or more of the following: **coclass**, **progid**, or **vi_progid**.|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [COM Attributes](../vs140/com-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)