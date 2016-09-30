---
title: "synchronize"
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
  - "vc-attr.synchronize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "synchronize attribute"
ms.assetid: 15fc8544-955d-4765-b3d5-0f619c8b3f40
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# synchronize
Synchronizes access to the target method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **synchronize** C++ attribute implements support for synchronizing the target method of an object. Synchronization allows multiple objects to use a common resource (such as a method of a class) by controlling the access of the target method.  
  
 The code inserted by this attribute calls the proper <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method (determined by the threading model) at the beginning of the target method. When the method is exited, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is automatically called. For more information on these functions, see [CComAutoThreadModule::Lock](../vs140/ccomautothreadmodule--lock.md)  
  
 This attribute requires that the [coclass](../vs140/coclass.md), [progid](../vs140/progid.md), or [vi_progid](../vs140/vi_progid.md) attribute (or another attribute that implies one of these) also be applied to the same element. If any single attribute is used, the other two are automatically applied. For example, if **progid** is applied, **vi_progid** and **coclass** are also applied.  
  
## Example  
 The following code provides synchronization for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Class method, method|  
|**Repeatable**|No|  
|**Required attributes**|One or more of the following: **coclass**, **progid**, or **vi_progid**.|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [COM Attributes](../vs140/com-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)