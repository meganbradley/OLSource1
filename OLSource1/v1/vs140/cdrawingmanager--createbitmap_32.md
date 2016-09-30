---
title: "CDrawingManager::CreateBitmap_32"
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
  - "CDrawingManager.CreateBitmap_32"
  - "CDrawingManager::CreateBitmap_32"
  - "CreateBitmap_32"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateBitmap_32 method"
ms.assetid: 5c72423b-4838-4a21-ac37-9d1948d904fc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::CreateBitmap_32
Creates a 32-bit device-independent bitmap (DIB) that applications can write to directly.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A [CSize](../vs140/csize-class.md) parameter that indicates the size of the bitmap.|  
|[out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to a data pointer that receives the location of the DIB's bit values.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A handle to the original bitmap|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|An RGB value specifying transparent color of the original bitmap.|  
  
## Return Value  
 A handle to the newly created DIB bitmap if this method is successful; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 For more information about how to create a DIB bitmap, see [CreateDIBSection](http://msdn.microsoft.com/library/windows/desktop/dd183491).  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CreateDIBSection](http://msdn.microsoft.com/library/windows/desktop/dd183491)