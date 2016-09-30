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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A CString object that contains the name of the font family.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The logical size of the font in DIP ("device-independent pixel") units. A DIPequals 1/96 inch.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A value that indicates the font weight for the text object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A value that indicates the font style for the text object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value that indicates the font stretch for the text object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A CString object that contains the locale name.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to a font collection object. When this is NULL, indicates the system font collection.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DTextFormat Class](../vs140/cd2dtextformat-class.md)