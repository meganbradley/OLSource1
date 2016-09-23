---
title: "COleSafeArray::UnaccessData"
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
  - UnaccessData
  - COleSafeArray::UnaccessData
  - COleSafeArray.UnaccessData
dev_langs: 
  - C++
helpviewer_keywords: 
  - UnaccessData method
ms.assetid: 4b7593c8-6631-4521-83fd-3a9572b758c5
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleSafeArray::UnaccessData
Decrements the lock count of an array and invalidates the pointer retrieved by `AccessData`.  
  
## Syntax  
  
```  
  
void UnaccessData( );  
```  
  
## Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
## Example  
 See the example for [COleSafeArray::AccessData](../vs140/colesafearray--accessdata.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::AccessData](../vs140/colesafearray--accessdata.md)