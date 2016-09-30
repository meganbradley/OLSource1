---
title: "support_error_info"
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
  - "vc-attr.support_error_info"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "support_error_info attribute"
ms.assetid: 20a2b55c-4738-4b35-a71d-e5e9c3a7e3bc
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# support_error_info
Implements support for returning detailed errors.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **error_interface**  
 The identifier of the interface implementing **IErrorInfo**.  
  
## Remarks  
 The **support_error_info** C++ attribute implements support for returning detailed, contextual errors encountered by the target object to the client. For the object to support errors, the methods of the **IErrorInfo** interface must be implemented by the object. For more information, see [Supporting IDispatch and IErrorInfo](../vs140/supporting-idispatch-and-ierrorinfo.md).  
  
 This attribute adds the [ISupportErrorInfoImpl](../vs140/isupporterrorinfoimpl-class.md) class as a base class to the target object. This results in a default implementation of **ISupportErrorInfo** and can be used when a single interface generates errors on an object.  
  
## Example  
 The following code adds default support for the **ISupportErrorInfo** interface to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**|  
|**Repeatable**|Yes|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [COM Attributes](../vs140/com-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)