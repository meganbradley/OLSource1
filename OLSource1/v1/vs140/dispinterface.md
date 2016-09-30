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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When the **dispinterface** C++ attribute precedes an interface, it causes the interface to be placed inside the library block in the generated .idl file.  
  
 Unless you specify a base class, a dispatch interface will derive from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You must specify an [id](../vs140/id.md) for the members of a dispatch interface.  
  
 The usage example for [dispinterface](http://msdn.microsoft.com/library/windows/desktop/aa366802) in the MIDL documentation:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is not valid for the **dispinterface** attribute.  
  
## Example  
 See the example for [bindable](../vs140/bindable.md) for an example of how to use **dispinterface**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|**dual**, **object**, **oleautomation**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, **ms_union**|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Attributes by Usage](../vs140/attributes-by-usage.md)   
 [uuid](../vs140/uuid--c---attributes-.md)   
 [dual](../vs140/dual.md)   
 [custom](../vs140/custom--c---.md)   
 [object](../vs140/object--c---.md)   
 [__interface](../vs140/__interface.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)