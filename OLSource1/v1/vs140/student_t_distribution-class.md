---
title: "student_t_distribution Class"
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
  - "std::tr1::student_t_distribution"
  - "tr1::student_t_distribution"
  - "std.tr1.student_t_distribution"
  - "random/std::tr1::student_t_distribution"
  - "tr1.student_t_distribution"
  - "student_t_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "student_t_distribution class"
ms.assetid: 87b48127-9311-4d07-95df-833ed46bf0b1
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# student_t_distribution Class
Generates a Student's             *t*-distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The floating-point result type, defaults to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 The template class describes a distribution that produces values of a user-specified integral type, or type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if none is provided, distributed according to the Student's                 *t*-Distribution. The following table links to articles about individual members.  
  
||||  
|-|-|-|  
|[student_t_distribution::student_t_distribution](#student_t_distribution__student_t_distribution)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>||[student_t_distribution::param_type](#student_t_distribution__param_type)|  
  
 The property function <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns the value for the stored distribution parameter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
 For detailed information about the Student's                 *t*-distribution, see the Wolfram MathWorld article                 [Students t-Distribution](http://go.microsoft.com/fwlink/?LinkId=401094).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="student_t_distribution__student_t_distribution">\</a>  student_t_distribution::student_t_distribution  
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
  
##  \<a name="student_t_distribution__param_type">\</a>  student_t_distribution::param_type  
 Stores all the parameters of the distribution.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [student_t_distribution Class](../vs140/student_t_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)