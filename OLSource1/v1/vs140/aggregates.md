---
title: "aggregates"
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
  - "vc-attr.aggregates"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregates attribute"
  - "aggregation [C++]"
  - "aggregate objects [C++], aggregates attribute"
  - "aggregates [C++]"
ms.assetid: 67a084c9-941f-474b-a029-9c93b38ebe9a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# aggregates
Indicates that the object aggregates the object specified by the CLSID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the CLSID of the aggregatable object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The name of the variable that is to be inserted. This variable contains the **IUnknown** of the object being aggregated.  
  
## Remarks  
 When applied to an object, the **aggregates** C++ attribute implements an outer wrapper for the object being aggregated (specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 This attribute requires that the [coclass](../vs140/coclass.md), [progid](../vs140/progid.md), or [vi_progid](../vs140/vi_progid.md) attribute (or another attribute that implies one of these) also be applied to the same element. If any single attribute is used, the other two are automatically applied. For example, if **progid** is applied, **vi_progid** and **coclass** are also applied.  
  
 **ATL Projects**  
  
 If this attribute is used within a project that uses ATL, the behavior of the attribute changes. First, the following entry is added to the COM map of the target object:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Second, the [DECLARE_GET_CONTROLLING_UNKNOWN](../vs140/declare_get_controlling_unknown.md) macro is also added.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|**Repeatable**|Yes|  
|**Required attributes**|One or more of the following: **coclass**, **progid**, or **vi_progid**.|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [COM Attributes](../vs140/com-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Aggregation](http://msdn.microsoft.com/library/windows/desktop/ms686558)   
 [Aggregatable](http://msdn.microsoft.com/library/windows/desktop/aa366721)   
 [COM_INTERFACE_ENTRY_AUTOAGGREGATE_BLIND](../vs140/com_interface_entry_autoaggregate_blind.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)