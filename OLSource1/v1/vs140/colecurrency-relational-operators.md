---
title: "COleCurrency Relational Operators"
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
  - "COleCurrency Relational Operators"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator <, currency"
  - "operator >, currency"
  - "operator<=, currency"
  - "!= operator"
  - "<= operator, currency comparison"
  - "operator!=, currency"
  - "operator>=, currency"
  - "operator!=, relational operators"
  - "operator<, currency"
  - "< operator, comparing specific objects"
  - "operator !=, currency"
  - "operator !=, relational operators"
  - ">= operator, currency comparison"
  - "operator ==, currency"
  - "operator <=, currency"
  - "== operator"
  - "operator >=, currency"
  - "> operator, currency comparison"
  - "COleCurrency class, operators"
  - "operator==, currency"
ms.assetid: 94f2d16a-f3d1-4c3b-8fc9-77aec76383c4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency Relational Operators
Compare two currency values and return nonzero if the condition is true; otherwise 0.  
  
## Syntax  
  
```  
  
      BOOL operator ==(  
   const COleCurrency& cur   
) const;  
BOOL operator !=(  
   const COleCurrency& cur   
) const;  
BOOL operator <(  
   const COleCurrency& cur   
) const;  
BOOL operator >(  
   const COleCurrency& cur   
) const;  
BOOL operator <=(  
   const COleCurrency& cur   
) const;  
BOOL operator >=(  
   const COleCurrency& cur   
) const;  
```  
  
## Remarks  
  
> [!NOTE]
>  The return value of the ordering operations (**<**, **\<=**, **>**, **>=**) is undefined if the status of either operand is null or invalid. The equality operators (`==`, `!=`) consider the status of the operands.  
  
## Example  
 [!code[NVC_MFCOleContainer#20](../vs140/codesnippet/CPP/colecurrency-relational-operators_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleCurrency::GetStatus](../vs140/colecurrency--getstatus.md)