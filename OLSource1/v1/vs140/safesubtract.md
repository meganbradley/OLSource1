---
title: "SafeSubtract"
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
  - "SafeSubtract"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SafeSubtract function"
ms.assetid: c2712ddc-173f-46a1-b09c-e7ebbd9e68b2
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeSubtract
Subtracts two numbers in a way that protects against overflow.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first number in the subtraction. This must be of type T.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number to subtract from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This must be of type U.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The parameter where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> stores the result.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if no error occurs; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if an error occurs.  
  
## Remarks  
 This method is part of [The SafeInt Library](../vs140/safeint-library.md) and is designed for a single subtraction operation without creating an instance of the [SafeInt Class](../vs140/safeint-class.md).  
  
> [!NOTE]
>  This method should only be used when a single mathematical operation must be protected. If there are multiple operations, you should use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class instead of calling the individual stand-alone functions.  
  
 For more information about the template types T and U, see [SafeInt Functions](../vs140/safeint-functions.md).  
  
## Requirements  
 **Header:** safeint.h  
  
 **Namespace:** Microsoft::Utilities  
  
## See Also  
 [SafeInt Functions](../vs140/safeint-functions.md)   
 [The SafeInt Library](../vs140/safeint-library.md)   
 [SafeInt Class](../vs140/safeint-class.md)   
 [SafeAdd](../vs140/safeadd.md)