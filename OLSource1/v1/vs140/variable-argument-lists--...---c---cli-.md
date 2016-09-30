---
title: "Variable Argument Lists (...) (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Variable Argument Lists (...) (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "variable argument lists"
  - "parameter arrays"
ms.assetid: db1a27f4-02a8-4318-8690-1f2893f52b38
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Variable Argument Lists (...) (C++-CLI)
This example shows how you can use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> syntax in Visual C++ to implement functions that have a variable number of arguments.  
  
> [!NOTE]
>  This topic pertains to C++/CLI. For information about using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in ISO Standard C++, see [Ellipses and Variadics](../vs140/ellipses-and-variadic-templates.md) and [Ellipses and Default Arguments](../vs140/ellipses-and-default-arguments.md).  
  
 The parameter that uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be the last parameter in the parameter list.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Code Example  
 The following example shows how to call from C# a Visual C++ function that takes a variable number of arguments.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be called from C# or Visual Basic, for example, as though it were a function that can take a variable number of arguments.  
  
 In C#, an argument that is passed to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter can be called by a variable number of arguments. The following code sample is in C#.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A call to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in Visual C++ can pass an initialized array or a variable-length array.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Arrays](../vs140/arrays--c---component-extensions-.md)