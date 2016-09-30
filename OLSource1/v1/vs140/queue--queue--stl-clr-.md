---
title: "queue::queue (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "queue::queue (STL/CLR)"
f1_keywords: 
  - "cliext::queue::queue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "queue member [STL/CLR]"
ms.assetid: 6106c07f-d5eb-4f0b-82df-ee4e2e751047
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# queue::queue (STL-CLR)
Constructs a container adapter object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 right  
 Object to copy.  
  
 wrapped  
 Wrapped container to use.  
  
## Remarks  
 The constructor:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 creates an empty wrapped container. You use it to specify an empty initial controlled sequence.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 creates a wrapped container that is a copy of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the queue object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 creates a wrapped container that is a copy of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the queue object <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The constructor:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 uses the existing container <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as the wrapped container. You use it to construct a queue from an existing container.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **size() = 0**  
 **x x x x x**  
 **x x x x x**  
 **x x x x x**   
## Requirements  
 **Header:** \<cliext/queue>  
  
 **Namespace:** cliext  
  
## See Also  
 [queue](../vs140/queue--stl-clr-.md)   
 [assign](../vs140/queue--assign--stl-clr-.md)   
 [generic_container](../vs140/queue--generic_container--stl-clr-.md)   
 [operator=](../vs140/queue--operator=--stl-clr-.md)