---
title: "COleCurrency::operator &lt;&lt;, &gt;&gt;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleCurrency.operator<<>>
  - COleCurrency::operator>>
  - COleCurrency.operator>>
  - COleCurrency.operator<<
  - COleCurrency::operator<<
  - COleCurrency::operator<<>>
  - operator<<>>
  - operator>>
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator<<, currency
  - operator>>
  - >> operator, currency
  - << operator
  - operator >>, currency
  - operator <<, currency
  - operator>>, currency
  - COleCurrency class, Dump/Archive
  - COleCurrency class, operators
ms.assetid: 47f12021-25a0-4652-9d35-7c524b1d73c4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleCurrency::operator &lt;&lt;, &gt;&gt;
Supports diagnostic dumping and storing to an archive.  
  
## Syntax  
  
```  
  
      friend CDumpContext& operator <<(  
   CDumpContext& dc,  
   COleCurrency curSrc   
);  
friend CArchive& operator <<(  
   CArchive& ar,  
   COleCurrency curSrc   
);  
friend CArchive& operator >>(  
   CArchive& ar,  
   COleCurrency& curSrc   
);  
```  
  
## Remarks  
 The extraction (**>>**) operator supports loading from an archive.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [CArchive Class](../vs140/carchive-class.md)