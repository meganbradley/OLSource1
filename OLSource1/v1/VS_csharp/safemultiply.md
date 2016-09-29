---
title: "SafeMultiply"
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
  - "SafeMultiply"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SafeMultiply function"
ms.assetid: 81d988a5-fac7-4930-8c37-c24fa8e2c853
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeMultiply
Multiplies two numbers together in a way that protects against overflow.  
  
## Syntax  
  
```  
template<typename T, typename U>  
inline bool SafeMultiply (  
   T t,  
   U u,  
   T& result  
) throw ();  
```  
  
#### Parameters  
 [in] `t`  
 The first number to multiply. This must be of type T.  
  
 [in] `u`  
 The second number to multiply. This must be of type U.  
  
 [out] `result`  
 The parameter where `SafeMultiply` stores the result.  
  
## Return Value  
 `true` if no error occurs; `false` if an error occurs.  
  
## Remarks  
 This method is part of [The SafeInt Library](../VS_csharp/safeint-library.md) and is designed for a single multiplication operation without creating an instance of the [SafeInt Class](../VS_csharp/safeint-class.md).  
  
> [!NOTE]
>  This method should only be used when a single mathematical operation must be protected. If there are multiple operations, you should use the `SafeInt` class instead of calling the individual stand-alone functions.  
  
 For more information about the template types T and U, see [SafeInt Functions](../VS_csharp/safeint-functions.md).  
  
## Requirements  
 **Header:** safeint.h  
  
 **Namespace:** Microsoft::Utilities  
  
## See Also  
 [SafeInt Functions](../VS_csharp/safeint-functions.md)   
 [The SafeInt Library](../VS_csharp/safeint-library.md)   
 [SafeInt Class](../VS_csharp/safeint-class.md)   
 [SafeDivide](../VS_csharp/safedivide.md)