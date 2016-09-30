---
title: "ispunct"
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
  - "std::ispunct"
  - "locale/std::ispunct"
  - "std.ispunct"
  - "ispunct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ispunct function"
  - "ispunct"
ms.assetid: 4239da1d-1dee-4f8a-b845-8d04f8c5445d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ispunct
Tests whether an element in a locale is a punctuation character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
## Return Value  
 **true** if the element tested is a punctuation character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[ctype](../vs140/ctype-class.md)\<**CharType**> >(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**punct**, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std