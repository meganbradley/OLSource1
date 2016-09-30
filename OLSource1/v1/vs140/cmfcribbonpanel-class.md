---
title: "CMFCRibbonPanel Class"
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
  - "CMFCRibbonPanel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonPanel class"
ms.assetid: 51d70749-1140-4386-b103-f14082049ba6
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel Class
Implements a panel that contains a set of ribbon elements. When the panel is drawn, it displays as many elements as possible, given the size of the panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonPanel::CMFCRibbonPanel](#cmfcribbonpanel__cmfcribbonpanel)|Constructs and initializes a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonPanel::Add](#cmfcribbonpanel__add)|Adds a ribbon element to the panel.|  
|[CMFCRibbonPanel::AddSeparator](#cmfcribbonpanel__addseparator)|Adds a separator to the ribbon panel.|  
|[CMFCRibbonPanel::AddToolBar](#cmfcribbonpanel__addtoolbar)|Adds a toolbar to the ribbon panel.|  
|[CMFCRibbonPanel::FindByData](#cmfcribbonpanel__findbydata)||  
|[CMFCRibbonPanel::FindByID](#cmfcribbonpanel__findbyid)|Returns an element identified by a specified command ID.|  
|[CMFCRibbonPanel::GetCaptionHeight](#cmfcribbonpanel__getcaptionheight)||  
|[CMFCRibbonPanel::GetCount](#cmfcribbonpanel__getcount)|Returns the number of elements in the ribbon panel.|  
|[CMFCRibbonPanel::GetData](#cmfcribbonpanel__getdata)|Returns the user-defined data associated with the panel.|  
|[CMFCRibbonPanel::GetDefaultButton](#cmfcribbonpanel__getdefaultbutton)||  
|[CMFCRibbonPanel::GetDroppedDown](#cmfcribbonpanel__getdroppeddown)||  
|[CMFCRibbonPanel::GetElement](#cmfcribbonpanel__getelement)|Returns the ribbon element located at a specified index.|  
|[CMFCRibbonPanel::GetElements](#cmfcribbonpanel__getelements)|Retrieves all elements that are contained in the ribbon panel.|  
|[CMFCRibbonPanel::GetElementsByID](#cmfcribbonpanel__getelementsbyid)||  
|[CMFCRibbonPanel::GetFocused](#cmfcribbonpanel__getfocused)|Returns a focused element.|  
|[CMFCRibbonPanel::GetGalleryRect](#cmfcribbonpanel__getgalleryrect)|Returns a bounding rectangle of Gallery element.|  
|[CMFCRibbonPanel::GetHighlighted](#cmfcribbonpanel__gethighlighted)||  
|[CMFCRibbonPanel::GetIndex](#cmfcribbonpanel__getindex)||  
|[CMFCRibbonPanel::GetItemIDsList](#cmfcribbonpanel__getitemidslist)||  
|[CMFCRibbonPanel::GetName](#cmfcribbonpanel__getname)||  
|[CMFCRibbonPanel::GetParentButton](#cmfcribbonpanel__getparentbutton)||  
|[CMFCRibbonPanel::GetParentCategory](#cmfcribbonpanel__getparentcategory)|Returns the parent category of the ribbon panel.|  
|[CMFCRibbonPanel::GetParentMenuBar](#cmfcribbonpanel__getparentmenubar)||  
|[CMFCRibbonPanel::GetPreferedMenuLocation](#cmfcribbonpanel__getpreferedmenulocation)||  
|[CMFCRibbonPanel::GetPressed](#cmfcribbonpanel__getpressed)||  
|[CMFCRibbonPanel::GetRect](#cmfcribbonpanel__getrect)||  
|[CMFCRibbonPanel::GetVisibleElements](#cmfcribbonpanel__getvisibleelements)|Obtains an array of visible elements.|  
|[CMFCRibbonPanel::HasElement](#cmfcribbonpanel__haselement)||  
|[CMFCRibbonPanel::HitTest](#cmfcribbonpanel__hittest)||  
|[CMFCRibbonPanel::HitTestEx](#cmfcribbonpanel__hittestex)||  
|[CMFCRibbonPanel::Insert](#cmfcribbonpanel__insert)|Inserts a ribbon element at the given position.|  
|[CMFCRibbonPanel::InsertSeparator](#cmfcribbonpanel__insertseparator)|Inserts a separator at the given position.|  
|[CMFCRibbonPanel::IsCenterColumnVert](#cmfcribbonpanel__iscentercolumnvert)|Specifies whether all panel elements should be centered (aligned) vertically, by column.|  
|[CMFCRibbonPanel::IsCollapsed](#cmfcribbonpanel__iscollapsed)||  
|[CMFCRibbonPanel::IsHighlighted](#cmfcribbonpanel__ishighlighted)||  
|[CMFCRibbonPanel::IsJustifyColumns](#cmfcribbonpanel__isjustifycolumns)|Specifies whether all panel columns have the same width.|  
|[CMFCRibbonPanel::IsMainPanel](#cmfcribbonpanel__ismainpanel)||  
|[CMFCRibbonPanel::IsMenuMode](#cmfcribbonpanel__ismenumode)||  
|[CMFCRibbonPanel::MakeGalleryItemVisible](#cmfcribbonpanel__makegalleryitemvisible)|Scrolls the gallery to make the specified Ribbon element visible.|  
|[CMFCRibbonPanel::OnKey](#cmfcribbonpanel__onkey)||  
|[CMFCRibbonPanel::RecalcWidths](#cmfcribbonpanel__recalcwidths)||  
|[CMFCRibbonPanel::Remove](#cmfcribbonpanel__remove)|Removes and optionally deletes an element located at the specified index.|  
|[CMFCRibbonPanel::RemoveAll](#cmfcribbonpanel__removeall)|Removes all elements from the ribbon panel.|  
|[CMFCRibbonPanel::Replace](#cmfcribbonpanel__replace)|Replaces one element with another based on their respective index values.|  
|[CMFCRibbonPanel::ReplaceByID](#cmfcribbonpanel__replacebyid)|Replaces one element with another based on a specified command ID.|  
|[CMFCRibbonPanel::SetCenterColumnVert](#cmfcribbonpanel__setcentercolumnvert)|Orders the panel to align elements vertically, by column.|  
|[CMFCRibbonPanel::SetData](#cmfcribbonpanel__setdata)|Associates user-defined data with the ribbon panel.|  
|[CMFCRibbonPanel::SetElementMenu](#cmfcribbonpanel__setelementmenu)|Assigns a popup menu to the element that has the given command ID.|  
|[CMFCRibbonPanel::SetElementRTC](#cmfcribbonpanel__setelementrtc)|Adds a ribbon element specified by the provided runtime class information to the ribbon panel.|  
|[CMFCRibbonPanel::SetElementRTCByID](#cmfcribbonpanel__setelementrtcbyid)|Adds a ribbon element specified by the provided runtime class information to the ribbon panel.|  
|[CMFCRibbonPanel::SetFocused](#cmfcribbonpanel__setfocused)|Sets focus to the specified Ribbon element.|  
|[CMFCRibbonPanel::SetJustifyColumns](#cmfcribbonpanel__setjustifycolumns)|Enables or disables column justification.|  
|[CMFCRibbonPanel::SetKeys](#cmfcribbonpanel__setkeys)|Sets the keyboard shortcut that displays the ribbon panel.|  
|[CMFCRibbonPanel::ShowPopup](#cmfcribbonpanel__showpopup)||  
  
## Remarks  
 Ribbon panels are logical groupings of related tasks that you create within ribbon categories. As the size of the ribbon changes, the panel layout automatically adjusts to display as many elements as possible.  
  
 You can get a ribbon panels that is contained in a ribbon category by calling the [CMFCRibbonCategory::GetPanel](../vs140/cmfcribboncategory-class.md#cmfcribboncategory__getpanel) method.  
  
## Example  
 The following example demonstrates how to configure a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object by using various methods in the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> class. The example shows how to set the keyboard shortcut that displays the ribbon panel, align elements in the panel vertically by column, and enable column justification. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#10](../vs140/codesnippet/CPP/cmfcribbonpanel-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonPanel](../vs140/cmfcribbonpanel-class.md)  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
##  \<a name="cmfcribbonpanel__add">\</a>  CMFCRibbonPanel::Add  
 Appends the specified ribbon element to the array of ribbon elements that is contained in the ribbon panel.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__addseparator">\</a>  CMFCRibbonPanel::AddSeparator  
 Adds a separator to the ribbon panel.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Call this method to add a separator to the ribbon panel. The separator will be added next to the ribbon element that was added by the previous call to [CMFCRibbonPanel::Add](#cmfcribbonpanel__add). To insert a separator at a given position, call [CMFCRibbonPanel::InsertSeparator](#cmfcribbonpanel__insertseparator).  
  
##  \<a name="cmfcribbonpanel__addtoolbar">\</a>  CMFCRibbonPanel::AddToolBar  
 Adds a toolbar to the ribbon panel.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar to add.  
  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar's cold images.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar's hot images.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar's disabled images.  
  
### Return Value  
 Call this method to add a toolbar to the ribbon panel. The toolbar will be added next to the ribbon element added by the previous call to [CMFCRibbonPanel::Add](#cmfcribbonpanel__add).  
  
### Remarks  
 For more information about toolbars, hot images, cold images, and disabled images, see [CMFCToolBar Class](../vs140/cmfctoolbar-class.md).  
  
##  \<a name="cmfcribbonpanel__cmfcribbonpanel">\</a>  CMFCRibbonPanel::CMFCRibbonPanel  
 Constructs and initializes a [CMFCRibbonPanel](../vs140/cmfcribbonpanel-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The name of the ribbon panel.  
  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Handle to the icon of the default button for the ribbon panel.  
  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Pointer to a ribbon gallery for the ribbon panel.  
  
##  \<a name="cmfcribbonpanel__findbydata">\</a>  CMFCRibbonPanel::FindByData  
 Retrieves the ribbon element that is associated with the specified data.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The data associated with a ribbon element.  
  
### Return Value  
 Pointer to a ribbon element if the method was successful; otherwise <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__findbyid">\</a>  CMFCRibbonPanel::FindByID  
 Retrieves the ribbon element that is identified by the specified command ID.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The command ID of a ribbon element.  
  
### Return Value  
 The ribbon element that is identified by the specified command ID; otherwise <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if no ribbon element is identified with the specified command ID.  
  
##  \<a name="cmfcribbonpanel__getcaptionheight">\</a>  CMFCRibbonPanel::GetCaptionHeight  
 Retrieves the height of a caption for the ribbon panel.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The height, in pixels, of a caption for the ribbon panel.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getcount">\</a>  CMFCRibbonPanel::GetCount  
 Retrieves the number of ribbon elements that are contained in the ribbon panel.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The number of ribbon elements that are contained in the ribbon panel.  
  
##  \<a name="cmfcribbonpanel__getdata">\</a>  CMFCRibbonPanel::GetData  
 Returns the user-defined data associated with the panel.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The user-defined data associated with the panel.  
  
##  \<a name="cmfcribbonpanel__getdefaultbutton">\</a>  CMFCRibbonPanel::GetDefaultButton  
 Retrieves the default button for the ribbon panel.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The default button for the ribbon panel.  
  
### Remarks  
 The default button is displayed when a ribbon panel has insufficient space to display its ribbon elements.  
  
##  \<a name="cmfcribbonpanel__getdroppeddown">\</a>  CMFCRibbonPanel::GetDroppedDown  
 Retrieves a pointer to a ribbon element if its pop-up menu is dropped down.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to the ribbon element that has its pop-up menu dropped down; otherwise <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> if no ribbon element has its pop-up menu dropped down.  
  
### Remarks  
 Only ribbon elements that are contained in the ribbon panel are tested.  
  
##  \<a name="cmfcribbonpanel__getelement">\</a>  CMFCRibbonPanel::GetElement  
 Returns the ribbon element located at a specified index.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the element to retrieve.  
  
### Return Value  
 A valid pointer to the base ribbon element located at position <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> in the ribbon panel, or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> if there is no element at the specified index.  
  
##  \<a name="cmfcribbonpanel__getelements">\</a>  CMFCRibbonPanel::GetElements  
 Retrieves all ribbon elements that are contained in the ribbon panel.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 An array to fill with all the ribbon elements that are contained in the ribbon panel.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getelementsbyid">\</a>  CMFCRibbonPanel::GetElementsByID  
 Adds ribbon elements that have the specified command ID to the specified array.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Command ID for a ribbon element.  
  
 [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Array of ribbon elements.  
  
### Remarks  
 Only ribbon elements that are contained in the ribbon panel are tested.  
  
##  \<a name="cmfcribbonpanel__gethighlighted">\</a>  CMFCRibbonPanel::GetHighlighted  
 Retrieves the ribbon element that is highlighted on the ribbon panel.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to the ribbon element that is highlighted on the ribbon panel.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getindex">\</a>  CMFCRibbonPanel::GetIndex  
 Retrieves the zero-based index of the specified ribbon element from the array of ribbon elements that are contained in the ribbon panel.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
### Return Value  
 Zero-based index of the specified ribbon element if the method was successful; otherwise -1.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getitemidslist">\</a>  CMFCRibbonPanel::GetItemIDsList  
 Retrieves the command IDs for all ribbon elements in the ribbon panel.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The list of command IDs for ribbon elements that are contained in the ribbon panel.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getname">\</a>  CMFCRibbonPanel::GetName  
 Retrieves the name of the ribbon panel.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The name of the ribbon panel.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getparentbutton">\</a>  CMFCRibbonPanel::GetParentButton  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getparentcategory">\</a>  CMFCRibbonPanel::GetParentCategory  
 Returns the parent category of the ribbon panel.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the ribbon category that contains this ribbon panel.  
  
##  \<a name="cmfcribbonpanel__getparentmenubar">\</a>  CMFCRibbonPanel::GetParentMenuBar  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getpreferedmenulocation">\</a>  CMFCRibbonPanel::GetPreferedMenuLocation  
 Retrieves the preferred display rectangle for the pop-up menu of the ribbon panel.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method always returns <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. Override this method to retrieve the preferred display rectangle for the pop-up menu of the ribbon panel.  
  
##  \<a name="cmfcribbonpanel__getpressed">\</a>  CMFCRibbonPanel::GetPressed  
 Retrieves a pointer to a ribbon element on the ribbon panel if the user currently presses it.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a ribbon element if the user currently presses it; otherwise <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getrect">\</a>  CMFCRibbonPanel::GetRect  
 Retrieves the display rectangle for the ribbon panel.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The display rectangle for the ribbon panel.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__haselement">\</a>  CMFCRibbonPanel::HasElement  
 Indicates whether the ribbon panel contains the specified ribbon element.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
### Return Value  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if the ribbon panel contains the specified ribbon element; otherwise <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__highlight">\</a>  CMFCRibbonPanel::Highlight  
 Sets the highlight color for the selected ribbon panel and for the ribbon element specified by the point.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> to highlight the ribbon panel; <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> to unhighlight the ribbon panel.  
  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__hittest">\</a>  CMFCRibbonPanel::HitTest  
 Retrieves a ribbon element if the specified point is located in it.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to test the ribbon panel caption; otherwise <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
### Return Value  
 Pointer to a ribbon element if the specified point is located in it; otherwise <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
### Remarks  
 Only ribbon elements that are contained in the ribbon panel are tested.  
  
##  \<a name="cmfcribbonpanel__hittestex">\</a>  CMFCRibbonPanel::HitTestEx  
 Retrieves the zero-based index of the ribbon element that has the specified point located in it.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The x and y coordinates of the pointer, relative to the upper-left corner of the window.  
  
### Return Value  
 The zero-based index of the ribbon element that has the specified point located in it; otherwise -1.  
  
### Remarks  
 Only ribbon elements that are contained in the ribbon panel are tested.  
  
##  \<a name="cmfcribbonpanel__insert">\</a>  CMFCRibbonPanel::Insert  
 Inserts the specified ribbon element at the specified position in the array of ribbon elements that is contained in the ribbon panel.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Pointer to a ribbon element.  
  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Zero-based value, ranging from -1 to the number of ribbon elements that are contained in the array.  
  
### Return Value  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> if the ribbon element was inserted successfully; otherwise <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the value of <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is -1, or if <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> equals the number of ribbon elements in the array, the specified ribbon element is added to the end of the array. If the value of <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is out of range, the method will fail.  
  
##  \<a name="cmfcribbonpanel__insertseparator">\</a>  CMFCRibbonPanel::InsertSeparator  
 Inserts a separator at the given position.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Specifies the zero-based index where the separator is inserted.  
  
### Return Value  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> if the separator has been inserted successfully; otherwise, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to insert a separator at the position specified by <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. To insert a separator next to the most recently added ribbon element, call [CMFCRibbonPanel::AddSeparator](#cmfcribbonpanel__addseparator).  
  
##  \<a name="cmfcribbonpanel__iscentercolumnvert">\</a>  CMFCRibbonPanel::IsCenterColumnVert  
 Indicates whether the vertical positions of ribbon elements are centered within their display rectangle.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> if the vertical positions of ribbon elements are centered within their display rectangle; otherwise <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonpanel__iscollapsed">\</a>  CMFCRibbonPanel::IsCollapsed  
 Indicates whether the display size of the ribbon panel is minimized in the horizontal direction.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> if the display size of the ribbon panel is minimized in the horizontal direction; otherwise <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
### Remarks  
 When a ribbon panel is collapsed, it only displays its default button, its name, and a drop-down arrow.  
  
##  \<a name="cmfcribbonpanel__ishighlighted">\</a>  CMFCRibbonPanel::IsHighlighted  
 Indicates whether the display of the ribbon panel is highlighted.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> if the display of the ribbon panel is highlighted; otherwise <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
### Remarks  
 The display of a ribbon panel is highlighted when the pointer is over it.  
  
##  \<a name="cmfcribbonpanel__isjustifycolumns">\</a>  CMFCRibbonPanel::IsJustifyColumns  
 Indicates whether the display dimensions of ribbon elements that are in the same column in the ribbon panel are set to the same width.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if the display dimensions of ribbon elements that are in the same column in the ribbon panel are set to the same width; otherwise <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonpanel__ismainpanel">\</a>  CMFCRibbonPanel::IsMainPanel  
 Indicates whether the ribbon panel is the main ribbon panel.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 Always returns <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method always returns <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>. Override this method to indicate whether the ribbon panel is the main ribbon panel.  
  
 The main ribbon panel is displayed when the user selects the application button.  
  
##  \<a name="cmfcribbonpanel__ismenumode">\</a>  CMFCRibbonPanel::IsMenuMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__onkey">\</a>  CMFCRibbonPanel::OnKey  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__recalcwidths">\</a>  CMFCRibbonPanel::RecalcWidths  
 Recalculates the width of each display layout configuration for the ribbon panel.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Pointer to a device context for the ribbon panel.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The height of the ribbon panel.  
  
### Remarks  
 A ribbon panel changes its layout configuration as the available width changes.  
  
##  \<a name="cmfcribbonpanel__remove">\</a>  CMFCRibbonPanel::Remove  
 Removes and optionally deletes an element located at the specified index.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the element that is removed from the ribbon panel.  
  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> to delete the element being removed; otherwise, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> if the element has been removed and deleted (if <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>); <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> if the element was not removed or if there is no ribbon element located at <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to remove an element from the ribbon panel.  
  
##  \<a name="cmfcribbonpanel__removeall">\</a>  CMFCRibbonPanel::RemoveAll  
 Deletes all ribbon elements from the ribbon panel.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
 All ribbon elements are deleted from the ribbon panel and destroyed.  
  
##  \<a name="cmfcribbonpanel__replace">\</a>  CMFCRibbonPanel::Replace  
 Replaces one element with another based on their index value.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the element to replace.  
  
 [in] [out] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A valid pointer to the element that replaces the original element.  
  
### Return Value  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the original ribbon element has been replaced successfully by the new ribbon element; <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> if the ribbon element was not replaced or if there is no element at the specified index.  
  
### Remarks  
 To replace a ribbon element by command ID, call [CMFCRibbonPanel::ReplaceByID](#cmfcribbonpanel__replacebyid).  
  
##  \<a name="cmfcribbonpanel__replacebyid">\</a>  CMFCRibbonPanel::ReplaceByID  
 Replaces one element with another based on a specified command ID.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 Specifies the command ID of the element to replace.  
  
 [in] [out] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 A valid pointer to the element that will replace the original element.  
  
### Return Value  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> if the original ribbon element has been replaced successfully by the new ribbon element; <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> if the ribbon element was not replaced or if no element with the specified command ID actually exists.  
  
### Remarks  
 To replace a ribbon element based on position, call [CMFCRibbonPanel::Replace](#cmfcribbonpanel__replace).  
  
##  \<a name="cmfcribbonpanel__setcentercolumnvert">\</a>  CMFCRibbonPanel::SetCenterColumnVert  
 Enables or disables the centering of the vertical positions of ribbon elements within their display rectangle.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> to center the vertical positions of ribbon elements within their display rectangle; <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> to disable this feature.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__setdata">\</a>  CMFCRibbonPanel::SetData  
 Associates user-defined data with the ribbon panel.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Specifies the user-defined data to set.  
  
### Remarks  
 Call this method to associate user-defined data with the ribbon panel.  
  
##  \<a name="cmfcribbonpanel__setelementmenu">\</a>  CMFCRibbonPanel::SetElementMenu  
 Assigns a popup menu to the element that has the given command ID.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 Specifies the command ID of the ribbon element where the menu is added.  
  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Specifies the handle to the Windows menu to add to the ribbon panel.  
  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> to specify that the command associated with the ribbon element should be executed if the ribbon element is clicked. In this case, the menu is only opened when the user clicks the arrow next to the ribbon element. <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> to specify that the command associated with the ribbon element should not be executed if the ribbon element is clicked. In this case, the popup menu appears regardless of where the user clicks on the element.  
  
 [in] <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> to specify that the popup menu is right-aligned; otherwise, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Specifies the resource ID of the menu to add to the ribbon panel.  
  
### Return Value  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> if the menu has been assigned to the ribbon element; otherwise, <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to assign a popup menu to the ribbon element that has the given command ID.  
  
##  \<a name="cmfcribbonpanel__setelementrtc">\</a>  CMFCRibbonPanel::SetElementRTC  
 Adds the ribbon element that is specified by the provided runtime class information to the ribbon panel.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the ribbon element to add.  
  
 [in] [out] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 A pointer to the runtime class information for the ribbon element that is added to the ribbon panel.  
  
### Return Value  
 The ribbon element that was created by using the specified runtime class information.  
  
### Remarks  
 If you want to add a custom element (for example, a color button) to the ribbon panel, you must specify the custom element's runtime class information. The ribbon stores this information, creates the custom element, and replaces an existing element that is located (identified by) the specified command ID. The ribbon then returns a pointer to the newly created element.  
  
##  \<a name="cmfcribbonpanel__setelementrtcbyid">\</a>  CMFCRibbonPanel::SetElementRTCByID  
 Adds a ribbon element that is specified by the provided runtime class information to the ribbon panel.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Specifies the command ID of the ribbon element to add.  
  
 [in] [out] <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A pointer to the runtime class information associated with the ribbon element that is added to the ribbon panel.  
  
### Return Value  
 The ribbon element that was created by using the specified runtime class information.  
  
### Remarks  
 If you want to add a custom element (for example, a color button) to the ribbon panel, you must specify the custom element's runtime class information. The ribbon stores this information, creates the custom element, and replaces an existing element located by the specified command ID. It then returns a pointer to the newly created element.  
  
### Example  
 The following example shows how to use the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
##  \<a name="cmfcribbonpanel__setjustifycolumns">\</a>  CMFCRibbonPanel::SetJustifyColumns  
 Enables or disables the adjustment of the width of ribbon elements in the same column.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> to adjust the width of ribbon elements in the same column to the width of the largest ribbon element in the column; <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> to disable this width adjustment.  
  
### Remarks  
 When this feature is enabled in a ribbon panel, the widths of ribbon elements in the same column are adjusted to the width of the largest ribbon element in the same column.  
  
##  \<a name="cmfcribbonpanel__setkeys">\</a>  CMFCRibbonPanel::SetKeys  
 Sets the keytip for the default button of the ribbon panel.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 The keytip for the default button of the ribbon panel.  
  
### Remarks  
 The default button is displayed when a ribbon panel has insufficient space to display its ribbon elements.  
  
##  \<a name="cmfcribbonpanel__showpopup">\</a>  CMFCRibbonPanel::ShowPopup  
 Creates and displays a pop-up menu for the ribbon panel.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Pointer to the default button for the ribbon panel.  
  
### Return Value  
 Pointer to the pop-up menu for the ribbon panel if the method was successful; otherwise <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
### Remarks  
 The pop-up menu for the ribbon panel is only available when the display of the ribbon panel is collapsed.  
  
##  \<a name="cmfcribbonpanel__setfocused">\</a>  CMFCRibbonPanel::SetFocused  
 Sets focus to the specified Ribbon element.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 A pointer to a Ribbon element that receives focus.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__makegalleryitemvisible">\</a>  CMFCRibbonPanel::MakeGalleryItemVisible  
 Scrolls the gallery to make the specified Ribbon element visible.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 A pointer to a Ribbon element to show.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__iswindows7look">\</a>  CMFCRibbonPanel::IsWindows7Look  
 Indicates whether the parent ribbon has Windows 7 look (small rectangular application button).  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if the parent ribbon has Windows 7 look; otherwise <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getvisibleelements">\</a>  CMFCRibbonPanel::GetVisibleElements  
 Retrieves an array of visible elements.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 When the function returns, this parameter contains an array of visible elements.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getgalleryrect">\</a>  CMFCRibbonPanel::GetGalleryRect  
 Returns a bounding rectangle of a Gallery element.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 Size and position of the Gallery element within this panel.  
  
### Remarks  
  
##  \<a name="cmfcribbonpanel__getfocused">\</a>  CMFCRibbonPanel::GetFocused  
 Returns a focused element.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a focused element or <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CObject Class](../vs140/cobject-class.md)   
 [CMFCRibbonCategory](../vs140/cmfcribboncategory-class.md)   
 [CMFCRibbonBaseElement Class](../vs140/cmfcribbonbaseelement-class.md)