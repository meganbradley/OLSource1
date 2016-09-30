---
title: "CMFCPropertyGridFontProperty::CMFCPropertyGridFontProperty"
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
  - "CMFCPropertyGridFontProperty"
  - "CMFCPropertyGridFontProperty.CMFCPropertyGridFontProperty"
  - "CMFCPropertyGridFontProperty::CMFCPropertyGridFontProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridFontProperty, constructor"
ms.assetid: 7fdb39f2-2aa7-4961-934b-fece05fbdfee
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridFontProperty::CMFCPropertyGridFontProperty
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the property.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A logical font structure that specifies the attributes of the font.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Styles that are applied to the font dialog box that is displayed when you click the property value drop-down button. The default value is the bitwise combination (OR) of CF_EFFECTS and CF_SCREENFONTS. For more information, see the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of the [CHOOSEFONT Structure](http://msdn.microsoft.com/library/windows/desktop/ms646832).  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Description of the font property. The default value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Application-specific data, such as an integer or a pointer to other data that is associated with the property. The default value is 0.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The color of the font. The default value is the default color.  
  
## Remarks  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object represents a font property in a property grid font control.  
  
## Example  
 The following example demonstrates how construct an object of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#26](../vs140/codesnippet/CPP/cmfcpropertygridfontproperty--cmfcpropertygridfontproperty_1.cpp)]  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridFontProperty Class](../vs140/cmfcpropertygridfontproperty-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/bb773327)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)