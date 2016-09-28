---
title: "SafeDivide"
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
  - "SafeDivide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SafeDivide function"
ms.assetid: b5b27484-ad6e-46b1-ba9f-1c7120dd103b
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeDivide
Divides two numbers in a way that protects against dividing by zero.  
  
## Syntax  
  
```  
template<typename T, typename U>  
inline bool SafeDivide (  
   T t,  
   U u,  
   T& result  
) throw ();  
```  
  
#### Parameters  
 [in] `t`  
 The divisor. This must be of type T.  
  
 [in] `u`  
 The dividend. This must be of type U.  
  
 [out] `result`  
 The parameter where `SafeDivide` stores the result.  
  
## Return Value  
 `true` if no error occurs; `false` if an error occurs.  
  
## Remarks  
 This method is part of [The SafeInt Library](../vs140/safeint-library.md) and is designed for a single division operation without creating an instance of the [SafeInt Class](../vs140/safeint-class.md).  
  
> [!NOTE]
>  This method should only be used when a single mathematical operation must be protected. If there are multiple operations, you should use the `SafeInt` class instead of calling the individual stand-alone functions.  
  
 For more information about the template types T and U, see [SafeInt Functions](../vs140/safeint-functions.md).  
  
## Requirements  
 **Header:** safeint.h  
  
 **Namespace:** Microsoft::Utilities  
  
## See Also  
 [SafeInt Functions](../vs140/safeint-functions.md)   
 [The SafeInt Library](../vs140/safeint-library.md)   
 [SafeInt Class](../vs140/safeint-class.md)   
 [SafeModulus](../vs140/safemodulus.md)   
 [SafeMultiply](../vs140/safemultiply.md)