---
title: "CD2DTextLayout::SetFontFamilyName"
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
  - "afxrendertarget/CD2DTextLayout::SetFontFamilyName"
  - "SetFontFamilyName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFontFamilyName method"
ms.assetid: c52b6b2b-044a-4c2c-8b7a-0927bc31b0fc
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DTextLayout::SetFontFamilyName
Sets null-terminated font family name for text within a specified text range  
  
## Syntax  
  
```  
BOOL SetFontFamilyName(  
   LPCWSTR pwzFontFamilyName,  
   DWRITE_TEXT_RANGE textRange  
);  
```  
  
#### Parameters  
 `pwzFontFamilyName`  
 The font family name that applies to the entire text string within the range specified by textRange  
  
 `textRange`  
 Text range to which this change applies  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DTextLayout Class](../vs140/cd2dtextlayout-class.md)