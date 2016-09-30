---
title: "complex&lt;float&gt;"
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
  - "std::complex<float>"
  - "std.complex<float>"
  - "complex<float>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "complex<float> function"
ms.assetid: 1178eb1e-39bd-4017-89cd-aea95f813939
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex&lt;float&gt;
Describes an object that stores an ordered pair of objects both of type **float***,* the first representing the real part of a complex number and the second representing the imaginary part.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value of type **float** for the real part of the complex number being constructed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of type **float** for the imaginary part of the complex number being constructed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The complex number of type **double** or of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> whose real and imaginary parts are used to initialize a complex number of type **float** being constructed.  
  
## Return Value  
 A complex number of type **float**.  
  
## Remarks  
 The explicit specialization of the template class complex to a complex class of type **float** differs from the template class only in the constructors it defines. The conversion from **float** to **double** is allowed to be implicit, but the less safe conversion from **float** to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is required to be **explicit**. The use of **explicit** rules out the initiation with type conversion using assignment syntax.  
  
 For more information on the template class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, see [complex Class](../vs140/complex-class.md). For a list of members of the template class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, see .  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header**: \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)