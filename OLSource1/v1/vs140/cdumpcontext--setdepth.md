---
title: "CDumpContext::SetDepth"
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
  - "SetDepth"
  - "CDumpContext::SetDepth"
  - "CDumpContext.SetDepth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDepth method"
  - "CDumpContext class, status"
ms.assetid: 9a1c7877-c19a-4cfc-a258-68b725fe96ae
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDumpContext::SetDepth
Sets the depth for the dump.  
  
## Syntax  
  
```  
  
      void SetDepth(  
   int nNewDepth   
);  
```  
  
#### Parameters  
 *nNewDepth*  
 The new depth value.  
  
## Remarks  
 If you are dumping a primitive type or simple `CObject` that contains no pointers to other objects, then a value of 0 is sufficient. A value greater than 0 specifies a deep dump where all objects are dumped recursively. For example, a deep dump of a collection will dump all elements of the collection. You may use other specific depth values in your derived classes.  
  
> [!NOTE]
>  Circular references are not detected in deep dumps and can result in infinite loops.  
  
## Example  
 [!code[NVC_MFC_Utilities#16](../vs140/codesnippet/CPP/cdumpcontext--setdepth_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CDumpContext Class](../vs140/cdumpcontext-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::Dump](../vs140/cobject--dump.md)