---
title: "make_collection (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "make_collection (STL/CLR)"
f1_keywords: 
  - "cliext::make_collection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_collection function [STL/CLR]"
ms.assetid: c25fb0cb-ebd8-4198-a565-bad28d32ee19
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_collection (STL-CLR)
Make a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> from an iterator pair.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Iter  
 The type of the wrapped iterators.  
  
 first  
 First iterator to wrap.  
  
 last  
 Second iterator to wrap.  
  
## Remarks  
 The template function returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to construct a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object from a pair of iterators.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**Count = 3**  
**IsSynchronized = False**  
**SyncRoot not nullptr = True**  
 **&#124; a b c &#124;**   
## Requirements  
 **Header:** \<cliext/adapter>  
  
 **Namespace:** cliext  
  
## See Also  
 [range_adapter](../vs140/range_adapter--stl-clr-.md)