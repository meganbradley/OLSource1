---
title: "property (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "property_cpp"
  - "Property"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property __declspec keyword"
  - "__declspec keyword [C++], property"
ms.assetid: f3b850ba-bf48-4df7-a1d6-8259d97309ce
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# property (C++)
**Microsoft Specific**  
  
 This attribute can be applied to non-static "virtual data members" in a class or structure definition. The compiler treats these "virtual data members" as data members by changing their references into function calls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When the compiler sees a data member declared with this attribute on the right of a member-selection operator ("**.**" or "**->**"), it converts the operation to a **get** or **put** function, depending on whether such an expression is an l-value or an r-value. In more complicated contexts, such as "<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>", a rewrite is performed by doing both **get** and **put**.  
  
 This attribute can also be used in the declaration of an empty array in a class or structure definition. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The above statement indicates that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be used with one or more array indices. In this case, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will be turned into <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will be turned into <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 **END Microsoft Specific**  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)