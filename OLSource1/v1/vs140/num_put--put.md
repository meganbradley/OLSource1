---
title: "num_put::put"
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
  - "std::num_put::put"
  - "xlocnum/std::num_put::put"
  - "std.num_put.put"
  - "num_put.put"
  - "num_put::put"
  - "put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put method"
ms.assetid: f8168dc4-dcff-41d4-af02-3e2d36bd7029
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# num_put::put
Converts a number into a sequence of **CharType**s that represents the number formatted for a given locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An iterator addressing the first element of the inserted string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specified the stream that contains locale with the numpunct facet used to punctuate the output and flags for formatting the output.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A character that is used for spacing.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number or Boolean type that is to be output.  
  
## Return Value  
 An output iterator the addresses the position one beyond the last element produced.  
  
## Remarks  
 All member functions return [do_put](../vs140/num_put--do_put.md)(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The thousands separator is: .**  
**num_put( ) = 1.000,67**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [num_put Class](../vs140/num_put-class.md)