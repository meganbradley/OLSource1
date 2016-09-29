---
title: "noncreatable"
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
  - "vc-attr.noncreatable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noncreatable attribute"
ms.assetid: 4d17937b-0bff-41af-ba57-53e18b7ab5a9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noncreatable
Defines an object that cannot be instantiated by itself.  
  
## Syntax  
  
```  
  
[noncreatable]  
  
```  
  
## Remarks  
 The **noncreatable** C++ attribute has the same functionality as the [noncreatable](http://msdn.microsoft.com/library/windows/desktop/aa367118) MIDL attribute and is automatically passed through to the generated .IDL file by the compiler.  
  
 When this attribute is used within a project that uses ATL, the behavior of the attribute changes. In addition to the above behavior, the attribute also injects the [OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../VS_csharp/object_entry_non_createable_ex_auto.md) macro. This macro indicates to ATL that the object cannot be created externally.  
  
## Example  
  
```  
// cpp_attr_ref_noncreatable.cpp  
// compile with: /LD  
#include <unknwn.h>  
[module(name="MyLib")];  
  
[object, uuid("11111111-1111-1111-1111-111111111111")]  
__interface A   
{  
};  
  
[coclass, uuid("11111111-1111-1111-1111-111111111112"), noncreatable]  
class CMyClass : public A   
{  
   HRESULT xx();  
};  
```  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, `struct`|  
|**Repeatable**|No|  
|**Required attributes**|**coclass**|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../VS_csharp/idl-attributes.md)   
 [Class Attributes](../VS_csharp/class-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)