---
title: "aggregatable"
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
  - "vc-attr.aggregatable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregatable attribute"
ms.assetid: 9253a46a-cd76-41f2-b3b6-86f709bb069c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# aggregatable
Indicates that the class supports aggregation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *value* (optional)  
 A parameter to indicate when the COM object can be aggregated:  
  
-   **never** The COM object cannot be aggregated.  
  
-   **allowed** The COM object can be created directly or it can be aggregated. This is the default.  
  
-   **always** The COM object cannot be created directly and can only be aggregated. When you call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for this object, you must specify the aggregating object's **IUnknown** interface (the controlling **IUnknown**).  
  
## Remarks  
 The **aggregatable** C++ attribute has the same functionality as the [aggregatable](http://msdn.microsoft.com/library/windows/desktop/aa366721) MIDL attribute. This means that the compiler will pass the **aggregatable** attribute through to the generated .idl file.  
  
 This attribute requires that the [coclass](../vs140/coclass.md), [progid](../vs140/progid.md), or [vi_progid](../vs140/vi_progid.md) attribute (or another attribute that implies one of these) also be applied to the same element. If any single attribute is used, the other two are automatically applied. For example, if **progid** is applied, **vi_progid** and **coclass** are also applied.  
  
 **ATL Projects**  
  
 If this attribute is used within a project that uses ATL, the behavior of the attribute changes. In addition to the previously described behavior, the attribute also adds one of the following macros to the target class:  
  
|Parameter value|Inserted macro|  
|---------------------|--------------------|  
|**Never**|[DECLARE_NOT_AGGREGATABLE](../vs140/declare_not_aggregatable.md)|  
|**Allowed**|[DECLARE_POLY_AGGREGATABLE](../vs140/declare_poly_aggregatable.md)|  
|**Always**|[DECLARE_ONLY_AGGREGATABLE](../vs140/declare_only_aggregatable.md)|  
  
## Example  
  
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
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Aggregation](http://msdn.microsoft.com/library/windows/desktop/ms686558)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)