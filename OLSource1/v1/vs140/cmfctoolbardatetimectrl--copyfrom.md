---
title: "CMFCToolBarDateTimeCtrl::CopyFrom"
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
  - CMFCToolBarDateTimeCtrl::CopyFrom
  - CopyFrom
  - CMFCToolBarDateTimeCtrl.CopyFrom
dev_langs: 
  - C++
helpviewer_keywords: 
  - CopyFrom method
ms.assetid: 46b0ee17-1ca4-4857-8385-401657bea0e2
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarDateTimeCtrl::CopyFrom
Copies the properties of another toolbar button to the current button.  
  
## Syntax  
  
```  
virtual void CopyFrom(  
   const CMFCToolBarButton& src  
);  
```  
  
#### Parameters  
 [in] `src`  
 A reference to the source button from which to copy.  
  
## Remarks  
 Call this method to copy another toolbar button to this toolbar button. `src` must be of type `CMFCToolBarDateTimeCtrl`.  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)