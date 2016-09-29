---
title: "CDC::SetStretchBltMode"
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
  - "CDC.SetStretchBltMode"
  - "SetStretchBltMode"
  - "CDC::SetStretchBltMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "SetStretchBltMode method"
ms.assetid: 0fc3542c-cb4a-435d-a32b-04300e88b9c6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetStretchBltMode
Sets the bitmap-stretching mode for the `StretchBlt` member function.  
  
## Syntax  
  
```  
  
      int SetStretchBltMode(  
   int nStretchMode   
);  
```  
  
#### Parameters  
 *nStretchMode*  
 Specifies the stretching mode. It can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|**BLACKONWHITE**|Performs a Boolean AND operation using the color values for the eliminated and existing pixels. If the bitmap is a monochrome bitmap, this mode preserves black pixels at the expense of white pixels.|  
|**COLORONCOLOR**|Deletes the pixels. This mode deletes all eliminated lines of pixels without trying to preserve their information.|  
|**HALFTONE**|Maps pixels from the source rectangle into blocks of pixels in the destination rectangle. The average color over the destination block of pixels approximates the color of the source pixels.|  
||After setting the **HALFTONE** stretching mode, an application must call the Win32 function [SetBrushOrgEx](http://msdn.microsoft.com/library/windows/desktop/dd162967) to set the brush origin. If it fails to do so, brush misalignment occurs.|  
|**STRETCH_ANDSCANS**|**Windows 95/98**: Same as **BLACKONWHITE**|  
|**STRETCH_DELETESCANS**|**Windows 95/98**: Same as **COLORONCOLOR**|  
|**STRETCH_HALFTONE**|**Windows 95/98**: Same as **HALFTONE**.|  
|**STRETCH_ORSCANS**|**Windows 95/98**: Same as **WHITEONBLACK**|  
|**WHITEONBLACK**|Performs a Boolean OR operation using the color values for the eliminated and existing pixels. If the bitmap is a monochrome bitmap, this mode preserves white pixels at the expense of black pixels.|  
  
## Return Value  
 The previous stretching mode. It can be **STRETCH_ANDSCANS**, **STRETCH_DELETESCANS**, or **STRETCH_ORSCANS**.  
  
## Remarks  
 The bitmap-stretching mode defines how information is removed from bitmaps that are compressed by using the function.  
  
 The **BLACKONWHITE** (**STRETCH_ANDSCANS**) and **WHITEONBLACK** (**STRETCH_ORSCANS**) modes are typically used to preserve foreground pixels in monochrome bitmaps. The **COLORONCOLOR** (**STRETCH_DELETESCANS**) mode is typically used to preserve color in color bitmaps.  
  
 The **HALFTONE** mode requires more processing of the source image than the other three modes; it is slower than the others, but produces higher quality images. Also note that **SetBrushOrgEx** must be called after setting the **HALFTONE** mode to avoid brush misalignment.  
  
 Additional stretching modes might also be available depending on the capabilities of the device driver.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetStretchBltMode](../vs140/cdc--getstretchbltmode.md)   
 [CDC::StretchBlt](../vs140/cdc--stretchblt.md)   
 [SetStretchBltMode](http://msdn.microsoft.com/library/windows/desktop/dd145089)