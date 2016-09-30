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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first number to compare. This must be of type T.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second number to compare. This must be of type U.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is less than or equal to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> extends the regular comparison operator by enabling you to compare two different types of numbers.  
  
 This method is part of [The SafeInt Library](../vs140/safeint-library.md) and is designed for a single comparison operation without creating an instance of the [SafeInt Class](../vs140/safeint-class.md).  
  
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
 [SafeGreaterThan](../vs140/safegreaterthan.md)   
 [SafeLessThan](../vs140/safelessthan.md)   
 [SafeGreaterThanEquals](../vs140/safegreaterthanequals.md)