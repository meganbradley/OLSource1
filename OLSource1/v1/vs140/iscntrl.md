---
title: "iscntrl"
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
  - "std.iscntrl"
  - "locale/std::iscntrl"
  - "std::iscntrl"
  - "iscntrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iscntrl function"
  - "iscntrl"
ms.assetid: 34f33027-0129-42d7-a3a1-b63500ecae62
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iscntrl
Tests whether an element in a locale is a control character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale containing the element to be tested.  
  
## Return Value  
 **true** if the element tested is a control character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**cntrl**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std