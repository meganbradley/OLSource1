---
title: "CMFCPropertyGridProperty Class"
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
  - "CMFCPropertyGridProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPropertyGridProperty class"
ms.assetid: 36f3fabe-0efe-468b-8a0b-5a7956db38a2
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridProperty Class
A <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object represents a list item in a property list control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridProperty::CMFCPropertyGridProperty](#cmfcpropertygridproperty__cmfcpropertygridproperty)|Constructs a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridProperty::AddOption](#cmfcpropertygridproperty__addoption)|Adds a new list item to a property list control.|  
|[CMFCPropertyGridProperty::AddSubItem](#cmfcpropertygridproperty__addsubitem)|Adds a child item to a property.|  
|[CMFCPropertyGridProperty::AdjustButtonRect](#cmfcpropertygridproperty__adjustbuttonrect)|Called by the parent property list control to tell a property to resize the bounding rectangle of an embedded button.|  
|[CMFCPropertyGridProperty::AdjustInPlaceEditRect](#cmfcpropertygridproperty__adjustinplaceeditrect)|Retrieves the boundaries of the text box and optional spin button control that are used to set a property value.|  
|[CMFCPropertyGridProperty::AllowEdit](#cmfcpropertygridproperty__allowedit)|Makes a property either editable or read-only.|  
|[CMFCPropertyGridProperty::CreateInPlaceEdit](#cmfcpropertygridproperty__createinplaceedit)|Called by the framework to create an editable control for a property.|  
|[CMFCPropertyGridProperty::CreateSpinControl](#cmfcpropertygridproperty__createspincontrol)|Called by the framework to create an editable spin button control.|  
|[CMFCPropertyGridProperty::Enable](#cmfcpropertygridproperty__enable)|Enables or disables a property.|  
|[CMFCPropertyGridProperty::EnableSpinControl](#cmfcpropertygridproperty__enablespincontrol)|Enables or disables a spin button control that is used to modify a property value.|  
|[CMFCPropertyGridProperty::Expand](#cmfcpropertygridproperty__expand)|Expands or collapses a property that contains sub-properties.|  
|[CMFCPropertyGridProperty::FormatProperty](#cmfcpropertygridproperty__formatproperty)|Formats the text representation of a property value.|  
|[CMFCPropertyGridProperty::GetData](#cmfcpropertygridproperty__getdata)|Retrieves a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> value that is associated with a property.|  
|[CMFCPropertyGridProperty::GetDescription](#cmfcpropertygridproperty__getdescription)|Retrieves a property description.|  
|[CMFCPropertyGridProperty::GetExpandedSubItems](#cmfcpropertygridproperty__getexpandedsubitems)|Retrieves the number of expanded sub-items.|  
|[CMFCPropertyGridProperty::GetHierarchyLevel](#cmfcpropertygridproperty__gethierarchylevel)|Retrieves the zero-based index of the property's hierarchy level.|  
|[CMFCPropertyGridProperty::GetName](#cmfcpropertygridproperty__getname)|Retrieves the name of the property.|  
|[CMFCPropertyGridProperty::GetNameTooltip](#cmfcpropertygridproperty__getnametooltip)|Called by the framework to display the name of the property in a tooltip.|  
|[CMFCPropertyGridProperty::GetOption](#cmfcpropertygridproperty__getoption)|Retrieves the text of the option that is specified by an index.|  
|[CMFCPropertyGridProperty::GetOptionCount](#cmfcpropertygridproperty__getoptioncount)|Retrieves the number of options that belong to a property.|  
|[CMFCPropertyGridProperty::GetOriginalValue](#cmfcpropertygridproperty__getoriginalvalue)|Retrieves the initial value of the current property.|  
|[CMFCPropertyGridProperty::GetParent](#cmfcpropertygridproperty__getparent)|Retrieves a pointer to a parent property.|  
|[CMFCPropertyGridProperty::GetRect](#cmfcpropertygridproperty__getrect)|Retrieves the bounding rectangle of a property.|  
|[CMFCPropertyGridProperty::GetSubItem](#cmfcpropertygridproperty__getsubitem)|Retrieves a sub-property identified by a zero-based index.|  
|[CMFCPropertyGridProperty::GetSubItemsCount](#cmfcpropertygridproperty__getsubitemscount)|Retrieves the number of sub-items.|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCPropertyGridProperty::GetValue](#cmfcpropertygridproperty__getvalue)|Retrieves a property value.|  
|[CMFCPropertyGridProperty::GetValueTooltip](#cmfcpropertygridproperty__getvaluetooltip)|Called by the framework to retrieve the text representation of the property value that is then displayed in a tooltip.|  
|[CMFCPropertyGridProperty::HitTest](#cmfcpropertygridproperty__hittest)|Points to the property object that corresponds to the property list item that corresponds to a point.|  
|[CMFCPropertyGridProperty::IsAllowEdit](#cmfcpropertygridproperty__isallowedit)|Indicates whether a property is editable.|  
|[CMFCPropertyGridProperty::IsEnabled](#cmfcpropertygridproperty__isenabled)|Indicates whether a property is enabled or disabled.|  
|[CMFCPropertyGridProperty::IsExpanded](#cmfcpropertygridproperty__isexpanded)|Indicates whether a property is expanded or collapsed.|  
|[CMFCPropertyGridProperty::IsGroup](#cmfcpropertygridproperty__isgroup)|Indicates whether the current property represents a group.|  
|[CMFCPropertyGridProperty::IsInPlaceEditing](#cmfcpropertygridproperty__isinplaceediting)|Indicates whether the current property is editable.|  
|[CMFCPropertyGridProperty::IsModified](#cmfcpropertygridproperty__ismodified)|Indicates whether the current property is modified.|  
|[CMFCPropertyGridProperty::IsParentExpanded](#cmfcpropertygridproperty__isparentexpanded)|Indicates whether the parents of the current property are expanded.|  
|[CMFCPropertyGridProperty::IsSelected](#cmfcpropertygridproperty__isselected)|Indicates whether the current property is selected.|  
|[CMFCPropertyGridProperty::IsVisible](#cmfcpropertygridproperty__isvisible)|Indicates whether the current property is visible.|  
|[CMFCPropertyGridProperty::OnClickButton](#cmfcpropertygridproperty__onclickbutton)|Called by the framework when the user clicks a button that is contained in a property.|  
|[CMFCPropertyGridProperty::OnClickName](#cmfcpropertygridproperty__onclickname)|Called by a parent property list control when a user clicks the name field of a property.|  
|[CMFCPropertyGridProperty::OnClickValue](#cmfcpropertygridproperty__onclickvalue)|Called by a parent property list control when a user clicks the value field of a property.|  
|[CMFCPropertyGridProperty::OnCloseCombo](#cmfcpropertygridproperty__onclosecombo)|Called by the framework when a combo box that is contained in a property is closed.|  
|[CMFCPropertyGridProperty::OnDblClick](#cmfcpropertygridproperty__ondblclk)|Called by the framework when the user double clicks a property.|  
|[CMFCPropertyGridProperty::OnDrawButton](#cmfcpropertygridproperty__ondrawbutton)|Called by the framework to draw a button that is contained in a property.|  
|[CMFCPropertyGridProperty::OnDrawDescription](#cmfcpropertygridproperty__ondrawdescription)|Called by the framework to display the property description.|  
|[CMFCPropertyGridProperty::OnDrawExpandBox](#cmfcpropertygridproperty__ondrawexpandbox)|Called by the framework to draw an expand box control near a property that contains sub-properties.|  
|[CMFCPropertyGridProperty::OnDrawName](#cmfcpropertygridproperty__ondrawname)|Called by the framework to display the property name.|  
|[CMFCPropertyGridProperty::OnDrawValue](#cmfcpropertygridproperty__ondrawvalue)|Called by the framework to display the property value.|  
|[CMFCPropertyGridProperty::OnEdit](#cmfcpropertygridproperty__onedit)|Called by the framework when the user is about to modify a property value.|  
|[CMFCPropertyGridProperty::OnEndEdit](#cmfcpropertygridproperty__onendedit)|Called by the framework when the user is finished modifying a property value.|  
|[CMFCPropertyGridProperty::OnKillSelection](#cmfcpropertygridproperty__onkillselection)||  
|[CMFCPropertyGridProperty::OnPosSizeChanged](#cmfcpropertygridproperty__onpossizechanged)||  
|[CMFCPropertyGridProperty::OnRClickName](#cmfcpropertygridproperty__onrclickname)|Called by the framework when the user clicks the right mouse button in the property name area.|  
|[CMFCPropertyGridProperty::OnRClickValue](#cmfcpropertygridproperty__onrclickvalue)|Called by the framework when the user clicks the right mouse button in the property value area.|  
|[CMFCPropertyGridProperty::OnSelectCombo](#cmfcpropertygridproperty__onselectcombo)|Called by the framework when the user selects an item from the editable combo box.|  
|[CMFCPropertyGridProperty::OnSetCursor](#cmfcpropertygridproperty__onsetcursor)|Called by the framework when the mouse pointer moves to a property item.|  
|[CMFCPropertyGridProperty::OnSetSelection](#cmfcpropertygridproperty__onsetselection)||  
|[CMFCPropertyGridProperty::OnUpdateValue](#cmfcpropertygridproperty__onupdatevalue)|Called by the framework when the value of an editable property has changed.|  
|[CMFCPropertyGridProperty::PushChar](#cmfcpropertygridproperty__pushchar)|Called from the property list control when the property is selected and the user enters a new character.|  
|[CMFCPropertyGridProperty::Redraw](#cmfcpropertygridproperty__redraw)|Redraws the property.|  
|[CMFCPropertyGridProperty::RemoveAllOptions](#cmfcpropertygridproperty__removealloptions)|Removes all options (items) from a property.|  
|[CMFCPropertyGridProperty::RemoveSubItem](#cmfcpropertygridproperty__removesubitem)|Removes the specified sub-item.|  
|[CMFCPropertyGridProperty::ResetOriginalValue](#cmfcpropertygridproperty__resetoriginalvalue)|Restores the original value of an edited property.|  
|[CMFCPropertyGridProperty::SetData](#cmfcpropertygridproperty__setdata)|Associates a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> value with a property.|  
|[CMFCPropertyGridProperty::SetDescription](#cmfcpropertygridproperty__setdescription)|Specifies the text that describes the current property.|  
|[CMFCPropertyGridProperty::SetName](#cmfcpropertygridproperty__setname)|Sets the name of a property.|  
|[CMFCPropertyGridProperty::SetOriginalValue](#cmfcpropertygridproperty__setoriginalvalue)|Sets the original value of an editable property.|  
|[CMFCPropertyGridProperty::SetValue](#cmfcpropertygridproperty__setvalue)|Sets the value of a property grid property.|  
|[CMFCPropertyGridProperty::Show](#cmfcpropertygridproperty__show)|Shows or hides a property.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridProperty::CreateCombo](#cmfcpropertygridproperty__createcombo)|Called by the framework to add a combo box to a property.|  
|[CMFCPropertyGridProperty::HasButton](#cmfcpropertygridproperty__hasbutton)|Indicates whether a property contains a button.|  
|[CMFCPropertyGridProperty::Init](#cmfcpropertygridproperty__init)|Called by the framework to initialize a property object.|  
|[CMFCPropertyGridProperty::IsSubItem](#cmfcpropertygridproperty__issubitem)|Indicates whether the specified property is a sub-item of the current property.|  
|[CMFCPropertyGridProperty::IsValueChanged](#cmfcpropertygridproperty__isvaluechanged)|Indicates whether the value of the current property has changed.|  
|[CMFCPropertyGridProperty::OnCtlColor](#cmfcpropertygridproperty__onctlcolor)|Called by the framework when it must retrieve a brush to fill the background color of a property.|  
|[CMFCPropertyGridProperty::OnDestroyWindow](#cmfcpropertygridproperty__ondestroywindow)|Called by the framework when a property is destroyed or when editing is finished.|  
|[CMFCPropertyGridProperty::OnKillFocus](#cmfcpropertygridproperty__onkillfocus)|Called by the framework when the property loses the input focus.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPropertyGridProperty::m_strFormatDouble](#cmfcpropertygridproperty__m_strformatdouble)|Format string for a value of type double.|  
|[CMFCPropertyGridProperty::m_strFormatFloat](#cmfcpropertygridproperty__m_strformatfloat)|Format string for a value of type float.|  
|[CMFCPropertyGridProperty::m_strFormatLong](#cmfcpropertygridproperty__m_strformatlong)|Format string for a value of type long.|  
|[CMFCPropertyGridProperty::m_strFormatShort](#cmfcpropertygridproperty__m_strformatshort)|Format string for a value of type short.|  
  
## Remarks  
 Use a <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object to represent a property, which you then add to a property list control. For more information, see [CMFCPropertyGridCtrl](../vs140/cmfcpropertygridctrl-class.md).  
  
 A property object can represent data types such as strings, dates, and Boolean or integer values. It can contain child properties, or it can contain a control such as a combo box or a button control.  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object. The example also demonstrates how to use various methods in the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> class to add an option, add a sub-item, enable a property, and show a property. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#27](../vs140/codesnippet/CPP/cmfcpropertygridproperty-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md)  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
##  \<a name="cmfcpropertygridproperty__addoption">\</a>  CMFCPropertyGridProperty::AddOption  
 Adds a new list item to a property list control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The list item (option) to add.  
  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> to add the list item only if it does not already exist; otherwise, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, which means that the list item is added. Otherwise, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, which means that the list item is not added because the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> and the list item specified by the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> parameter already exists.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__addsubitem">\</a>  CMFCPropertyGridProperty::AddSubItem  
 Adds a child item to a property.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Pointer to a property to add.  
  
### Return Value  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> if the specified property is successfully added as a child property. <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if the property is not added because it already occurs in the parent property.  
  
### Remarks  
 Use this method to create a hierarchical list of parent and child properties. After a child property is added, the parent property automatically displays an expand box control that is designated by a plus sign (+). When the user clicks the plus sign, the parent property expands and displays any child property items.  
  
##  \<a name="cmfcpropertygridproperty__adjustbuttonrect">\</a>  CMFCPropertyGridProperty::AdjustButtonRect  
 Called by the parent property list control to tell a property to resize the bounding rectangle of an embedded button.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 By default, this method:  
  
-   Adjusts the width of the button equal to the height of the button plus 3 pixels.  
  
-   Moves the bounding rectangle of the button to the right edge of the property  
  
-   Shifts the button 1 pixel below the top edge of the property.  
  
##  \<a name="cmfcpropertygridproperty__adjustinplaceeditrect">\</a>  CMFCPropertyGridProperty::AdjustInPlaceEditRect  
 Retrieves the boundaries of the text box and optional spin button control that are used to set a property value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 When this method returns, a rectangle that specifies the boundaries of the text box for the property value.  
  
 [out] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 When this method returns, a rectangle that specifies the boundaries of the spin button control for the property value. Or, if the property does not support a spin button, an empty rectangle.  
  
### Remarks  
 The value area of a property consists of a text box and possibly an *option button*, such as a spin button control. This method calculates the dimensions of the text box and option button and then returns those values in the specified parameters.  
  
##  \<a name="cmfcpropertygridproperty__allowedit">\</a>  CMFCPropertyGridProperty::AllowEdit  
 Makes a property either editable or read-only.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> to make the property editable; <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to make the property read-only. The default value is <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__cmfcpropertygridproperty">\</a>  CMFCPropertyGridProperty::CMFCPropertyGridProperty  
 Constructs a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The group name. A *group* is a collection of related properties in a property grid control. If the control is displayed hierarchically, the *group name* is displayed as a category title in the row above the group.  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Application-specific data, such as an integer or a pointer to other data that is associated with the property. The default value is 0.  
  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The name of the property.  
  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The property value.  
  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The property description. The default value is <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The edit mask, if the property is a masked edit control. The default value is <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The edit template, if the property is a masked edit control. The default value is <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 A list of valid characters, if the property is a masked edit control. The default value is <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if the property represents a list of values; <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> if the property represents a single value. The default value is <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__createcombo">\</a>  CMFCPropertyGridProperty::CreateCombo  
 Called by the framework to add a combo box to a property.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 Pointer to the parent window of the combo box.  
  
 [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The bounding rectangle of the combo box.  
  
### Return Value  
 Pointer to a new [CComboBox](../vs140/ccombobox-class.md) object.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__createinplaceedit">\</a>  CMFCPropertyGridProperty::CreateInPlaceEdit  
 Called by the framework to create an editable control for a property.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The bounding rectangle of the editable control.  
  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> to use the default property format to set the text of the editable control; otherwise, <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Return Value  
 A pointer to the editable control if this method succeeds; otherwise, <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method uses the values of the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> parameters that are specified in the [CMFCPropertyGridProperty](../vs140/cmfcpropertygridproperty-class.md) class constructor. By default, this method supports the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> variant types. This includes <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
 This method creates a [CMFCMaskedEdit](../vs140/cmfcmaskededit-class.md) control if one or more of the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> parameters are specified; otherwise, it creates a [CEdit](../vs140/cedit-class.md) control.  
  
##  \<a name="cmfcpropertygridproperty__createspincontrol">\</a>  CMFCPropertyGridProperty::CreateSpinControl  
 Called by the framework to create an editable spin button control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A rectangle that defines where the editable spin button control is created.  
  
### Return Value  
 A pointer to a new [CMFCSpinButtonCtrl](../vs140/cmfcspinbuttonctrl-class.md) object that is cast as a pointer to a [CSpinButtonCtrl](../vs140/cspinbuttonctrl-class.md) object.  
  
### Remarks  
 Call the [CMFCPropertyGridProperty::EnableSpinControl](#cmfcpropertygridproperty__enablespincontrol) method to display an editable spin button control at the right edge of the property.  
  
##  \<a name="cmfcpropertygridproperty__enable">\</a>  CMFCPropertyGridProperty::Enable  
 Enables or disables a property.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> to enable the property; <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> to disable the property. Disabled properties do not respond to mouse or keyboard input. The default value is <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__enablespincontrol">\</a>  CMFCPropertyGridProperty::EnableSpinControl  
 Enables or disables a spin button control that is used to modify a property value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> to enable the spin button control; <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> to disable the spin button control. The default value is <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The minimum value of the spin button control. The default value is 0.  
  
 [in] <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 The maximum value of the spin button control. The default value is 0.  
  
### Remarks  
 The framework automatically creates a spin button control when a property is about to be edited.  
  
 The property type, which is specified by the <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> parameter of the [CMFCPropertyGridProperty::CMFCPropertyGridProperty](#cmfcpropertygridproperty__cmfcpropertygridproperty) constructor, must be a supported variant type. Otherwise, this method asserts in debug mode. The supported types include <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpropertygridproperty__expand">\</a>  CMFCPropertyGridProperty::Expand  
 Expands or collapses a property that contains sub-properties.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> to expand the property; FALSE to collapse the property. The default value is <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__formatproperty">\</a>  CMFCPropertyGridProperty::FormatProperty  
 Formats the text representation of a property value.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The text representation of the property value.  
  
### Remarks  
 This method is called by the framework before the property value is displayed.  
  
##  \<a name="cmfcpropertygridproperty__getdata">\</a>  CMFCPropertyGridProperty::GetData  
 Retrieves a <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> value that is associated with a property.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The data that is returned is an application-specific value, such as a number or a pointer to other data. Specify the data value when you construct the property or when you call the [CMFCPropertyGridProperty::SetData](#cmfcpropertygridproperty__setdata) method.  
  
##  \<a name="cmfcpropertygridproperty__getdescription">\</a>  CMFCPropertyGridProperty::GetDescription  
 Retrieves a property description.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A text string that contains the property description.  
  
### Remarks  
 Property list control also uses this method to display the description of the property.  
  
##  \<a name="cmfcpropertygridproperty__getexpandedsubitems">\</a>  CMFCPropertyGridProperty::GetExpandedSubItems  
 Retrieves the number of expanded sub-items.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>176\</CodeContentPlaceHolder> to include the hidden sub-items in the count; otherwise, <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.|  
  
### Return Value  
 The number of expanded sub-items.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__gethierarchylevel">\</a>  CMFCPropertyGridProperty::GetHierarchyLevel  
 Retrieves the zero-based index of the property's hierarchy level.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The property's hierarchical level.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getname">\</a>  CMFCPropertyGridProperty::GetName  
 Retrieves the name of the property.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a string that contains the name of the property.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getnametooltip">\</a>  CMFCPropertyGridProperty::GetNameTooltip  
 Called by the framework to display the name of the property in a tooltip.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A string that contains the property name. By default, the return value is the empty string.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getoption">\</a>  CMFCPropertyGridProperty::GetOption  
 Retrieves the text of the option that is specified by an index.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The zero-based index of the property list item (option) to retrieve.  
  
### Return Value  
 Pointer to a string that contains the option text.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getoptioncount">\</a>  CMFCPropertyGridProperty::GetOptionCount  
 Retrieves the number of options that belong to a property.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The number of property list items (options) that are contained in the property control.  
  
### Remarks  
 Call the [CMFCPropertyGridProperty::AddOption](#cmfcpropertygridproperty__addoption) method to add items to the property list. Call the [CMFCPropertyGridProperty::RemoveAllOptions](#cmfcpropertygridproperty__removealloptions) method to remove all items.  
  
##  \<a name="cmfcpropertygridproperty__getoriginalvalue">\</a>  CMFCPropertyGridProperty::GetOriginalValue  
 Retrieves the initial value of the current property.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The original value of the current property.  
  
### Remarks  
 Use this method to undo the effect of an edit operation that changes the value of the current property.  
  
 The original value of the current property is set by the [CMFCPropertyGridProperty::CMFCPropertyGridProperty](#cmfcpropertygridproperty__cmfcpropertygridproperty) constructor, modified by the [CMFCPropertyGridProperty::SetOriginalValue](#cmfcpropertygridproperty__setoriginalvalue) method, and reset by the [CMFCPropertyGridProperty::ResetOriginalValue](#cmfcpropertygridproperty__resetoriginalvalue) method.  
  
##  \<a name="cmfcpropertygridproperty__getparent">\</a>  CMFCPropertyGridProperty::GetParent  
 Retrieves a pointer to a parent property.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a parent property object, or <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> for the top-level property.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getrect">\</a>  CMFCPropertyGridProperty::GetRect  
 Retrieves the bounding rectangle of a property.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 A [CRect](../vs140/crect-class.md) object that describes the bounding rectangle.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getsubitem">\</a>  CMFCPropertyGridProperty::GetSubItem  
 Retrieves a sub-property identified by a zero-based index.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 The zero-based index of the property to retrieve. This parameter is invalid if it is less than zero or greater than or equal to the number of sub-properties.  
  
### Return Value  
 A pointer to a property object that is a child item of this property.  
  
 -or-  
  
 In retail mode, <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> parameter is invalid. In debug mode, this method asserts.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getsubitemscount">\</a>  CMFCPropertyGridProperty::GetSubItemsCount  
 Retrieves the number of sub-items.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 The number of child items.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getvalue">\</a>  CMFCPropertyGridProperty::GetValue  
 Retrieves a property value.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 A variant that contains the property value.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__getvaluetooltip">\</a>  CMFCPropertyGridProperty::GetValueTooltip  
 Called by the framework to retrieve the text representation of the property value that is then displayed in a tooltip.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> object containing the textual representation of the property value. By default, this value is the empty string.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__hasbutton">\</a>  CMFCPropertyGridProperty::HasButton  
 Indicates whether a property contains a button.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> if a property contains a button (or property list); otherwise, <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__hittest">\</a>  CMFCPropertyGridProperty::HitTest  
 Points to the property object that corresponds to the property list item that corresponds to a point.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 The point to test, in client coordinates. This parameter is typically the current mouse pointer location.  
  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 The point to test, in client coordinates.  
  
 [out] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 When this method returns, indicates the area that contains the specified point. For more information, see Remarks. The default value is <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> to test any area in the property control; <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> to test only the description area. The default value is <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>.  
  
### Return Value  
 A pointer to a property object or <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method tests property sub-items if the specified point is not found within any of the property items.  
  
 The following table lists the values that can be returned to the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> parameter.  
  
|Area|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|The expand box control, which is designated by a plus sign (+).|  
|<CodeContentPlaceHolder>198\</CodeContentPlaceHolder>|The property name.|  
|<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|The property value.|  
  
##  \<a name="cmfcpropertygridproperty__init">\</a>  CMFCPropertyGridProperty::Init  
 Called by the framework to initialize a property object.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__isallowedit">\</a>  CMFCPropertyGridProperty::IsAllowEdit  
 Indicates whether a property is editable.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> if the property is editable; otherwise <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__isenabled">\</a>  CMFCPropertyGridProperty::IsEnabled  
 Indicates whether a property is enabled or disabled.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> if the property is enabled; <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if the property is disabled.  
  
### Remarks  
 Tells whether a property is enabled or disabled.  
  
##  \<a name="cmfcpropertygridproperty__isexpanded">\</a>  CMFCPropertyGridProperty::IsExpanded  
 Indicates whether a property is expanded or collapsed.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> if the property is expanded; <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> if the property is collapsed.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__isgroup">\</a>  CMFCPropertyGridProperty::IsGroup  
 Indicates whether the current property represents a group.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> if the current property object represents a group; <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> if the property represents a value.  
  
### Remarks  
 A *group* is a collection of related properties in a property grid control. If the control is displayed hierarchically, the *group name* is displayed as a category title in the row above the group.  
  
##  \<a name="cmfcpropertygridproperty__isinplaceediting">\</a>  CMFCPropertyGridProperty::IsInPlaceEditing  
 Indicates whether the current property is editable.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> if the current property is editable; otherwise, <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__ismodified">\</a>  CMFCPropertyGridProperty::IsModified  
 Indicates whether the current property is modified.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> if the property is modified; otherwise, <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__isparentexpanded">\</a>  CMFCPropertyGridProperty::IsParentExpanded  
 Indicates whether the parents of the current property are expanded.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> if all parents of the current property are expanded; <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> if the parent properties are collapsed.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__isselected">\</a>  CMFCPropertyGridProperty::IsSelected  
 Indicates whether the current property is selected.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> if the current property is selected; otherwise, <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__issubitem">\</a>  CMFCPropertyGridProperty::IsSubItem  
 Indicates whether the specified property is a sub-item of the current property.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 A pointer to a property.  
  
### Return Value  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> if the specified property is a sub-item of the current property; otherwise, <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpropertygridproperty__isvaluechanged">\</a>  CMFCPropertyGridProperty::IsValueChanged  
 Indicates whether the value of the current property has changed.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> if the value of the current property has changed; otherwise, <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__isvisible">\</a>  CMFCPropertyGridProperty::IsVisible  
 Indicates whether the current property is visible.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> if the current property is visible; otherwise; <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__m_strformatdouble">\</a>  CMFCPropertyGridProperty::m_strFormatDouble  
 Holds a format string for a value of type double.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__m_strformatfloat">\</a>  CMFCPropertyGridProperty::m_strFormatFloat  
 Holds a format string for a value of type float.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__m_strformatlong">\</a>  CMFCPropertyGridProperty::m_strFormatLong  
 Holds a format string for a value of type long.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__m_strformatshort">\</a>  CMFCPropertyGridProperty::m_strFormatShort  
 Holds a format string for a value of type short.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__onclickbutton">\</a>  CMFCPropertyGridProperty::OnClickButton  
 Called by the framework when the user clicks a button that is contained in a property.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 A point, in client coordinates.  
  
### Remarks  
 By default, this method does nothing.  
  
##  \<a name="cmfcpropertygridproperty__onclickname">\</a>  CMFCPropertyGridProperty::OnClickName  
 Called by a parent property list control when a user clicks the name field of a property.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>|A point, in client coordinates.|  
  
### Remarks  
 By default, this method does nothing.  
  
##  \<a name="cmfcpropertygridproperty__onclickvalue">\</a>  CMFCPropertyGridProperty::OnClickValue  
 Called by a parent property list control when a user clicks the value field of a property.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 A mouse message.  
  
 [in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 A point, in client coordinates.  
  
### Return Value  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> if the specified mouse message is processed by this method; otherwise, <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method returns <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> if the current property is not editable. Otherwise, the edit or spin control that is associated with this property processes the specified mouse message, and then this method returns <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpropertygridproperty__onclosecombo">\</a>  CMFCPropertyGridProperty::OnCloseCombo  
 Called by the framework when a combo box that is contained in a property is closed.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__onctlcolor">\</a>  CMFCPropertyGridProperty::OnCtlColor  
 Called by the framework when it must retrieve a brush to fill the background color of a property.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 Pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 (This parameter is not used.)  
  
### Return Value  
 The handle to a brush if this method is successful; otherwise, <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__ondblclk">\</a>  CMFCPropertyGridProperty::OnDblClk  
 Called by the framework when the user double clicks a property.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
 A point, in client coordinates.  
  
### Return Value  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method selects the next property item in the property list control.  
  
##  \<a name="cmfcpropertygridproperty__ondestroywindow">\</a>  CMFCPropertyGridProperty::OnDestroyWindow  
 Called by the framework when a property is destroyed or when editing is finished.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__ondrawbutton">\</a>  CMFCPropertyGridProperty::OnDrawButton  
 Called by the framework to draw a button that is contained in a property.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies where to draw a button.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__ondrawdescription">\</a>  CMFCPropertyGridProperty::OnDrawDescription  
 Called by the framework to draw the property description.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies where to draw the property description.  
  
### Remarks  
 By default, this method draws the property name and description in the font used by the parent property list control. The property description is drawn in regular style and the property name is drawn in bold style.  
  
##  \<a name="cmfcpropertygridproperty__ondrawexpandbox">\</a>  CMFCPropertyGridProperty::OnDrawExpandBox  
 Called by the framework to draw an expand box control near a property that contains sub-properties.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies where to draw the expand box control.  
  
### Remarks  
 Click the expand box control to expand or collapse a list of sub-properties. The expand box control is designated by a square that contains a plus (+) or minus (-) sign. A plus sign indicates that the property can be expanded to show a list of sub-properties. A minus sign indicates that the list can be collapsed to show only the property.  
  
##  \<a name="cmfcpropertygridproperty__ondrawname">\</a>  CMFCPropertyGridProperty::OnDrawName  
 Called by the framework to display the property name.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies where to draw the property name.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__ondrawvalue">\</a>  CMFCPropertyGridProperty::OnDrawValue  
 Called by the framework to display the property value.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 A bounding rectangle that specifies where to draw the property value.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__onedit">\</a>  CMFCPropertyGridProperty::OnEdit  
 Called by the framework when the user is about to modify a property value.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 (This parameter is not used.) A pointer to a point, in client coordinates.  
  
### Return Value  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> if the edit operation starts successfully; otherwise, <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function is called by the framework when the user is about to modify a property value. By default, this method starts the appropriate editor for a combo box control or a spin control.  
  
##  \<a name="cmfcpropertygridproperty__onendedit">\</a>  CMFCPropertyGridProperty::OnEndEdit  
 Called by the framework when the user is finished modifying a property value.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Return Value  
 This method always returns <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method destroys the current editing control and then returns <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpropertygridproperty__onkillfocus">\</a>  CMFCPropertyGridProperty::OnKillFocus  
 Called by the framework when the property loses the input focus.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>|(Not used.) Pointer to a window.|  
  
### Return Value  
 This method always returns <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, this method does nothing and then returns <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>. If you override this method, return <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> if the framework can end the edit operation when the property loses the input focus.  
  
##  \<a name="cmfcpropertygridproperty__onkillselection">\</a>  CMFCPropertyGridProperty::OnKillSelection  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
  
### Remarks  
 By default, this method does nothing.  
  
##  \<a name="cmfcpropertygridproperty__onpossizechanged">\</a>  CMFCPropertyGridProperty::OnPosSizeChanged  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
  
### Remarks  
 By default, this method does nothing.  
  
##  \<a name="cmfcpropertygridproperty__onrclickname">\</a>  CMFCPropertyGridProperty::OnRClickName  
 Called by the framework when the user clicks the right mouse button in the property name area.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>|A point, in client coordinates.|  
  
### Remarks  
 By default, this method does nothing.  
  
##  \<a name="cmfcpropertygridproperty__onrclickvalue">\</a>  CMFCPropertyGridProperty::OnRClickValue  
 Called by the framework when the user clicks the right mouse button in the property value area.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>|A point, in client coordinates.|  
|[in] <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>|A Boolean.|  
  
### Remarks  
 By default, this method does nothing and the <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> parameter has no predefined purpose.  
  
##  \<a name="cmfcpropertygridproperty__onselectcombo">\</a>  CMFCPropertyGridProperty::OnSelectCombo  
 Called by the framework when the user selects an item from the editable combo box.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
 By default, this method uses the text of the selected item to update the property value.  
  
##  \<a name="cmfcpropertygridproperty__onsetcursor">\</a>  CMFCPropertyGridProperty::OnSetCursor  
 Called by the framework when the mouse pointer moves to a property item.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> if the current property is a variant type or a list of values, and this method successfully loads the insertion point (I-beam) mouse cursor; otherwise, <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method supports the following variant types: <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpropertygridproperty__onsetselection">\</a>  CMFCPropertyGridProperty::OnSetSelection  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
  
### Remarks  
 By default, this method does nothing.  
  
##  \<a name="cmfcpropertygridproperty__onupdatevalue">\</a>  CMFCPropertyGridProperty::OnUpdateValue  
 Called by the framework when the value of an editable property has changed.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__pushchar">\</a>  CMFCPropertyGridProperty::PushChar  
 Called from the property list control when the property is selected and the user enters a new character.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 A character.  
  
### Return Value  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> if the edit operation is continuing; otherwise, <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method supports a property that is either a list of values or one of the following variant types: <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcpropertygridproperty__redraw">\</a>  CMFCPropertyGridProperty::Redraw  
 Redraws the property.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__removealloptions">\</a>  CMFCPropertyGridProperty::RemoveAllOptions  
 Removes all options (items) from a property.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Remarks  
 Options are also known as the list items of a property list control.  
  
##  \<a name="cmfcpropertygridproperty__removesubitem">\</a>  CMFCPropertyGridProperty::RemoveSubItem  
 Removes the specified sub-item.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 Pointer to a property sub-item.  
  
 [in] <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> to delete the property object that is specified by the <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> parameter; otherwise, <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>.  
  
### Return Value  
  
### Remarks  
 Specify <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> parameter if you intend to move the specified sub-item; that is, remove the sub-item and then add it elsewhere.  
  
##  \<a name="cmfcpropertygridproperty__resetoriginalvalue">\</a>  CMFCPropertyGridProperty::ResetOriginalValue  
 Restores the original value of an edited property.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__setdata">\</a>  CMFCPropertyGridProperty::SetData  
 Associates a <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> value with a property.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 An application-specific 32-bit value, such as an integer or a pointer to other data.  
  
### Remarks  
 Use the [CMFCPropertyGridProperty::GetData](#cmfcpropertygridproperty__getdata) method to retrieve the <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> value. Use the [CMFCPropertyGridCtrl::FindItemByData](../vs140/cmfcpropertygridctrl-class.md#cmfcpropertygridctrl__finditembydata) method to locate the property list item that is associated with the specified <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> value.  
  
##  \<a name="cmfcpropertygridproperty__setdescription">\</a>  CMFCPropertyGridProperty::SetDescription  
 Specifies the text that describes the current property.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 Text that describes the current property.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__setname">\</a>  CMFCPropertyGridProperty::SetName  
 Sets the name of a property.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 The property name.  
  
 [in] <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> to redraw the property immediately; otherwise, <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__setoriginalvalue">\</a>  CMFCPropertyGridProperty::SetOriginalValue  
 Sets the original value of an editable property.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 A value.  
  
### Remarks  
 Use the [CMFCPropertyGridProperty::ResetOriginalValue](#cmfcpropertygridproperty__resetoriginalvalue) method to reset the original value of an edited property.  
  
##  \<a name="cmfcpropertygridproperty__setvalue">\</a>  CMFCPropertyGridProperty::SetValue  
 Sets the value of a property grid property.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 A reference to a value.  
  
### Remarks  
  
##  \<a name="cmfcpropertygridproperty__show">\</a>  CMFCPropertyGridProperty::Show  
 Shows or hides a property.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> to display the current property and its sub-items; <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> to hide the current property and its sub-items. The default value is <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> to recalculate how to draw the label and value of a property and then draw the property; <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> to use existing calculations to draw the property. The default value is <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCPropertyGridCtrl](../vs140/cmfcpropertygridctrl-class.md)