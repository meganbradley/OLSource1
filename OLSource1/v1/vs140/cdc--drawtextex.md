---
title: "CDC::DrawTextEx"
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
  - "CDC::DrawTextEx"
  - "DrawTextEx"
  - "CDC.DrawTextEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawTextEx method"
  - "CDC class, text functions"
ms.assetid: ce88ed51-cf4f-4af2-b014-db9d5773aa5c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawTextEx
Formats text in the given rectangle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the string to be drawn. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is –1, the string must be null terminated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the number of chars in the string. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is –1, then <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assumed to be a long pointer to a null-terminated string and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> computes the character count automatically.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the rectangle (in logical coordinates) in which the text is to be formatted.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object that contains the specified characters to be drawn.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the method of formatting the text. It can be any combination of the values described for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter in [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. (Combine using the bitwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator):  
  
> [!NOTE]
>  Some <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> flag combinations can cause the passed string to be modified. Using **DT_MODIFYSTRING** with either **DT_END_ELLIPSIS** or **DT_PATH_ELLIPSIS** may cause the string to be modified, causing an assertion in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> override. The values <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, **DT_INTERNAL**, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> cannot be used with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Pointer to a [DRAWTEXTPARAMS](http://msdn.microsoft.com/library/windows/desktop/dd162500) structure that specifies additional formatting options. This parameter can be **NULL**.  
  
## Remarks  
 It formats text by expanding tabs into appropriate spaces, aligning text to the left, right, or center of the given rectangle, and breaking text into lines that fit within the given rectangle. The type of formatting is specified by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [CDC::DrawText](../vs140/cdc--drawtext.md) and [DrawTextEx](http://msdn.microsoft.com/library/windows/desktop/dd162499) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The text color may be set by [CDC::SetTextColor](../vs140/cdc--settextcolor.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::DrawText](../vs140/cdc--drawtext.md)   
 [CDC::ExtTextOut](../vs140/cdc--exttextout.md)   
 [CDC::TabbedTextOut](../vs140/cdc--tabbedtextout.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CDC::SetTextAlign](../vs140/cdc--settextalign.md)