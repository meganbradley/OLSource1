---
title: "bernoulli_distribution Class"
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
  - "tr1.bernoulli_distribution"
  - "random/std::tr1::bernoulli_distribution"
  - "std.tr1.bernoulli_distribution"
  - "bernoulli_distribution"
  - "tr1::bernoulli_distribution"
  - "std::tr1::bernoulli_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bernoulli_distribution class"
  - "bernoulli_distribution class [TR1]"
ms.assetid: 586bcde1-95ca-411a-bf17-4aaf19482f34
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bernoulli_distribution Class
Generates a Bernoulli distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The class describes a distribution that produces values of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, distributed according to the Bernoulli distribution discrete probability function. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[bernoulli_distribution::bernoulli_distribution](#bernoulli_distribution__bernoulli_distribution)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>||[bernoulli_distribution::param_type](#bernoulli_distribution__param_type)|  
  
 The property member <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns the currently stored distribution parameter value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the Bernoulli distribution discrete probability function, see the Wolfram MathWorld article                 [Bernoulli Distribution](http://go.microsoft.com/fwlink/?LinkId=398467).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="bernoulli_distribution__bernoulli_distribution">\</a>  bernoulli_distribution::bernoulli_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The stored <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> member function.  
  
 For more information and a code example, see [bernoulli_distribution Class](../vs140/binomial_distribution-class.md).  
  
##  \<a name="bernoulli_distribution__param_type">\</a>  bernoulli_distribution::param_type  
 Contains the parameters of the distribution.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [bernoulli_distribution Class](../vs140/bernoulli_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)