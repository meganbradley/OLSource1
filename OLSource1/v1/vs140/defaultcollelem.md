---
title: "defaultcollelem"
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
  - vc-attr.defaultcollelem
dev_langs: 
  - C++
helpviewer_keywords: 
  - defaultcollelem attribute
ms.assetid: 3dbbd293-8b83-4f70-a36b-64cc1d0b6713
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# defaultcollelem
Used for Visual Basic code optimization.  
  
## Syntax  
  
```  
  
[defaultcollelem]  
  
```  
  
## Remarks  
 The **defaultcollelem** C++ attribute has the same functionality as the [defaultcollelem](http://msdn.microsoft.com/library/windows/desktop/aa366792) MIDL attribute.  
  
## Example  
 The following code shows an interface method using the **defaultcollelem** attribute:  
  
```  
// cpp_attr_ref_defaultcollelem.cpp  
// compile with: /LD  
#include <unknwn.h>  
[module(name="MyLib")];  
[object, uuid("00000000-0000-0000-0000-000000000001")]  
__interface IMyForm   
{     
   [propget, id(1), bindable, defaultcollelem, displaybind,   
   defaultbind, requestedit] HRESULT P1([out, retval] long *nSize);  
   [propput, id(1), bindable, defaultcollelem, displaybind,   
   defaultbind, requestedit] HRESULT P1([in] long nSize);  
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
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Method Attributes](../vs140/method-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)