---
title: "complex Class"
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
  - "complex"
  - "std::complex"
  - "std.complex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "complex numbers"
  - "complex class"
ms.assetid: d6492e1c-5eba-4bc5-835b-2a88001a5868
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex Class
The template class describes an object that stores two objects of type             **Type**, one that represents the real part of a complex number and one that represents the imaginary part.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An object of class                 **Type**:  
  
-   Has a public default constructor, destructor, copy constructor, and assignment operator with conventional behavior.  
  
-   Can be assigned integer or floating-point values, or type cast to such values with conventional behavior.  
  
-   Defines the arithmetic operators and math functions, as needed, that are defined for the floating-point types with conventional behavior.  
  
 In particular, no subtle differences may exist between copy construction and default construction followed by assignment. None of the operations on objects of class                 **Type** may throw exceptions.  
  
 Explicit specializations of template class complex exist for the three floating-point types. In this implementation, a value of any other type                 **Type** is typecast to                 **double** for actual calculations, with the                 **double** result assigned back to the stored object of type                 **Type**<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
### Constructors  
  
|||  
|-|-|  
|[complex](#complex__complex)|Constructs a complex number with specified real and imaginary parts or as a copy of some other complex number.|  
  
### Typedefs  
  
|||  
|-|-|  
|[value_type](#complex__value_type)|A type that represents the data type used to represent the real and imaginary parts of a complex number.|  
  
### Member Functions  
  
|||  
|-|-|  
|[imag](#complex__imag)|Extracts the imaginary component of a complex number.|  
|[real](#complex__real)|Extracts the real component of a complex number.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*=](#complex__operator_star_eq)|Multiplies a target complex number by a factor, which may be complex or be the same type as are the real and imaginary parts of the complex number.|  
|[operator+=](#complex__operator_add_eq)|Adds a number to a target complex number, where the number added may be complex or of the same type as are the real and imaginary parts of the complex number to which it is added.|  
|[operator-=](#complex__operator-_eq)|Subtracts a number from a target complex number, where the number subtracted may be complex or of the same type as are the real and imaginary parts of the complex number to which it is added.|  
|[operator/=](#complex__operator__eq)|Divides a target complex number by a divisor, which may be complex or be the same type as are the real and imaginary parts of the complex number.|  
|[operator=](#complex__operator_eq)|Assigns a number to a target complex number, where the number assigned may be complex or of the same type as are the real and imaginary parts of the complex number to which it is being assigned.|  
  
## Requirements  
 **Header**: \<complex>  
  
 **Namespace:** std  
  
##  \<a name="complex__complex">\</a>  complex::complex  
 Constructs a complex number with specified real and imaginary parts or as a copy of some other complex number.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The value of the real part used to initialize the complex number being constructed.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The value of the imaginary part used to initialize the complex number being constructed.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The complex number whose real and imaginary parts are used to initialize the complex number being constructed.  
  
### Remarks  
 The first constructor initializes the stored real part to _                        *RealVal* and the stored imaginary part to \_                        *Imagval*. The second constructor initializes the stored real part to                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>**.real**() and the stored imaginary part to                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>**.imag**().  
  
 In this implementation, if a translator does not support member template functions, the template:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 is replaced with:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 which is the copy constructor.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="complex__imag">\</a>  complex::imag  
 Extracts the imaginary component of a complex number.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A complex number whose imaginary value is to be extracted.  
  
### Return Value  
 The imaginary part of the complex number.  
  
### Remarks  
 For a complex number                         *a + bi*, the imaginary part or component is                         *Im(a + bi) = b.*  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **The complex number c1 = (4,3)**  
**The real part of c1 is c1.real ( ) = 4.**  
**The imaginary part of c1 is c1.imag ( ) = 3.**    
##  \<a name="complex__operator_star_eq">\</a>  complex::operator*=  
 Multiplies a target complex number by a factor, which may be complex or be the same type as are the real and imaginary parts of the complex number.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A complex number or a number that is of the same type as the parameter of the target complex number.  
  
### Return Value  
 A complex number that has been multiplied by the number specified as a parameter.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="complex__operator_add_eq">\</a>  complex::operator+=  
 Adds a number to a target complex number, where the number added may be complex or of the same type as are the real and imaginary parts of the complex number to which it is added.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A complex number or a number that is of the same type as the parameter of the target complex number.  
  
### Return Value  
 A complex number that has had the number specified as a parameter added.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,-1)**  
**The sum of the two complex numbers is: cs1 = cl1 + cr1 = (5,3)**  
**The complex number cr1 added to the complex number cl1 is:**  
 **cl1 += cr1 = (5,3)**  
**The modulus of cl1 is: 5.83095**  
**The argument of cl1 is: 0.54042 radians, which is 30.9638 degrees.**  
**The left-side complex number is cl2 = (-2,4)**  
**The right-side complex number is cr2 = 5**  
**The sum of the two complex numbers is: cs2 = cl2 + cr2 = (3,4)**  
**The complex number cr2 added to the complex number cl2 is:**  
 **cl2 += cr2 = (3,4)**  
**The modulus of cl2 is: 5**  
**The argument of cl2 is: 0.927295 radians, which is 53.1301 degrees.**    
##  \<a name="complex__operator-_eq">\</a>  complex::operator-=  
 Subtracts a number from a target complex number, where the number subtracted may be complex or of the same type as are the real and imaginary parts of the complex number to which it is added.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A complex number to be subtracted from the target complex number.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A real number to be subtracted from the target complex number.  
  
### Return Value  
 A complex number that has had the number specified as a parameter subtracted from it.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,-1)**  
**The difference between the two complex numbers is:**  
 **cs1 = cl1 - cr1 = (1,5)**  
**Complex number cr1 subtracted from complex number cl1 is:**  
 **cl1 -= cr1 = (1,5)**  
**The modulus of cl1 is: 5.09902**  
**The argument of cl1 is: 1.3734 radians, which is 78.6901 degrees.**  
**The left-side complex number is cl2 = (2,4)**  
**The right-side complex number is cr2 = 5**  
**The difference between the two complex numbers is:**  
 **cs2 = cl2 - cr2 = (-3,4)**  
**Complex number cr2 subtracted from complex number cl2 is:**  
 **cl2 -= cr2 = (-3,4)**  
**The modulus of cl2 is: 5**  
**The argument of cl2 is: 2.2143 radians, which is 126.87 degrees.**    
##  \<a name="complex__operator__eq">\</a>  complex::operator/=  
 Divides a target complex number by a divisor, which may be complex or be the same type as are the real and imaginary parts of the complex number.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A complex number to be subtracted from the target complex number.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A real number to be subtracted from the target complex number.  
  
### Return Value  
 A complex number that has been divided by the number specified as a parameter.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (2.59808,1.5)**  
**The right-side complex number is cr1 = (1,1.73205)**  
**The quotient of the two complex numbers is: cs1 = cl1 /cr1 = (1.29904,-0.75)**  
**Quotient of two complex numbers is also: cl1 /= cr1 = (1.29904,-0.75)**  
**The modulus of cl1 is: 1.5**  
**The argument of cl1 is: -0.523599 radians, which is -30 degrees.**  
**The left-side complex number is cl2 = (2.59808,1.5)**  
**The right-side complex number is cr2 = 5**  
**The quotient of the two complex numbers is: cs2 /= cl2 cr2 = (0.519615,0.3)**  
**Quotient of two complex numbers is also: cl2 = /cr2 = (0.519615,0.3)**  
**The modulus of cl2 is: 0.6**  
**The argument of cl2 is: 0.523599 radians, which is 30 degrees.**    
##  \<a name="complex__operator_eq">\</a>  complex::operator=  
 Assigns a number to a target complex number, where the number assigned may be complex or of the same type as are the real and imaginary parts of the complex number to which it is being assigned.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A complex number or a number that is of the same type as the parameter of the target complex number.  
  
### Return Value  
 A complex number that has been assigned the number specified as a parameter.  
  
### Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,-1)**  
**The complex number cr1 assigned to the complex number cl1 is:**  
 **cl1 = cr1 = (2,-1)**  
**The left-side complex number is cl2 = (-2,4)**  
**The right-side complex number is cr2 = 5**  
**The complex number cr2 assigned to the complex number cl2 is:**  
 **cl2 = cr2 = (5,0)**  
**The complex number (3, 4) assigned to the complex number cl2 is:**  
 **cl2 = (3,4)**    
##  \<a name="complex__real">\</a>  complex::real  
 Gets or sets the real component of a complex number.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A complex number whose real value is to be extracted.  
  
### Return Value  
 The real part of the complex number.  
  
### Remarks  
 For a complex number                         *a + bi*, the real part or component is                         *Re(a + bi) = a.*  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The complex number c1 = (4,3)**  
**The real part of c1 is c1.real ( ) = 4.**  
**The imaginary part of c1 is c1.imag ( ) = 3.**    
##  \<a name="complex__value_type">\</a>  complex::value_type  
 A type that represents the data type used to represent the real and imaginary parts of a complex number.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is a synonym for the class complex                         **Type** template parameter.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **Specifying initial real & imaginary parts**  
**of type value_type: c1 = (3,4).**    
## See Also  
 [complex Members](assetId:///d5c4466c-43a0-4817-aca1-9a5d492dae28)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)