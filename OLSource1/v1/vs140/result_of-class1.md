---
title: "result_of Class1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "result_of Class"
f1_keywords: 
  - "result_of"
  - "std.result_of"
  - "std::result_of"
  - "type_traits/std::result_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "result_of"
ms.assetid: 5374a096-4b4a-4712-aa97-6852c5cdd6be
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# result_of Class1
Determines the return type of the callable type that takes the specified argument types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The callable type to query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The types of the argument list to the callable type to query.  
  
## Remarks  
 Use this template to determine at compile time the result type of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>), where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a callable type invoked with an argument list of the types in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member of the template class names the result type of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the unevaluated expression <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is well-formed. Otherwise, the template class has no member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and all types in the parameter pack <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be complete types, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or arrays of unknown bound.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)