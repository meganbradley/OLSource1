---
title: "isalpha"
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
  - "isalpha"
  - "std.isalpha"
  - "std::isalpha"
  - "locale/std::isalpha"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isalpha"
  - "isalpha function"
ms.assetid: 86cecb0a-7bd0-4925-bba1-43ddfe9321d8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isalpha
Tests whether an element in a locale is an alphabetic character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale containing the alphabetic element to be tested.  
  
## Return Value  
 **true** if the element tested is alphabetic; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**alpha**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std