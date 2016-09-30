---
title: "CMFCRibbonEdit Class"
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
  - "CMFCRibbonEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonEdit class"
ms.assetid: 9b85f1f2-446b-454e-9af9-104fdad8a897
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonEdit Class
Implements an edit control that is located on a ribbon bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonEdit::CMFCRibbonEdit](#cmfcribbonedit__cmfcribbonedit)|Constructs a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonEdit::CanBeStretched](#cmfcribbonedit__canbestretched)|Indicates whether the height of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> control can increase vertically to the height of a ribbon row.|  
|[CMFCRibbonEdit::CMFCRibbonEdit](#cmfcribbonedit__cmfcribbonedit)|Constructs a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonEdit::CopyFrom](#cmfcribbonedit__copyfrom)|Copies the state of the specified <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object to the current <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonEdit::CreateEdit](#cmfcribbonedit__createedit)|Creates a new text box for the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonEdit::DestroyCtrl](#cmfcribbonedit__destroyctrl)|Destroys the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonEdit::DropDownList](#cmfcribbonedit__dropdownlist)|Drops down a list box.|  
|[CMFCRibbonEdit::EnableSpinButtons](#cmfcribbonedit__enablespinbuttons)|Enables and sets the range of the spin button for the text box.|  
|[CMFCRibbonEdit::GetCompactSize](#cmfcribbonedit__getcompactsize)|Retrieves the compact size of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonEdit::GetEditText](#cmfcribbonedit__getedittext)|Retrieves the text in the text box.|  
|[CMFCRibbonEdit::GetIntermediateSize](#cmfcribbonedit__getintermediatesize)|Retrieves the intermediate size of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonEdit::GetTextAlign](#cmfcribbonedit__gettextalign)|Retrieves the alignment of the text in the text box.|  
|[CMFCRibbonEdit::GetWidth](#cmfcribbonedit__getwidth)|Retrieves the width, in pixels, of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> control.|  
|[CMFCRibbonEdit::HasCompactMode](#cmfcribbonedit__hascompactmode)|Indicates whether the display size for the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> control can be compact.|  
|[CMFCRibbonEdit::HasFocus](#cmfcribbonedit__hasfocus)|Indicates whether the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> control has the focus.|  
|[CMFCRibbonEdit::HasLargeMode](#cmfcribbonedit__haslargemode)|Indicates whether the display size for the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> control can be large.|  
|[CMFCRibbonEdit::HasSpinButtons](#cmfcribbonedit__hasspinbuttons)|Indicates whether the text box has a spin button.|  
|[CMFCRibbonEdit::IsHighlighted](#cmfcribbonedit__ishighlighted)|Indicates whether the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> control is highlighted.|  
|[CMFCRibbonEdit::OnAfterChangeRect](#cmfcribbonedit__onafterchangerect)|Called by the framework when the dimensions of the display rectangle for the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> control changes.|  
|[CMFCRibbonEdit::OnDraw](#cmfcribbonedit__ondraw)|Called by the framework to draw the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> control.|  
|[CMFCRibbonEdit::OnDrawLabelAndImage](#cmfcribbonedit__ondrawlabelandimage)|Called by the framework to draw the label and image for the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> control.|  
|[CMFCRibbonEdit::OnDrawOnList](#cmfcribbonedit__ondrawonlist)|Called by the framework to draw the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> control in a commands list box.|  
|[CMFCRibbonEdit::OnEnable](#cmfcribbonedit__onenable)|Called by the framework to enable or disable the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> control.|  
|[CMFCRibbonEdit::OnHighlight](#cmfcribbonedit__onhighlight)|Called by the framework when the pointer enters or leaves the bounds of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> control.|  
|[CMFCRibbonEdit::OnKey](#cmfcribbonedit__onkey)|Called by the framework when the user presses a keytip and the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> control has the focus.|  
|[CMFCRibbonEdit::OnLButtonDown](#cmfcribbonedit__onlbuttondown)|Called by the framework to update the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> control when the user presses the left mouse button on the control.|  
|[CMFCRibbonEdit::OnLButtonUp](#cmfcribbonedit__onlbuttonup)|Called by the framework when the user releases the left mouse button.|  
|[CMFCRibbonEdit::OnRTLChanged](#cmfcribbonedit__onrtlchanged)|Called by the framework to update the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> control when the layout changes direction.|  
|[CMFCRibbonEdit::OnShow](#cmfcribbonedit__onshow)|Called by the framework to show or hide the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> control.|  
|[CMFCRibbonEdit::Redraw](#cmfcribbonedit__redraw)|Updates the display of the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> control.|  
|[CMFCRibbonEdit::SetACCData](#cmfcribbonedit__setaccdata)|Sets the accessibility data for the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.|  
|[CMFCRibbonEdit::SetEditText](#cmfcribbonedit__setedittext)|Sets the text in the text box.|  
|[CMFCRibbonEdit::SetTextAlign](#cmfcribbonedit__settextalign)|Sets the text alignment of the text box.|  
|[CMFCRibbonEdit::SetWidth](#cmfcribbonedit__setwidth)|Sets the width of the text box for the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> control.|  
  
## Remarks  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object, show spin buttons next to the edit control, and set the text of the edit control. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#7](../vs140/codesnippet/CPP/cmfcribbonedit-class_1.cpp)]  
  
## Requirements  
 **Header:** afxRibbonEdit.h  
  
##  \<a name="cmfcribbonedit__canbestretched">\</a>  CMFCRibbonEdit::CanBeStretched  
 Indicates whether the height of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control can increase vertically to the height of a ribbon row.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__cmfcribbonedit">\</a>  CMFCRibbonEdit::CMFCRibbonEdit  
 Constructs a [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Command ID for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The width, in pixels, of the text box for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The label for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Index of the small image to use for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control. The collection of small images is maintained by the parent ribbon category.  
  
### Remarks  
 The [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control does not use a large image.  
  
##  \<a name="cmfcribbonedit__copyfrom">\</a>  CMFCRibbonEdit::CopyFrom  
 Copies the state of the specified [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object to the current [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The source [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
### Remarks  
 The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> parameter must be of type [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md).  
  
##  \<a name="cmfcribbonedit__createedit">\</a>  CMFCRibbonEdit::CreateEdit  
 Creates a new text box for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A pointer to the parent window of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Specifies the style of the text box. You can combine the window styles listed in the Remarks section with the                                 [edit control styles](http://msdn.microsoft.com/library/windows/desktop/bb775464) that are described in the Windows SDK.  
  
### Return Value  
 A pointer to the new text box if the method was successful; otherwise, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method in a derived class to create a custom text box.  
  
 You can apply the following [Window Styles](../vs140/window-styles.md) to a text box:  
  
-   **WS_CHILD**  
  
-   **WS_VISIBLE**  
  
-   **WS_DISABLED**  
  
-   **WS_GROUP**  
  
-   **WS_TABSTOP**  
  
##  \<a name="cmfcribbonedit__destroyctrl">\</a>  CMFCRibbonEdit::DestroyCtrl  
 Destroys the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbonedit__dropdownlist">\</a>  CMFCRibbonEdit::DropDownList  
 Drops down a list box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 By default this method does nothing. Override this method to drop down a list box.  
  
##  \<a name="cmfcribbonedit__enablespinbuttons">\</a>  CMFCRibbonEdit::EnableSpinButtons  
 Enables and sets the range of the spin button for the text box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The minimum value of the spin button.  
  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The maximum value of the spin button.  
  
### Remarks  
 Spin buttons display an up and down arrow and enable users to move through a fixed set of values.  
  
##  \<a name="cmfcribbonedit__getcompactsize">\</a>  CMFCRibbonEdit::GetCompactSize  
 Retrieves the compact size of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
### Return Value  
 The compact size of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__getedittext">\</a>  CMFCRibbonEdit::GetEditText  
 Retrieves the text in the text box.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The text in the text box.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__getintermediatesize">\</a>  CMFCRibbonEdit::GetIntermediateSize  
 Retrieves the intermediate size of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
### Return Value  
 The intermediate size of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__gettextalign">\</a>  CMFCRibbonEdit::GetTextAlign  
 Retrieves the alignment of the text in the text box.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A text alignment enumerated value. See the Remarks section for possible values.  
  
### Remarks  
 The returned value is one of the following edit control styles:  
  
-   **ES_LEFT** for left alignment  
  
-   **ES_CENTER** for center alignment  
  
-   **ES_RIGHT** for right alignment  
  
 For more information about these styles, see                         [Edit Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775464).  
  
##  \<a name="cmfcribbonedit__getwidth">\</a>  CMFCRibbonEdit::GetWidth  
 Retrieves the width, in pixels, of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> if the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control is in floating mode; otherwise, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
### Return Value  
 The width, in pixels, of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__hascompactmode">\</a>  CMFCRibbonEdit::HasCompactMode  
 Indicates whether the display size for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control can be compact.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. Override this method to indicate whether the display size can be compact.  
  
##  \<a name="cmfcribbonedit__hasfocus">\</a>  CMFCRibbonEdit::HasFocus  
 Indicates whether the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control has the focus.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> if the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control has the focus; otherwise <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__haslargemode">\</a>  CMFCRibbonEdit::HasLargeMode  
 Indicates whether the display size for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control can be large.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default this method always returns <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. Override this method to indicate whether the display size can be large.  
  
##  \<a name="cmfcribbonedit__hasspinbuttons">\</a>  CMFCRibbonEdit::HasSpinButtons  
 Indicates whether the text box has a spin button.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> if the text box has a spin button; otherwise <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__ishighlighted">\</a>  CMFCRibbonEdit::IsHighlighted  
 Indicates whether the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control is highlighted.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control is highlighted; otherwise <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__onafterchangerect">\</a>  CMFCRibbonEdit::OnAfterChangeRect  
 Called by the framework when the dimensions of the display rectangle for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control change.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__ondraw">\</a>  CMFCRibbonEdit::OnDraw  
 Called by the framework to draw the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__ondrawlabelandimage">\</a>  CMFCRibbonEdit::OnDrawLabelAndImage  
 Called by the framework to draw the label and image for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__ondrawonlist">\</a>  CMFCRibbonEdit::OnDrawOnList  
 Called by the framework to draw the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control in a commands list box.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Pointer to a device context for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The display text [](../vs140/cmfcribbonedit-class.md "CMFCRibbonEdit Class").  
  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Distance, in pixels, from the left side of the list box to the display text.  
  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The display rectangle for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
 The commands list box displays ribbon controls to enable users to customize the quick access toolbar.  
  
##  \<a name="cmfcribbonedit__onenable">\</a>  CMFCRibbonEdit::OnEnable  
 Called by the framework to enable or disable the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to enable the control; <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to disable the control.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__onhighlight">\</a>  CMFCRibbonEdit::OnHighlight  
 Called by the framework when the pointer enters or leaves the bounds of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> if the pointer is in the bounds of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control; otherwise, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__onkey">\</a>  CMFCRibbonEdit::OnKey  
 Called by the framework when the user presses a keytip and the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control has the focus.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> if the keytip displays a pop-up menu; otherwise, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> if the event was handled; otherwise, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__onlbuttondown">\</a>  CMFCRibbonEdit::OnLButtonDown  
 Called by the framework to update the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control when the user presses the left mouse button on the control.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__onlbuttonup">\</a>  CMFCRibbonEdit::OnLButtonUp  
 Called by the framework when the user releases the left mouse button.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__onrtlchanged">\</a>  CMFCRibbonEdit::OnRTLChanged  
 Called by the framework to update the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control when the layout changes direction.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> if the layout is right-to-left; <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> if the layout is left-to-right.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__onshow">\</a>  CMFCRibbonEdit::OnShow  
 Called by the framework to show or hide the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> to show the control; <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> to hide the control.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__redraw">\</a>  CMFCRibbonEdit::Redraw  
 Updates the display of the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 This method redraws the display rectangle for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object by indirectly calling                         [CWnd::RedrawWindow](http://msdn.microsoft.com/library/windows/desktop/dd162911) with the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> flags set.  
  
##  \<a name="cmfcribbonedit__setaccdata">\</a>  CMFCRibbonEdit::SetACCData  
 Sets the accessibility data for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Pointer to the parent window for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The accessibility data for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) object.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonedit__setedittext">\</a>  CMFCRibbonEdit::SetEditText  
 Sets the text in the text box.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The text for the text box.  
  
##  \<a name="cmfcribbonedit__settextalign">\</a>  CMFCRibbonEdit::SetTextAlign  
 Sets the text alignment of the text box.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A text alignment enumerated value. See the Remarks section for possible values.  
  
### Remarks  
 The parameter <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> is one of the following edit control styles:  
  
-   **ES_LEFT** for left alignment  
  
-   **ES_CENTER** for center alignment  
  
-   **ES_RIGHT** for right alignment  
  
 For more information about these styles, see                         [Edit Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775464).  
  
##  \<a name="cmfcribbonedit__setwidth">\</a>  CMFCRibbonEdit::SetWidth  
 Sets the width of the text box for the [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The width, in pixels, of the text box.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> to set the width for floating mode; <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> to set the width for regular mode.  
  
### Remarks  
 The [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md) control has two widths depending on its display mode: floating mode and regular mode.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [CMFCRibbonBar](../vs140/cmfcribbonbar-class.md)