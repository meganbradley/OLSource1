---
title: "seed_seq Class"
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
  - "tr1::seed_seq"
  - "std::tr1::seed_seq"
  - "tr1.seed_seq"
  - "seed_seq"
  - "std.tr1.seed_seq"
  - "random/std::tr1::seed_seq"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seed_seq class"
ms.assetid: cba114f7-9ac6-4f2f-b773-9c84805401d6
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# seed_seq Class
Stores a vector of unsigned integer values that can supply a randomized seed for a random-number engine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Types  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>   
The type of the elements of the seed sequence. A 32-bit unsigned integer type.  
  
## Constructors  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>   
Default constructor, initializes to have an empty internal sequence.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>   
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>   
Uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to set the internal sequence.                   
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be an integer type.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>   
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>   
Initializes the internal sequence using all elements in the input iterator range provided.                  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must be an integer type.  
  
## Members  
  
### Generating Functions  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>   
Populates the elements of the provided sequence using an internal algorithm. This algorithm is affected by the internal sequence with which <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> was initialized.                          
Does nothing if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
### Property Functions  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>   
Returns the number of elements in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>   
Copies the internal sequence into the output iterator <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## Example  
 The following code example exercises the three constructors and generates output from the resulting <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> instances when assigned to an array. For an example that uses <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> with a random number generator, see [\<random>](../vs140/-random-.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  **seed_seq::size(): 0**  
**seed_seq::param():**  
**Generating a sequence of 5 elements into an array:**  
**505382999**  
**163489202**  
**3932644188**  
**763126080**  
**73937346**  
**seed_seq::size(): 3**  
**seed_seq::param(): 1701 1729 1791**  
**Generating a sequence of 5 elements into an array:**  
**1730669648**  
**1954224479**  
**2809786021**  
**1172893117**  
**2393473414**  
**seed_seq::size(): 7**  
**seed_seq::param(): 65 32 66 32 67 32 68**  
**Generating a sequence of 5 elements into an array:**  
**3139879222**  
**3775111734**  
**1084804564**  
**2485037668**  
**1985355432**   
## Remarks  
 Member functions of this class do not throw exceptions.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)