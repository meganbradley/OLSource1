---
title: "COleSafeArray::Destroy"
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
  - "COleSafeArray::Destroy"
  - "COleSafeArray.Destroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Destroy method"
ms.assetid: 827e52d1-a670-4dbc-bf82-6fd586683522
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Destroy
Destroys an existing array descriptor and all the data in the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If objects are stored in the array, each object is released. On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::DestroyData](../vs140/colesafearray--destroydata.md)   
 [COleSafeArray::DestroyDescriptor](../vs140/colesafearray--destroydescriptor.md)