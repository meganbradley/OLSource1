---
title: "ComPtr::operator Microsoft::WRL::Details::BoolType Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: cfba6521-fb30-4fb8-afb2-cfab1cb5e0b8
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtr::operator Microsoft::WRL::Details::BoolType Operator
Indicates whether or not a ComPtr is managing the object lifetime of an interface.  
  
## Syntax  
  
```  
WRL_NOTHROW operator Microsoft::WRL::Details::BoolType() const;  
```  
  
## Return Value  
 If an interface is associated with this ComPtr, the address of the [BoolStruct::Member](../vs140/boolstruct--member-data-member.md) data member; otherwise, `nullptr`.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../vs140/comptr-class.md)   
 [ComPtr::Get](../vs140/comptr--get-method.md)