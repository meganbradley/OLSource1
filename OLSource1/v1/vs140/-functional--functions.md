---
title: "&lt;functional&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c34d0b45-50a7-447a-9368-2210d06339a4
caps.latest.revision: 12
---
# &lt;functional&gt; functions
||||  
|-|-|-|  
|[bind Function](#bind_function)|[bind1st Function](#bind1st_function)|[bind2nd Function](#bind2nd_function)|  
|[bit_and Function](#bit_and_function)|[bit_not Function](#bit_not_function)|[bit_or Function](#bit_or_function)|  
|[bit_xor Function](#bit_xor_function)|[cref Function](#cref_function)|[mem_fn Function](#mem_fn_function)|  
|[mem_fun Function](#mem_fun_function)|[mem_fun_ref Function](#mem_fun_ref_function)|[not1 Function](#not1_function)|  
|[not2 Function](#not2_function)|[ptr_fun Function](#ptr_fun_function)|[ref Function](#ref_function)|  
|[swap Function](#swap_function)|  
  
##  \<a name="bind_function">\</a>  bind Function  
 Binds arguments to a callable object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The type of the object to call.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The type of the Nth call argument.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The object to call.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The Nth call argument.  
  
### Remarks  
 The types <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> must be copy constructible, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> must be a valid expression for some values <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 The first template function returns a forwarding call wrapper <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> with a weak result type. The effect of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> [result_of](../vs140/result_of-class2.md)<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is the cv-qualifiers of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and the values and types of the bound arguments <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> are determined as specified below. You use it to bind arguments to a callable object to make a callable object with a tailored argument list.  
  
 The second template function returns a forwarding call wrapper <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> with a nested type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> that is a synonym for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. The effect of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is the cv-qualifiers of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and the values and types of the bound arguments <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> are determined as specified below. You use it to bind arguments to a callable object to make a callable object with a tailored argument list and with a specified return type.  
  
 The values of the bound arguments <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and their corresponding types <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> depend on the type of the corresponding argument <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> in the call to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> and the cv-qualifiers <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> of the call wrapper <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> as follows:  
  
 if <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> the argument <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>;  
  
 if the value of <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> the argument <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>;  
  
 if the value <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is not zero the argument <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>;  
  
 otherwise the argument <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and its type <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
 For example, given a function <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> the expression <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> returns a forwarding call wrapper <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. The expression <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> returns a forwarding call wrapper <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
 The number of arguments in a call to <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> in addition to the argument <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> must be equal to the number of arguments that can be passed to the callable object <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. Thus, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is correct, and both <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> are incorrect.  
  
 The number of arguments in the function call to the call wrapper returned by <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> must be at least as large as the highest numbered value of <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> for all of the placeholder arguments in the call to <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. Thus, <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is correct (and returns <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>), and <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is incorrect.  
  
### Example  
  
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
##  \<a name="bind1st_function">\</a>  bind1st Function  
 A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the first argument of the binary function to a specified value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The binary function object to be converted to a unary function object.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The value to which the first argument of the binary function object is to be bound.  
  
### Return Value  
 The unary function object that results from binding the first argument of the binary function object to the value <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
### Remarks  
 Function binders are a kind of function adaptor and, because they return function objects, can be used in certain types of function composition to construct more complicated and powerful expressions.  
  
 If <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is an object of type <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> is a constant, then <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>) is equivalent to the [binder1st](../vs140/binder1st-class.md) class constructor <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>> ( <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>) and is more convenient.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The vector v1 = ( 0 5 10 15 20 25 )**  
**The number of elements in v1 greater than 10 is: 3.**  
**The number of elements in v1 greater than 5 is: 4.**  
**The number of elements in v1 less than 10 is: 2.**    
##  \<a name="bind2nd_function">\</a>  bind2nd Function  
 A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the second argument of the binary function to a specified value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The binary function object to be converted to a unary function object.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The value to which the second argument of the binary function object is to be bound.  
  
### Return Value  
 The unary function object that results from binding the second argument of the binary function object to the value <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
### Remarks  
 Function binders are a kind of function adaptor and, because they return function objects, can be used in certain types of function composition to construct more complicated and powerful expressions.  
  
 If <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> is an object of type **Operation** and <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is a constant, then <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> ) is equivalent to the [binder2nd](../vs140/binder2nd-class.md) class constructor **binder2nd\<Operation>** ( <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> ) and more convenient.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The vector v1 = ( 0 5 10 15 20 25 )**  
**The number of elements in v1 greater than 10 is: 3.**  
**The number of elements in v1 greater than 15 is: 2.**  
**The number of elements in v1 less than 10 is: 2.**    
##  \<a name="bit_and_function">\</a>  bit_and Function  
 A predefined function object that performs the bitwise AND operation (binary <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>) on its arguments.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Any type that supports an <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The left operand of the bitwise AND operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The right operand of the bitwise AND operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>.  
  
### Return Value  
 The result of <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> functor is restricted to integral types for the basic data types, or to user-defined types that implement binary <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>.  
  
##  \<a name="bit_not_function">\</a>  bit_not Function  
 A predefined function object that performs the bitwise complement (NOT) operation (unary <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>) on its argument.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 A type that supports a unary <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The operand of the bitwise complement operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of an lvalue or rvalue reference argument of inferred type <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
### Return Value  
 The result of <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> functor is restricted to integral types for the basic data types, or to user-defined types that implement binary <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
##  \<a name="bit_or_function">\</a>  bit_or Function  
 A predefined function object that performs the bitwise OR operation ( <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>) on its arguments.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 Any type that supports an <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The left operand of the bitwise OR operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The right operand of the bitwise OR operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
### Return Value  
 The result of <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> functor is restricted to integral types for the basic data types, or to user-defined types that implement <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
##  \<a name="bit_xor_function">\</a>  bit_xor Function  
 A predefined function object that performs the bitwise XOR operation (binary <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>) on its arguments.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Any type that supports an <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> that takes operands of the specified or inferred types.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The left operand of the bitwise XOR operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The right operand of the bitwise XOR operation. The unspecialized template takes an lvalue reference argument of type <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of lvalue and rvalue reference arguments of inferred type <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
### Return Value  
 The result of <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>. The specialized template does perfect forwarding of the result, which has the type that's returned by <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> functor is restricted to integral types for the basic data types, or to user-defined types that implement binary <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
##  \<a name="cref_function">\</a>  cref Function  
 Constructs a const <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> from an argument.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 The type of the argument to wrap.  
  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 The argument to wrap.  
  
### Remarks  
 The first function returns <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>. You use it to wrap a const reference. The second function returns <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>. You use it to rewrap a wrapped reference as a const reference.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **i = 1**  
**cref(i) = 1**  
**cref(neg)(i) = -1**    
##  \<a name="mem_fn_function">\</a>  mem_fn Function  
 Generates a simple call wrapper.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 The return type of the wrapped function.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The type of the member function pointer.  
  
### Remarks  
 The template function returns a simple call wrapper <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, with a weak result type, such that the expression <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>. It does not throw any exceptions.  
  
 The returned call wrapper is derived from <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> (hence defining the nested type <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> and the nested type <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>) only if the type <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> is a pointer to member function with cv-qualifier <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> that takes no arguments.  
  
 The returned call wrapper is derived from <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> (hence defining the nested type <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>, the nested type <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>, and the nested type <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>) only if the type <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> is a pointer to member function with cv-qualifier <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> that takes one argument, of type <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **3^2 == 9**  
**3\*2 == 6**    
##  \<a name="mem_fun_function">\</a>  mem_fun Function  
 Helper template functions used to construct function object adaptors for member functions when initialized with pointer arguments.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 A pointer to the member function of class **Type** to be converted to a function object.  
  
### Return Value  
 A **const** or **non_const** function object of type <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="mem_fun_ref_function">\</a>  mem_fun_ref Function  
 Helper template functions used to construct function object adaptors for member functions when initialized by using reference arguments.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 A pointer to the member function of class <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> to be converted to a function object.  
  
### Return Value  
 A <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> function object of type <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **The original values stored in v1 are: 1 2 3 4 5 6 7 8 9 10 11 12 13**   
**With the primes removed, the remaining values in v1 are: 4 6 8 9 10 12**   
**The original values stored in v2 are: 1 2 3 4 5 6 7 8 9 10 11 12 13**   
**With the even numbers removed, the remaining values are: 1 3 5 7 9 11 13**     
##  \<a name="not1_function">\</a>  not1 Function  
 Returns the complement of a unary predicate.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 The unary predicate to be negated.  
  
### Return Value  
 A unary predicate that is the negation of the unary predicate modified.  
  
### Remarks  
 If a <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> is constructed from a unary predicate **Pred**(                        *x*), then it returns **!Pred**(                        *x*).  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **The vector v1 = ( 0 5 10 15 20 25 30 35 )**  
**The number of elements in v1 greater than 10 is: 5.**  
**The number of elements in v1 not greater than 10 is: 3.**    
##  \<a name="not2_function">\</a>  not2 Function  
 Returns the complement of a binary predicate.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 The binary predicate to be negated.  
  
### Return Value  
 A binary predicate that is the negation of the binary predicate modified.  
  
### Remarks  
 If a <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> is constructed from a binary predicate **BinPred**(                        *x*,                         *y*), then it returns ! **BinPred**(                        *x*,                         *y*).  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **Original vector v1 = ( 6262 6262 41 18467 6334 26500 19169 )**  
**Sorted vector v1 = ( 41 6262 6262 6334 18467 19169 26500 )**  
**Resorted vector v1 = ( 26500 19169 18467 6334 6262 6262 41 )**    
##  \<a name="ptr_fun_function">\</a>  ptr_fun Function  
 Helper template functions used to convert unary and binary function pointers, respectively, into unary and binary adaptable functions.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 The unary or binary function pointer to be converted to an adaptable function.  
  
### Return Value  
 The first template function returns the unary function [pointer_to_unary_function](../vs140/pointer_to_unary_function-class.md) < <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>, **Result**>(* <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>).  
  
 The second template function returns binary function [pointer_to_binary_function](../vs140/pointer_to_binary_function-class.md) \< **Arg1**, **Arg2**, **Result**>(* <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>).  
  
### Remarks  
 A function pointer is a function object and may be passed to any Standard Template Library algorithm that is expecting a function as a parameter, but it is not adaptable. To use it with an adaptor, such as binding a value to it or using it with a negator, it must be supplied with the nested types that make such an adaptation possible. The conversion of unary and binary function pointers by the <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> helper function allows the function adaptors to work with unary and binary function pointers.  
  
### Example  
 [!code[functional_ptr_fun#1](../vs140/codesnippet/CPP/-functional--functions_1.cpp)]  
  
##  \<a name="ref_function">\</a>  ref Function  
 Constructs a <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> from an argument.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A reference to <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>; specifically, <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>.  
  
### Example  
  The following example defines two functions: one bound to a string variable, the other bound to a reference of the string variable computed by a call to <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>. When the value of the variable changes, the first function continues to use the old value and the second function uses the new value.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **tiger cat lion cougar**  
**tiger lion cougar**  
**tiger lion cougar**  
**tiger cougar**    
##  \<a name="swap_function">\</a>  swap Function  
 Swaps two <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 The type controlled by the function objects.  
  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
 The first function object.  
  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
 The second function object.  
  
### Remarks  
 The function returns <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  **empty == false**  
**val == -3**  
**empty == true**  
**empty == true**  
**empty == false**  
**val == -3**    
## See Also  
 [&lt;functional&gt;](../vs140/-functional-.md)