---
title: "Function Templates"
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
  - "function templates"
  - "templates, function"
  - "function templates, about function templates"
ms.assetid: 59b56a4b-0689-4161-9c07-25021562e2a7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Templates
Class templates define a family of related classes that are based on the type arguments passed to the class upon instantiation. Function templates are similar to class templates but define a family of functions. With function templates, you can specify a set of functions that are based on the same code but act on different types or classes. The following function template swaps two items:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code defines a family of functions that swap the values of the arguments. From this template, you can generate functions that will swap <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and **long** types and also user-defined types. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will even swap classes if the class's copy constructor and assignment operator are properly defined.  
  
 In addition, the function template will prevent you from swapping objects of different types, because the compiler knows the types of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameters at compile time.  
  
 Although this function could be performed by a nontemplated function, using void pointers, the template version is typesafe. Consider the following calls:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The second <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> call triggers a compile-time error, because the compiler cannot generate a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function with parameters of different types. If void pointers were used, both function calls would compile correctly, but the function would not work properly at run time.  
  
 Explicit specification of the template arguments for a function template is allowed. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When the template argument is explicitly specified, normal implicit conversions are done to convert the function argument to the type of the corresponding function template parameters. In the above example, the compiler will convert (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) to type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## See Also  
 [Templates](../vs140/templates--c---.md)   
 [Function Template Instantiation](../vs140/function-template-instantiation.md)   
 [Explicit Instantiation](../vs140/explicit-instantiation.md)   
 [Explicit Specialization of Function Templates](../vs140/explicit-specialization-of-function-templates.md)