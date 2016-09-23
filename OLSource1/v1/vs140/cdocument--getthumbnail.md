---
title: "CDocument::GetThumbnail"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - afxwin/CDocument::GetThumbnail
  - GetThumbnail
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetThumbnail
ms.assetid: 30b3a2af-e1c9-4be7-b4b6-a1527e91c478
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocument::GetThumbnail
Creates a bitmap to be used by the thumbnail provider to display the thumbnail.  
  
## Syntax  
  
```  
virtual BOOL GetThumbnail(  
   UINT cx,  
   HBITMAP* phbmp,  
   DWORD* pdwAlpha  
);  
```  
  
#### Parameters  
 `cx`  
 Specifies the width and height of the bitmap.  
  
 `phbmp`  
 Contains a handle to a bitmap, when the function returns successfully.  
  
 `pdwAlpha`  
 Contains a DWORD specifying the alpha channel value, when the function returns successfully.  
  
## Return Value  
 Returns `TRUE` if a bitmap for the thumbnail was created successfully; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)