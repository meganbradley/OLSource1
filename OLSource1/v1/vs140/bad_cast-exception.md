---
title: "bad_cast Exception"
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
  - "bad_cast"
  - "bad_cast_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exceptions, bad_cast"
  - "bad_cast keyword [C++]"
ms.assetid: 31eae1e7-d8d5-40a0-9fef-64a6a4fc9021
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bad_cast Exception
The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> exception is thrown by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator as the result of a failed cast to a reference type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The interface for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following code contains an example of a failed <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that throws the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> exception.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The exception is thrown because the object being cast (a Shape) is not derived from the specified cast type (Circle). To avoid the exception, add these declarations to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Then reverse the sense of the cast in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [dynamic_cast Operator](../vs140/dynamic_cast-operator.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [C++ Exception Handling](../vs140/c---exception-handling.md)