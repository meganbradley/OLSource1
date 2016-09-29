---
title: "identity Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::identity"
  - "utility/std::identity"
  - "identity"
  - "std.identity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "identity class"
  - "identity structure"
ms.assetid: 990756fd-7969-4b39-ad7e-0878e8dac8fd
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# identity Structure
A struct that provides a type definition as the template parameter.  
  
## Syntax  
  
```  
template<class Type>  
   struct identity {  
      typedef Type type;  
      Type operator()(const Type& _Left) const;  
   };  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|The value to identify.|  
  
## Remarks  
 The class contains the public type definition `type`, which is the same as the template parameter Type. It is used in conjunction with template function [forward](../vs140/-utility--functions.md#forward) to ensure that a function parameter has the desired type.  
  
 For compatibility with older code, the class also defines the identity function `operator()` which returns its argument `_Left`.  
  
## Requirements  
 **Header:** <utility\>  
  
 **Namespace:** std  
  
## See Also  
 [<utility\>](../vs140/-utility-.md)