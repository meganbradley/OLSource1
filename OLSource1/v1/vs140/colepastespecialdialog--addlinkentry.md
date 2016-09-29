---
title: "COlePasteSpecialDialog::AddLinkEntry"
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
  - "COlePasteSpecialDialog::AddLinkEntry"
  - "COlePasteSpecialDialog.AddLinkEntry"
  - "AddLinkEntry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddLinkEntry method"
ms.assetid: fd439bf7-4ebc-4e5c-8363-469202e4cf92
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePasteSpecialDialog::AddLinkEntry
Adds a new entry to the list of supported Clipboard formats.  
  
## Syntax  
  
```  
  
      OLEUIPASTEFLAG AddLinkEntry(  
   UINT cf  
);  
```  
  
#### Parameters  
 `cf`  
 The clipboard format to add.  
  
## Return Value  
 An [OLEUIPASTEFLAG](http://msdn.microsoft.com/library/windows/desktop/ms682172) structure containing the information for the new link entry.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePasteSpecialDialog Class](../vs140/colepastespecialdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)