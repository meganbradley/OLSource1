---
title: "CDC::DrawText"
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
  - "DT_EXPANDTABS"
  - "DT_EXTERNALLEADING"
  - "CDC.DrawText"
  - "DT_BOTTOM"
  - "DT_TABSTOP"
  - "DT_CALCRECT"
  - "DT_SINGLELINE"
  - "DT_VCENTER"
  - "DT_LEFT"
  - "DrawText"
  - "DT_NOCLIP"
  - "CDC::DrawText"
  - "DT_CENTER"
  - "DT_RIGHT"
  - "DT_TOP"
  - "DT_NOPREFIX"
  - "DT_WORDBREAK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawText method"
  - "DT_CENTER"
  - "DT_NOCLIP"
  - "DT_WORDBREAK"
  - "DT_CALCRECT"
  - "DT_EXTERNALLEADING"
  - "DT_TOP"
  - "DT_EXPANDTABS"
  - "DT_TABSTOP"
  - "DT_RIGHT"
  - "DT_NOPREFIX"
  - "DT_VCENTER"
  - "DT_SINGLELINE"
  - "DT_LEFT"
  - "DT_BOTTOM"
  - "CDC class, text functions"
ms.assetid: de687c9f-55f7-4e4e-8cb6-13fd6d9e7327
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawText
Call this member function to format text in the given rectangle. To specify additional formatting options, use [CDC::DrawTextEx](../vs140/cdc--drawtextex.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the string to be drawn. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is –1, the string must be null-terminated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the number of chars in the string. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is –1, then <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assumed to be a long pointer to a null-terminated string and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> computes the character count automatically.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the rectangle (in logical coordinates) in which the text is to be formatted.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object that contains the specified characters to be drawn.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the method of formatting the text. It can be any combination of the values described for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter in [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. (combine using the bitwise OR operator):  
  
> [!NOTE]
>  Some <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> flag combinations can cause the passed string to be modified. Using **DT_MODIFYSTRING** with either **DT_END_ELLIPSIS** or **DT_PATH_ELLIPSIS** may cause the string to be modified, causing an assertion in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> override. The values <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, **DT_INTERNAL**, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> cannot be used with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value.  
  
## Return Value  
 The height of the text if the function is successful.  
  
## Remarks  
 It formats text by expanding tabs into appropriate spaces, aligning text to the left, right, or center of the given rectangle, and breaking text into lines that fit within the given rectangle. The type of formatting is specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 This member function uses the device context's selected font, text color, and background color to draw the text. Unless the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> format is used, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> clips the text so that the text does not appear outside the given rectangle. All formatting is assumed to have multiple lines unless the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> format is given.  
  
 If the selected font is too large for the specified rectangle, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function does not attempt to substitute a smaller font.  
  
 If the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> flag is specified, the rectangle specified by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> will be updated to reflect the width and height needed to draw the text.  
  
 If the **TA_UPDATECP** text-alignment flag has been set (see [CDC::SetTextAlign](../vs140/cdc--settextalign.md)), <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> will display text starting at the current position, rather than at the left of the given rectangle. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> will not wrap text when the **TA_UPDATECP** flag has been set (that is, the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> flag will have no effect).  
  
 The text color may be set by [CDC::SetTextColor](../vs140/cdc--settextcolor.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetTextColor](../vs140/cdc--settextcolor.md)   
 [CDC::ExtTextOut](../vs140/cdc--exttextout.md)   
 [CDC::TabbedTextOut](../vs140/cdc--tabbedtextout.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CDC::SetTextAlign](../vs140/cdc--settextalign.md)