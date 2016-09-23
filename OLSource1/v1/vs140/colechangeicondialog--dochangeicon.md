---
title: "COleChangeIconDialog::DoChangeIcon"
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
  - COleChangeIconDialog::DoChangeIcon
  - COleChangeIconDialog.DoChangeIcon
  - DoChangeIcon
dev_langs: 
  - C++
helpviewer_keywords: 
  - DoChangeIcon method
  - COleChangeIconDialog class, operations and attributes
ms.assetid: c6e5bfd1-d560-4a05-8d46-abb383a0c45c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleChangeIconDialog::DoChangeIcon
Call this function to change the icon representing the item to the one selected in the dialog box after [DoModal](../vs140/colechangeicondialog--domodal.md) returns **IDOK**.  
  
## Syntax  
  
```  
  
      BOOL DoChangeIcon(  
   COleClientItem* pItem   
);  
```  
  
#### Parameters  
 `pItem`  
 Points to the item whose icon is changing.  
  
## Return Value  
 Nonzero if change is successful; otherwise 0.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleChangeIconDialog Class](../vs140/colechangeicondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleChangeIconDialog::DoModal](../vs140/colechangeicondialog--domodal.md)