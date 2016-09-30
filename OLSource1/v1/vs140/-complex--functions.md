---
title: "&lt;complex&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 58b14e94-0e0c-493e-8237-8b4d685904a2
caps.latest.revision: 14
---
# &lt;complex&gt; functions
||||  
|-|-|-|  
|[Functions tan](#functions_tan)|[abs](#abs)|[arg](#arg)|  
|[conj](#conj)|[cos](#cos)|[cosh](#cosh)|  
|[exp](#exp)|[imag](#imag)|[log](#log)|  
|[log10](#log10)|[norm](#norm)|[polar](#polar)|  
|[pow](#pow)|[real](#real)|[sin](#sin)|  
|[sinh](#sinh)|[sqrt](#sqrt)|[tanh](#tanh)|  
  
##  \<a name="abs">\</a>  abs  
 Calculates the modulus of a complex number.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The complex number whose modulus is to be determined.  
  
### Return Value  
 The modulus of a complex number.  
  
### Remarks  
 The *modulus* of a complex number is a measure of the length of the vector representing the complex number. The modulus of a complex number                         a + bi is                         sqrt (a<sup>2\</sup> + b<sup>2\</sup>),  written                         &#124;a + bi&#124;. The *norm* of a complex number                         a + bi is (a<sup>2\</sup> + b<sup>2\</sup>), so the modulus of a complex number is the square root of its norm.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The modulus of c1 is recovered from c1 using: abs ( c1 ) = 5**  
**Argument of c1 is recovered from c1 using:**  
 **arg ( c1 ) = 0 radians, which is 0 degrees.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**  
**The complex numbers c2 & c3 have the same principal arguments.**    
##  \<a name="arg">\</a>  arg  
 Extracts the argument from a complex number.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The complex number whose argument is to be determined.  
  
### Return Value  
 The argument of the complex number.  
  
### Remarks  
 The argument is the angle that the complex vector makes with the positive real axis in the complex plane. For a complex number                         *a + bi*, the argument is equal to arctan(                        *b/a*)                        *.* The angle has a positive sense when measured in a counterclockwise direction from the positive real axis and a negative sense when measured in a clockwise direction. The principal values are greater than –pi and less than or equal to +pi.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The modulus of c1 is recovered from c1 using: abs ( c1 ) = 5**  
**Argument of c1 is recovered from c1 using:**  
 **arg ( c1 ) = 0 radians, which is 0 degrees.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**  
**The complex numbers c2 & c3 have the same principal arguments.**    
##  \<a name="conj">\</a>  conj  
 Returns the complex conjugate of a complex number.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The complex number whose complex conjugate is being returned.  
  
### Return Value  
 The complex conjugate of the input complex number.  
  
### Remarks  
 The complex conjugate of a complex number                         *a + bi* is                         *a – bi*. The product of a complex number and its conjugate is the norm of the number                         *a*2 +                         *b*2.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The complex number c1 = (4,3)**  
**The real part of c1 is real ( c1 ) = 4.**  
**The imaginary part of c1 is imag ( c1 ) = 3.**  
**The complex conjugate of c1 is c2 = conj ( c1 )= (4,-3)**  
**The real part of c2 is real ( c2 ) = 4.**  
**The imaginary part of c2 is imag ( c2 ) = -3.**  
**The norm of (c1 \* conj (c1) ) is c1 \* c2 = 25**    
##  \<a name="cos">\</a>  cos  
 Returns the cosine of a complex number.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The complex number whose cosine is being determined.  
  
### Return Value  
 The complex number that is the cosine of the input complex number.  
  
### Remarks  
 Identities defining the complex cosines:  
  
 cos (                        *z*) = (1/2)\*( exp (                        *iz*) + exp (- *iz*) )  
  
 cos (                        *z*) = cos (                        *a* +                         *bi*) = cos (                        *a*) cosh (                        *b*) - isin (                        *a*) sinh (                        *b*)  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **Complex number c1 = (3,4)**  
**Complex number c2 = cos ( c1 ) = (-27.0349,-3.85115)**  
**The modulus of c2 is: 27.3079**  
**The argument of c2 is: -3.00009 radians, which is -171.893 degrees.**  
**The complex components cos (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.730543,-0.39695)**  
**(1.22777,-0.469075)**  
**(1.54308,1.21529e-013)**  
**(1.22777,0.469075)**  
**(0.730543,0.39695)**  
**(0.540302,-1.74036e-013)**    
##  \<a name="cosh">\</a>  cosh  
 Returns the hyperbolic cosine of a complex number.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The complex number whose hyperbolic cosine is being determined.  
  
### Return Value  
 The complex number that is the hyperbolic cosine of the input complex number.  
  
### Remarks  
 Identities defining the complex hyperbolic cosines:  
  
 cos (                        *z*) = (1/2)\*( exp (                        *z*) + exp (- *z*) )  
  
 cos (                        *z*) = cosh (                        *a + bi*) = cosh (                        *a*) cos (                        *b*) + isinh (                        *a*) sin (                        *b*)  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **Complex number c1 = (3,4)**  
**Complex number c2 = cosh ( c1 ) = (-6.58066,-7.58155)**  
**The modulus of c2 is: 10.0392**  
**The argument of c2 is: -2.28564 radians, which is -130.957 degrees.**  
**The complex components cosh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(1.22777,0.469075)**  
**(0.730543,0.39695)**  
**(0.540302,-8.70178e-014)**  
**(0.730543,-0.39695)**  
**(1.22777,-0.469075)**  
**(1.54308,2.43059e-013)**    
##  \<a name="exp">\</a>  exp  
 Returns the exponential function of a complex number.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The complex number whose exponential is being determined.  
  
### Return Value  
 The complex number that is the exponential of the input complex number.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="imag">\</a>  imag  
 Extracts the imaginary component of a complex number.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The complex number whose real part is to be extracted.  
  
### Return Value  
 The imaginary part of the complex number as a global function.  
  
### Remarks  
 This template function cannot be used to modify the real part of the complex number. To change the real part, a new complex number must be assigned the component value.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The complex number c1 = (4,3)**  
**The real part of c1 is real ( c1 ) = 4.**  
**The imaginary part of c1 is imag ( c1 ) = 3.**    
##  \<a name="log">\</a>  log  
 Returns the natural logarithm of a complex number.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The complex number whose natural logarithm is being determined.  
  
### Return Value  
 The complex number that is the natural logarithm of the input complex number.  
  
### Remarks  
 The branch cuts are along the negative real axis.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="log10">\</a>  log10  
 Returns the base 10 logarithm of a complex number.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The complex number whose base 10 logarithm is being determined.  
  
### Return Value  
 The complex number that is the base 10 logarithm of the input complex number.  
  
### Remarks  
 The branch cuts are along the negative real axis.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="norm">\</a>  norm  
 Extracts the norm of a complex number.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The complex number whose norm is to be determined.  
  
### Return Value  
 The norm of a complex number.  
  
### Remarks  
 The norm of a complex number                         *a + bi* is                         *(a*<sup>2\</sup> *+ b*<sup>2\</sup>*).* The norm of a complex number is the square of its modulus. The modulus of a complex number is a measure of the length of the vector representing the complex number. The modulus of a complex number                         *a + bi* is <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>*(a*<sup>2\</sup> *+ b*<sup>2\</sup>*),* written                         *&#124;a + bi&#124;.*  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The complex numbers c2 & c3 have the same principal arguments.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**  
**The norm of c2 given by: norm ( c2 ) = 25**  
**The modulus of c2 is the square root of the norm: sqrt ( normc2 ) = 5.**    
##  \<a name="polar">\</a>  polar  
 Returns the complex number, which corresponds to a specified modulus and argument, in Cartesian form.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *_Modulus*  
 The modulus of the complex number being input.  
  
 *_Argument*  
 The argument of the complex number being input.  
  
### Return Value  
 Cartesian form of the complex number specified in polar form.  
  
### Remarks  
 The polar form of a complex number provides the modulus                         *r* and the argument , where these parameters are related to the real and imaginary Cartesian components                         *a* and                         *b* by the equations                         *a* = r \* cos (  ) and b =                         *r* \* sin ()                        *.*  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The complex numbers c2 & c3 have the same principal arguments.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**    
##  \<a name="pow">\</a>  pow  
 Evaluates the complex number obtained by raising a base that is a complex number to the power of another complex number.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The complex number or number that is of the parameter type for the complex number that is the base to be raised to a power by the member function.  
  
 *_Power*  
 The integer or complex number or number that is of the parameter type for the complex number that is the power that the base is to be raised to by the member function.  
  
### Return Value  
 The complex number obtained by raising the specified base to the specified power.  
  
### Remarks  
 The functions each effectively convert both operands to the return type, and then return the converted **left** to the power **right**.  
  
 The branch cut is along the negative real axis.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **Complex number for base cb1 = (3,4)**  
**Integer for power = 2**  
**Complex number returned from complex base and integer power:**  
 **ce1 = cb1 ^ cp1 = (-7,24)**  
**The modulus of ce1 is: 25**  
**The argument of ce1 is: 1.85459 radians, which is 106.26 degrees.**  
**Complex number for base cb2 = (3,4)**  
**Type double for power cp2 = pi = 3.14159**  
**Complex number returned from complex base and double power:**  
 **ce2 = cb2 ^ cp2 = (-152.915,35.5475)**  
**The modulus of ce2 is: 156.993**  
**The argument of ce2 is: 2.91318 radians, which is 166.913 degrees.**  
**Complex number for base cb3 = (3,4)**  
**Complex number for power cp3= (-2,1)**  
**Complex number returned from complex base and complex power:**  
 **ce3 = cb3 ^ cp3 = (0.0153517,-0.00384077)**  
**The modulus of ce3 is: 0.0158249**  
**The argument of ce3 is: -0.245153 radians, which is -14.0462 degrees.**  
**Type double for base cb4 = pi = 3.14159**  
**Complex number for power cp4 = (2,-1)**  
**Complex number returned from double base and complex power:**  
 **ce4 = cb4 ^ cp4 = (4.07903,-8.98725)**  
**The modulus of ce4 is: 9.8696**  
**The argument of ce4 is: -1.14473 radians, which is -65.5882 degrees.**    
##  \<a name="real">\</a>  real  
 Extracts the real component of a complex number.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The complex number whose real part is to be extracted.  
  
### Return Value  
 The real part of the complex number as a global function.  
  
### Remarks  
 This template function cannot be used to modify the real part of the complex number. To change the real part, a new complex number must be assigned the component value.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  **The complex number c1 = (4,3)**  
**The real part of c1 is real ( c1 ) = 4.**  
**The imaginary part of c1 is imag ( c1 ) = 3.**    
##  \<a name="sin">\</a>  sin  
 Returns the sine of a complex number.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The complex number whose sine is being determined.  
  
### Return Value  
 The complex number that is the sine of the input complex number.  
  
### Remarks  
 Identities defining the complex sines:  
  
 sin (                        *z*) = (1/2 *i*)\*( exp (                        *iz*) – exp (- *iz*) )  
  
 sin (                        *z*) = sin (                        *a + bi*) = sin (                        *a*) cosh (                        *b*) + icos (                        *a*) sinh (                        *b*)  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **Complex number c1 = (3,4)**  
**Complex number c2 = sin ( c1 ) = (3.85374,-27.0168)**  
**The modulus of c2 is: 27.2903**  
**The argument of c2 is: -1.42911 radians, which is -81.882 degrees.**  
**The complex components sin (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.85898,0.337596)**  
**(0.670731,0.858637)**  
**(-1.59572e-013,1.1752)**  
**(-0.670731,0.858637)**  
**(-0.85898,0.337596)**  
**(-0.841471,-1.11747e-013)**    
##  \<a name="sinh">\</a>  sinh  
 Returns the hyperbolic sine of a complex number.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The complex number whose hyperbolic sine is being determined.  
  
### Return Value  
 The complex number that is the hyperbolic sine of the input complex number.  
  
### Remarks  
 Identities defining the complex hyperbolic sines:  
  
 sinh (                        *z*) = (1/2)\*( exp (                        *z*) – exp (- *z*) )  
  
 sinh (                        *z*) = sinh (                        *a + bi*) = sinh (                        *a*) cos (                        *b*) +                         *i*cosh (                        *a*) sin (                        *b*)  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  **Complex number c1 = (3,4)**  
**Complex number c2 = sinh ( c1 ) = (-6.54812,-7.61923)**  
**The modulus of c2 is: 10.0464**  
**The argument of c2 is: -2.28073 radians, which is -130.676 degrees.**  
**The complex components sinh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.858637,0.670731)**  
**(0.337596,0.85898)**  
**(-5.58735e-014,0.841471)**  
**(-0.337596,0.85898)**  
**(-0.858637,0.670731)**  
**(-1.1752,-3.19145e-013)**    
##  \<a name="sqrt">\</a>  sqrt  
 Calculates the square root of a complex number.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The complex number whose square root is to be found.  
  
### Return Value  
 The square root of a complex number.  
  
### Remarks  
 The square root will have a phase angle in the half-open interval (-pi/2, pi/2].  
  
 The branch cuts in the complex plane are along the negative real axis.  
  
 The square root of a complex number will have a modulus that is the square root of the input number and an argument that is one-half that of the input number.  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  **c1 = polar ( 5.0 ) = (-2.58529e-012,25)**  
**c2 = sqrt ( c1 ) = (3.53553,3.53553)**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.785398 radians, which is 45 degrees.**  
**The modulus of c2 = sqrt( abs ( c1 ) ) =5**  
**The argument of c2 = ( 1 / 2 ) \* arg ( c1 ) =0.785398 radians,**  
 **which is 45 degrees.**    
##  \<a name="functions_tan">\</a>  Functions tan  
 Returns the tangent of a complex number.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The complex number whose tangent is being determined.  
  
### Return Value  
 The complex number that is the tangent of the input complex number.  
  
### Remarks  
 Identities defining the complex cotangent:  
  
 tan (                        *z*) = sin (                        *z*) / cos (                        *z*) = ( exp (                        *iz*) – exp (- *iz*) ) /                         *i*( exp (                        *iz*) + exp (- *iz*) )  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  **Complex number c1 = (3,4)**  
**Complex number c2 = tan ( c1 ) = (-0.000187346,0.999356)**  
**The modulus of c2 is: 0.999356**  
**The argument of c2 is: 1.57098 radians, which is 90.0107 degrees.**  
**The complex components tan (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.713931,0.85004)**  
**(0.24356,0.792403)**  
**(-4.34302e-014,0.761594)**  
**(-0.24356,0.792403)**  
**(-0.713931,0.85004)**  
**(-1.55741,-7.08476e-013)**    
##  \<a name="tanh">\</a>  tanh  
 Returns the hyperbolic tangent of a complex number.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The complex number whose hyperbolic tangent is being determined.  
  
### Return Value  
 The complex number that is the hyperbolic tangent of the input complex number.  
  
### Remarks  
 Identities defining the complex hyperbolic cotangent:  
  
 tanh (                        *z*) = sinh (                        *z*) / cosh (                        *z*) = ( exp (                        *z*) – exp (- *z*) ) / ( exp (                        *z*) + exp (- *z*) )  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  **Complex number c1 = (3,4)**  
**Complex number c2 = tanh ( c1 ) = (1.00071,0.00490826)**  
**The modulus of c2 is: 1.00072**  
**The argument of c2 is: 0.00490474 radians, which is 0.281021 degrees.**  
**The complex components tanh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.792403,0.24356)**  
**(0.85004,0.713931)**  
**(-3.54238e-013,1.55741)**  
**(-0.85004,0.713931)**  
**(-0.792403,0.24356)**  
**(-0.761594,-8.68604e-014)**    
## See Also  
 [&lt;complex&gt;](../vs140/-complex-.md)