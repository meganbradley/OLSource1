---
title: "CMFCToolBarEditBoxButton Class"
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
  - "OnDrawOnCustomizeList"
  - "OnDraw"
  - "CMFCToolBarEditBoxButton::OnDrawOnCustomizeList"
  - "CMFCToolBarEditBoxButton.SetACCData"
  - "CMFCToolBarEditBoxButton::OnDraw"
  - "OnCalculateSize"
  - "SetACCData"
  - "CMFCToolBarEditBoxButton"
  - "CMFCToolBarEditBoxButton::SetACCData"
  - "CMFCToolBarEditBoxButton::Serialize"
  - "CMFCToolBarEditBoxButton.OnDraw"
  - "CMFCToolBarEditBoxButton.OnDrawOnCustomizeList"
  - "CMFCToolBarEditBoxButton::OnCalculateSize"
  - "Serialize"
  - "CMFCToolBarEditBoxButton.Serialize"
  - "CMFCToolBarEditBoxButton.OnCalculateSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarEditBoxButton class"
  - "SetACCData method"
  - "OnCalculateSize method"
  - "OnDraw method"
  - "OnDrawOnCustomizeList method"
  - "Serialize method"
ms.assetid: b21d9b67-6bf7-4ca9-bd62-b237756e0ab3
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton Class
A toolbar button that contains an edit control ( [CEdit](../vs140/cedit-class.md)).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarEditBoxButton::CMFCToolBarEditBoxButton](#cmfctoolbareditboxbutton__cmfctoolbareditboxbutton)|Constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarEditBoxButton::CanBeStretched](#cmfctoolbareditboxbutton__canbestretched)|Specifies whether a user can stretch the button during customization. (Overrides [CMFCToolBarButton::CanBeStretched](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__canbestretched).)|  
|[CMFCToolBarEditBoxButton::CopyFrom](#cmfctoolbareditboxbutton__copyfrom)|Copies the properties of another toolbar button to the current button. (Overrides [CMFCToolBarButton::CopyFrom](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__copyfrom).)|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> [CreateEdit](#cmfctoolbareditboxbutton__createedit)|Creates a new edit control in the button.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCToolBarEditBoxButton::GetByCmd](#cmfctoolbareditboxbutton__getbycmd)|Retrieves the first <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object in the application that has the specified command ID.|  
|[CMFCToolBarEditBoxButton::GetContentsAll](#cmfctoolbareditboxbutton__getcontentsall)|Retrieves the text of the first edit box toolbar control that has the specified command ID.|  
|[CMFCToolBarEditBoxButton::GetContextMenuID](#cmfctoolbareditboxbutton__getcontextmenuid)|Retrieves the resource ID of the shortcut menu that is associated with the button.|  
|[CMFCToolBarEditBoxButton::GetEditBorder](#cmfctoolbareditboxbutton__geteditborder)|Retrieves the bounding rectangle of the edit part of the edit box button.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> [GetEditBox](#cmfctoolbareditboxbutton__geteditbox)|Returns a pointer to the edit control that is embedded in the button.|  
|[CMFCToolBarEditBoxButton::GetHwnd](#cmfctoolbareditboxbutton__gethwnd)|Retrieves the window handle that is associated with the toolbar button. (Overrides [CMFCToolBarButton::GetHwnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__gethwnd).)|  
|[CMFCToolBarEditBoxButton::GetInvalidateRect](#cmfctoolbareditboxbutton__getinvalidaterect)|Retrieves the region of the client area of the button that must be redrawn. (Overrides [CMFCToolBarButton::GetInvalidateRect](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__getinvalidaterect).)|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCToolBarEditBoxButton::HaveHotBorder](#cmfctoolbareditboxbutton__havehotborder)|Determines whether a border of the button is displayed when a user clicks the button. (Overrides [CMFCToolBarButton::HaveHotBorder](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__havehotborder).)|  
|[CMFCToolBarEditBoxButton::IsFlatMode](#cmfctoolbareditboxbutton__isflatmode)|Determines whether edit box buttons have a flat style.|  
|[CMFCToolBarEditBoxButton::NotifyCommand](#cmfctoolbareditboxbutton__notifycommand)|Specifies whether the button processes the                                         [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message. (Overrides [CMFCToolBarButton::NotifyCommand](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__notifycommand).)|  
|[CMFCToolBarEditBoxButton::OnAddToCustomizePage](#cmfctoolbareditboxbutton__onaddtocustomizepage)|Called by the framework when the button is added to a **Customize** dialog box. (Overrides [CMFCToolBarButton::OnAddToCustomizePage](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onaddtocustomizepage).)|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Called by the framework to calculate the size of the button for the specified device context and docking state. (Overrides [CMFCToolBarButton::OnCalculateSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncalculatesize).)|  
|[CMFCToolBarEditBoxButton::OnChangeParentWnd](#cmfctoolbareditboxbutton__onchangeparentwnd)|Called by the framework when the button is inserted into a new toolbar. (Overrides [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd).)|  
|[CMFCToolBarEditBoxButton::OnClick](#cmfctoolbareditboxbutton__onclick)|Called by the framework when the user clicks the mouse button. (Overrides [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclick).)|  
|[CMFCToolBarEditBoxButton::OnCtlColor](#cmfctoolbareditboxbutton__onctlcolor)|Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> message. (Overrides [CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onctlcolor).)|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Called by the framework to draw the button by using the specified styles and options. (Overrides [CMFCToolBarButton::OnDraw](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondraw).)|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box. (Overrides [CMFCToolBarButton::OnDrawOnCustomizeList](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondrawoncustomizelist).)|  
|[CMFCToolBarEditBoxButton::OnGlobalFontsChanged](#cmfctoolbareditboxbutton__onglobalfontschanged)|Called by the framework when the global font has changed. (Overrides [CMFCToolBarButton::OnGlobalFontsChanged](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onglobalfontschanged).)|  
|[CMFCToolBarEditBoxButton::OnMove](#cmfctoolbareditboxbutton__onmove)|Called by the framework when the parent toolbar moves. (Overrides [CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onmove).)|  
|[CMFCToolBarEditBoxButton::OnShow](#cmfctoolbareditboxbutton__onshow)|Called by the framework when the button becomes visible or invisible. (Overrides [CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onshow).)|  
|[CMFCToolBarEditBoxButton::OnSize](#cmfctoolbareditboxbutton__onsize)|Called by the framework when the parent toolbar changes its size or position and this change causes the button to change size. (Overrides [CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onsize).)|  
|[CMFCToolBarEditBoxButton::OnUpdateToolTip](#cmfctoolbareditboxbutton__onupdatetooltip)|Called by the framework when the parent toolbar updates its tooltip text. (Overrides [CMFCToolBarButton::OnUpdateToolTip](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onupdatetooltip).)|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Reads this object from an archive or writes it to an archive. (Overrides [CMFCToolBarButton::Serialize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__serialize).)|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Populates the provided <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object with accessibility data from the toolbar button. (Overrides [CMFCToolBarButton::SetACCData](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__setaccdata).)|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> [SetContents](#cmfctoolbareditboxbutton__setcontents)|Sets the text in the edit control of the button.|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> [SetContentsAll](#cmfctoolbareditboxbutton__setcontentsall)|Finds the edit control button that has a specified command ID, and sets the text in the edit control of that button.|  
|[CMFCToolBarEditBoxButton::SetContextMenuID](#cmfctoolbareditboxbutton__setcontextmenuid)|Specifies the resource ID of the shortcut menu that is associated with the button.|  
|[CMFCToolBarEditBoxButton::SetFlatMode](#cmfctoolbareditboxbutton__setflatmode)|Specifies the flat style appearance of edit box buttons in the application.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder> [SetStyle](#cmfctoolbareditboxbutton__setstyle)|Specifies the style of the button. (Overrides [CMFCToolBarButton::SetStyle](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__setstyle).)|  
  
## Remarks  
 To add an edit box button to a toolbar, follow these steps:  
  
 1. Reserve a dummy resource ID for the button in the parent toolbar resource.  
  
 2. Construct a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
 3. In the message handler that processes the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> message, replace the dummy button with the new combo box button by using [CMFCToolBar::ReplaceButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__replacebutton).  
  
 For more information, see [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md).  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> class. The example shows how to specify that a user can stretch the button during customization, specify that a border of the button is displayed when a user clicks the button, set the text in the text box control, specify the flat style appearance of edit box buttons in the application, and specify the style of a toolbar edit box control.  
  
 [!code[NVC_MFC_RibbonApp#40](../vs140/codesnippet/CPP/cmfctoolbareditboxbutton-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)  
  
 [CMFCToolBarEditBoxButton](../vs140/cmfctoolbareditboxbutton-class.md)  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
##  \<a name="cmfctoolbareditboxbutton__canbestretched">\</a>  CMFCToolBarEditBoxButton::CanBeStretched  
 Specifies whether a user can stretch the button during customization.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, the framework does not allow the user to stretch a toolbar button during customization. This method extends the base class implementation ( [CMFCToolBarButton::CanBeStretched](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__canbestretched)) by allowing the user to stretch an edit box toolbar button during customization.  
  
##  \<a name="cmfctoolbareditboxbutton__cmfctoolbareditboxbutton">\</a>  CMFCToolBarEditBoxButton::CMFCToolBarEditBoxButton  
 Constructs a [CMFCToolBarEditBoxButton](../vs140/cmfctoolbareditboxbutton-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies the control ID.  
  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Specifies the zero-based index of a toolbar image. The image is located in the [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object that [CMFCToolBar](../vs140/cmfctoolbar-class.md) class maintains.  
  
 [in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Specifies the edit control style.  
  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Specifies the width in pixels of the edit control.  
  
### Remarks  
 The default constructor sets the edit control style to the following combination:  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
 The default width of the control is 150 pixels.  
  
##  \<a name="cmfctoolbareditboxbutton__copyfrom">\</a>  CMFCToolBarEditBoxButton::CopyFrom  
 Copies the properties of another toolbar button to the current button.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A reference to the source button from which to copy.  
  
### Remarks  
 Call this method to copy another toolbar button to this toolbar button. <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> must be of type <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbareditboxbutton__createedit">\</a>  CMFCToolBarEditBoxButton::CreateEdit  
 Creates a new edit control in the button.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies the parent window of the edit control. It must not be NULL.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Specifies the edit control's size and position.  
  
### Return Value  
 A pointer to the newly created edit control; it is <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> if the control's creation and attachment fail.  
  
### Remarks  
 You construct a [CMFCToolBarEditBoxButton](../vs140/cmfctoolbareditboxbutton-class.md) object in two steps. First call the constructor, and then call <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> which creates the Windows edit control and attaches it to the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbareditboxbutton__getbycmd">\</a>  CMFCToolBarEditBoxButton::GetByCmd  
 Retrieves the first <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object in the application that has the specified command ID.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The command ID of the button to retrieve.  
  
### Return Value  
 The first <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object in the application that has the specified command ID, or <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> if no such object exists.  
  
### Remarks  
 This shared utility method is used by methods such as [CMFCToolBarEditBoxButton::SetContentsAll](#cmfctoolbareditboxbutton__setcontentsall) and [CMFCToolBarEditBoxButton::GetContentsAll](#cmfctoolbareditboxbutton__getcontentsall) to set or get the text of the first edit box toolbar control that has the specified command ID.  
  
##  \<a name="cmfctoolbareditboxbutton__getcontentsall">\</a>  CMFCToolBarEditBoxButton::GetContentsAll  
 Retrieves the text of the first edit box toolbar control that has the specified command ID.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The command ID of the button from which to retrieve contents.  
  
### Return Value  
 A <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object that contains the text of the first edit box toolbar control that has the specified command ID.  
  
### Remarks  
 This method returns the empty string if no <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> objects have the specified command ID.  
  
##  \<a name="cmfctoolbareditboxbutton__getcontextmenuid">\</a>  CMFCToolBarEditBoxButton::GetContextMenuID  
 Retrieves the resource ID of the shortcut menu that is associated with the button.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The resource ID of the shortcut menu that is associated with the button or 0 if the button has no associated shortcut menu.  
  
### Remarks  
 The framework uses the resource ID to create the shortcut menu when the user right-clicks on the button.  
  
##  \<a name="cmfctoolbareditboxbutton__geteditborder">\</a>  CMFCToolBarEditBoxButton::GetEditBorder  
 Retrieves the bounding rectangle of the edit part of the edit box button.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object that receives the bounding rectangle.  
  
### Remarks  
 This method retrieves the bounding rectangle of the edit control in client coordinates. It expands the size of the rectangle in each direction by one pixel.  
  
 The [CMFCVisualManager::OnDrawEditBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondraweditborder) method calls this method when it draws the border around a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbareditboxbutton__geteditbox">\</a>  CMFCToolBarEditBoxButton::GetEditBox  
 Returns a pointer to the [CEdit](../vs140/cedit-class.md) control that is embedded in the button.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the [CEdit](../vs140/cedit-class.md) control that the button contains. It is <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> control has not been created yet.  
  
### Remarks  
 You create the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> control by calling [CMFCToolBarEditBoxButton::CreateEdit](#cmfctoolbareditboxbutton__createedit).  
  
##  \<a name="cmfctoolbareditboxbutton__gethwnd">\</a>  CMFCToolBarEditBoxButton::GetHwnd  
 Retrieves the window handle that is associated with the toolbar button.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The window handle that is associated with the button.  
  
### Remarks  
 This method overrides the [CMFCToolBarButton::GetHwnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__gethwnd) method by returning the window handle of the edit control part of the edit box button.  
  
##  \<a name="cmfctoolbareditboxbutton__getinvalidaterect">\</a>  CMFCToolBarEditBoxButton::GetInvalidateRect  
 Retrieves the region of the client area of the button that must be redrawn.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object that specifies the region that must be redrawn.  
  
### Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::GetInvalidateRect](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__getinvalidaterect), by including in the region the area of the text label.  
  
##  \<a name="cmfctoolbareditboxbutton__havehotborder">\</a>  CMFCToolBarEditBoxButton::HaveHotBorder  
 Determines whether a border of the button is displayed when a user clicks the button.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a button displays its border when selected; otherwise 0.  
  
### Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::HaveHotBorder](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__havehotborder), by returning a nonzero value if the control is visible.  
  
##  \<a name="cmfctoolbareditboxbutton__isflatmode">\</a>  CMFCToolBarEditBoxButton::IsFlatMode  
 Determines whether edit box buttons have a flat style.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the buttons have a flat style; otherwise, 0.  
  
### Remarks  
 By default, edit box buttons have a flat style. Use the [CMFCToolBarEditBoxButton::SetFlatMode](#cmfctoolbareditboxbutton__setflatmode) method to change the flat style appearance for your application.  
  
##  \<a name="cmfctoolbareditboxbutton__notifycommand">\</a>  CMFCToolBarEditBoxButton::NotifyCommand  
 Specifies whether the button processes the                 [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The notification message that is associated with the command.  
  
### Return Value  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> if the button processes the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> message, or <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to indicate that the message must be handled by the parent toolbar.  
  
### Remarks  
 The framework calls this method when it is about to send a                         [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message to the parent window.  
  
 This method extends the base class implementation ( [CMFCToolBarButton::NotifyCommand](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__notifycommand)) by processing the                         [EN_UPDATE](http://msdn.microsoft.com/library/windows/desktop/bb761687) notification. For each edit box with the same command ID as this object, it sets its text label to the text label of this object.  
  
##  \<a name="cmfctoolbareditboxbutton__onaddtocustomizepage">\</a>  CMFCToolBarEditBoxButton::OnAddToCustomizePage  
 Called by the framework when the button is added to a **Customize** dialog box.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnAddToCustomizePage](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onaddtocustomizepage)) by copying the properties from the edit box control in any toolbar that has the same command ID as this object. This method does nothing if no toolbar has an edit box control that has the same command ID as this object.  
  
 For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
##  \<a name="cmfctoolbareditboxbutton__onchangeparentwnd">\</a>  CMFCToolBarEditBoxButton::OnChangeParentWnd  
 Called by the framework when the button is inserted into a new toolbar.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to the new parent window.  
  
### Remarks  
 This method overrides the base class implementation ( [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd)) by recreating the internal <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbareditboxbutton__onclick">\</a>  CMFCToolBarEditBoxButton::OnClick  
 Called by the framework when the user clicks the mouse button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Unused.  
  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Unused.  
  
### Return Value  
 Nonzero if the button processes the click message; otherwise 0.  
  
### Remarks  
 This method overrides the base class implementation ( [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclick)) by returning a nonzero value if the internal <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object is visible.  
  
##  \<a name="cmfctoolbareditboxbutton__onctlcolor">\</a>  CMFCToolBarEditBoxButton::OnCtlColor  
 Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Unused.  
  
### Return Value  
 A handle to the global window brush.  
  
### Remarks  
 This method overrides the base class implementation ( [CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onctlcolor)) by setting the text and background colors of the provided device context to the global text and background colors, respectively.  
  
 For more information about global options that are available to your application, see [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md).  
  
##  \<a name="cmfctoolbareditboxbutton__onglobalfontschanged">\</a>  CMFCToolBarEditBoxButton::OnGlobalFontsChanged  
 Called by the framework when the global font has changed.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnGlobalFontsChanged](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onglobalfontschanged)) by changing the font of the control to that of the global font.  
  
 For more information about global options that are available to your application, see [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md).  
  
##  \<a name="cmfctoolbareditboxbutton__onmove">\</a>  CMFCToolBarEditBoxButton::OnMove  
 Called by the framework when the parent toolbar moves.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 This method overrides the default class implementation ( [CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onmove)) by updating the position of the internal <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object  
  
##  \<a name="cmfctoolbareditboxbutton__onshow">\</a>  CMFCToolBarEditBoxButton::OnShow  
 Called by the framework when the button becomes visible or invisible.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Specifies whether the button is visible. If this parameter is <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, the button is visible. Otherwise, the button is not visible.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onshow)) by displaying the button if <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. Otherwise, this method hides the button.  
  
##  \<a name="cmfctoolbareditboxbutton__onsize">\</a>  CMFCToolBarEditBoxButton::OnSize  
 Called by the framework when the parent toolbar changes its size or position and this change causes the button to change size.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The new width of the button, in pixels.  
  
### Remarks  
 This method overrides the default class implementation, [CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onsize), by updating the size and position of the internal <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbareditboxbutton__onupdatetooltip">\</a>  CMFCToolBarEditBoxButton::OnUpdateToolTip  
 Called by the framework when the parent toolbar updates its tooltip text.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Unused.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Unused.  
  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The control that displays the tooltip text.  
  
 [out] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object that receives the updated tooltip text.  
  
### Return Value  
 Nonzero if the method updates the tooltip text; otherwise 0.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnUpdateToolTip](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onupdatetooltip)) by displaying the tooltip text that is associated with the edit part of the button. If the internal <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object is <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> or the window handle of the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object does not identify an existing window, this method does nothing and returns <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbareditboxbutton__setcontents">\</a>  CMFCToolBarEditBoxButton::SetContents  
 Sets the text in the text box control.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Specifies the new text to set.  
  
##  \<a name="cmfctoolbareditboxbutton__setcontentsall">\</a>  CMFCToolBarEditBoxButton::SetContentsAll  
 Finds a [CMFCToolBarEditBoxButton](../vs140/cmfctoolbareditboxbutton-class.md) object that has a specified command ID and sets the specified text within its text box.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Specifies the command ID of the control for which the text will be changed.  
  
 [in] <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Specifies the new text to set.  
  
### Return Value  
 Nonzero if the text was set; 0 if the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> control with the specified command ID does not exist.  
  
##  \<a name="cmfctoolbareditboxbutton__setcontextmenuid">\</a>  CMFCToolBarEditBoxButton::SetContextMenuID  
 Specifies the resource ID of the shortcut menu that is associated with the button.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The resource ID of the shortcut menu.  
  
### Remarks  
 The framework uses the resource ID to create the shortcut menu when the user right-clicks the toolbar button.  
  
##  \<a name="cmfctoolbareditboxbutton__setflatmode">\</a>  CMFCToolBarEditBoxButton::SetFlatMode  
 Specifies the flat style appearance of edit box buttons in the application.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The flat style for edit box buttons. If this parameter is <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, the flat style appearance is enabled; otherwise the flat style appearance is disabled.  
  
### Remarks  
 The default flat style for edit box buttons is <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. Use the [CMFCToolBarEditBoxButton::IsFlatMode](#cmfctoolbareditboxbutton__isflatmode) method to retrieve the flat style appearance for your application.  
  
##  \<a name="cmfctoolbareditboxbutton__setstyle">\</a>  CMFCToolBarEditBoxButton::SetStyle  
 Specifies the style of a toolbar edit box control.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A new style to set.  
  
### Remarks  
 This method sets [CMFCToolBarButton::m_nStyle](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__m_nstyle) to <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> It also disables the text box when the application is in Customize mode, and enables it when the application is not in Customize mode (see [CMFCToolBar::SetCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__setcustomizemode) and [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscustomizemode)). See [ToolBar Control Styles](../vs140/toolbar-control-styles.md) for a list of valid style flags.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md)   
 [CEdit](../vs140/cedit-class.md)   
 [CMFCToolBar::ReplaceButton](../vs140/cmfctoolbar-class.md#cmfctoolbar__replacebutton)   
 [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md)