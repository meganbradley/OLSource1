---
title: "&lt;alg&gt; move"
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
  - "std::move"
  - "algorithm/std::move"
  - "move"
  - "std.move"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move function"
ms.assetid: 3e2ba411-48a8-42ce-b9b8-faa020f00645
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;alg&gt; move
Move elements associated with a specified range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An input iterator that indicates where to start the range of elements to move.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range of elements to move.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The output iterator that is to contain the moved elements.  
  
## Property Value/Return Value  
 Returns an output iterator to the first element that was not moved.  
  
## Remarks  
 The template function evaluates <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [move](assetId:///bfa07080-5187-4aa7-87b5-d2d2a3fc65ab)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> once for each <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the range <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, for strictly increasing values of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> starting with the lowest value. It then returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> designate regions of storage, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> must not be in the range <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)