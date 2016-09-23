---
title: "CMFCRibbonEdit::CopyFrom"
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
  - CMFCRibbonEdit::CopyFrom
  - CopyFrom
  - CMFCRibbonEdit.CopyFrom
dev_langs: 
  - C++
helpviewer_keywords: 
  - CopyFrom method
ms.assetid: cfd9bd53-ca6a-4bce-8a87-22f8b8588aae
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonEdit::CopyFrom
Copies the state of the specified [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object to the current [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md) object.  
  
## Syntax  
  
```  
virtual void CopyFrom(  
   const CMFCRibbonBaseElement& src  
);  
```  
  
#### Parameters  
 [in] `src`  
 The source [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md) object.  
  
## Remarks  
 The `src` parameter must be of type [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md).  
  
## Requirements  
 **Header:** afxribbonedit.h  
  
## See Also  
 [CMFCRibbonEdit Class](../vs140/cmfcribbonedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)