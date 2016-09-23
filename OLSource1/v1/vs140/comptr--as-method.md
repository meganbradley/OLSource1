---
title: "ComPtr::As Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - client/Microsoft::WRL::ComPtr::As
dev_langs: 
  - C++
helpviewer_keywords: 
  - As method
ms.assetid: 2ad6c262-9bdb-4c59-a330-1af8bcd445cc
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ComPtr::As Method
Returns a ComPtr object that represents the interface identified by the specified template parameter.  
  
## Syntax  
  
```  
  
template<  
   typename U  
>  
HRESULT As(  
   _Out_ ComPtr<U>* p  
) const;  
  
template<  
   typename U  
>  
HRESULT As(  
   _Out_ Details::ComPtrRef<ComPtr<U>> p  
) const;  
  
```  
  
#### Parameters  
 `U`  
 The interface to be represented by parameter `p`.  
  
 `p`  
 A ComPtr object that represents the interface specified by parameter `U`. Parameter `p` must not refer to the current ComPtr object.  
  
## Remarks  
 The first template is the form that you should use in your code. The second template is an internal, helper specialization that supports C++ language features such as the [auto](../vs140/auto--c---.md) type deduction keyword.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../vs140/comptr-class.md)