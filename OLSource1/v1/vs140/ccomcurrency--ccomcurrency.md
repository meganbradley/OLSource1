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
  
```  
  
      CComCurrency( ) throw( );   
CComCurrency(  
   const CComCurrency& curSrc   
) throw( );  
CComCurrency(  
   CURRENCY cySrc   
) throw( );  
CComCurrency(  
   DECIMAL dSrc   
);  
CComCurrency(  
   ULONG ulSrc   
);  
CComCurrency(  
   USHORT usSrc   
);  
CComCurrency(  
   CHAR cSrc   
);  
CComCurrency(  
   DOUBLE dSrc   
);  
CComCurrency(  
   FLOAT fSrc   
);  
CComCurrency(  
   LONG lSrc   
);  
CComCurrency(  
   SHORT sSrc   
);  
CComCurrency(  
   BYTE bSrc   
);  
CComCurrency(  
   LONGLONG nInteger,  
   SHORT nFraction   
);  
explicit CComCurrency(  
   LPDISPATCH pDispSrc   
);  
explicit CComCurrency(  
   const VARIANT& varSrc   
);  
explicit CComCurrency(  
   LPCWSTR szSrc   
);  
explicit CComCurrency(  
   LPCSTR szSrc   
);  
```  
  
#### Parameters  
 `curSrc`  
 An existing `CComCurrency` object.  
  
 `cySrc`  
 A variable of type **CURRENCY**.  
  
 `bSrc`,  `dSrc`,  `fSrc`,  `lSrc`,  *sSrc*,  *ulSrc, usSrc*  
 The initial value given to the member variable `m_currency`.  
  
 `cSrc`  
 A character containing the initial value given to the member variable `m_currency`.  
  
 `nInteger`,  *nFraction*  
 The integer and fractional components of the initial monetary value. See the [CComCurrency](../vs140/ccomcurrency-class.md) overview for more information.  
  
 `pDispSrc`  
 An `IDispatch` pointer.  
  
 *varSrc*  
 A variable of type **VARIANT**. The locale of the current thread is used to perform the conversion.  
  
 `szSrc`  
 A Unicode or ANSI string containing the initial value. The locale of the current thread is used to perform the conversion.  
  
## Remarks  
 The constructor sets the initial value of [CComCurrency::m_currency](../vs140/ccomcurrency--m_currency.md), and accepts a wide range of data types, including integers, strings, floating-point numbers, **CURRENCY** variables, and other `CComCurrency` objects. If no value is provided, `m_currency` is set to 0.  
  
 In the event of an error, such as an overflow, the constructors lacking an empty exception specification (**throw()**) call `AtlThrow` with an HRESULT describing the error.  
  
 When using floating-point or double values to assign a value, note that **CComCurrency(10.50)** is equivalent to **CComCurrency(10,5000)** and not **CComCurrency(10,50)**.  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)