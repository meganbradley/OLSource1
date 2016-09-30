---
title: "Names with No Linkage"
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
  - "functions [C++], parameters"
  - "typedef names, linkage"
  - "enumerators [C++], linkage"
  - "names [C++], with no linkage"
  - "function parameters [C++]"
ms.assetid: 7174c500-12d2-4572-8c16-63c27c758fb1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Names with No Linkage
The only names that have no linkage are:  
  
-   Function parameters.  
  
-   Block-scoped names not declared as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or **static**.  
  
-   Enumerators.  
  
-   Names declared in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement. An exception is when the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement is used to provide a name for an unnamed class type. The name may then have external linkage if the class has external linkage. The following example shows a situation in which a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> name has external linkage:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> name, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, becomes the class name for the unnamed structure. It is then used to declare a function with external linkage.  
  
 Because <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> names have no linkage, their definitions can differ between translation units. Because the compilations take place discretely, there is no way for the compiler to detect these differences. As a result, errors of this kind are not detected until link time. Consider the following case:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The preceding code generates an "unresolved external" error at link time.  
  
## Example  
 C++ functions can be defined only in file or class scope. The following example illustrates how to define functions and shows an erroneous function definition:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Program and Linkage](../vs140/program-and-linkage---c---.md)