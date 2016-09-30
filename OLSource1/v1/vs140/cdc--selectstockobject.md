---
title: "CDC::SelectStockObject"
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
  - "SelectStockObject"
  - "CDC.SelectStockObject"
  - "CDC::SelectStockObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectStockObject method"
  - "CDC class, type-safe selection helpers"
ms.assetid: e135edec-c283-49e7-b682-4b3e077b4ca4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SelectStockObject
Selects a [CGdiObject](../vs140/cgdiobject-class.md) object that corresponds to one of the predefined stock pens, brushes, or fonts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the kind of stock object desired. It can be one of the following values:  
  
-   **BLACK_BRUSH** Black brush.  
  
-   **DKGRAY_BRUSH** Dark gray brush.  
  
-   **GRAY_BRUSH** Gray brush.  
  
-   **HOLLOW_BRUSH** Hollow brush.  
  
-   **LTGRAY_BRUSH** Light gray brush.  
  
-   **NULL_BRUSH** Null brush.  
  
-   **WHITE_BRUSH** White brush.  
  
-   **BLACK_PEN** Black pen.  
  
-   **NULL_PEN** Null pen.  
  
-   **WHITE_PEN** White pen.  
  
-   **ANSI_FIXED_FONT** ANSI fixed system font.  
  
-   **ANSI_VAR_FONT** ANSI variable system font.  
  
-   **DEVICE_DEFAULT_FONT** Device-dependent font.  
  
-   **OEM_FIXED_FONT** OEM-dependent fixed font.  
  
-   **SYSTEM_FONT** The system font. By default, Windows uses the system font to draw menus, dialog-box controls, and other text. It is best, however, not to rely on SYSTEM_FONT to obtain the font used by dialogs and windows. Instead, use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function with the SPI_GETNONCLIENTMETRICS parameter to retrieve the current font. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> takes into account the current theme and provides font information for captions, menus, and message dialogs.  
  
-   **SYSTEM_FIXED_FONT** The fixed-width system font used in Windows prior to version 3.0. This object is available for compatibility with earlier versions of Windows.  
  
-   **DEFAULT_PALETTE** Default color palette. This palette consists of the 20 static colors in the system palette.  
  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that was replaced if the function is successful. The actual object pointed to is a [CPen](../vs140/cpen-class.md), [CBrush](../vs140/cbrush-class.md), or [CFont](../vs140/cfont-class.md) object. If the call is unsuccessful, the return value is **NULL**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::GetObject](../vs140/cgdiobject--getobject.md)