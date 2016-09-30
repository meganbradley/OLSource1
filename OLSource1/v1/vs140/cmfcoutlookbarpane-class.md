---
title: "CMFCOutlookBarPane Class"
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
  - "CMFCOutlookBarPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Dock method"
  - "IsChangeState method"
  - "SmartUpdate method"
  - "OnBeforeFloat method"
  - "RestoreOriginalstate method"
  - "CMFCOutlookBarPane class"
  - "CanBeRestored method"
ms.assetid: 094e2ef3-a118-487e-a4cc-27626108fe08
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarPane Class
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
 A control derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) that can be inserted into an Outlook bar ( [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md)). The Outlook bar pane contains a column of large buttons. The user can scroll up and down the list of buttons if it is larger than the pane. When the user detaches an Outlook bar pane from the Outlook bar, it can float or dock in the main frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCOutlookBarPane::AddButton](#cmfcoutlookbarpane__addbutton)|Adds a button to the Outlook bar pane.|  
|[CMFCOutlookBarPane::CanBeAttached](#cmfcoutlookbarpane__canbeattached)|Determines whether the pane can be docked to another pane or frame window. (Overrides [CBasePane::CanBeAttached](../vs140/cbasepane-class.md#cbasepane__canbeattached).)|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Determines whether the system can restore a toolbar to its original state after customization. (Overrides [CMFCToolBar::CanBeRestored](../vs140/cmfctoolbar-class.md#cmfctoolbar__canberestored).)|  
|[CMFCOutlookBarPane::ClearAll](#cmfcoutlookbarpane__clearall)|Frees the resources used by the images in the Outlook bar pane.|  
|[CMFCOutlookBarPane::Create](#cmfcoutlookbarpane__create)|Creates the Outlook bar pane.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Called by the framework to dock the Outlook bar pane. (Overrides <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.)|  
|[CMFCOutlookBarPane::EnablePageScrollMode](#cmfcoutlookbarpane__enablepagescrollmode)|Specifies whether the scroll arrows on the Outlook bar pane advance the list of buttons by page, or by button.|  
|[CMFCOutlookBarPane::GetRegularColor](#cmfcoutlookbarpane__getregularcolor)|Returns the regular (non-selected) text color of the Outlook bar pane.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCOutlookBarPane::IsBackgroundTexture](#cmfcoutlookbarpane__isbackgroundtexture)|Determines whether there is a background image loaded for the Outlook bar pane.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Determines whether a floating pane may be docked. (Overrides <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.)|  
|[CMFCOutlookBarPane::IsDrawShadedHighlight](#cmfcoutlookbarpane__isdrawshadedhighlight)|Determines whether the button border is shaded when a button is highlighted and a background image is displayed.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Called by the framework when a pane is about to float. (Overrides [CPane::OnBeforeFloat](../vs140/cpane-class.md#cpane__onbeforefloat).)|  
|[CMFCOutlookBarPane::RemoveButton](#cmfcoutlookbarpane__removebutton)|Removes the button that has a specified command ID.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Restores the original state of a toolbar. (Overrides [CMFCToolBar::RestoreOriginalstate](../vs140/cmfctoolbar-class.md#cmfctoolbar__restoreoriginalstate).)|  
|[CMFCOutlookBarPane::SetBackColor](#cmfcoutlookbarpane__setbackcolor)|Sets the background color.|  
|[CMFCOutlookBarPane::SetBackImage](#cmfcoutlookbarpane__setbackimage)|Sets the background image.|  
|[CMFCOutlookBarPane::SetDefaultState](#cmfcoutlookbarpane__setdefaultstate)|Resets the Outlook bar pane to the original set of buttons.|  
|[CMFCOutlookBarPane::SetExtraSpace](#cmfcoutlookbarpane__setextraspace)|Sets the number of pixels of padding used around buttons in the Outlook bar pane.|  
|[CMFCOutlookBarPane::SetTextColor](#cmfcoutlookbarpane__settextcolor)|Sets the colors of regular and highlighted text in the Outlook bar pane.|  
|[CMFCOutlookBarPane::SetTransparentColor](#cmfcoutlookbarpane__settransparentcolor)|Sets the transparent color for the Outlook bar pane.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Used internally to update the Outlook bar. (Overrides <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.)|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCOutlookBarPane::EnableContextMenuItems](#cmfcoutlookbarpane__enablecontextmenuitems)|Specifies which shortcut menu items are displayed in customization mode.|  
|[CMFCOutlookBarPane::RemoveAllButtons](#cmfcoutlookbarpane__removeallbuttons)|Removes all the buttons from the Outlook bar pane. (Overrides [CMFCToolBar::RemoveAllButtons](../vs140/cmfctoolbar-class.md#cmfctoolbar__removeallbuttons).)|  
  
## Remarks  
 For information about how to implement an Outlook bar, see [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md).  
  
 For an example of an Outlook bar, see the OutlookDemo sample project.  
  
## Example  
 The following example demonstrates how to use various methods of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class. The example shows how to create an Outlook bar pane, enable the page scroll mode, enable docking, and set the background color of the Outlook bar. This code snippet is part of the [Outlook Multi Views sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_OutlookMultiViews#3](../vs140/codesnippet/CPP/cmfcoutlookbarpane-class_1.h)]  
[!code[NVC_MFC_OutlookMultiViews#4](../vs140/codesnippet/CPP/cmfcoutlookbarpane-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CMFCBaseToolBar](../vs140/cmfcbasetoolbar-class.md)  
  
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)  
  
 [CMFCOutlookBarPane](../vs140/cmfcoutlookbarpane-class.md)  
  
## Requirements  
 **Header:** afxoutlookbarpane.h  
  
##  \<a name="cmfcoutlookbarpane__addbutton">\</a>  CMFCOutlookBarPane::AddButton  
 Adds a button to the Outlook bar pane.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Specifies the resource identifier of a bitmap.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Specifies the button's text.  
  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Specifies the button control's ID.  
  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Specifies the zero-based index on the outlook bar's page at which to insert the button.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A string resource ID.  
  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Specifies the name of the disk image file to load.  
  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies the button's text.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A handle to a button's bitmap.  
  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A handle to a buttons' icon.  
  
### Return Value  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if a button was added successfully; otherwise <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to insert a new button into an Outlook bar's page. The button's image can be loaded either from the application resources or from a disk file.  
  
 If the page ID specified by <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is -1, the button is inserted into the first page.  
  
 If the index specified by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is -1, the button is added at the end of the page.  
  
##  \<a name="cmfcoutlookbarpane__canbeattached">\</a>  CMFCOutlookBarPane::CanBeAttached  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcoutlookbarpane__clearall">\</a>  CMFCOutlookBarPane::ClearAll  
 Frees the resources used by the images on the Outlook bar pane.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This method directly calls [CMFCToolBarImages::Clear](../vs140/cmfctoolbarimages-class.md#cmfctoolbarimages__clear), which is called on the images that are used by the Outlook bar pane.  
  
##  \<a name="cmfcoutlookbarpane__create">\</a>  CMFCOutlookBarPane::Create  
 Creates the Outlook bar pane.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies the parent window of the Outlook bar pane control. Must not be <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The window style.  For a list of window styles, see [Window Styles](../vs140/window-styles.md).  
  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The control ID. Must be unique to enable saving of the control's state.  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies special styles that define the behavior of the Outlook bar pane control when it is detached from the Outlook bar.  
  
### Return Value  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Remarks  
 To construct a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object, first call the constructor, and then call <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, which creates the Outlook bar pane control and attaches it to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
 For more information about <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> see [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex).  
  
##  \<a name="cmfcoutlookbarpane__enablecontextmenuitems">\</a>  CMFCOutlookBarPane::EnableContextMenuItems  
 Specifies which shortcut menu items are displayed in customization mode.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A pointer to a toolbar button that a user clicked.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A pointer to the shortcut menu.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> if the shortcut menu should be displayed; otherwise <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method to modify the framework standard shortcut menu that the framework displays in customization mode.  
  
 The default implementation checks the customization mode ( [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscustomizemode)) and if it is set to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, disables all the shortcut menu items except **Delete**. Then, it just passes the input parameters to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  *Context menu* is a synonym for shortcut menu.  
  
##  \<a name="cmfcoutlookbarpane__enablepagescrollmode">\</a>  CMFCOutlookBarPane::EnablePageScrollMode  
 Specifies whether the scroll arrows on the Outlook bar pane advance the list of buttons page by page, or button by button.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, enable the page scroll mode. If <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, disable the page scroll mode.  
  
##  \<a name="cmfcoutlookbarpane__getregularcolor">\</a>  CMFCOutlookBarPane::GetRegularColor  
 Returns the regular (that is, non-selected) text color of the Outlook bar pane.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The current text color as an RGB color value.  
  
### Remarks  
 Use [SetTextColor](#cmfcoutlookbarpane__settextcolor) to set the current (regular and selected) text color of the Outlook bar. You can obtain the default text color by calling the                         [GetSysColor](http://msdn.microsoft.com/library/windows/desktop/ms724371) function with the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> index.  
  
##  \<a name="cmfcoutlookbarpane__isbackgroundtexture">\</a>  CMFCOutlookBarPane::IsBackgroundTexture  
 Determines whether there is a background image loaded for the Outlook bar pane.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> if there is background image to display; otherwise <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can add a background image by calling [SetBackImage](#cmfcoutlookbarpane__setbackimage) function.  
  
 If there is no background image, the background is painted with a color specified by using [SetBackColor](#cmfcoutlookbarpane__setbackcolor).  
  
##  \<a name="cmfcoutlookbarpane__isdrawshadedhighlight">\</a>  CMFCOutlookBarPane::IsDrawShadedHighlight  
 Determines whether the button border is shaded when a button is highlighted and a background image is displayed.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> if button's borders are shaded; otherwise <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcoutlookbarpane__removeallbuttons">\</a>  CMFCOutlookBarPane::RemoveAllButtons  
 Removes all the buttons from the Outlook bar pane.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cmfcoutlookbarpane__removebutton">\</a>  CMFCOutlookBarPane::RemoveButton  
 Removes the button that has a specified command ID.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Specifies the command ID of a button to remove.  
  
### Return Value  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> if the button was successfully removed; <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> if the specified command ID is not valid.  
  
##  \<a name="cmfcoutlookbarpane__setbackcolor">\</a>  CMFCOutlookBarPane::SetBackColor  
 Sets the background color of the Outlook bar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Specifies the new background color.  
  
### Remarks  
 Call this function to set the current background color for the Outlook bar. The background color is used only if there is no background image.  
  
##  \<a name="cmfcoutlookbarpane__setbackimage">\</a>  CMFCOutlookBarPane::SetBackImage  
 Sets the background image.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies the image resource ID.  
  
### Remarks  
 Call this method to set the Outlook bar's background image. The list of background images is managed by the embedded [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object.  
  
##  \<a name="cmfcoutlookbarpane__setdefaultstate">\</a>  CMFCOutlookBarPane::SetDefaultState  
 Resets the Outlook bar pane to the original set of buttons.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 This method restores the Outlook bar buttons to the original set. This method is like <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, except that it does not trigger a redraw of the Outlook bar pane.  
  
##  \<a name="cmfcoutlookbarpane__setextraspace">\</a>  CMFCOutlookBarPane::SetExtraSpace  
 Sets the number of pixels of padding used around buttons in the Outlook bar pane.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="cmfcoutlookbarpane__settextcolor">\</a>  CMFCOutlookBarPane::SetTextColor  
 Sets the colors of regular and highlighted text in the Outlook bar pane.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Specifies the new color for non-selected text.  
  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Specifies the new color for selected text.  
  
##  \<a name="cmfcoutlookbarpane__settransparentcolor">\</a>  CMFCOutlookBarPane::SetTransparentColor  
 Sets the transparent color for the Outlook bar pane.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Specifies the new transparent color.  
  
### Remarks  
 The transparent color is required to display transparent images. Any occurrence of this color in an image is painted with the background color instead.  There is no blending of background and foreground images.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)   
 [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md)   
 [CMFCOutlookBarTabCtrl](../vs140/cmfcoutlookbartabctrl-class.md)