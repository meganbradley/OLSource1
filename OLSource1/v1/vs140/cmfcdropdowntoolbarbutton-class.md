---
title: "CMFCDropDownToolbarButton Class"
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
  - "CMFCDropDownToolbarButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCDropDownToolbarButton class"
  - "OnCancelMode method"
ms.assetid: bc9d69e6-bd3e-4c15-9368-e80a504a0ba7
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolbarButton Class
A type of toolbar button that behaves like a regular button when it is clicked. However, it opens a drop-down toolbar ( [CMFCDropDownToolBar](../vs140/cmfcdropdowntoolbar-class.md) if the user presses and holds the toolbar button down.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCDropDownToolbarButton::CMFCDropDownToolbarButton](#cmfcdropdowntoolbarbutton__cmfcdropdowntoolbarbutton)|Constructs a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCDropDownToolbarButton::CopyFrom](#cmfcdropdowntoolbarbutton__copyfrom)|Copies the properties of another toolbar button to the current button. (Overrides [CMFCToolBarButton::CopyFrom](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__copyfrom).)|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCDropDownToolbarButton::DropDownToolbar](#cmfcdropdowntoolbarbutton__dropdowntoolbar)|Opens a drop-down toolbar.|  
|[CMFCDropDownToolbarButton::ExportToMenuButton](#cmfcdropdowntoolbarbutton__exporttomenubutton)|Copies text from the toolbar button to a menu. (Overrides [CMFCToolBarButton::ExportToMenuButton](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__exporttomenubutton).)|  
|[CMFCDropDownToolbarButton::GetDropDownToolBar](#cmfcdropdowntoolbarbutton__getdropdowntoolbar)|Retrieves the drop-down toolbar that is associated with the button.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCDropDownToolbarButton::IsDropDown](#cmfcdropdowntoolbarbutton__isdropdown)|Determines whether the drop-down toolbar is currently open.|  
|[CMFCDropDownToolbarButton::IsExtraSize](#cmfcdropdowntoolbarbutton__isextrasize)|Determines whether the button can be displayed with an extended border. (Overrides [CMFCToolBarButton::IsExtraSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__isextrasize).)|  
|[CMFCDropDownToolbarButton::OnCalculateSize](#cmfcdropdowntoolbarbutton__oncalculatesize)|Called by the framework to calculate the size of the button for the specified device context and docking state. (Overrides [CMFCToolBarButton::OnCalculateSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncalculatesize).)|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Called by the framework to handle the                                         [WM_CANCELMODE](http://msdn.microsoft.com/library/windows/desktop/ms632615) message. (Overrides <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.)|  
|[CMFCDropDownToolbarButton::OnChangeParentWnd](#cmfcdropdowntoolbarbutton__onchangeparentwnd)|Called by the framework when the button is inserted into a new toolbar. (Overrides [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd).)|  
|[CMFCDropDownToolbarButton::OnClick](#cmfcdropdowntoolbarbutton__onclick)|Called by the framework when the user clicks the mouse button. (Overrides [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclick).)|  
|[CMFCDropDownToolbarButton::OnClickUp](#cmfcdropdowntoolbarbutton__onclickup)|Called by the framework when the user releases the mouse button. (Overrides [CMFCToolBarButton::OnClickUp](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclickup).)|  
|[CMFCDropDownToolbarButton::OnContextHelp](#cmfcdropdowntoolbarbutton__oncontexthelp)|Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> message. (Overrides [CMFCToolBarButton::OnContextHelp](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncontexthelp).)|  
|[CMFCDropDownToolbarButton::OnCustomizeMenu](#cmfcdropdowntoolbarbutton__oncustomizemenu)|Modifies the provided menu when the application displays a shortcut menu on the parent toolbar. (Overrides [CMFCToolBarButton::OnCustomizeMenu](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncustomizemenu).)|  
|[CMFCDropDownToolbarButton::OnDraw](#cmfcdropdowntoolbarbutton__ondraw)|Called by the framework to draw the button by using the specified styles and options. (Overrides [CMFCToolBarButton::OnDraw](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondraw).)|  
|[CMFCDropDownToolbarButton::OnDrawOnCustomizeList](#cmfcdropdowntoolbarbutton__ondrawoncustomizelist)|Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box. (Overrides [CMFCToolBarButton::OnDrawOnCustomizeList](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondrawoncustomizelist).)|  
|[CMFCDropDownToolbarButton::Serialize](#cmfcdropdowntoolbarbutton__serialize)|Reads this object from an archive or writes it to an archive. (Overrides [CMFCToolBarButton::Serialize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__serialize).)|  
|[CMFCDropDownToolbarButton::SetDefaultCommand](#cmfcdropdowntoolbarbutton__setdefaultcommand)|Sets the default command that the framework uses when a user clicks the button.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCDropDownToolbarButton::m_uiShowBarDelay](#cmfcdropdowntoolbarbutton__m_uishowbardelay)|Specifies the length of time that a user must hold the mouse button down before the drop-down toolbar appears.|  
  
## Remarks  
 A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> differs from an ordinary button in that it has a small arrow in the lower-right corner of the button. After the user selects a button from the drop-down toolbar, the framework displays its icon on the top-level toolbar button (the button with the small arrow in the lower-right corner).  
  
 For information about how to implement a drop-down toolbar, see [CMFCDropDownToolBar](../vs140/cmfcdropdowntoolbar-class.md).  
  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object can be exported to a [CMFCToolbarMenuButton](../vs140/cmfctoolbarmenubutton-class.md) object and displayed as a menu button with a pop-up menu.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)  
  
 [CMFCDropDownToolbarButton](../vs140/cmfcdropdowntoolbarbutton-class.md)  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
##  \<a name="cmfcdropdowntoolbarbutton__copyfrom">\</a>  CMFCDropDownToolbarButton::CopyFrom  
 Copies the properties of another toolbar button to the current button.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A reference to the source button from which to copy.  
  
### Remarks  
 Call this method to copy another toolbar button to this toolbar button. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> must be of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcdropdowntoolbarbutton__cmfcdropdowntoolbarbutton">\</a>  CMFCDropDownToolbarButton::CMFCDropDownToolbarButton  
 Constructs a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The default text of the button.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object that is displayed when the user presses the button.  
  
### Remarks  
 The second overload of the constructor copies to the drop-down button the first button from the toolbar that <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> specifies.  
  
 Typically, a drop-down toolbar button uses the text from the most recently used button in the toolbar that <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> specifies. It uses the text specified by <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> when the button is converted to a menu button or is displayed in the **Commands** tab of the **Customize** dialog box. For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
### Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#31](../vs140/codesnippet/CPP/cmfcdropdowntoolbarbutton-class_1.cpp)]  
  
##  \<a name="cmfcdropdowntoolbarbutton__dropdowntoolbar">\</a>  CMFCDropDownToolbarButton::DropDownToolbar  
 Opens a drop-down toolbar.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The parent window of the drop-down frame, or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to use the parent window of the drop-down toolbar button.  
  
### Return Value  
 Nonzero if the method is successful; otherwise 0.  
  
### Remarks  
 The [CMFCDropDownToolbarButton::OnClick](#cmfcdropdowntoolbarbutton__onclick) method calls this method to open the drop-down toolbar when the user presses and holds the toolbar button down.  
  
 This methods creates the drop-down toolbar by using the [CMFCDropDownFrame::Create](../vs140/cmfcdropdownframe-class.md#cmfcdropdownframe__create) method. If the parent toolbar is docked vertically, this method positions the drop-down toolbar either to the left-hand or right-hand side of the parent toolbar, depending on the fit. Otherwise, this method positions the drop-down toolbar underneath the parent toolbar.  
  
 This method fails if <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and the drop-down toolbar button does not have a parent window.  
  
##  \<a name="cmfcdropdowntoolbarbutton__exporttomenubutton">\</a>  CMFCDropDownToolbarButton::ExportToMenuButton  
 Copies text from the toolbar button to a menu.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A reference to the target menu button.  
  
### Return Value  
 Nonzero if the method succeeds; otherwise 0.  
  
### Remarks  
 This method calls the base class implementation ( [CMFCToolBarButton::ExportToMenuButton](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__exporttomenubutton)) and then appends to the target menu button a pop-up menu that contains each toolbar menu item in this button. This method does not append sub-menus to the pop-up menu.  
  
 This method fails if the parent toolbar, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, is <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or the base class implementation returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcdropdowntoolbarbutton__getdropdowntoolbar">\</a>  CMFCDropDownToolbarButton::GetDropDownToolBar  
 Retrieves the drop-down toolbar that is associated with the button.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The drop-down toolbar that is associated with the button.  
  
### Remarks  
 This method returns the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> data member.  
  
##  \<a name="cmfcdropdowntoolbarbutton__isdropdown">\</a>  CMFCDropDownToolbarButton::IsDropDown  
 Determines whether the drop-down toolbar is currently open.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the drop-down toolbar is currently open; otherwise 0.  
  
### Remarks  
 The framework opens the drop-down toolbar by using the [CMFCDropDownToolbarButton::DropDownToolbar](#cmfcdropdowntoolbarbutton__dropdowntoolbar) method. The framework closes the drop-down toolbar when the user presses the left-mouse button in the non-client area of the drop-down toolbar.  
  
##  \<a name="cmfcdropdowntoolbarbutton__isextrasize">\</a>  CMFCDropDownToolbarButton::IsExtraSize  
 Determines whether the button can be displayed with an extended border.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the toolbar button can be displayed with an extended border; otherwise 0.  
  
### Remarks  
 For more information about extended borders, see [CMFCToolBarButton::IsExtraSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__isextrasize).  
  
##  \<a name="cmfcdropdowntoolbarbutton__m_uishowbardelay">\</a>  CMFCDropDownToolbarButton::m_uiShowBarDelay  
 Specifies the length of time that a user must hold the mouse button down before the drop-down toolbar appears.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 The delay time is measured in milliseconds. The default value is 500. You can set another delay by changing the value of this shared data member.  
  
##  \<a name="cmfcdropdowntoolbarbutton__oncalculatesize">\</a>  CMFCDropDownToolbarButton::OnCalculateSize  
 Called by the framework to calculate the size of the button for the specified device context and docking state.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The default size of the button.  
  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. This parameter is <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> if the toolbar is docked horizontally or is floating, or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> if the toolbar is docked vertically.  
  
### Return Value  
 A <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> structure that contains the dimensions of the button, in pixels.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnCalculateSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncalculatesize)) by adding the width of the drop-down arrow to the horizontal dimension of the button size.  
  
##  \<a name="cmfcdropdowntoolbarbutton__onchangeparentwnd">\</a>  CMFCDropDownToolbarButton::OnChangeParentWnd  
 Called by the framework when the button is inserted into a new toolbar.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The new parent window.  
  
### Remarks  
 This method overrides the base class implementation ( [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd)) by clearing the text label ( [CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__m_strtext)) and setting the [CMFCToolBarButton::m_bText](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__m_btext) and [CMFCToolBarButton::m_bUserButton](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__m_buserbutton) data members to <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcdropdowntoolbarbutton__onclick">\</a>  CMFCDropDownToolbarButton::OnClick  
 Called by the framework when the user clicks the mouse button.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The parent window of the toolbar button.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> if the message should be handled with a delay.  
  
### Return Value  
 Nonzero if the button processes the click message; otherwise 0.  
  
### Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclick), by updating the state of the drop-down toolbar.  
  
 When a user clicks the toolbar button, this method creates a timer that waits the length of time specified by the [m_uiShowBarDelay](#cmfcdropdowntoolbarbutton__m_uishowbardelay) data member and then opens the drop-down toolbar by using the [CMFCDropDownToolbarButton::DropDownToolbar](#cmfcdropdowntoolbarbutton__dropdowntoolbar) method. This method closes the drop-down toolbar the second time the user clicks the toolbar button.  
  
##  \<a name="cmfcdropdowntoolbarbutton__onclickup">\</a>  CMFCDropDownToolbarButton::OnClickUp  
 Called by the framework when the user releases the mouse button.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the button processes the click message; otherwise 0.  
  
### Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::OnClickUp](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclickup), by updating the state of the drop-down toolbar.  
  
 This method stops the drop-down toolbar timer if it is active. It closes the drop-down toolbar if it is open.  
  
 For more information about the drop-down toolbar and drop-down toolbar timer, see [CMFCDropDownToolbarButton::OnClick](#cmfcdropdowntoolbarbutton__onclick).  
  
##  \<a name="cmfcdropdowntoolbarbutton__oncontexthelp">\</a>  CMFCDropDownToolbarButton::OnContextHelp  
 Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The parent window of the toolbar button.  
  
### Return Value  
 Nonzero if the button processes the help message; otherwise 0.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnContextHelp](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncontexthelp)) by calling the [CMFCDropDownToolbarButton::OnClick](#cmfcdropdowntoolbarbutton__onclick) method with <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. This method returns the value that is returned by [CMFCDropDownToolbarButton::OnClick](#cmfcdropdowntoolbarbutton__onclick).  
  
 For more information about the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> [TN028: Context-Sensitive Help Support](../vs140/tn028--context-sensitive-help-support.md).  
  
##  \<a name="cmfcdropdowntoolbarbutton__oncustomizemenu">\</a>  CMFCDropDownToolbarButton::OnCustomizeMenu  
 Modifies the provided menu when the application displays a shortcut menu on the parent toolbar.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The menu to customize.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnCustomizeMenu](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncustomizemenu)) by disabling the following menu items:  
  
-   **Copy Button Image**  
  
-   **Button Appearance**  
  
-   **Image**  
  
-   **Text**  
  
-   **Image and Text**  
  
 Override this method to modify the shortcut menu that the framework displays in customization mode.  
  
##  \<a name="cmfcdropdowntoolbarbutton__ondraw">\</a>  CMFCDropDownToolbarButton::OnDraw  
 Called by the framework to draw the button by using the specified styles and options.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The collection of toolbar images that is associated with the button.  
  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The dock state of the parent toolbar. This parameter is <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> when the button is docked horizontally and <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> when the button is docked vertically.  
  
 [in] <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies whether the toolbar is in customization mode. This parameter is <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> when the toolbar is in customization mode and <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> when the toolbar is not in customization mode.  
  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Specifies whether the button is highlighted. This parameter is <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> when the button is highlighted and <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> when the button is not highlighted.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Specifies whether the button should display its border. This parameter is <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> when the button should display its border and <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> when the button should not display its border.  
  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Specifies whether to shade disabled buttons or use the disabled images collection. This parameter is <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> when disabled buttons should be shaded and <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> when this method should use the disabled images collection.  
  
### Remarks  
 Override this method to customize toolbar button drawing.  
  
##  \<a name="cmfcdropdowntoolbarbutton__ondrawoncustomizelist">\</a>  CMFCDropDownToolbarButton::OnDrawOnCustomizeList  
 Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The bounding rectangle of the button.  
  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Whether the button is selected. If this parameter is <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, the button is selected. If this parameter is <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, the button is not selected.  
  
### Return Value  
 The width, in pixels, of the button on the specified device context.  
  
### Remarks  
 This method is called by the customization dialog box ( **Commands** tab) when the button is required to display itself on the owner-draw list box.  
  
 This method extends the base class implementation ( [CMFCToolBarButton::OnDrawOnCustomizeList](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondrawoncustomizelist)) by changing the text label of the button to the name of the button (that is,to the value of the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> parameter that you passed to the constructor).  
  
##  \<a name="cmfcdropdowntoolbarbutton__serialize">\</a>  CMFCDropDownToolbarButton::Serialize  
 Reads this object from an archive or writes it to an archive.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object from which or to which to serialize.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::Serialize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__serialize)) by serializing the resource ID of the parent toolbar. When the archive is loading ( [CArchive::IsLoading](../vs140/carchive-class.md#carchive__isloading) returns a nonzero value), this method sets the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> data member to the toolbar that contains the serialized resource ID.  
  
##  \<a name="cmfcdropdowntoolbarbutton__setdefaultcommand">\</a>  CMFCDropDownToolbarButton::SetDefaultCommand  
 Sets the default command that the framework uses when a user clicks the button.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The ID of the default command.  
  
### Remarks  
 Call this method to specify a default command that the framework executes when the user clicks the button. An item with the command ID specified by <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> must be located in the parent drop-down toolbar.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCDropDownToolBar](../vs140/cmfcdropdowntoolbar-class.md)   
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)   
 [CMFCToolbarMenuButton](../vs140/cmfctoolbarmenubutton-class.md)   
 [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md)