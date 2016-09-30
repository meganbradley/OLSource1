---
title: "bind Function"
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
  - "bind"
  - "functional/std::tr1::bind"
  - "std.tr1.bind"
  - "std::tr1::bind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bind function [TR1]"
ms.assetid: a278b579-3802-4fad-a04a-2b4120a3862b
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bind Function
Binds arguments to a callable object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the object to call.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the Nth call argument.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The object to call.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The Nth call argument.  
  
## Remarks  
 The types <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must be copy constructible, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be a valid expression for some values <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The first template function returns a forwarding call wrapper <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with a weak result type. The effect of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> [result_of](../vs140/result_of-class2.md)<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is the cv-qualifiers of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the values and types of the bound arguments <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are determined as specified below. You use it to bind arguments to a callable object to make a callable object with a tailored argument list.  
  
 The second template function returns a forwarding call wrapper <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> with a nested type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> that is a synonym for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The effect of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is the cv-qualifiers of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and the values and types of the bound arguments <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are determined as specified below. You use it to bind arguments to a callable object to make a callable object with a tailored argument list and with a specified return type.  
  
 The values of the bound arguments <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and their corresponding types <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> depend on the type of the corresponding argument <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in the call to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and the cv-qualifiers <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> of the call wrapper <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> as follows:  
  
 if <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> the argument <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>;  
  
 if the value of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> the argument <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>;  
  
 if the value <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is not zero the argument <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>;  
  
 otherwise the argument <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 For example, given a function <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> the expression <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> returns a forwarding call wrapper <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. The expression <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> returns a forwarding call wrapper <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
 The number of arguments in a call to <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> in addition to the argument <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> must be equal to the number of arguments that can be passed to the callable object <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>. Thus, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is correct, and both <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> are incorrect.  
  
 The number of arguments in the function call to the call wrapper returned by <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> must be at least as large as the highest numbered value of <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> for all of the placeholder arguments in the call to <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. Thus, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is correct (and returns <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>), and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is incorrect.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1^2 == 1**  
**2^2 == 4**  
**3^2 == 9**  
**1\*2 == 2**  
**2\*2 == 4**  
**3\*2 == 6**  
**1^2 == 1**  
**2^2 == 4**  
**3^2 == 9**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [is_bind_expression](../vs140/is_bind_expression-class.md)   
 [_1](../vs140/_1-object.md)