---
title: "uninitialized_copy"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "uninitialized_copy"
  - "memory/std::uninitialized_copy"
  - "std.uninitialized_copy"
  - "std::uninitialized_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uninitialized_copy"
  - "uninitialized_copy function"
ms.assetid: 23a09cb8-4116-475e-b0bb-5d3e7daca5aa
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uninitialized_copy
Copies objects from a specified source range into an uninitialized destination range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the source range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the source range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A forward iterator addressing the first element in the destination range.  
  
## Return Value  
 A forward iterator addressing the first position beyond the destination range, unless the source range was empty and iterator addresses *_First.*  
  
## Remarks  
 This algorithm allows the decoupling of memory allocation from object construction.  
  
 The template function effectively executes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std