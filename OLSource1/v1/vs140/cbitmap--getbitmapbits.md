---
title: "CBitmap::GetBitmapBits"
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
  - CBitmap::GetBitmapBits
  - GetBitmapBits
  - CBitmap.GetBitmapBits
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetBitmapBits method
ms.assetid: ada3e266-41f8-445b-b4ba-a23c423f9dab
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBitmap::GetBitmapBits
Copies the bit pattern of the attached bitmap into the specified buffer.  
  
## Syntax  
  
```  
DWORD GetBitmapBits(  
   DWORD dwCount,  
   LPVOID lpBits  
) const;  
```  
  
#### Parameters  
 `dwCount`  
 The number of bytes to copy to the buffer.  
  
 `lpBits`  
 Pointer to the buffer that will receive the bitmap.  
  
## Return Value  
 The number of bytes copied to the buffer if the method was successful; otherwise 0.  
  
## Remarks  
 Use [CBitmap::GetBitmap](../vs140/cbitmap--getbitmap.md) to determine the required buffer size.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::GetObject](../vs140/cgdiobject--getobject.md)   
 [GetBitmapBits](http://msdn.microsoft.com/library/windows/desktop/dd144850)