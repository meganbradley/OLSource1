---
title: "BasicType"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BasicType enumeration"
ms.assetid: 19ae53ba-cd6e-47b6-9f94-27ae663ce955
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BasicType
Specifies the symbol's basic type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 btNoType  
 No basic type is specified.  
  
 btVoid  
 Basic type is a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 btChar  
 Basic type is a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (C/C++ type).  
  
 btWChar  
 Basic type is a wide (Unicode) character (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 btInt  
 Basic type is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (C/C++ type).  
  
 btUInt  
 Basic type is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (C/C++ type).  
  
 btFloat  
 Basic type is a floating-point number (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
 btBCD  
 Basic type is a binary-coded decimal (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
 btBool  
 Basic type is a Boolean (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
 btLong  
 Basic type is a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (C/C++ type).  
  
 btULong  
 Basic type is an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (C/C++ type).  
  
 btCurrency  
 Basic type is currency.  
  
 btDate  
 Basic type is date/time (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>).  
  
 btVariant  
 Basic type is a variable type structure (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
 btComplex  
 Basic type is a complex number.  
  
 btBit  
 Basic type is a bit.  
  
 btBSTR  
 Basic type is a basic or binary string (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>).  
  
 btHresult  
 Basic type is an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The values in this enumeration are returned by the [IDiaSymbol::get_baseType](../vs140/idiasymbol--get_basetype.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaSymbol::get_baseType](../vs140/idiasymbol--get_basetype.md)   
 [IDiaSymbol::get_length](../vs140/idiasymbol--get_length.md)