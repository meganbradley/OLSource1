---
title: "mersenne_twister_engine Class"
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
  - "random/std::tr1::mersenne_twister_engine"
  - "tr1.mersenne_twister_engine"
  - "std.tr1.mersenne_twister_engine"
  - "std::tr1::mersenne_twister_engine"
  - "tr1::mersenne_twister_engine"
  - "mersenne_twister_engine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mersenne_twister_engine class"
ms.assetid: 7ee968fa-a1cc-450f-890f-7305de062685
caps.latest.revision: 26
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# mersenne_twister_engine Class
Generates a high quality random sequence of integers based on the Mersenne twister algorithm.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The unsigned integer result type. For possible types, see [\<random>](../vs140/-random-.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Word size**. Size of each word, in bits, of the state sequence.                         **Precondition**: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **State size**. The number of elements (values) in the state sequence.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **Shift size**. The number of elements to skip during each twist.                         **Precondition**: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **Mask bits**.                         **Precondition**: <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 **XOR mask**.                         **Precondition**: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 **Tempering shift parameters**. Used as shift values during scrambling (tempering). Precondition: <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 **Tempering bit mask parameters**. Used as bit mask values during scrambling (tempering). Precondition: <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 **Initialization multiplier**. Used to help with initialization of the sequence. Precondition: <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Members  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is a member constant, defined as <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, used as the default parameter value for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and the single value constructor.  
  
 For more information about engine members, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 This template class describes a random number engine, returning values on the closed interval [ <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder><sup>W\</sup> - <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>]. It holds a large integral value with <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> bits. It extracts <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> bits at a time from this large value, and when it has used all the bits it twists the large value by shifting and mixing the bits so that it has a new set of bits to extract from. The engine's state is the last <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>-bit values used if <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> has been called at least <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> times, otherwise the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>-bit values that have been used and the last <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> values of the seed.  
  
 The generator twists the large value that it holds by using a twisted generalized feedback shift register defined by shift values <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, a twist value <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and a conditional XOR-mask <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. Additionally, the bits of the raw shift register are scrambled (tempered) according to a bit-scrambling matrix defined by values <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 The template argument <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> must be large enough to hold values up to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder><sup>W\</sup> - <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. The values of the other template arguments must satisfy the following requirements: <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 Although you can construct a generator from this engine directly, it is recommended you use one of these predefined typedefs:  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>: 32-bit Mersenne twister engine (Matsumoto and Nishimura, 1998).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>: 64-bit Mersenne twister engine (Matsumoto and Nishimura, 2000).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For detailed information about the Mersenne twister algorithm, see the Wikipedia article                 [Mersenne twister](http://go.microsoft.com/fwlink/?LinkId=402356).  
  
## Example  
 For a code example, see [\<random>](../vs140/-random-.md).  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)