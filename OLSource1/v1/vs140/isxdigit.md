---
title: "isxdigit"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "locale/std::isxdigit"
  - "std::isxdigit"
  - "isxdigit"
  - "std.isxdigit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isxdigit"
  - "isxdigit function"
ms.assetid: f8e323cd-1b83-40c2-b62a-6af0cbbd0d02
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isxdigit
Tests whether an element in a locale is a character used to represent a hexadecimal number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
## Return Value  
 **true** if the element tested is a character used to represent a hexadecimal number; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\< **CharType**> >(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**xdigit**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
 Hexadecimal digits use base 16 to represent numbers, using the numbers 0 through 9 plus case-insensitive letters A through F to represent the decimal numbers 0 through 15.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std