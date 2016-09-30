---
title: "Name Resolution for Dependent Types"
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
ms.assetid: 34066bb4-0c79-4fd8-bda7-539a60a277ab
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Name Resolution for Dependent Types
Use **typename** for qualified names in template definitions to tell the compiler that the given qualified name identifies a type. For more information, see [typename](../vs140/typename.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name lookup for dependent names examines names from both the context of the template definition—in the following example, this context would find <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>—and the context of the template instantiation.In the following example, the template is instantiated in main; therefore, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is visible from the point of instantiation and is picked as the better match. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> were renamed, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> would be called instead.  
  
 All names are resolved as if they were dependent names. Nevertheless, we recommend that you use fully qualified names if there is any possible conflict.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Template Disambiguation  
 [!INCLUDE[cpp_dev11_long](../vs140/includes/cpp_dev11_long_md.md)] enforces the C++98/03/11 standard rules for disambiguation with the "template" keyword. In the following example, [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)] would accept both the nonconforming lines and the conforming lines.  [!INCLUDE[cpp_dev11_long](../vs140/includes/cpp_dev11_long_md.md)] accepts only the conforming lines.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Conformance with the disambiguation rules is required because, by default, C++ assumes that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> isn't a template, and so the compiler interprets the following "<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>" as a less-than. It has to know that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a template so that it can correctly parse "<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>" as an angle bracket.  
  
## See Also  
 [Name Resolution](../vs140/templates-and-name-resolution.md)