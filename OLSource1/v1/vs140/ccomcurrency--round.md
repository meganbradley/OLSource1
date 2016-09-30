---
title: "CComCurrency::Round"
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
  - "ATL.CComCurrency.Round"
  - "ATL::CComCurrency::Round"
  - "Round"
  - "CComCurrency.Round"
  - "CComCurrency::Round"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Round method"
ms.assetid: f0a11a5a-50af-4149-b167-8e138c9a4332
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCurrency::Round
Call this method to round the currency to a specified number of decimal places.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nDecimals*  
 The number of digits to which <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will be rounded, in the range 0 to 4.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on failure.  
  
## Example  
 [!code[NVC_ATL_Utilities#52](../vs140/codesnippet/CPP/ccomcurrency--round_1.cpp)]  
  
## Requirements  
 **Header:** atlcur.h  
  
## See Also  
 [CComCurrency Class](../vs140/ccomcurrency-class.md)