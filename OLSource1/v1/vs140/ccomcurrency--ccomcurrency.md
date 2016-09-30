---
title: "CComCurrency::CComCurrency"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CComCurrency"
  - "ATL.CComCurrency.CComCurrency"
  - "CComCurrency::CComCurrency"
  - "CComCurrency.CComCurrency"
  - "ATL::CComCurrency::CComCurrency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComCurrency constructor"
  - "CComCurrency class, constructor"
ms.assetid: ac0e5c20-f7f5-4418-a398-8146030dd7ab
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::CComCurrency
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A variable of type **CURRENCY**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>,  *sSrc*,  *ulSrc, usSrc*  
 The initial value given to the member variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A character containing the initial value given to the member variable <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>,  *nFraction*  
 The integer and fractional components of the initial monetary value. See the [CComCurrency](../vs140/ccomcurrency-class.md) overview for more information.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> pointer.  
  
 *varSrc*  
 A variable of type **VARIANT**. The locale of the current thread is used to perform the conversion.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A Unicode or ANSI string containing the initial value. The locale of the current thread is used to perform the conversion.  
  
## Remarks  
 The constructor sets the initial value of [CComCurrency::m_currency](../vs140/ccomcurrency--m_currency.md), and accepts a wide range of data types, including integers, strings, floating-point numbers, **CURRENCY** variables, and other <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects. If no value is provided, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set to 0.  
  
 In the event of an error, such as an overflow, the constructors lacking an empty exception specification (**throw()**) call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
 When using floating-point or double values to assign a value, note that **CComCurrency(10.50)** is equivalent to **CComCurrency(10,5000)** and not **CComCurrency(10,50)**.  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)