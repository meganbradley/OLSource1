---
title: "CMFCPropertyGridFontProperty Class"
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
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridFontProperty::OnClickButton method"
  - "CMFCPropertyGridFontProperty class"
  - "CMFCPropertyGridFontProperty::FormatProperty method"
ms.assetid: 83693f33-bbd3-4fcb-a9ad-fa79fcf2ca24
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridFontProperty Class
The `CMFCPropertyGridFileProperty` class supports a property list control item that opens a font selection dialog box.  
  
## Syntax  
  
```  
class CMFCPropertyGridFontProperty : public CMFCPropertyGridProperty  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridFontProperty::CMFCPropertyGridFontProperty](#cmfcpropertygridfontproperty__cmfcpropertygridfontproperty)|Constructs a `CMFCPropertyGridFontProperty` object.|  
|`CMFCPropertyGridFontProperty::~CMFCPropertyGridFontProperty`|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|`CMFCPropertyGridFontProperty::FormatProperty`|Formats the text representation of a property value. (Overrides [CMFCPropertyGridProperty::FormatProperty](../VS_csharp/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__formatproperty).)|  
|[CMFCPropertyGridFontProperty::GetColor](#cmfcpropertygridfontproperty__getcolor)|Retrieves the font color that the user selects from the font dialog box.|  
|[CMFCPropertyGridFontProperty::GetLogFont](#cmfcpropertygridfontproperty__getlogfont)|Retrieves the font that the user selects from the font dialog box.|  
|`CMFCPropertyGridFontProperty::GetThisClass`|Used by the framework to obtain a pointer to the [CRuntimeClass](../VS_csharp/cruntimeclass-structure.md) object that is associated with this class type.|  
|`CMFCPropertyGridFontProperty::OnClickButton`|Called by the framework when the user clicks a button that is contained in a property. (Overrides [CMFCPropertyGridProperty::OnClickButton](../VS_csharp/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__onclickbutton).)|  
  
## Remarks  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CMFCPropertyGridProperty](../VS_csharp/cmfcpropertygridproperty-class.md)  
  
 [CMFCPropertyGridFontProperty](../VS_csharp/cmfcpropertygridfontproperty-class.md)  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
##  <a name="cmfcpropertygridfontproperty__cmfcpropertygridfontproperty"></a>  CMFCPropertyGridFontProperty::CMFCPropertyGridFontProperty  
 Constructs a `CMFCPropertyGridFontProperty` object.  
  
```  
CMFCPropertyGridFontProperty(  
   const CString& strName,  
   LOGFONT& lf,  
   DWORD dwFontDialogFlags = CF_EFFECTS | CF_SCREENFONTS,  
   LPCTSTR lpszDescr = NULL,  
   DWORD_PTR dwData = 0,  
   COLORREF color = (COLORREF)-1  
);  
```  
  
### Parameters  
 [in] `strName`  
 The name of the property.  
  
 [in] `lf`  
 A logical font structure that specifies the attributes of the font.  
  
 [in] `dwFontDialogFlags`  
 Styles that are applied to the font dialog box that is displayed when you click the property value drop-down button. The default value is the bitwise combination (OR) of CF_EFFECTS and CF_SCREENFONTS. For more information, see the `Flags` parameter of the                                 [CHOOSEFONT Structure](http://msdn.microsoft.com/library/windows/desktop/ms646832).  
  
 [in] `lpszDescr`  
 Description of the font property. The default value is `NULL`.  
  
 [in] `dwData`  
 Application-specific data, such as an integer or a pointer to other data that is associated with the property. The default value is 0.  
  
 [in] `color`  
 The color of the font. The default value is the default color.  
  
### Remarks  
 A `CMFCPropertyGridFontProperty` object represents a font property in a property grid font control.  
  
### Example  
 The following example demonstrates how construct an object of the `CMFCPropertyGridFontProperty` class. This example is part of the [New Controls sample](../VS_csharp/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#26](../VS_csharp/codesnippet/CPP/cmfcpropertygridfontproperty-class_1.cpp)]  
  
##  <a name="cmfcpropertygridfontproperty__getcolor"></a>  CMFCPropertyGridFontProperty::GetColor  
 Retrieves the font color that the user selects from the font dialog box.  
  
```  
COLORREF GetColor() const;  
```  
  
### Return Value  
 An RGB color value that represents the selected font color.  
  
### Remarks  
  
##  <a name="cmfcpropertygridfontproperty__getlogfont"></a>  CMFCPropertyGridFontProperty::GetLogFont  
 Retrieves the font that the user selects from the font dialog box.  
  
```  
LPLOGFONT GetLogFont();  
```  
  
### Return Value  
 A pointer to a                         [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure that describes the selected font.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [Classes](../VS_csharp/mfc-classes.md)   
 [CMFCPropertyGridCtrl](../VS_csharp/cmfcpropertygridctrl-class.md)   
 [CMFCPropertyGridProperty](../VS_csharp/cmfcpropertygridproperty-class.md)