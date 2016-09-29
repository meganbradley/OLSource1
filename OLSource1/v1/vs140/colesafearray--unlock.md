---
title: "COleSafeArray::Unlock"
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
  - "COleSafeArray.Unlock"
  - "COleSafeArray::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 9e69efdc-c6d3-4efa-818e-065c87c1d1ff
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Unlock
Decrements the lock count of an array so it can be freed or resized.  
  
## Syntax  
  
```  
  
void Unlock( );  
```  
  
## Remarks  
 This function is called after access to the data in an array is finished. On error, it throws a [COleException](../vs140/coleexception-class.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::Lock](../vs140/colesafearray--lock.md)   
 [SafeArrayUnlock](assetId:///654995ab-1959-44dc-9e26-11c34e489c14)