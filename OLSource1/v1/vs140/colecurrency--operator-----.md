---
title: "COleCurrency::operator *, -"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "COleCurrency::operator *, /"
f1_keywords: 
  - "COleCurrency.operator*/"
  - "COleCurrency.operator/"
  - "COleCurrency.operator*"
  - "COleCurrency::operator*"
  - "operator/"
  - "COleCurrency::operator*/"
  - "COleCurrency::operator/"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "* operator, with specific objects"
  - "/ operator, currency objects"
  - "COleCurrency class, operators"
ms.assetid: 8e2790b5-c3c1-4568-8798-b550b5153f4a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency::operator *, -
Allow you to scale a **COleCurrency** value by an integral value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the **COleCurrency** operand is null, the status of the resulting **COleCurrency** value is null.  
  
 If the arithmetic operation overflows or underflows, the status of the resulting **COleCurrency** value is invalid.  
  
 If the **COleCurrency** operand is invalid, the status of the resulting **COleCurrency** value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](../vs140/colecurrency--m_status.md) member variable.  
  
## Example  
 [!code[NVC_MFCOleContainer#18](../vs140/codesnippet/CPP/colecurrency--operator-----_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::operator *=, /=](../vs140/colecurrency--operator--=---=.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)