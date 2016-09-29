---
title: "hidden"
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
  - "vc-attr.hidden"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hidden attribute"
ms.assetid: 199c96dd-fc07-46c7-af93-92020aebebe7
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hidden
Indicates that the item exists but should not be displayed in a user-oriented browser.  
  
## Syntax  
  
```  
  
[hidden]  
  
```  
  
## Remarks  
 The **hidden** C++ attribute has the same functionality as the [hidden](http://msdn.microsoft.com/library/windows/desktop/aa366861) MIDL attribute.  
  
## Example  
 See the example for [bindable](../vs140/bindable.md) for an example of how to use **hidden**.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|`interface`, **class**, `struct`, method, property|  
|**Repeatable**|No|  
|**Required attributes**|**coclass** (when applied to **class** or `struct`)|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Interface Attributes](../vs140/interface-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Method Attributes](../vs140/method-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)