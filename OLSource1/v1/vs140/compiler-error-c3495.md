---
title: "Compiler Error C3495"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C3495"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3495"
ms.assetid: 1fd40cb8-8373-403d-b8a8-f08424a50807
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3495
'var': a lambda capture must have automatic storage duration  
  
 You cannot capture a variable that does not have automatic storage duration, such as a variable that is marked <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
-   Do not pass a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable to the capture list of the lambda expression.  
  
## Example  
 The following example generates C3495 because the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> appears in the capture list of a lambda expression:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)   
 [(NOTINBUILD)Storage-Class Specifiers](assetId:///10b3d22d-cb40-450b-994b-08cf9a211b6c)