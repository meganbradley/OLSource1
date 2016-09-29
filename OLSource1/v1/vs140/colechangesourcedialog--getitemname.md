---
title: "COleChangeSourceDialog::GetItemName"
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
  - "GetItemName"
  - "COleChangeSourceDialog.GetItemName"
  - "COleChangeSourceDialog::GetItemName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemName method"
ms.assetid: d727848e-532b-4289-b719-6bacf75e3fb8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleChangeSourceDialog::GetItemName
Call this function to retrieve the item moniker portion of the display name for the linked client item.  
  
## Syntax  
  
```  
  
CString GetItemName( );  
  
```  
  
## Return Value  
 The item moniker portion of the source display name for the [COleClientItem](../vs140/coleclientitem-class.md) specified in the constructor.  
  
## Remarks  
 The file moniker together with the item moniker gives the complete display name.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleChangeSourceDialog Class](../vs140/colechangesourcedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleChangeSourceDialog::GetFileName](../vs140/colechangesourcedialog--getfilename.md)   
 [COleChangeSourceDialog::GetDisplayName](../vs140/colechangesourcedialog--getdisplayname.md)