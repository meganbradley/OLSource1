---
title: "COleSafeArray::Copy"
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
  - "COleSafeArray.Copy"
  - "COleSafeArray::Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Copy method"
ms.assetid: 9367acf0-c2d1-43b0-96ac-d5c489c34c55
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Copy
Creates a copy of an existing safe array.  
  
## Syntax  
  
```  
  
      void Copy(  
   LPSAFEARRAY* ppsa   
);  
```  
  
#### Parameters  
 *ppsa*  
 Pointer to a location in which to return the new array descriptor.  
  
## Remarks  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SafeArrayCopy](assetId:///8f84d4f6-1852-4ad8-b174-f3fa37e5bbd6)