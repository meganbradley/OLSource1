---
title: "COleCurrency::SetCurrency"
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
  - "COleCurrency::SetCurrency"
  - "SetCurrency"
  - "COleCurrency.SetCurrency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCurrency method"
ms.assetid: 833d28c8-c633-4b11-a4af-18aad70ffe1c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::SetCurrency
Call this member function to set the units and fractional part of this **COleCurrency** object.  
  
## Syntax  
  
```  
  
      void SetCurrency(  
   long nUnits,  
   long nFractionalUnits   
);  
```  
  
#### Parameters  
 `nUnits`, `nFractionalUnits`  
 Indicate the units and fractional part (in 1/10,000's) of the value to be copied into this **COleCurrency** object.  
  
## Remarks  
 If the absolute value of the fractional part is greater than 10,000, the appropriate adjustment is made to the units, as shown in the third of the following examples.  
  
 Note that the units and fractional part are specified by signed long values. The fourth of the following examples shows what happens when the parameters have different signs.  
  
## Example  
 [!code[NVC_MFCOleContainer#14](../vs140/codesnippet/CPP/colecurrency--setcurrency_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::COleCurrency](../vs140/colecurrency--colecurrency.md)   
 [COleCurrency::operator =](../vs140/colecurrency--operator-=.md)   
 [COleCurrency::m_cur](../vs140/colecurrency--m_cur.md)