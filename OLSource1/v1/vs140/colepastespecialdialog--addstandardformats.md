---
title: "COlePasteSpecialDialog::AddStandardFormats"
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
  - "AddStandardFormats"
  - "COlePasteSpecialDialog::AddStandardFormats"
  - "COlePasteSpecialDialog.AddStandardFormats"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COlePasteSpecialDialog class, operations and attributes"
  - "AddStandardFormats method"
ms.assetid: 3c4efa02-d0b2-41e1-b2be-8e20f2034cb2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePasteSpecialDialog::AddStandardFormats
Call this function to add the following Clipboard formats to the list of formats your application can support in a Paste Special operation:  
  
## Syntax  
  
```  
  
      void AddStandardFormats(  
   BOOL bEnableLink = TRUE   
);  
```  
  
#### Parameters  
 *bEnableLink*  
 Flag that determines whether to add `CF_LINKSOURCE` to the list of formats your application can paste.  
  
## Remarks  
  
-   **CF_BITMAP**  
  
-   **CF_DIB**  
  
-   `CF_METAFILEPICT`  
  
-   **"Embedded Object"**  
  
-   (optionally) **"Link Source"**  
  
 These formats are used to support embedding and linking.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePasteSpecialDialog Class](../vs140/colepastespecialdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePasteSpecialDialog::AddFormat](../vs140/colepastespecialdialog--addformat.md)