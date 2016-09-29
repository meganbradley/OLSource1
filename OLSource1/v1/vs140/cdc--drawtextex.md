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
  
```  
  
      virtual int DrawTextEx(  
   LPTSTR lpszString,  
   int nCount,  
   LPRECT lpRect,  
   UINT nFormat,  
   LPDRAWTEXTPARAMS lpDTParams  
);  
int DrawTextEx(  
   const CString& str,  
   LPRECT lpRect,  
   UINT nFormat,  
   LPDRAWTEXTPARAMS lpDTParams  
);  
```  
  
#### Parameters  
 `lpszString`  
 Points to the string to be drawn. If `nCount` is –1, the string must be null terminated.  
  
 `nCount`  
 Specifies the number of chars in the string. If `nCount` is –1, then `lpszString` is assumed to be a long pointer to a null-terminated string and `DrawText` computes the character count automatically.  
  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the rectangle (in logical coordinates) in which the text is to be formatted.  
  
 `str`  
 A [CString](../vs140/cstringt-class.md) object that contains the specified characters to be drawn.  
  
 `nFormat`  
 Specifies the method of formatting the text. It can be any combination of the values described for the `uFormat` parameter in [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. (Combine using the bitwise `OR` operator):  
  
> [!NOTE]
>  Some `uFormat` flag combinations can cause the passed string to be modified. Using **DT_MODIFYSTRING** with either **DT_END_ELLIPSIS** or **DT_PATH_ELLIPSIS** may cause the string to be modified, causing an assertion in the `CString` override. The values `DT_CALCRECT`, `DT_EXTERNALLEADING`, **DT_INTERNAL**, `DT_NOCLIP`, and `DT_NOPREFIX` cannot be used with the `DT_TABSTOP` value.  
  
 `lpDTParams`  
 Pointer to a [DRAWTEXTPARAMS](http://msdn.microsoft.com/library/windows/desktop/dd162500) structure that specifies additional formatting options. This parameter can be **NULL**.  
  
## Remarks  
 It formats text by expanding tabs into appropriate spaces, aligning text to the left, right, or center of the given rectangle, and breaking text into lines that fit within the given rectangle. The type of formatting is specified by `nFormat` and `lpDTParams`. For more information, see [CDC::DrawText](../vs140/cdc--drawtext.md) and [DrawTextEx](http://msdn.microsoft.com/library/windows/desktop/dd162499) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
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