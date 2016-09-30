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
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class supports a property list control item that opens a font selection dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridFontProperty::CMFCPropertyGridFontProperty](#cmfcpropertygridfontproperty__cmfcpropertygridfontproperty)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Formats the text representation of a property value. (Overrides [CMFCPropertyGridProperty::FormatProperty](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__formatproperty).)|  
|[CMFCPropertyGridFontProperty::GetColor](#cmfcpropertygridfontproperty__getcolor)|Retrieves the font color that the user selects from the font dialog box.|  
|[CMFCPropertyGridFontProperty::GetLogFont](#cmfcpropertygridfontproperty__getlogfont)|Retrieves the font that the user selects from the font dialog box.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Called by the framework when the user clicks a button that is contained in a property. (Overrides [CMFCPropertyGridProperty::OnClickButton](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__onclickbutton).)|  
  
## Remarks  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md)  
  
 [CMFCPropertyGridFontProperty](../vs140/cmfcpropertygridfontproperty-class.md)  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
##  \<a name="cmfcpropertygridfontproperty__cmfcpropertygridfontproperty">\</a>  CMFCPropertyGridFontProperty::CMFCPropertyGridFontProperty  
 Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The name of the property.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A logical font structure that specifies the attributes of the font.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Styles that are applied to the font dialog box that is displayed when you click the property value drop-down button. The default value is the bitwise combination (OR) of CF_EFFECTS and CF_SCREENFONTS. For more information, see the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter of the                                 [CHOOSEFONT Structure](http://msdn.microsoft.com/library/windows/desktop/ms646832).  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Description of the font property. The default value is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Application-specific data, such as an integer or a pointer to other data that is associated with the property. The default value is 0.  
  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The color of the font. The default value is the default color.  
  
### Remarks  
 A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object represents a font property in a property grid font control.  
  
### Example  
 The following example demonstrates how construct an object of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#26](../vs140/codesnippet/CPP/cmfcpropertygridfontproperty-class_1.cpp)]  
  
##  \<a name="cmfcpropertygridfontproperty__getcolor">\</a>  CMFCPropertyGridFontProperty::GetColor  
 Retrieves the font color that the user selects from the font dialog box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An RGB color value that represents the selected font color.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridfontproperty__getlogfont">\</a>  CMFCPropertyGridFontProperty::GetLogFont  
 Retrieves the font that the user selects from the font dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a                         [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure that describes the selected font.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCPropertyGridCtrl](../vs140/cmfcpropertygridctrl-class.md)   
 [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md)