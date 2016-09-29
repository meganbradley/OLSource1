---
title: "CObject::AssertValid"
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
  - "CObject::AssertValid"
  - "CObject.AssertValid"
  - "AssertValid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AssertValid method"
  - "CObject class, diagnostics"
ms.assetid: 534a0744-4ab6-423d-b492-b4058b3d5157
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject::AssertValid
Validates this object's integrity.  
  
## Syntax  
  
```  
  
virtual void AssertValid( ) const;  
```  
  
## Remarks  
 `AssertValid` performs a validity check on this object by checking its internal state. In the Debug version of the library, `AssertValid` may assert and thus terminate the program with a message that lists the line number and filename where the assertion failed.  
  
 When you write your own class, you should override the `AssertValid` function to provide diagnostic services for yourself and other users of your class. The overridden `AssertValid` usually calls the `AssertValid` function of its base class before checking data members unique to the derived class.  
  
 Because `AssertValid` is a **const** function, you are not permitted to change the object state during the test. Your own derived class `AssertValid` functions should not throw exceptions but rather should assert whether they detect invalid object data.  
  
 The definition of "validity" depends on the object's class. As a rule, the function should perform a "shallow check." That is, if an object contains pointers to other objects, it should check to see whether the pointers are not null, but it should not perform validity testing on the objects referred to by the pointers.  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all `CObject` examples.  
  
 [!code[NVC_MFCCObjectSample#7](../vs140/codesnippet/CPP/cobject--assertvalid_1.cpp)]  
  
 For another example, see [AfxDoForAllObjects](../vs140/afxdoforallobjects.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)