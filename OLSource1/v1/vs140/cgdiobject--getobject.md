---
title: "CGdiObject::GetObject"
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
  - "CGdiObject::GetObject"
  - "CGdiObject.GetObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetObject method"
  - "CGdiObject class, operations"
ms.assetid: b2dbc14b-d08b-4aad-8101-0103ccaa7470
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::GetObject
Fills a buffer with data that defines a specified object.  
  
## Syntax  
  
```  
  
      int GetObject(  
   int nCount,  
   LPVOID lpObject   
) const;  
```  
  
#### Parameters  
 `nCount`  
 Specifies the number of bytes to copy into the `lpObject` buffer.  
  
 `lpObject`  
 Points to a user-supplied buffer that is to receive the information.  
  
## Return Value  
 The number of bytes retrieved; otherwise 0 if an error occurs.  
  
## Remarks  
 The function retrieves a data structure whose type depends on the type of graphic object, as shown by the following list:  
  
|Object|Buffer type|  
|------------|-----------------|  
|`CPen`|[LOGPEN](../vs140/logpen-structure.md)|  
|`CBrush`|[LOGBRUSH](../vs140/logbrush-structure.md)|  
|`CFont`|[LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)|  
|`CBitmap`|[BITMAP](../vs140/bitmap-structure.md)|  
|`CPalette`|**WORD**|  
|`CRgn`|Not supported|  
  
 If the object is a `CBitmap` object, `GetObject` returns only the width, height, and color format information of the bitmap. The actual bits can be retrieved by using [CBitmap::GetBitmapBits](../vs140/cbitmap--getbitmapbits.md).  
  
 If the object is a `CPalette` object, `GetObject` retrieves a **WORD** that specifies the number of entries in the palette. The function does not retrieve the [LOGPALETTE](http://msdn.microsoft.com/library/windows/desktop/dd145040) structure that defines the palette. An application can get information on palette entries by calling [CPalette::GetPaletteEntries](../vs140/cpalette--getpaletteentries.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap::GetBitmapBits](../vs140/cbitmap--getbitmapbits.md)   
 [CPalette::GetPaletteEntries](../vs140/cpalette--getpaletteentries.md)