---
title: "CTypedPtrArray::Add"
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
  - "CTypedPtrArray.Add"
  - "CTypedPtrArray::Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTypedPtrArray class, operations"
  - "Add method [MFC]"
ms.assetid: 29ec9e63-7431-4546-92f1-8692595606e9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrArray::Add
This member function calls `BASE_CLASS`**::Add**.  
  
## Syntax  
  
```  
  
      INT_PTR Add(   
   TYPE newElement    
);  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of element to be added to the array.  
  
 `newElement`  
 The element to be added to this array.  
  
## Return Value  
 The index of the added element.  
  
## Remarks  
 For more detailed remarks, see [CObArray::Add](../vs140/cobarray--add.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrArray Class](../vs140/ctypedptrarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)