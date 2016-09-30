---
title: "&lt;valarray&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 109778fc-440e-4239-b23e-bafda2b165c2
caps.latest.revision: 13
---
# &lt;valarray&gt; functions
||||  
|-|-|-|  
|[abs](#abs)|[acos](#acos)|[asin](#asin)|  
|[atan](#atan)|[atan2](#atan2)|[cos](#cos)|  
|[cosh](#cosh)|[exp](#exp)|[log](#log)|  
|[log10](#log10)|[pow](#pow)|[sin](#sin)|  
|[sinh](#sinh)|[sqrt](#sqrt)|[swap](#swap)|  
|[tan](#tan)|[tanh](#tanh)|  
  
##  \<a name="abs">\</a>  abs  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The initial valarray is: 0 -1 -2 -3 4 5 6 7 8 .**  
**The absolute value of the initial valarray is: 0 1 2 3 4 5 6 7 8 .**    
##  \<a name="acos">\</a>  acos  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the arccosine of the elements of the input valarray.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the arccosine of the elements of the input valarray.  
  
### Remarks  
 The units of the returned elements are in radians.  
  
 The return value is a principal value between 0 and +pi that is consistent with the cosine value input.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The initial valarray is: -1 -0.75 -0.5 -0.25 0 0.25 0.5 0.75 1**  
**The arccosine of the initial valarray is:**  
 **3.14159  radians, which is          180  degrees**  
 **2.41886  radians, which is       138.59  degrees**  
 **2.0944  radians, which is          120  degrees**  
 **1.82348  radians, which is      104.478  degrees**  
 **1.5708  radians, which is           90  degrees**  
 **1.31812  radians, which is      75.5225  degrees**  
 **1.0472  radians, which is           60  degrees**  
 **0.722734  radians, which is      41.4096  degrees**  
 **0  radians, which is            0  degrees**    
##  \<a name="asin">\</a>  asin  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the arcsine of the elements of the input valarray.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the arcsine of the elements of the input valarray.  
  
### Remarks  
 The units of the returned elements are in radians.  
  
 The return value is a principal value between +pi/2 and –pi/2 that is consistent with the sine value input.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The initial valarray is: -1 -0.75 -0.5 -0.25 0 0.25 0.5 0.75 1**  
**The arcsine of the initial valarray is:**  
 **-1.5708  radians, which is          -90  degrees**  
 **-0.848062  radians, which is     -48.5904  degrees**  
 **-0.523599  radians, which is          -30  degrees**  
 **-0.25268  radians, which is     -14.4775  degrees**  
 **0  radians, which is            0  degrees**  
 **0.25268  radians, which is      14.4775  degrees**  
 **0.523599  radians, which is           30  degrees**  
 **0.848062  radians, which is      48.5904  degrees**  
 **1.5708  radians, which is           90  degrees**    
##  \<a name="atan">\</a>  atan  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the principal value of the arctangent of the elements of the input valarray.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the arctangent of the elements of the input valarray.  
  
### Remarks  
 The units of the returned elements are in radians.  
  
 The return value is a principal value between +pi/2 and –pi/2 that is consistent with the tangent value input.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The initial valarray is: -100 -3.75 -2.5 -1.25 0 1.25 2.5 3.75 100 .**  
**The arcsine of the initial valarray is:**  
 **-1.5608  radians, which is     -89.4271  degrees**  
 **-1.31019  radians, which is     -75.0686  degrees**  
 **-1.19029  radians, which is     -68.1986  degrees**  
 **-0.896055  radians, which is     -51.3402  degrees**  
 **0  radians, which is            0  degrees**  
 **0.896055  radians, which is      51.3402  degrees**  
 **1.19029  radians, which is      68.1986  degrees**  
 **1.31019  radians, which is      75.0686  degrees**  
 **1.5608  radians, which is      89.4271  degrees**    
##  \<a name="atan2">\</a>  atan2  
 Returns a valarray whose elements are equal to the arctangent of the Cartesian components specified by a combination of constants and elements of valarrays.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The constant numerical data type or input valarray whose elements provide the values for the y-coordinate of the arctangent argument.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The constant numerical data type or input valarray whose elements provide the values for the x-coordinate of the arctangent argument.  
  
### Return Value  
 A valarray whose elements <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> are equal to the arctangent of:  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> [                                 *I* ] /                                 *_Righ*t [                                 *I* ] for the first template function.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> [                                 *I* ] / <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> for the second template function.  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> [                                 *I* ] for the third template function.  
  
### Remarks  
 The units of the returned elements are in radians.  
  
 This function preserves information about the signs of the components in the argument that is lost by the standard tangent function, and this knowledge of the quadrant enables the return value to be assigned a unique angle between +pi and –pi.  
  
 If <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> have a different number of elements, the result is undefined.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The initial valarray for the x coordinate is: ( 1 -1 -1 1 ).**  
**The initial valarray for the y coordinate is: ( 1 1 -1 -1 ).**  
**The atan2 ( y / x ) of the initial valarrays is:**  
 **0.785398  radians, which is           45degrees**  
 **2.35619  radians, which is          135degrees**  
 **-2.35619  radians, which is         -135degrees**  
 **-0.785398  radians, which is          -45degrees**    
##  \<a name="cos">\</a>  cos  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the cosine of the elements of the input valarray.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The initial valarray is:**  
 **-3.14159  radians, which is   -180  degrees**  
 **-2.35619  radians, which is   -135  degrees**  
 **-1.5708  radians, which is    -90  degrees**  
 **-0.785398  radians, which is    -45  degrees**  
 **0  radians, which is      0  degrees**  
 **0.785398  radians, which is     45  degrees**  
 **1.5708  radians, which is     90  degrees**  
 **2.35619  radians, which is    135  degrees**  
 **3.14159  radians, which is    180  degrees**  
**The cosine of the initial valarray is:**  
**-1**  
**-0.707107**  
**-1.03412e-013**  
**0.707107**  
**1**  
**0.707107**  
**-1.03412e-013**  
**-0.707107**  
**-1**    
##  \<a name="cosh">\</a>  cosh  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the hyperbolic cosine of the elements of the input valarray.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the hyperbolic cosine of the elements of the input valarray.  
  
### Remarks  
 Identities defining the hyperbolic cosine in terms of exponential function:  
  
 cosh (                         *z* ) = ( exp (                         *z* ) + exp ( - *z* ) ) / 2  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The initial valarray is:**  
 **-3.14159  radians, which is   -180  degrees**  
 **-2.35619  radians, which is   -135  degrees**  
 **-1.5708  radians, which is    -90  degrees**  
 **-0.785398  radians, which is    -45  degrees**  
 **0  radians, which is      0  degrees**  
 **0.785398  radians, which is     45  degrees**  
 **1.5708  radians, which is     90  degrees**  
 **2.35619  radians, which is    135  degrees**  
 **3.14159  radians, which is    180  degrees**  
**The hyperbolic cosine of the initial valarray is:**  
**11.592**  
**5.32275**  
**2.50918**  
**1.32461**  
**1**  
**1.32461**  
**2.50918**  
**5.32275**  
**11.592**    
##  \<a name="exp">\</a>  exp  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the natural exponential of the elements of the input valarray.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the natural exponential of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **Initial valarray: -10 -7.5 -5 -2.5 0 2.5 5 7.5 10**  
**The natural exponential of the initial valarray is:**  
**4.53999e-005**  
**0.000553084**  
**0.00673795**  
**0.082085**  
**1**  
**12.1825**  
**148.413**  
**1808.04**  
**22026.5**    
##  \<a name="log">\</a>  log  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the natural logarithm of the elements of the input valarray.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **Initial valarray: 0 10 20 30 40 50 60 70 80**  
**The natural logarithm of the initial valarray is:**  
**-1.#INF**  
**2.30259**  
**2.99573**  
**3.4012**  
**3.68888**  
**3.91202**  
**4.09434**  
**4.2485**  
**4.38203**    
##  \<a name="log10">\</a>  log10  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the base 10 or common logarithm of the elements of the input valarray.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the common logarithm of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **Initial valarray: 0 10 20 30 40 50 60 70 80 90 100**  
**The common logarithm of the initial valarray is:**  
**-1.#INF**  
**1**  
**1.30103**  
**1.47712**  
**1.60206**  
**1.69897**  
**1.77815**  
**1.8451**  
**1.90309**  
**1.95424**  
**2**    
##  \<a name="pow">\</a>  pow  
 Operates on the elements of input valarrays and constants, returning a valarray whose elements are equal to a base specified either by the elements of an input valarray or a constant raised to an exponent specified either by the elements of an input valarray or a constant.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The input valarray whose elements supply the base for each element to be exponentiated.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The input valarray whose elements supply the power for each element to be exponentiated.  
  
### Return Value  
 A valarray whose elements <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> are equal to:  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> [                                 *I* ] raised to the power <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> [                                 *I* ] for the first template function.  
  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> [                                 *I* ] raised to the power <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> for the second template function.  
  
-   <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> raised to the power <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> [                                 *I* ] for the third template function.  
  
### Remarks  
 If <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> have a different number of elements, the result is undefined.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  **The initial valarray for the base is: ( 0 0 1 1 2 2 ).**  
**The initial valarray for the exponent is: ( 0 2 4 6 8 10 ).**  
**The power of (n/2) \* exp (2n) for n = 0 to n = 5 is:**  
**n = 0   gives 1**  
**n = 1   gives 0**  
**n = 2   gives 1**  
**n = 3   gives 1**  
**n = 4   gives 256**  
**n = 5   gives 1024**    
##  \<a name="sin">\</a>  sin  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the sine of the elements of the input valarray.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the sine of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  **The initial valarray is:**  
 **-3.14159   radians, which is    -180   degrees**  
 **-2.35619   radians, which is    -135   degrees**  
 **-1.5708   radians, which is     -90   degrees**  
 **-0.785398   radians, which is     -45   degrees**  
 **0   radians, which is       0   degrees**  
 **0.785398   radians, which is      45   degrees**  
 **1.5708   radians, which is      90   degrees**  
 **2.35619   radians, which is     135   degrees**  
 **3.14159   radians, which is     180   degrees**  
**The sine of the initial valarray is:**  
**2.06823e-013**  
**-0.707107**  
**-1**  
**-0.707107**  
**0**  
**0.707107**  
**1**  
**0.707107**  
**-2.06823e-013**    
##  \<a name="sinh">\</a>  sinh  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the hyperbolic sine of the elements of the input valarray.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the hyperbolic sine of the elements of the input valarray.  
  
### Remarks  
 Identities defining the hyperbolic sine in terms of exponential function:  
  
 sinh (                         *z* ) = ( exp (                         *z* ) – exp ( - *z* ) ) / 2  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  **The initial valarray is:**  
 **-3.14159   radians, which is    -180  degrees**  
 **-2.35619   radians, which is    -135  degrees**  
 **-1.5708   radians, which is     -90  degrees**  
 **-0.785398   radians, which is     -45  degrees**  
 **0   radians, which is       0  degrees**  
 **0.785398   radians, which is      45  degrees**  
 **1.5708   radians, which is      90  degrees**  
 **2.35619   radians, which is     135  degrees**  
 **3.14159   radians, which is     180  degrees**  
**The hyperbolic sine of the initial valarray is:**  
**-11.5487**  
**-5.22797**  
**-2.3013**  
**-0.868671**  
**0**  
**0.868671**  
**2.3013**  
**5.22797**  
**11.5487**    
##  \<a name="sqrt">\</a>  sqrt  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the square root of the elements of the input valarray.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the square root of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **The initial valarray is: ( 0 1 4 9 16 ).**  
**The square root of the initial valarray is: ( 0 1 2 3 4 ).**    
##  \<a name="swap">\</a>  swap  
 Exchanges the elements of two valarrays.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|An object of type <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|An object of type <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The template function executes <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
##  \<a name="tan">\</a>  tan  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the tangent of the elements of the input valarray.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the tangent of the elements of the input valarray.  
  
### Example  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  **The initial valarray is:**  
 **-1.5708     radians, which is     -90   degrees**  
 **-1.1781     radians, which is   -67.5   degrees**  
 **-0.785398     radians, which is     -45   degrees**  
 **-0.392699     radians, which is   -22.5   degrees**  
 **0     radians, which is       0   degrees**  
 **0.392699     radians, which is    22.5   degrees**  
 **0.785398     radians, which is      45   degrees**  
 **1.1781     radians, which is    67.5   degrees**  
 **1.5708     radians, which is      90   degrees**  
**The tangent of the initial valarray is:**  
 **9.6701e+012**  
**-2.41421**  
**-1**  
**-0.414214**  
**0**  
**0.414214**  
**1**  
**2.41421**  
**-9.6701e+012**    
##  \<a name="tanh">\</a>  tanh  
 Operates on the elements of an input valarray, returning a valarray whose elements are equal to the hyperbolic tangent of the elements of the input valarray.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
### Return Value  
 A valarray whose elements are equal to the hyperbolic cosine of the elements of the input valarray.  
  
### Remarks  
 Identities defining the hyperbolic tangent in terms of the exponential function:  
  
 tanh (                         *z* ) = sinh (                         *z* ) / cosh (                         *z* ) = ( exp (                         *z* ) – exp ( - *z* ) ) / ( exp (                         *z* ) + exp ( - *z* ) )  
  
### Example  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  **The initial valarray is:**  
 **-3.14159   radians, which is      -180  degrees**  
 **-2.35619   radians, which is      -135  degrees**  
 **-1.5708   radians, which is       -90  degrees**  
 **-0.785398   radians, which is       -45  degrees**  
 **0   radians, which is         0  degrees**  
 **0.785398   radians, which is        45  degrees**  
 **1.5708   radians, which is        90  degrees**  
 **2.35619   radians, which is       135  degrees**  
 **3.14159   radians, which is       180  degrees**  
**The hyperbolic tangent of the initial valarray is:**  
**-0.996272**  
**-0.982193**  
**-0.917152**  
**-0.655794**  
**0**  
**0.655794**  
**0.917152**  
**0.982193**  
**0.996272**    
## See Also  
 [&lt;valarray&gt;](../vs140/-valarray-.md)