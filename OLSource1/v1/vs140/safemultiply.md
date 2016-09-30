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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first number to multiply. This must be of type T.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second number to multiply. This must be of type U.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The parameter where <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> stores the result.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if no error occurs; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if an error occurs.  
  
## Remarks  
 This method is part of [The SafeInt Library](../vs140/safeint-library.md) and is designed for a single multiplication operation without creating an instance of the [SafeInt Class](../vs140/safeint-class.md).  
  
> [!NOTE]
>  This method should only be used when a single mathematical operation must be protected. If there are multiple operations, you should use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class instead of calling the individual stand-alone functions.  
  
 For more information about the template types T and U, see [SafeInt Functions](../vs140/safeint-functions.md).  
  
## Requirements  
 **Header:** safeint.h  
  
 **Namespace:** Microsoft::Utilities  
  
## See Also  
 [SafeInt Functions](../vs140/safeint-functions.md)   
 [The SafeInt Library](../vs140/safeint-library.md)   
 [SafeInt Class](../vs140/safeint-class.md)   
 [SafeDivide](../vs140/safedivide.md)