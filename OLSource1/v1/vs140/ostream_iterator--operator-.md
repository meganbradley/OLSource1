---
title: "ostream_iterator::operator*"
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
  - "std::ostream_iterator::operator*"
  - "ostream_iterator.operator*"
  - "std.ostream_iterator.operator*"
  - "ostream_iterator::operator*"
  - "operator*"
  - "iterator/std::ostream_iterator::operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "* operator"
  - "operator*"
  - "* operator, with specific iterator expressions"
  - "multiplication operator, iterator expressions"
ms.assetid: 8ac7bd2f-23ae-446d-a94d-8efca1a2264d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator::operator*
Dereferencing operator used to implement the output iterator expression \**ii* = *x*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The requirements for an output iterator that the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must satisfy require only the expression \**ii* = *t* be valid and says nothing about the **operator** or the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on their own. The member operator in this implementation returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Elements written to output stream:**  
**10**  
**20**  
**30**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)