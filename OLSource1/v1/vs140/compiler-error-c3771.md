---
title: "Compiler Error C3771"
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
  - "C3771"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3771"
ms.assetid: 68c23b25-7f21-4eaa-8f7e-38fda1130a69
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3771
"identifier" : friend declaration cannot be found in the nearest namespace scope  
  
 The class template declaration for the specified template *identifier* cannot be found within the current namespace.  
  
### To correct this error  
  
-   Ensure that the class template declaration for the template identifier is defined in the current namespace or that the template identifier is a fully-qualified name.  
  
## Example  
 The following code example declares a class template and function in namespace <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, but attempts to declare a friend function template in namespace <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Template Specifications](../vs140/template-specifications.md)