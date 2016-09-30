---
title: "CDrawingManager::PrepareShadowMask"
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
  - "CDrawingManager.PrepareShadowMask"
  - "CDrawingManager::PrepareShadowMask"
  - "PrepareShadowMask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrepareShadowMask method"
ms.assetid: c2cdac13-adbb-4bd3-9e67-1c1b8888bae0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::PrepareShadowMask
Creates a bitmap that can be used as a shadow.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The width and height of the shadow.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The color of the shadow.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The minimum brightness of the shadow.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum brightness of the shadow.  
  
## Return Value  
 A handle to the created bitmap if this method is successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to 0, this method exits and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is less than 3, the width and height of the shadow are set to 3 pixels.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)