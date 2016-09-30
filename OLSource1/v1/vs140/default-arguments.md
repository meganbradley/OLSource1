---
title: "Default Arguments"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arguments [C++], function"
  - "function declarators"
  - "functions [C++], default arguments"
  - "declaring functions, declarators"
  - "default arguments"
  - "arguments [C++], default"
  - "defaults [C++], arguments"
ms.assetid: d32cf516-05cb-4d4d-b169-92f5649fdfa2
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Default Arguments
In many cases, functions have arguments that are used so infrequently that a default value would suffice. To address this, the default-argument facility allows for specifying only those arguments to a function that are meaningful in a given call. To illustrate this concept, consider the example presented in [Function Overloading](../vs140/function-overloading.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In many applications, a reasonable default can be supplied for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, eliminating the need for two functions:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The implementation of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function is changed slightly to reflect the fact that only one such function exists for type **double**:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To invoke the new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function, use code such as the following:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Note these points when using default arguments:  
  
-   Default arguments are used only in function calls where trailing arguments are omitted — they must be the last argument(s). Therefore, the following code is illegal:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   A default argument cannot be redefined in later declarations even if the redefinition is identical to the original. Therefore, the following code produces an error:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     The problem with this code is that the function declaration in the definition redefines the default argument for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
-   Additional default arguments can be added by later declarations.  
  
-   Default arguments can be provided for pointers to functions. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [C++ Abstract Declarators](assetId:///e7e18c18-0cad-4450-942b-d27e1d4dd088)