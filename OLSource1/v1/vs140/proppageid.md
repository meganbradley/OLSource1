---
title: "PROPPAGEID"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "PROPPAGEID"
  - "AFXCTL/PROPPAGEID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROPPAGEID macro"
ms.assetid: ecffa330-cc16-4473-abab-2d0b7f86edd3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROPPAGEID
Adds a property page for use by your OLE control.  
  
## Syntax  
  
```  
  
PROPPAGEID(  
clsid )  
```  
  
#### Parameters  
 `clsid`  
 The unique class ID of a property page.  
  
## Remarks  
 All `PROPPAGEID` macros must be placed between the `BEGIN_PROPPAGEIDS` and `END_PROPPAGEIDS` macros in your control's implementation file.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [BEGIN_PROPPAGEIDS](../vs140/begin_proppageids.md)   
 [END_PROPPAGEIDS](../vs140/end_proppageids.md)