---
title: "islower"
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
  - "islower"
  - "std.islower"
  - "locale/std::islower"
  - "std::islower"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "islower"
  - "islower function"
ms.assetid: b95bf7f6-dd52-4174-8a29-19c6980bd6a8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# islower
Tests whether an element in a locale is lower case.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
## Return Value  
 **true** if the element tested is a lowercase character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). [is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**lower**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std