---
title: "helpstringcontext"
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
  - "vc-attr.helpstringcontext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "helpstringcontext attribute [C++]"
ms.assetid: d4cd135e-d91c-4aa3-9353-8aeb096f52cf
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# helpstringcontext
Specifies the ID of a help topic in an .hlp or .chm file.  
  
## Syntax  
  
```  
  
      [ helpstringcontext(  
   contextID  
) ]  
```  
  
#### Parameters  
 `contextID`  
 A 32-bit Help context identifier in the Help file.  
  
## Remarks  
 The **helpstringcontext** C++ attribute has the same functionality as the [helpstringcontext](http://msdn.microsoft.com/library/windows/desktop/aa366858) ODL attribute.  
  
## Example  
  
```  
// cpp_attr_ref_helpstringcontext.cpp  
// compile with: /LD  
#include <unknwn.h>  
[module(name="MyLib")];  
  
[   object,   
   helpstring("help string"),   
   helpstringcontext(1),   
   uuid="11111111-1111-1111-1111-111111111111"  
]  
__interface IMyI   
{  
   HRESULT xx();  
};  
```  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, `interface`, interface method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Interface Attributes](../vs140/interface-attributes.md)   
 [Class Attributes](../vs140/class-attributes.md)   
 [Method Attributes](../vs140/method-attributes.md)   
 [module](../vs140/module--c---.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)