---
title: "exponential_distribution Class"
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
  - "std::tr1::exponential_distribution"
  - "exponential_distribution"
  - "tr1::exponential_distribution"
  - "tr1.exponential_distribution"
  - "random/std::tr1::exponential_distribution"
  - "std.tr1.exponential_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exponential_distribution class [TR1]"
  - "exponential_distribution class"
ms.assetid: d54f3126-a09b-45f9-a30b-0d94d03bcdc9
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exponential_distribution Class
Generates an exponential distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if none is provided, distributed according to the Exponential Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[exponential_distribution::exponential_distribution](#exponential_distribution__exponential_distribution)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>||[exponential_distribution::param_type](#exponential_distribution__param_type)|  
  
 The property function <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the value for the stored distribution parameter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the exponential distribution, see the Wolfram MathWorld article                 [Exponential Distribution](http://go.microsoft.com/fwlink/?LinkId=401098).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="exponential_distribution__exponential_distribution">\</a>  exponential_distribution::exponential_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> distribution parameter.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The parameter package used to construct the distribution.  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value holds the value <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object whose stored parameters are initialized from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. You can obtain and set the current parameters of an existing distribution by calling the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member function.  
  
##  \<a name="exponential_distribution__param_type">\</a>  exponential_distribution::param_type  
 Stores the parameters of the distribution.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [exponential_distribution Class](../vs140/exponential_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)