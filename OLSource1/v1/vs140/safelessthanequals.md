---
title: "SafeLessThanEquals"
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
  - "SafeLessThanEquals"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SafeLessThanEquals function"
ms.assetid: cbd70526-faf2-4fbc-96a0-b61e8cf5f04a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeLessThanEquals
Compares two numbers.  
  
## Syntax  
  
```  
template <typename T, typename U>  
inline bool SafeLessThanEquals (  
   const T t,  
   const U u  
) throw ();  
```  
  
#### Parameters  
 [in] `t`  
 The first number to compare. This must be of type T.  
  
 [in] `u`  
 The second number to compare. This must be of type U.  
  
## Return Value  
 `true` if `t` is less than or equal to `u`; otherwise `false`.  
  
## Remarks  
 `SafeLessThanEquals` extends the regular comparison operator by enabling you to compare two different types of numbers.  
  
 This method is part of [The SafeInt Library](../vs140/safeint-library.md) and is designed for a single comparison operation without creating an instance of the [SafeInt Class](../vs140/safeint-class.md).  
  
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
 [SafeGreaterThan](../vs140/safegreaterthan.md)   
 [SafeLessThan](../vs140/safelessthan.md)   
 [SafeGreaterThanEquals](../vs140/safegreaterthanequals.md)