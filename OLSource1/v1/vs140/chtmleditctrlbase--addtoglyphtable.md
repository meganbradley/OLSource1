---
title: "CHtmlEditCtrlBase::AddToGlyphTable"
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
  - "AddToGlyphTable"
  - "CHtmlEditCtrlBase<T>::AddToGlyphTable"
  - "CHtmlEditCtrlBase::AddToGlyphTable"
  - "CHtmlEditCtrlBase.AddToGlyphTable"
  - "CHtmlEditCtrlBase<T>.AddToGlyphTable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToGlyphTable method"
ms.assetid: e3e51c82-2aa7-431d-b053-cc10cdcd5179
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::AddToGlyphTable
Adds an entry to the glyph table, which specifies images to display for specific tags in design mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The tag name (for example, "P" or "table").  
  
 *szImgUrl*  
 The image URL.  
  
 *nTagType*  
 Tag type: 0 means the image is for the opening tag only. 1 means the image is for the closing tag only. 2 means the image is for both the opening and closing tags. Single tags such as br and comment must be added with the tag type set to 0.  
  
 *nAlignment*  
 Alignment (rectangular elements only): This parameter indicates that the image is for an element with an alignment attribute. Left = 0, center = 1, right = 2, and undefined = 3. Left, right, or center attributes must be explicitly set on the element.  
  
 *nPosInfo*  
 Positioning information. Determines what cascading style sheets (CSS) positioning value the glyph applies to, where static positioning = 0, absolute positioning = 1, relative positioning = 2, and all = 3. This field enables you to specify one glyph for a tag when it is not positioned and another glyph to show an anchor point when the tag is positioned.  
  
 *nDirection*  
 The direction. This parameter specifies the image for a tag based on the reading order of the current language. 0 specifies left to right, 1 specifies right to left, 2 specifies top to bottom, 3 specifies bottom to top, and 4 specifies all. You normally set this field to 4.  
  
 *nImgWidth*  
 The image width in pixels.  
  
 *nImgHeight*  
 The image height in pixels.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 For more information on the parameters, see "Glyph Table String Format" in [Using Editing Glyphs](https://msdn.microsoft.com/en-us/library/aa969614.aspx).  
  
 This method sends the [IDM_ADDTOGLYPHTABLE command ID](https://msdn.microsoft.com/en-us/library/aa769891.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::EmptyGlyphTable](../vs140/chtmleditctrlbase--emptyglyphtable.md)