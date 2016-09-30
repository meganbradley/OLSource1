---
title: "range_adapter::range_adapter (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "range_adapter::range_adapter (STL/CLR)"
f1_keywords: 
  - "cliext::range_adapter::range_adapter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "range_adapter member [STL/CLR]"
ms.assetid: b16af13f-3358-4e82-927d-d0d4986bcb18
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# range_adapter::range_adapter (STL-CLR)
Constructs an adapter object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 first  
 First iterator to wrap.  
  
 last  
 Second iterator to wrap.  
  
 right  
 Object to copy.  
  
## Remarks  
 The constructor:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 initializes the stored iterator pair with default constructed iterators.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 initializes the stored iterator pair by copying the pair stored in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 initializes the stored iterator pair by copying the pair stored in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 initializes the stored iterator pair with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
 **a b c**  
 **a b c**   
## Requirements  
 **Header:** \<cliext/adapter>  
  
 **Namespace:** cliext  
  
## See Also  
 [range_adapter](../vs140/range_adapter--stl-clr-.md)   
 [operator=](../vs140/range_adapter--operator=--stl-clr-.md)