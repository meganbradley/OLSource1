---
title: "Overview of Overloading"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function overloading, about function overloading"
  - "operator overloading, about operator overloading"
ms.assetid: cd012dd4-607c-4f8e-bd2e-2bd506ac81ea
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Overview of Overloading
With the C++ language, you can overload functions and operators. Overloading is the practice of supplying more than one definition for a given function name in the same scope. The compiler is left to pick the appropriate version of the function or operator based on the arguments with which it is called. For example, the function max is considered an overloaded function. It can be used in code such as the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the first function call, where the maximum value of two variables of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is being requested, the function <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called. However, in the second function call, the arguments are of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, so the function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is called.  
  
## See Also  
 [Overloading  (C++)](../vs140/overloading---c---.md)