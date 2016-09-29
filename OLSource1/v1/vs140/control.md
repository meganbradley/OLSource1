---
title: "control"
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
  - "vc-attr.control"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Control attribute"
ms.assetid: 3d046bb2-4afe-4cb8-a762-233b296e1975
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# control
Specifies that the user-defined type is a control.  
  
## Syntax  
  
```  
  
[control]  
  
```  
  
## Remarks  
 The **control** attribute implies the [coclass](../vs140/coclass.md) attribute. The **control** C++ attribute has the same functionality as the [control](http://msdn.microsoft.com/library/windows/desktop/aa366764) MIDL attribute.  
  
## Example  
  
```  
// cpp_attr_ref_control.cpp  
// compile with: /LD  
#include <windows.h>  
[module(name="Test", control=true)];  
  
[object, uuid("9e66a290-4365-11d2-a997-00c04fa37ddb")]  
__interface ICustom {  
   HRESULT Custom([in] long l, [out, retval] long *pLong);  
};  
  
[coclass, control, appobject, uuid("9e66a294-4365-11d2-a997-00c04fa37ddb")]  
class CTest : public ICustom {};  
```  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, `struct`|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Typedef, Enum, Union, and Struct Attributes](../vs140/typedef--enum--union--and-struct-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)