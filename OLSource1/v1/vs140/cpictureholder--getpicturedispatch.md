---
title: "CPictureHolder::GetPictureDispatch"
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
  - CPictureHolder.GetPictureDispatch
  - CPictureHolder::GetPictureDispatch
  - GetPictureDispatch
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPictureDispatch method
ms.assetid: 1a925625-e7bd-4549-a606-60e0b9477d64
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPictureHolder::GetPictureDispatch
This function returns a pointer to the `CPictureHolder` object's `IPictureDisp` interface.  
  
## Syntax  
  
```  
  
LPPICTUREDISP GetPictureDispatch( );  
```  
  
## Return Value  
 A pointer to the `CPictureHolder` object's `IPictureDisp` interface.  
  
## Remarks  
 The caller must call **Release** on this pointer when finished with it.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPictureHolder Class](../vs140/cpictureholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPictureHolder::SetPictureDispatch](../vs140/cpictureholder--setpicturedispatch.md)