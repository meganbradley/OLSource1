---
title: "Clipboard format is not valid"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrID460"
dev_langs: 
  - "VB"
ms.assetid: 71a4a045-65bb-417d-b3bd-99a9fa3c53f6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Clipboard format is not valid
The specified Clipboard format is incompatible with the method being executed. Among the possible causes for this error are:  
  
-   Using the Clipboard's `GetText` or `SetText` method with a Clipboard format other than `vbCFText` or `vbCFLink`.  
  
-   Using the Clipboard's `GetData` or `SetData` method with a Clipboard format other than `vbCFBitmap`, `vbCFDIB`, or `vbCFMetafile`.  
  
-   Using the `DataObject``GetData` method or `SetData` method with a Clipboard format in the range reserved by Microsoft Windows for registered formats (&HC000-&HFFFF), when that Clipboard format has not been registered with Microsoft Windows.  
  
### To correct this error  
  
-   Remove the invalid format and specify a valid one.  
  
## See Also  
 [Clipboard: Adding Other Formats](../vs140/clipboard--adding-other-formats.md)