---
title: "References to Pointers"
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
  - "references, to pointers"
ms.assetid: 4ce48b08-1511-4d2f-a31f-95f99eac0c70
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# References to Pointers
References to pointers can be declared in much the same way as references to objects. Declaring a reference to a pointer yields a modifiable value that is used like a normal pointer.  
  
## Example  
 The following code samples illustrate the difference between using a pointer to a pointer and a reference to a pointer.  
  
 Functions <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are functionally equivalent (although they are not called the same way). The difference is that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> uses double indirection whereas <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses the convenience of a reference to a pointer.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Usage: Refptr [1 &#124; 2]**  
**where:**  
**1 uses double indirection**  
**2 uses a reference to a pointer.**  
**Input is from stdin.**   
## See Also  
 [References](../vs140/references--c---.md)