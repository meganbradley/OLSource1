---
title: "helpstringdll"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - vc-attr.helpstringdll
dev_langs: 
  - C++
helpviewer_keywords: 
  - helpstringdll attribute [C++]
ms.assetid: 121271fa-f061-492b-b87f-bbfcf4b02e7b
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# helpstringdll
Specifies the name of the DLL to use to perform document string lookup (localization).  
  
## Syntax  
  
```  
  
      [ helpstringdll(  
   "string"  
) ]  
```  
  
#### Parameters  
 `string`  
 The DLL to use to perform document string lookup.  
  
## Remarks  
 The **helpstringdll** C++ attribute has the same functionality as the [helpstringdll](http://msdn.microsoft.com/library/windows/desktop/aa366860) MIDL attribute.  
  
## Example  
  
```  
// cpp_attr_ref_helpstringdll.cpp  
// compile with: /LD  
#include <unknwn.h>  
[module(name="MyLib", helpstringdll="xx.dll")];  
  
[object, uuid("00000000-0000-0000-0000-000000000001")]  
__interface IMyI   
{  
   HRESULT xxx();  
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
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)