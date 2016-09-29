---
title: "CD2DTextFormat::CD2DTextFormat"
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
  - "afxrendertarget/CD2DTextFormat::CD2DTextFormat"
  - "CD2DTextFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DTextFormat class, constructor"
ms.assetid: 9751afc1-6616-4b42-aa20-ef6418f02c73
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DTextFormat::CD2DTextFormat
Constructs a CD2DTextFormat object.  
  
## Syntax  
  
```  
CD2DTextFormat(  
   CRenderTarget* pParentTarget,  
   const CString& strFontFamilyName,  
   FLOAT fontSize,  
   DWRITE_FONT_WEIGHT fontWeight = DWRITE_FONT_WEIGHT_NORMAL,  
   DWRITE_FONT_STYLE fontStyle = DWRITE_FONT_STYLE_NORMAL,  
   DWRITE_FONT_STRETCH fontStretch = DWRITE_FONT_STRETCH_NORMAL,  
   const CString& strFontLocale = _T(""),  
   IDWriteFontCollection* pFontCollection = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `strFontFamilyName`  
 A CString object that contains the name of the font family.  
  
 `fontSize`  
 The logical size of the font in DIP ("device-independent pixel") units. A DIPequals 1/96 inch.  
  
 `fontWeight`  
 A value that indicates the font weight for the text object.  
  
 `fontStyle`  
 A value that indicates the font style for the text object.  
  
 `fontStretch`  
 A value that indicates the font stretch for the text object.  
  
 `strFontLocale`  
 A CString object that contains the locale name.  
  
 `pFontCollection`  
 A pointer to a font collection object. When this is NULL, indicates the system font collection.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DTextFormat Class](../vs140/cd2dtextformat-class.md)