---
title: "test2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0e9a97dd-2f54-490f-8498-23ad7bb80bf3
caps.latest.revision: 31
---
# test2
Describes an object that stores an ordered pair of objects both of type             **double***,* the first representing the real part of a complex number and the second representing the imaginary part.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value of type                         **double** for the real part of the complex number being constructed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of type                         **double** for the imaginary part of the complex number being constructed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The complex number of type                         **float** or of type                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> whose real and imaginary parts are used to initialize a complex number of type                         **double** being constructed.  
  
## Return Value  
 A complex number of type                 **double**.  
  
## Remarks  
 The explicit specialization of the template class complex to a complex class of type                 **double** differs from the template class only in the constructors it defines. The conversion from                 **float** to                 **double** is allowed to be implicit, but the conversion from                 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to                 **double** is required to be                 **explicit**. The use of                 **explicit** rules out the initiation with type conversion using assignment syntax.  
  
 For more information on the template class                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, see                 [complex Class](../vs140/complex-class.md). For a list of members of the template class                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, see .  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header**: \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)