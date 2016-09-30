---
title: "isspace"
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
  - "locale/std::isspace"
  - "isspace"
  - "std.isspace"
  - "std::isspace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isspace function"
  - "isspace"
ms.assetid: 3ac254c4-92aa-4238-882a-3a3fb576cdf5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isspace
Tests whether an element in a locale is a whitespace character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
## Return Value  
 **true** if the element tested is a whitespace character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**space**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std