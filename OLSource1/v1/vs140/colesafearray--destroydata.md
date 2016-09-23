---
title: "COleSafeArray::DestroyData"
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
  - COleSafeArray::DestroyData
  - COleSafeArray.DestroyData
  - DestroyData
dev_langs: 
  - C++
helpviewer_keywords: 
  - DestroyData method
ms.assetid: 6b7b330a-74a4-4746-8295-89f44f704d46
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleSafeArray::DestroyData
Destroys all the data in a safe array.  
  
## Syntax  
  
```  
  
void DestroyData( );  
```  
  
## Remarks  
 If objects are stored in the array, each object is released. On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::Destroy](../vs140/colesafearray--destroy.md)   
 [COleSafeArray::DestroyDescriptor](../vs140/colesafearray--destroydescriptor.md)