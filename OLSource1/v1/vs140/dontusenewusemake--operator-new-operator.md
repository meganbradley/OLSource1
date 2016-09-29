---
title: "DontUseNewUseMake::operator new Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "implements/Microsoft::WRL::Details::DontUseNewUseMake::operator new"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator new operator"
ms.assetid: 6af07a0d-2271-430c-9d9b-5a4223fed049
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DontUseNewUseMake::operator new Operator
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
void* operator new(  
   size_t,  
   _In_ void* placement  
);  
```  
  
#### Parameters  
 `__unnamed0`  
 An unnamed parameter that specifies the number of bytes of memory to allocate.  
  
 `placement`  
 The type to be allocated.  
  
## Return Value  
 Provides a way to pass additional arguments if you overload operator `new`.  
  
## Remarks  
 Overloads operator `new` and prevents it from being used in RuntimeClass.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [DontUseNewUseMake Class](../vs140/dontusenewusemake-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)