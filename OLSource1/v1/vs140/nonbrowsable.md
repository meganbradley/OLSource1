---
title: "nonbrowsable"
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
  - "vc-attr.nonbrowsable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nonbrowsable attribute"
ms.assetid: e71a98e7-4b65-454a-9829-342b9f2a84be
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nonbrowsable
Indicates that an interface member should not be displayed in a property browser.  
  
## Syntax  
  
```  
  
[nonbrowsable]  
  
```  
  
## Remarks  
 The **nonbrowsable** C++ attribute has the same functionality as the [nonbrowsable](http://msdn.microsoft.com/library/windows/desktop/aa367117) MIDL attribute.  
  
## Example  
  
```  
// cpp_attr_ref_nonbrowsable.cpp  
// compile with: /LD  
#include <unknwn.h>  
[module(name="MyLib")];  
  
[object, helpstring("help string"), helpstringcontext(1),   
uuid="11111111-1111-1111-1111-111111111111"]   
__interface IMyI  
{  
   [nonbrowsable] HRESULT xx();  
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
 [Method Attributes](../vs140/method-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)