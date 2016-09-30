---
title: "Linkage in Names with File Scope"
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
  - "scope [C++], linkage rules"
  - "linkage [C++], scope linkage rules"
  - "names [C++], scope linkage rules"
  - "static modifier, file scope"
  - "static names and file scope"
  - "file scope [C++]"
  - "declarations [C++], external"
  - "external linkage, scope linkage rules"
  - "static variables, external declarations"
ms.assetid: 38d3fa5e-1861-466e-a590-84b86f7b184e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linkage in Names with File Scope
The following linkage rules apply to names (other than <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and enumerator names) with file scope:  
  
-   If a name is explicitly declared as **static**, it has internal linkage and identifies a program element inside its own translation unit.  
  
-   Enumerator names and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> names have no linkage.  
  
-   All other names with file scope have external linkage.  
  
 **Microsoft Specific**  
  
-   If a function name with file scope is explicitly declared as **inline**, it has external linkage if it is instantiated or its address is referenced. Therefore, it is possible for a function with file scope to have either internal or external linkage.  
  
 **END Microsoft Specific**  
  
 A class has internal linkage if it:  
  
-   Uses no C++ functionality (for example, member-access control, member functions, constructors, destructors, and so on).  
  
-   Is not used in the declaration of another name that has external linkage. This constraint means that objects of class type that are passed to functions with external linkage cause the class to have external linkage.  
  
## See Also  
 [Program and Linkage](../vs140/program-and-linkage---c---.md)