---
title: "codecvt_byname Class"
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
  - "std.codecvt_byname"
  - "codecvt_byname"
  - "std::codecvt_byname"
  - "xlocale/std::codecvt_byname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "codecvt_byname class"
ms.assetid: b63b6c04-f60c-47b9-8e30-a933f24a8ffb
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt_byname Class
A derived template class that describes an object that can serve as a collate facet of a given locale, enabling the retrieval of information specific to a cultural area concerning conversions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A named locale.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An initial reference count.  
  
## Remarks  
 Byname facets are automatically created when a named locale is constructed.  
  
 Its behavior is determined by the named locale <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Each constructor initializes its base object with [codecvt](../vs140/codecvt-class.md)\<CharType, Byte, StateType>( <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)