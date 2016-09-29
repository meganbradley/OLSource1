---
title: "CDC::SetLayout"
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
  - "CDC::SetLayout"
  - "SetLayout"
  - "CDC.SetLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLayout method"
  - "CDC class, layout functions"
ms.assetid: 6f562bb6-cf73-465b-a1c6-eb3d560c2980
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetLayout
Call this member function to change the layout of the text and graphics for a device context to right to left, the standard layout for cultures such as Arabic and Hebrew.  
  
## Syntax  
  
```  
  
      DWORD SetLayout(  
   DWORD dwLayout   
);  
```  
  
#### Parameters  
 `dwLayout`  
 Device context layout and bitmap control flags. It can be a combination of the following values.  
  
|Value|Meaning|  
|-----------|-------------|  
|LAYOUT_BITMAPORIENTATIONPRESERVED|Disables any reflection for calls to [CDC::BitBlt](../vs140/cdc--bitblt.md) and [CDC::StretchBlt](../vs140/cdc--stretchblt.md).|  
|LAYOUT_RTL|Sets the default horizontal layout to be right to left.|  
|LAYOUT_LTR|Sets the default layout to be left to right.|  
  
## Return Value  
 If successful, the previous layout of the device context.  
  
 If unsuccessful, **GDI_ERROR**. To get extended error information, call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 Normally, you would not call **SetLayout** for a window. Rather, you control the right-to-left layout in a window by setting the [extended window styles](../vs140/extended-window-styles.md) such as **WS_EX_RTLREADING**. A device context, such as a printer or a metafile, does not inherit this layout. The only way to set the device context for a right-to-left layout is by calling **SetLayout**.  
  
 If you call **SetLayout( LAYOUT_RTL** ), **SetLayout** automatically changes the mapping mode to `MM_ISOTROPIC`. As a result, a subsequent call to [GetMapMode](../vs140/cdc--getmapmode.md) will return **MM_ISOTROPIC** instead of `MM_TEXT`.  
  
 In some cases, such as with many bitmaps, you may want to preserve the left-to-right layout. In these cases, render the image by calling `BitBlt` or `StretchBlt`, then set the bitmap control flag for `dwLayout` to **LAYOUT_BITMAPORIENTATIONPRESERVED**.  
  
 Once you change the layout with the **LAYOUT_RTL** flag, the flags normally specifying right or left are reversed. To avoid confusion, you may want to define alternate names for the standard flags. For a list of suggested alternate flag names, see [SetLayout](http://msdn.microsoft.com/library/windows/desktop/dd162979) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetLayout](../vs140/cdc--getlayout.md)   
 [CDC::SetMapMode](../vs140/cdc--setmapmode.md)