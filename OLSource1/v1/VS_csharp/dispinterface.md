---
title: "dispinterface"
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
  - "vc-attr.dispinterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dispinterface attribute"
ms.assetid: 61c5a4a1-ae92-47e9-8ee4-f847be90172b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# dispinterface
Places an interface in the .idl file as a dispatch interface.  
  
## Syntax  
  
```  
  
[dispinterface]  
  
```  
  
## Remarks  
 When the **dispinterface** C++ attribute precedes an interface, it causes the interface to be placed inside the library block in the generated .idl file.  
  
 Unless you specify a base class, a dispatch interface will derive from `IDispatch`. You must specify an [id](../VS_csharp/id.md) for the members of a dispatch interface.  
  
 The usage example for [dispinterface](http://msdn.microsoft.com/library/windows/desktop/aa366802) in the MIDL documentation:  
  
```  
dispinterface helloPro   
   { interface hello; };   
```  
  
 is not valid for the **dispinterface** attribute.  
  
## Example  
 See the example for [bindable](../VS_csharp/bindable.md) for an example of how to use **dispinterface**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|`interface`|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|**dual**, **object**, **oleautomation**, `local`, **ms_union**|  
  
 For more information, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../VS_csharp/idl-attributes.md)   
 [Attributes by Usage](../VS_csharp/attributes-by-usage.md)   
 [uuid](../VS_csharp/uuid--c---attributes-.md)   
 [dual](../VS_csharp/dual.md)   
 [custom](../VS_csharp/custom--c---.md)   
 [object](../VS_csharp/object--c---.md)   
 [__interface](../VS_csharp/__interface.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)