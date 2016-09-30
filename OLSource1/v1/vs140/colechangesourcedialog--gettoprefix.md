---
title: "COleChangeSourceDialog::GetToPrefix"
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
  - "COleChangeSourceDialog.GetToPrefix"
  - "COleChangeSourceDialog::GetToPrefix"
  - "GetToPrefix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToPrefix method"
ms.assetid: 0568b059-8d79-4137-8b40-a644dbc9eabc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleChangeSourceDialog::GetToPrefix
Call this function to get the new prefix string for the source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The new prefix string of the source.  
  
## Remarks  
 Call this function only after [DoModal](../vs140/colechangesourcedialog--domodal.md) returns **IDOK**.  
  
 This value comes directly from the **lpszTo** member of the [OLEUICHANGESOURCE](http://msdn.microsoft.com/library/windows/desktop/ms682160) structure.  
  
 For more information, see the [OLEUICHANGESOURCE](http://msdn.microsoft.com/library/windows/desktop/ms682160) structure in [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleChangeSourceDialog Class](../vs140/colechangesourcedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleChangeSourceDialog::GetFromPrefix](../vs140/colechangesourcedialog--getfromprefix.md)