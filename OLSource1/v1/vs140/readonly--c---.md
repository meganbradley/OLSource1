---
title: "readonly (C++)"
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
  - "vc-attr.readonly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "readonly attribute"
ms.assetid: 1246cadd-5304-43a9-beea-51153d12704d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# readonly (C++)
Prohibits assignment to a data member.  
  
## Syntax  
  
```  
  
[readonly]  
  
```  
  
## Remarks  
 The **readonly** C++ attribute has the same functionality as the [readonly](http://msdn.microsoft.com/library/windows/desktop/aa367152) MIDL attribute.  
  
 If you want to prohibit modification of a method parameter, then use the [in](../vs140/in--c---.md) attribute.  
  
## Example  
 The following code shows a use of the **readonly** attribute:  
  
```  
// cpp_attr_ref_readonly.cpp  
// compile with: /LD  
[idl_quote("midl_pragma warning(disable:2461)")];  
#include "unknwn.h"  
[module(name="ATLFIRELib")];  
  
[dispinterface, uuid(11111111-1111-1111-1111-111111111111)]  
__interface IFireTabCtrl  
{  
   [readonly, id(1)] int i();  
};  
```  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Interface method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Data Member Attributes](../vs140/data-member-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)