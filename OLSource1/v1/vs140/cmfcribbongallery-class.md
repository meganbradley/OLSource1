---
title: "CMFCRibbonGallery Class"
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
  - "CMFCRibbonGallery"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonGallery class"
ms.assetid: 9734c9c9-981c-4b3f-8c59-264fd41811b4
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery Class
Implements Office 2007-style ribbon galleries.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonGallery::CMFCRibbonGallery](#cmfcribbongallery__cmfcribbongallery)|Constructs and initializes a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonGallery::AddGroup](#cmfcribbongallery__addgroup)|Adds a new group to the gallery.|  
|[CMFCRibbonGallery::AddSubItem](#cmfcribbongallery__addsubitem)|Adds a new menu item to the drop-down menu.|  
|[CMFCRibbonGallery::Clear](#cmfcribbongallery__clear)|Clears the content of the gallery.|  
|[CMFCRibbonGallery::EnableMenuResize](#cmfcribbongallery__enablemenuresize)|Enables or disables resizing of the menu panel.|  
|[CMFCRibbonGallery::EnableMenuSideBar](#cmfcribbongallery__enablemenusidebar)|Enables or disables the side bar to the left of the popup menu.|  
|[CMFCRibbonGallery::GetCompactSize](#cmfcribbongallery__getcompactsize)|(Overrides [CMFCRibbonButton::GetCompactSize](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__getcompactsize).)|  
|[CMFCRibbonGallery::GetDroppedDown](#cmfcribbongallery__getdroppeddown)|(Overrides [CMFCRibbonBaseElement::GetDroppedDown](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__getdroppeddown).)|  
|[CMFCRibbonGallery::GetGroupName](#cmfcribbongallery__getgroupname)|Returns the name of the group that is located at the specified index.|  
|[CMFCRibbonGallery::GetGroupOffset](#cmfcribbongallery__getgroupoffset)||  
|[CMFCRibbonGallery::GetIconsInRow](#cmfcribbongallery__geticonsinrow)|Returns the number of items in a row of the ribbon gallery.|  
|[CMFCRibbonGallery::GetItemToolTip](#cmfcribbongallery__getitemtooltip)|Returns the tooltip text that is associated with an item in the gallery.|  
|[CMFCRibbonGallery::GetLastSelectedItem](#cmfcribbongallery__getlastselecteditem)|Returns the index of the last item in the gallery that the user selected.|  
|[CMFCRibbonGallery::GetPaletteID](#cmfcribbongallery__getpaletteid)|Returns the command ID of the current gallery.|  
|[CMFCRibbonGallery::GetRegularSize](#cmfcribbongallery__getregularsize)|(Overrides [CMFCRibbonButton::GetRegularSize](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__getregularsize).)|  
|[CMFCRibbonGallery::GetSelectedItem](#cmfcribbongallery__getselecteditem)||  
|[CMFCRibbonGallery::HasMenu](#cmfcribbongallery__hasmenu)|(Overrides [CMFCRibbonButton::HasMenu](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__hasmenu).)|  
|[CMFCRibbonGallery::IsButtonMode](#cmfcribbongallery__isbuttonmode)|Specifies whether the gallery is contained in a gallery button.|  
|[CMFCRibbonGallery::IsMenuResizeEnabled](#cmfcribbongallery__ismenuresizeenabled)|Specifies whether menu resizing is enabled or disabled.|  
|[CMFCRibbonGallery::IsMenuResizeVertical](#cmfcribbongallery__ismenuresizevertical)||  
|[CMFCRibbonGallery::IsMenuSideBar](#cmfcribbongallery__ismenusidebar)|Specifies whether the side bar is enabled or disabled.|  
|[CMFCRibbonGallery::OnAfterChangeRect](#cmfcribbongallery__onafterchangerect)|(Overrides <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonGallery::OnDraw](#cmfcribbongallery__ondraw)|(Overrides [CMFCRibbonButton::OnDraw](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__ondraw).)|  
|[CMFCRibbonGallery::OnEnable](#cmfcribbongallery__onenable)|(Overrides <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonGallery::OnRTLChanged](#cmfcribbongallery__onrtlchanged)|(Overrides [CMFCRibbonBaseElement::OnRTLChanged](../vs140/cmfcribbonbaseelement-class.md#cmfcribbonbaseelement__onrtlchanged).)|  
|[CMFCRibbonGallery::RedrawIcons](#cmfcribbongallery__redrawicons)|Redraws the gallery.|  
|[CMFCRibbonGallery::RemoveItemToolTips](#cmfcribbongallery__removeitemtooltips)|Removes the tooltips from all items in the gallery.|  
|[CMFCRibbonGallery::SelectItem](#cmfcribbongallery__selectitem)||  
|[CMFCRibbonGallery::SetACCData](#cmfcribbongallery__setaccdata)|(Overrides [CMFCRibbonButton::SetACCData](../vs140/cmfcribbonbutton-class.md#cmfcribbonbutton__setaccdata).)|  
|[CMFCRibbonGallery::SetButtonMode](#cmfcribbongallery__setbuttonmode)|Specifies whether to display the ribbon gallery as a drop-down button or as a palette directly on the ribbon.|  
|[CMFCRibbonGallery::SetGroupName](#cmfcribbongallery__setgroupname)|Sets the name of a group.|  
|[CMFCRibbonGallery::SetIconsInRow](#cmfcribbongallery__seticonsinrow)|Defines the number of items per row in the gallery.|  
|[CMFCRibbonGallery::SetItemToolTip](#cmfcribbongallery__setitemtooltip)|Sets the tooltip text for an item in the gallery.|  
|[CMFCRibbonGallery::SetPalette](#cmfcribbongallery__setpalette)|Attaches a palette to a ribbon gallery.|  
|[CMFCRibbonGallery::SetPaletteID](#cmfcribbongallery__setpaletteid)|Defines the command ID that is sent in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> message when a gallery item has been selected.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonGallery::OnDrawPaletteIcon](#cmfcribbongallery__ondrawpaletteicon)|Called by the framework when a gallery icon is drawn.|  
  
## Remarks  
 A gallery button behaves just like a regular menu button except that it displays a gallery when a user opens it. When you select an item in a gallery, the framework sends the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> message together with command ID of the button. When you handle the message, you should call [CMFCRibbonGallery::GetLastSelectedItem](#cmfcribbongallery__getlastselecteditem) to determine which item was selected from the gallery.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> class to configure a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object. The example illustrates how to specify the number of items per row in the gallery, enable resizing of the menu panel, enable the side bar to the left of the pop-up menu, and display the ribbon gallery as a palette directly on the ribbon bar. This code snippet is part of the [Draw Client sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#6](../vs140/codesnippet/CPP/cmfcribbongallery-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md) [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md) [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonGallery](../vs140/cmfcribbongallery-class.md)  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
##  \<a name="cmfcribbongallery__addgroup">\</a>  CMFCRibbonGallery::AddGroup  
 Adds a new group to the gallery.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Specifies the name of the group.  
  
 [in]  <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies the resource ID of the image list that contains the images for the group.  
  
 [in]  <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the width in pixels of an image.  
  
 [in]  <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A reference to image list that contains group images.  
  
 [in]  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Specifies the number of icons in the group. This parameter should be specified only for custom (owner drawn) groups.  
  
### Remarks  
 You can divide the items on a ribbon gallery into multiple groups by calling this method. Each group can have a caption.  
  
##  \<a name="cmfcribbongallery__addsubitem">\</a>  CMFCRibbonGallery::AddSubItem  
 Adds a new menu item to the drop-down menu.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A pointer to the item to add to the menu.  
  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies the zero-based index of a location where to insert the item.  
  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to specify that the item should be inserted before the ribbon gallery; otherwise, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can combine popup galleries with popup menu items by calling this method. Menu items can be placed before or after the gallery.  
  
 To insert the item before the gallery, set <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. Set <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to insert the item below the gallery.  
  
> [!NOTE]
>  The parameter <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> specifies the insertion index both at the top of the gallery and at the bottom of the gallery. For example, if you need to insert an item one position before the gallery, set <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to 1 and <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. Similarly, if you need to insert an item one position below the gallery, set <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to 1 and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbongallery__clear">\</a>  CMFCRibbonGallery::Clear  
 Clears the content of the gallery.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Call this method to remove all content from the ribbon gallery. This must be done before you attach a new ribbon gallery or set of groups to the ribbon gallery.  
  
##  \<a name="cmfcribbongallery__cmfcribbongallery">\</a>  CMFCRibbonGallery::CMFCRibbonGallery  
 Constructs and initializes a [CMFCRibbonGallery](../vs140/cmfcribbongallery-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Specifies the command ID of the command to execute when a user clicks the button.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Specifies the text to appear on the button.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The zero-based index of the small image to appear on the button.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The zero-based index of the large image to appear on the button.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A reference to the [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object that contains the images to appear on the gallery.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The resource ID of the list of images to display on the gallery.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the image on the gallery.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies the size, in pixels, of the gallery image.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Specifies the number of icons in the gallery.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies whether to use the default or the owner-drawn button style.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__enablemenuresize">\</a>  CMFCRibbonGallery::EnableMenuResize  
 Enables or disables resizing of the menu panel.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> to enable resizing the menu; otherwise, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> to specify that the gallery can be resized only vertically; <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to specify that the gallery can be resized both vertically and horizontally.  
  
### Remarks  
 Use this method to enable or disable resizing the ribbon gallery. When resizing is enabled, the ribbon gallery displays a gripper that a user can use to resize it.  
  
##  \<a name="cmfcribbongallery__enablemenusidebar">\</a>  CMFCRibbonGallery::EnableMenuSideBar  
 Enables or disables the side bar to the left of the popup menu.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to specify that the side bar is enabled; otherwise, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to enable or disable the Office XP-style side bar at the left side of the menu.  
  
##  \<a name="cmfcribbongallery__getcompactsize">\</a>  CMFCRibbonGallery::GetCompactSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getdroppeddown">\</a>  CMFCRibbonGallery::GetDroppedDown  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getgroupname">\</a>  CMFCRibbonGallery::GetGroupName  
 Returns the name of the group that is located at the specified index.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Specifies the zero-based index for the group whose name you want to retrieve.  
  
### Return Value  
 The name of the group located at the specified index. Passing an invalid index will result in a failed assertion.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getgroupoffset">\</a>  CMFCRibbonGallery::GetGroupOffset  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__geticonsinrow">\</a>  CMFCRibbonGallery::GetIconsInRow  
 Returns the number of items in a row of the ribbon gallery.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The number of items in a row.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getitemtooltip">\</a>  CMFCRibbonGallery::GetItemToolTip  
 Returns the tooltip text that is associated with an item in the gallery.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item for which to retrieve the tooltip text.  
  
### Return Value  
 A pointer to the tooltip string assigned to an item in the ribbon gallery. It can be <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> if no tooltip is assigned to that item.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getlastselecteditem">\</a>  CMFCRibbonGallery::GetLastSelectedItem  
 Returns the index of the last item in the ribbon gallery that the user selected.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Specifies the command ID of the menu item that opened the ribbon gallery.  
  
### Return Value  
 When the user selects any item in the ribbon gallery, the library sends the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> message along with Command ID of the menu button that opened the ribbon gallery.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getpaletteid">\</a>  CMFCRibbonGallery::GetPaletteID  
 Returns the command ID of the current palette.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The command ID of the currently selected palette.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getregularsize">\</a>  CMFCRibbonGallery::GetRegularSize  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__getselecteditem">\</a>  CMFCRibbonGallery::GetSelectedItem  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__hasmenu">\</a>  CMFCRibbonGallery::HasMenu  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__isbuttonmode">\</a>  CMFCRibbonGallery::IsButtonMode  
 Specifies whether the palette is contained in a gallery button.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> if the palette is displayed as a drop-down menu button; <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> if the palette is displayed directly on the ribbon.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__ismenuresizeenabled">\</a>  CMFCRibbonGallery::IsMenuResizeEnabled  
 Specifies whether menu resizing is enabled.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> if menu resizing has been enabled; otherwise, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__ismenuresizevertical">\</a>  CMFCRibbonGallery::IsMenuResizeVertical  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__ismenusidebar">\</a>  CMFCRibbonGallery::IsMenuSideBar  
 Specifies whether the side bar is enabled or disabled.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> if the Office XP-style side bar is drawn at the left side of the popup menu; otherwise, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__onafterchangerect">\</a>  CMFCRibbonGallery::OnAfterChangeRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__ondraw">\</a>  CMFCRibbonGallery::OnDraw  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__ondrawpaletteicon">\</a>  CMFCRibbonGallery::OnDrawPaletteIcon  
 Called by the framework when a gallery icon is drawn.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A pointer to the device context that is used for drawing.  
  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle of the icon to draw.  
  
 [in] <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 Specifies the zero-based index in the image list of gallery icons of the icon to draw.  
  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A pointer to the icon being drawn.  
  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 Specifies the color for the text of the item to draw.  
  
### Remarks  
 You can override this method in a derived class to customize the appearance of a ribbon gallery.  
  
##  \<a name="cmfcribbongallery__onenable">\</a>  CMFCRibbonGallery::OnEnable  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__onrtlchanged">\</a>  CMFCRibbonGallery::OnRTLChanged  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__redrawicons">\</a>  CMFCRibbonGallery::RedrawIcons  
 Redraws the gallery.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 Call this function to redraw the gallery. You must call this method if you have changed the contents of the gallery at runtime.  
  
##  \<a name="cmfcribbongallery__removeitemtooltips">\</a>  CMFCRibbonGallery::RemoveItemToolTips  
 Removes the tooltips from all items in the gallery.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcribbongallery__selectitem">\</a>  CMFCRibbonGallery::SelectItem  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__setaccdata">\</a>  CMFCRibbonGallery::SetACCData  
 Populates the specified <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object by using accessibility data from the ribbon gallery.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The parent window of the ribbon gallery window.  
  
 [out] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object that receives the accessibility data from the ribbon gallery.  
  
### Return Value  
  
### Remarks  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> if the method is successful; otherwise, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbongallery__setbuttonmode">\</a>  CMFCRibbonGallery::SetButtonMode  
 Determines whether to display the ribbon gallery as a drop-down button or as a palette directly on the ribbon.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> to display the ribbon gallery as a drop-down menu button; <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> to display the contents of the ribbon gallery directly on the ribbon.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__setgroupname">\</a>  CMFCRibbonGallery::SetGroupName  
 Sets the name of a group.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Specifies the zero-based index for the group for which the name is being changed.  
  
 [in] <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 Specifies the new name for the group.  
  
### Remarks  
 The group whose name is being changed must have been added using the [CMFCRibbonGallery::AddGroup](#cmfcribbongallery__addgroup) method.  
  
##  \<a name="cmfcribbongallery__seticonsinrow">\</a>  CMFCRibbonGallery::SetIconsInRow  
 Specifies the number of items per row in the gallery.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Specifies the number of items to appear in each row of the gallery.  
  
### Remarks  
 Use this method to specify the width of the ribbon gallery.  
  
##  \<a name="cmfcribbongallery__setitemtooltip">\</a>  CMFCRibbonGallery::SetItemToolTip  
 Sets the tooltip text for an item in the gallery.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The zero-based index of the palette item with which to associate the tooltip.  
  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The text to appear on the tooltip.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__setpalette">\</a>  CMFCRibbonGallery::SetPalette  
 Attaches a palette to a ribbon gallery.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Specifies the image list that contains the icons to appear on the gallery.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 Specifies the resource ID of the image list that contains the icons to appear on the gallery.  
  
 [in] <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of an image on the gallery.  
  
### Remarks  
  
##  \<a name="cmfcribbongallery__setpaletteid">\</a>  CMFCRibbonGallery::SetPaletteID  
 Defines the command ID that is sent in the                 **WM_COMMAND** message when a user selects a gallery item.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Specifies the command ID that is sent in the                                 **WM_COMMAND** message when a user selects a gallery item.  
  
### Remarks  
 To determine the specific item that a user selected from the gallery, call the [CMFCRibbonGallery::GetLastSelectedItem](#cmfcribbongallery__getlastselecteditem) static method.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [CMFCRibbonGalleryMenuButton Class](../vs140/cmfcribbongallerymenubutton-class.md)