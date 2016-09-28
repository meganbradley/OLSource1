---
title: "COleCurrency::operator +=, -="
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
  - "COleCurrency.operator+="
  - "COleCurrency::operator-="
  - "COleCurrency.operator-="
  - "COleCurrency.operator+=-="
  - "COleCurrency::operator+=-="
  - "COleCurrency::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator+=, currency"
  - "operator-="
  - "+= operator, currency"
  - "-= operator"
  - "COleCurrency class, operators"
  - "operator +=, currency"
ms.assetid: 1805c36c-cacf-4c58-b4a1-3b769afb95bf
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::operator +=, -=
Allow you to add and subtract a **COleCurrency** value to and from this **COleCurrency** object.  
  
## Syntax  
  
```  
  
      const COleCurrency& operator +=(  
   const COleCurrency& cur   
);  
const COleCurrency& operator -=(  
   const COleCurrency& cur   
);  
```  
  
## Remarks  
 If either of the operands is null, the status of this **COleCurrency** object is set to null.  
  
 If the arithmetic operation overflows, the status of this **COleCurrency** object is set to invalid.  
  
 If either of the operands is invalid and the other is not null, the status of this **COleCurrency** object is set to invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](../vs140/colecurrency--m_status.md) member variable.  
  
## Example  
 [!code[NVC_MFCOleContainer#17](../vs140/codesnippet/CPP/colecurrency--operator--=---=_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::operator +, -](../vs140/colecurrency--operator-----.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)