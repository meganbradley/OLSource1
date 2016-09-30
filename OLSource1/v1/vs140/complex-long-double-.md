---
title: "complex&lt;long double&gt;"
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
  - "std::complex<long double>"
  - "complex<long double>"
  - "std.complex<long double>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "complex<long double> function"
ms.assetid: 37591991-b385-46e9-b727-d534dbc10432
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex&lt;long double&gt;
Describes an object that stores an ordered pair of objects both of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the first representing the real part of a complex number and the second representing the imaginary part.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of type **long double** for the real part of the complex number being constructed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for the imaginary part of the complex number being constructed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The complex number of type **double** or of type **float** whose real and imaginary parts are used to initialize a complex number of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> being constructed.  
  
## Return Value  
 A complex number of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The explicit specialization of the template class complex to a complex class of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> differs from the template class only in the constructors it defines. The conversion from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to **float** is allowed to be implicit, but the conversion from **double** to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is required to be **explicit**. The use of **explicit** rules out the initiation with type conversion using assignment syntax.  
  
 For more information on the template class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, see [complex Class](../vs140/complex-class.md). For a list of members of the template class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, see .  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header**: \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)