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
This operator assigns the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to a new value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A **CComCurrency** object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A variable of type **CURRENCY**.  
  
 *sSrc*,  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>,  *bSrc*,  *usSrc*,  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>,  *cSrc*,  *ulSrc*,  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The numeric value to assign to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Returns the updated <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. In the event of an error, such as an overflow, this operator calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with an HRESULT describing the error.  
  
## Example  
 [!code[NVC_ATL_Utilities#65](../vs140/codesnippet/CPP/ccomcurrency--operator-=_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)