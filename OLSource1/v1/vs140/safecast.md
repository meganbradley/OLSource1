---
title: "SafeCast"
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
  - "SafeCast"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SafeCast function"
ms.assetid: 55316729-8456-403a-9f96-59d4038f67af
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SafeCast
Casts one type of number to another type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The source number to convert. This must be of type T.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to the new number type. This must be of type U.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if no error occurs; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if an error occurs.  
  
## Remarks  
 This method is part of [The SafeInt Library](../vs140/safeint-library.md) and is designed for a single casting operation without creating an instance of the [SafeInt Class](../vs140/safeint-class.md).  
  
> [!NOTE]
>  This method should only be used when a single operation must be protected. If there are multiple operations, you should use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class instead of calling the individual stand-alone functions.  
  
 For more information about the template types T and U, see [SafeInt Functions](../vs140/safeint-functions.md).  
  
## Requirements  
 **Header:** safeint.h  
  
 **Namespace:** Microsoft::Utilities  
  
## See Also  
 [SafeInt Functions](../vs140/safeint-functions.md)   
 [The SafeInt Library](../vs140/safeint-library.md)   
 [SafeInt Class](../vs140/safeint-class.md)