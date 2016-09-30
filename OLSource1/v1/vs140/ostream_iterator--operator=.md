---
title: "ostream_iterator::operator="
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
  - "std::ostream_iterator::operator="
  - "="
  - "operator="
  - "ostream_iterator.operator="
  - "std.ostream_iterator.operator="
  - "iterator/std::ostream_iterator::operator="
  - "ostream_iterator::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, iterators"
  - "operator =, iterators"
  - "= operator, with specific standard C++ library objects"
ms.assetid: a6be16e4-c6d7-4909-bcb7-373483c8aecb
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator::operator=
Assignment operator used to implement the output_iterator expression *<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for writing to an output stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value of the object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to be inserted into the output stream.  
  
## Return Value  
 The operator inserts <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> into the output stream associated with the object, followed by the delimiter specified in the [ostream_iterator constructor](../vs140/ostream_iterator--ostream_iterator.md) (if any), and then returns a reference to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The requirements for an output iterator that the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must satisfy require only the expression *<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> be valid and says nothing about the operator or the operator= on their own. This member operator returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
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