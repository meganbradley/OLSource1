---
title: "CDC::FromHandle"
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
  - CDC::FromHandle
  - CDC.FromHandle
dev_langs: 
  - C++
helpviewer_keywords: 
  - FromHandle method [MFC]
  - CDC class, initialization
ms.assetid: ced3d088-bf98-4f33-880e-00abfeb5d6e9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::FromHandle
Returns a pointer to a `CDC` object when given a handle to a device context.  
  
## Syntax  
  
```  
  
      static CDC* PASCAL FromHandle(  
   HDC hDC   
);  
```  
  
#### Parameters  
 `hDC`  
 Contains a handle to a Windows device context.  
  
## Return Value  
 The pointer may be temporary and should not be stored beyond immediate use.  
  
## Remarks  
 If a `CDC` object is not attached to the handle, a temporary `CDC` object is created and attached.  
  
## Example  
 See the example for [CPrintDialog::GetPrinterDC](../vs140/cprintdialog--getprinterdc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::DeleteTempMap](../vs140/cdc--deletetempmap.md)