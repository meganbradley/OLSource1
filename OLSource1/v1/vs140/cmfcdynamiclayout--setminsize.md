---
title: "CMFCDynamicLayout::SetMinSize"
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
ms.assetid: a0d068ce-0abd-4650-8c00-4dab96bb62da
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDynamicLayout::SetMinSize
Sets the window size below which layout is not adjusted.  
  
## Syntax  
  
```  
  
  void SetMinSize(  
const CSize& size );  
```  
  
#### Parameters  
 `size`  
 The desired size below which layout is not adjusted.  
  
## Remarks  
 The position and size of a child control is changed dynamically when a hosting window is being resized, but there is a minimum size below which the layout is not adjusted. The user can resize the window to a smaller size, but parts of the window are then hidden from view.  
  
## Requirements  
 **Header:** afxlayout.h  
  
## See Also  
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)   
 [CSize Class](../vs140/csize-class.md)