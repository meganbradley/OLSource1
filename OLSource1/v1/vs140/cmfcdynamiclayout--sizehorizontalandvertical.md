---
title: "CMFCDynamicLayout::SizeHorizontalAndVertical"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: 820d8638-7d8c-41f7-a525-0a4b7913032f
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDynamicLayout::SizeHorizontalAndVertical
Gets a [SizeSettings](../vs140/cmfcdynamiclayout--sizesettings-structure.md) value that defines how much a child control is resized horizontally when the user resizes its hosting window.  
  
## Syntax  
  
```vb  
  
  static SizeSettings SizeHorizontalAndVertical(    int nXRatio  
int nYRatio);  
```  
  
#### Parameters  
 `nXRatio`  
 Defines as a percentage how far a child control is resized horizontally when the user resizes the host window.  
  
 `nYRatio`  
 Defines as a percentage how far a child control is resized vertically when the user resizes the host window.  
  
## Return Value  
 A [SizeSettings](../vs140/cmfcdynamiclayout--sizesettings-structure.md) value that encapsulates the requested size ratio.  
  
## Remarks  
  
## Requirements  
 **Header:** afxlayout.h  
  
## See Also  
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)   
 [CMFCDynamicLayout::SizeSettings Structure](../vs140/cmfcdynamiclayout--sizesettings-structure.md)