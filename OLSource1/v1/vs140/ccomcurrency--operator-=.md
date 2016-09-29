---
title: "CComCurrency::operator ="
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
  - "CComCurrency.operator="
  - "ATL::CComCurrency::operator="
  - "ATL.CComCurrency.operator="
  - "CComCurrency::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, currency"
  - "operator=, currency"
ms.assetid: 270e85e3-734a-4acf-a701-1d718d0834ce
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::operator =
This operator assigns the `CComCurrency` object to a new value.  
  
## Syntax  
  
```  
  
      const CComCurrency & operator =(  
   const CComCurrency & curSrc   
) throw( );  
const CComCurrency & operator =(  
   CURRENCY cySrc   
) throw( );  
const CComCurrency & operator =(  
   FLOAT fSrc   
);  
const CComCurrency & operator =(  
   SHORT sSrc   
);  
const CComCurrency & operator =(  
   LONG lSrc   
);  
const CComCurrency & operator =(  
   BYTE bSrc   
);  
const CComCurrency & operator =(  
   USHORT usSrc   
);  
const CComCurrency & operator =(  
   DOUBLE dSrc   
);  
const CComCurrency & operator =(  
   CHAR cSrc   
);  
const CComCurrency & operator =(  
   ULONG ulSrc   
);  
const CComCurrency & operator =(  
   DECIMAL dSrc   
);  
```  
  
#### Parameters  
 `curSrc`  
 A **CComCurrency** object.  
  
 `cySrc`  
 A variable of type **CURRENCY**.  
  
 *sSrc*,  `fSrc`,  `lSrc`,  *bSrc*,  *usSrc*,  `dSrc`,  *cSrc*,  *ulSrc*,  `dSrc`  
 The numeric value to assign to the `CComCurrency` object.  
  
## Return Value  
 Returns the updated `CComCurrency` object. In the event of an error, such as an overflow, this operator calls `AtlThrow` with an HRESULT describing the error.  
  
## Example  
 [!code[NVC_ATL_Utilities#65](../vs140/codesnippet/CPP/ccomcurrency--operator-=_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)