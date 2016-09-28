---
title: "CD2DTextLayout::GetLocaleName"
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
  - "GetLocaleName"
  - "afxrendertarget/CD2DTextLayout::GetLocaleName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLocaleName method"
ms.assetid: 11ca4e73-4607-4273-943d-4dfe0fd36657
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DTextLayout::GetLocaleName
Gets the locale name of the text at the specified position.  
  
## Syntax  
  
```  
CString GetLocaleName(  
   UINT32 currentPosition,  
   DWRITE_TEXT_RANGE* textRange = NULL  
) const;  
```  
  
#### Parameters  
 `currentPosition`  
 The position of the text to inspect.  
  
 `textRange`  
 The range of text that has the same formatting as the text at the position specified by currentPosition. This means the run has the exact formatting as the position specified, including but not limited to the locale name.  
  
## Return Value  
 CString object that contains the current locale name.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DTextLayout Class](../vs140/cd2dtextlayout-class.md)