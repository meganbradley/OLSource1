---
title: "CMFCPropertyGridColorProperty Class"
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
  - "CMFCPropertyGridColorProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridColorProperty class"
  - "CMFCPropertyGridColorProperty::OnClickButton method"
  - "CMFCPropertyGridColorProperty::FormatProperty method"
  - "CMFCPropertyGridColorProperty::OnDrawValue method"
  - "CMFCPropertyGridColorProperty::OnUpdateValue method"
  - "CMFCPropertyGridColorProperty::OnEdit method"
ms.assetid: af37be93-a91e-40a2-9a65-0f3412c6f0f8
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridColorProperty Class
The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class supports a property list control item that opens a color selection dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridColorProperty::CMFCPropertyGridColorProperty](#cmfcpropertygridcolorproperty__cmfcpropertygridcolorproperty)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridColorProperty::EnableAutomaticButton](#cmfcpropertygridcolorproperty__enableautomaticbutton)|Enables the *automatic* button on the color selection dialog box. (The standard automatic button is labeled **Automatic**.)|  
|[CMFCPropertyGridColorProperty::EnableOtherButton](#cmfcpropertygridcolorproperty__enableotherbutton)|Enables the *other* button on the color selection dialog box. (The standard other button is labeled **More Colors…**.)|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Formats the text representation of a property value. (Overrides [CMFCPropertyGridProperty::FormatProperty](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__formatproperty).)|  
|[CMFCPropertyGridColorProperty::GetColor](#cmfcpropertygridcolorproperty__getcolor)|Gets the current color of the property.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Called by the framework when the user clicks a button that is contained in a property. (Overrides [CMFCPropertyGridProperty::OnClickButton](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__onclickbutton).)|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Called by the framework to display the property value. (Overrides [CMFCPropertyGridProperty::OnDrawValue](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__ondrawvalue).)|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Called by the framework when the user is about to modify a property value. (Overrides [CMFCPropertyGridProperty::OnEdit](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__onedit).)|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Called by the framework when the value of an editable property has changed. (Overrides [CMFCPropertyGridProperty::OnUpdateValue](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__onupdatevalue).)|  
|[CMFCPropertyGridColorProperty::SetColor](#cmfcpropertygridcolorproperty__setcolor)|Sets a new color for the property.|  
|[CMFCPropertyGridColorProperty::SetColumnsNumber](#cmfcpropertygridcolorproperty__setcolumnsnumber)|Specifies the number of columns in the current color property grid.|  
|[CMFCPropertyGridColorProperty::SetOriginalValue](#cmfcpropertygridcolorproperty__setoriginalvalue)|Sets the original value of an editable property.|  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class supports a color property that can be added to a property list control. For more information, see the [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md).  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class and configure this object by using various methods of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class. The code explains how to enable the automatic and other buttons, and how to set the color and the columns number. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#13](../vs140/codesnippet/CPP/cmfcpropertygridcolorproperty-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md)  
  
 [CMFCPropertyGridColorProperty](../vs140/cmfcpropertygridcolorproperty-class.md)  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
##  \<a name="cmfcpropertygridcolorproperty__cmfcpropertygridcolorproperty">\</a>  CMFCPropertyGridColorProperty::CMFCPropertyGridColorProperty  
 Constructs a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The name of the property.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The color value of the property.  
  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Pointer to a palette of colors. The default value is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The property description. The default value is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Application-specific data, such as an integer or a pointer to other data that is associated with the property. The default value is 0.  
  
##  \<a name="cmfcpropertygridcolorproperty__enableautomaticbutton">\</a>  CMFCPropertyGridColorProperty::EnableAutomaticButton  
 Enables the *automatic* button on the color selection dialog box. (The standard automatic button is labeled **Automatic**.)  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The label text of the automatic button.  
  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The RGB color value of the automatic (default) color.  
  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to enable the automatic button; otherwise, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridcolorproperty__enableotherbutton">\</a>  CMFCPropertyGridColorProperty::EnableOtherButton  
 Enables the *other* button on the color selection dialog box. (The standard other button is labeled **More Colors…**.)  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The label text of the other button.  
  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to display the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> dialog box; <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to display the standard color selection dialog box. The default value is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to display the other button; otherwise, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  The default value is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridcolorproperty__getcolor">\</a>  CMFCPropertyGridColorProperty::GetColor  
 Gets the current color of the property.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An RGB color value.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridcolorproperty__setcolor">\</a>  CMFCPropertyGridColorProperty::SetColor  
 Sets a new color for the property.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 An RGB color value.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridcolorproperty__setcolumnsnumber">\</a>  CMFCPropertyGridColorProperty::SetColumnsNumber  
 Specifies the number of columns in the current color property grid.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The preferred number of columns in the color property grid.  
  
### Remarks  
 This method sets the value of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> protected data member.  
  
##  \<a name="cmfcpropertygridcolorproperty__setoriginalvalue">\</a>  CMFCPropertyGridColorProperty::SetOriginalValue  
 Sets the original value of an editable property.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A value.  
  
### Remarks  
 Use the [CMFCPropertyGridProperty::ResetOriginalValue](../vs140/cmfcpropertygridproperty-class.md#cmfcpropertygridproperty__resetoriginalvalue) method to reset the original value of an edited property.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCPropList](../vs140/cmfcpropertygridctrl-class.md)   
 [CMFCProp](../vs140/cmfcpropertygridproperty-class.md)