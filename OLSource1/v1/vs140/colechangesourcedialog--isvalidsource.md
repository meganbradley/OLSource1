---
title: "COleChangeSourceDialog::IsValidSource"
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
  - COleChangeSourceDialog.IsValidSource
  - COleChangeSourceDialog::IsValidSource
  - IsValidSource
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsValidSource method
ms.assetid: 884b7417-abcc-45ae-95a1-217d33e5cd9e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleChangeSourceDialog::IsValidSource
Call this function to determine if the new source is valid.  
  
## Syntax  
  
```  
  
BOOL IsValidSource( );  
  
```  
  
## Return Value  
 Nonzero if the new source is valid, otherwise 0.  
  
## Remarks  
 Call this function only after [DoModal](../vs140/colechangesourcedialog--domodal.md) returns **IDOK**.  
  
 For more information, see the [OLEUICHANGESOURCE](http://msdn.microsoft.com/library/windows/desktop/ms682160) structure in [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleChangeSourceDialog Class](../vs140/colechangesourcedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleChangeSourceDialog::DoModal](../vs140/colechangesourcedialog--domodal.md)