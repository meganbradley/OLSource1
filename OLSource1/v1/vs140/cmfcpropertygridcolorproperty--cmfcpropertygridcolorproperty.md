---
title: "CMFCPropertyGridColorProperty::CMFCPropertyGridColorProperty"
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
  - "CMFCPropertyGridColorProperty.CMFCPropertyGridColorProperty"
  - "CMFCPropertyGridColorProperty::CMFCPropertyGridColorProperty"
  - "CMFCPropertyGridColorProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridColorProperty, constructor"
ms.assetid: bf1e1cae-9dc9-46c3-a399-19fe39ac995b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridColorProperty::CMFCPropertyGridColorProperty
Constructs a `CMFCPropertyGridColorProperty` object.  
  
## Syntax  
  
```  
CMFCPropertyGridColorProperty(  
   const CString& strName,  
   const COLORREF& color,  
   CPalette* pPalette = NULL,  
   LPCTSTR lpszDescr = NULL,  
   DWORD_PTR dwData = 0  
);  
```  
  
#### Parameters  
 [in] `strName`  
 The name of the property.  
  
 [in] `color`  
 The color value of the property.  
  
 [in] `pPalette`  
 Pointer to a palette of colors. The default value is `NULL`.  
  
 [in] `lpszDescr`  
 The property description. The default value is `NULL`.  
  
 [in] `dwData`  
 Application-specific data, such as an integer or a pointer to other data that is associated with the property. The default value is 0.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridColorProperty Class](../vs140/cmfcpropertygridcolorproperty-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)   
 [CPalette Class](../vs140/cpalette-class.md)