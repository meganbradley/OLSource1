---
title: "AFX_GLOBAL_DATA::DrawTextOnGlass"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DrawTextOnGlass"
  - "AFX_GLOBAL_DATA.DrawTextOnGlass"
  - "AFX_GLOBAL_DATA::DrawTextOnGlass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawTextOnGlass method"
  - "AFX_GLOBAL_DATA::DrawTextOnGlass"
ms.assetid: c4054a35-d9db-424a-8606-3c658230576e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::DrawTextOnGlass
Draws the specified text in the visual style of the specified theme.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the theme data of a window, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The framework uses the specified theme to draw the text if this parameter is not <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and themes are supported. Otherwise, the framework does not use a theme to draw the text.  
  
 Use the [OpenThemeData](http://msdn.microsoft.com/library/windows/desktop/bb759821) method to create an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The control part that has the desired text appearance. For more information, see the Parts column of the table in [Parts and States](http://msdn.microsoft.com/library/windows/desktop/bb773210). If this value is 0, the text is drawn in the default font, or a font selected into the device context.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The control state that has the desired text appearance. For more information, see the States column of the table in [Parts and States](http://msdn.microsoft.com/library/windows/desktop/bb773210).  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The text to draw.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The boundary of the area in which the specified text is drawn.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of flags that specify how the specified text is drawn.  
  
 If the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or if themes are not supported and enabled, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter of the [CDC::DrawText](../vs140/cdc--drawtext.md) method describes the valid flags. If themes are supported, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter of the [DrawThemeTextEx](http://msdn.microsoft.com/library/windows/desktop/bb773317) method describes the valid flags.  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The size of a glow effect that is drawn on the background before drawing the specified text. The default value is 0.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The color in which the specified text is drawn. The default value is the default color.  
  
## Return Value  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if a theme is used to draw the specified text; otherwise, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Remarks  
 A theme defines the visual style of an application. For more information, see [Themes and Visual Styles](_inet_themes_visualstyles_overview). A theme is not used to draw the text if the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or if the [DrawThemeTextEx](http://msdn.microsoft.com/library/windows/desktop/bb773317) method is not supported, or if [Desktop Window Manager](http://msdn.microsoft.com/library/windows/desktop/aa969540) (DWM) composition is disabled.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [Themes and Visual Styles](_inet_themes_visualstyles_overview)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [Parts and States](http://msdn.microsoft.com/library/windows/desktop/bb773210)   
 [CDC::DrawText](../vs140/cdc--drawtext.md)   
 [DrawThemeTextEx](http://msdn.microsoft.com/library/windows/desktop/bb773317)   
 [Desktop Window Manager](http://msdn.microsoft.com/library/windows/desktop/aa969540)   
 [Enable and Control DWM Composition](http://msdn.microsoft.com/library/windows/desktop/aa969538)