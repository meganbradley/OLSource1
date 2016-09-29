---
title: "COleSafeArray::Redim"
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
  - "ReDim"
  - "COleSafeArray::Redim"
  - "COleSafeArray.Redim"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Redim method"
ms.assetid: 347f3df4-ba85-4269-bffb-165f6f40803b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Redim
Changes the least significant (rightmost) bound of a safe array.  
  
## Syntax  
  
```  
  
      void Redim(  
   SAFEARRAYBOUND* psaboundNew   
);  
```  
  
#### Parameters  
 *psaboundNew*  
 Pointer to a new safe array bound structure containing the new array bound. Only the least significant dimension of an array may be changed.  
  
## Remarks  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::Create](../vs140/colesafearray--create.md)   
 [COleSafeArray::GetDim](../vs140/colesafearray--getdim.md)   
 [COleSafeArray::ResizeOneDim](../vs140/colesafearray--resizeonedim.md)