---
title: "_bstr_t::operator +=, +"
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
  - "_bstr_t::operator+"
  - "_bstr_t::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+= operator, appending strings"
  - "+ operator, _bstr_t objects"
ms.assetid: d28316ce-c2c8-4a38-bdb3-44fa4e582c44
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bstr_t::operator +=, +
**Microsoft Specific**  
  
 Appends characters to the end of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object or concatenates two strings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *s1*  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 *s2*  
 A multibyte string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Unicode string.  
  
## Remarks  
 These operators perform string concatenation:  
  
-   **operator+=(**  *s1*  **)** Appends the characters in the encapsulated <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of *s1* to the end of this object's encapsulated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
-   **operator+(**  *s1*  **)** Returns the new <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that is formed by concatenating this object's <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with that of *s1*.  
  
-   **operator+(**  *s2*  **&#124;**  *s1*  **)** Returns a new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that is formed by concatenating a multibyte string *s2*, converted to Unicode, with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> encapsulated in *s1*.  
  
-   **operator+(**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **,**  *s1*  **)** Returns a new <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that is formed by concatenating a Unicode string <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> encapsulated in *s1*.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_bstr_t Class](../vs140/_bstr_t-class.md)