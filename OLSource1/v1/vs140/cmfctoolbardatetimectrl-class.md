---
title: "CMFCToolBarDateTimeCtrl Class"
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
  - "CMFCToolBarDateTimeCtrl::OnDraw"
  - "OnDraw"
  - "CMFCToolBarDateTimeCtrl.Serialize"
  - "CMFCToolBarDateTimeCtrl.OnSize"
  - "CMFCToolBarDateTimeCtrl.OnDrawOnCustomizeList"
  - "OnSize"
  - "OnCalculateSize"
  - "CMFCToolBarDateTimeCtrl"
  - "CMFCToolBarDateTimeCtrl::OnCalculateSize"
  - "SetStyle"
  - "CMFCToolBarDateTimeCtrl::OnDrawOnCustomizeList"
  - "CMFCToolBarDateTimeCtrl.OnDraw"
  - "CMFCToolBarDateTimeCtrl.SetStyle"
  - "CMFCToolBarDateTimeCtrl::SetStyle"
  - "CMFCToolBarDateTimeCtrl.OnCalculateSize"
  - "CMFCToolBarDateTimeCtrl::Serialize"
  - "CMFCToolBarDateTimeCtrl::OnSize"
  - "Serialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStyle method"
  - "OnCalculateSize method"
  - "OnDraw method"
  - "OnDrawOnCustomizeList method"
  - "CMFCToolBarDateTimeCtrl class"
  - "Serialize method"
  - "OnSize method"
ms.assetid: a3853cb9-8ebc-444f-a1e4-9cf905e24c18
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl Class
A toolbar button that contains a date and time picker control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl](#cmfctoolbardatetimectrl__cmfctoolbardatetimectrl)|Constructs a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarDateTimeCtrl::CanBeStretched](#cmfctoolbardatetimectrl__canbestretched)|Specifies whether a user can stretch the button during customization. (Overrides [CMFCToolBarButton::CanBeStretched](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__canbestretched).)|  
|[CMFCToolBarDateTimeCtrl::CopyFrom](#cmfctoolbardatetimectrl__copyfrom)|Copies the properties of another toolbar button to the current button. (Overrides [CMFCToolBarButton::CopyFrom](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__copyfrom).)|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Reserved for future use.|  
|[CMFCToolBarDateTimeCtrl::CMFCToolBarButton::ExportToMenuButton](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__exporttomenubutton)|Copies text from the toolbar button to a menu.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCToolBarDateTimeCtrl::GetByCmd](#cmfctoolbardatetimectrl__getbycmd)|Retrieves the first <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object in the application that has the specified command ID.|  
|[CMFCToolBarDateTimeCtrl::GetDateTimeCtrl](#cmfctoolbardatetimectrl__getdatetimectrl)|Returns a pointer to the date and time picker control.|  
|[CMFCToolBarDateTimeCtrl::GetHwnd](#cmfctoolbardatetimectrl__gethwnd)|Retrieves the window handle that is associated with the toolbar button. (Overrides [CMFCToolBarButton::GetHwnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__gethwnd).)|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCToolBarDateTimeCtrl::GetTime](#cmfctoolbardatetimectrl__gettime)|Gets the selected time from a date and time picker control and puts it in a specified                                         [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure.|  
|[CMFCToolBarDateTimeCtrl::GetTimeAll](#cmfctoolbardatetimectrl__gettimeall)|Returns the selected time from the time picker control button that has a specified command ID.|  
|[CMFCToolBarDateTimeCtrl::HaveHotBorder](#cmfctoolbardatetimectrl__havehotborder)|Determines whether a border of the button is displayed when a user selects the button. (Overrides [CMFCToolBarButton::HaveHotBorder](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__havehotborder).)|  
|[CMFCToolBarDateTimeCtrl::NotifyCommand](#cmfctoolbardatetimectrl__notifycommand)|Specifies whether the button processes the                                         [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message. (Overrides [CMFCToolBarButton::NotifyCommand](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__notifycommand).)|  
|[CMFCToolBarDateTimeCtrl::OnAddToCustomizePage](#cmfctoolbardatetimectrl__onaddtocustomizepage)|Called by the framework when the button is added to a **Customize** dialog box. (Overrides [CMFCToolBarButton::OnAddToCustomizePage](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onaddtocustomizepage).)|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Called by the framework to calculate the size of the button for the specified device context and docking state. (Overrides [CMFCToolBarButton::OnCalculateSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__oncalculatesize).)|  
|[CMFCToolBarDateTimeCtrl::OnChangeParentWnd](#cmfctoolbardatetimectrl__onchangeparentwnd)|Called by the framework when the button is inserted into a new toolbar. (Overrides [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd).)|  
|[CMFCToolBarDateTimeCtrl::OnClick](#cmfctoolbardatetimectrl__onclick)|Called by the framework when the user clicks the control. (Overrides [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclick).)|  
|[CMFCToolBarDateTimeCtrl::OnCtlColor](#cmfctoolbardatetimectrl__onctlcolor)|Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> message. (Overrides [CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onctlcolor).)|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Called by the framework to draw the button by using the specified styles and options. (Overrides [CMFCToolBarButton::OnDraw](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondraw).)|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Called by the framework to draw the button in the **Commands** pane of the **Customize** dialog box. (Overrides [CMFCToolBarButton::OnDrawOnCustomizeList](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__ondrawoncustomizelist).)|  
|[CMFCToolBarDateTimeCtrl::OnGlobalFontsChanged](#cmfctoolbardatetimectrl__onglobalfontschanged)|Called by the framework when the global font has changed. (Overrides [CMFCToolBarButton::OnGlobalFontsChanged](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onglobalfontschanged).)|  
|[CMFCToolBarDateTimeCtrl::OnMove](#cmfctoolbardatetimectrl__onmove)|Called by the framework when the parent toolbar moves. (Overrides [CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onmove).)|  
|[CMFCToolBarDateTimeCtrl::OnShow](#cmfctoolbardatetimectrl__onshow)|Called by the framework when the button becomes visible or invisible. (Overrides [CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onshow).)|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Called by the framework when the parent toolbar changes its size or position and this change causes the button to change size. (Overrides [CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onsize).)|  
|[CMFCToolBarDateTimeCtrl::OnUpdateToolTip](#cmfctoolbardatetimectrl__onupdatetooltip)|Called by the framework when the parent toolbar updates its tooltip text. (Overrides [CMFCToolBarButton::OnUpdateToolTip](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onupdatetooltip).)|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Reads this object from an archive or writes it to an archive, (Overrides [CMFCToolBarButton::Serialize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__serialize).)|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Sets the style of the toolbar button. (Overrides [CMFCToolBarButton::SetStyle](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__setstyle).)|  
|[CMFCToolBarDateTimeCtrl::SetTime](#cmfctoolbardatetimectrl__settime)|Sets the time and date in the time picker control.|  
|[CMFCToolBarDateTimeCtrl::SetTimeAll](#cmfctoolbardatetimectrl__settimeall)|Sets the time and date in all instances of the time picker control that have a specified command ID.|  
  
## Remarks  
 For an example of how to use a date and time picker control, see the ToolbarDateTimePicker sample project. For information about how to add control buttons to toolbars, see [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)  
  
 [CMFCToolBarDateTimeCtrl](../vs140/cmfctoolbardatetimectrl-class.md)  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
##  \<a name="cmfctoolbardatetimectrl__canbestretched">\</a>  CMFCToolBarDateTimeCtrl::CanBeStretched  
 Specifies whether a user can stretch the button during customization.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 This method returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Remarks  
 By default, the framework does not allow the user to stretch a toolbar button during customization. This method extends the base class implementation ( [CMFCToolBarButton::CanBeStretched](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__canbestretched)) by allowing the user to stretch a date and time toolbar button during customization.  
  
##  \<a name="cmfctoolbardatetimectrl__cmfctoolbardatetimectrl">\</a>  CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl  
 Creates and initializes a [CMFCToolBarDateTimeCtrl](../vs140/cmfctoolbardatetimectrl-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The control ID.  
  
 [in]  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The index of the image in the toolbar's <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The style of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> window that is created when a user clicks the button.  
  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The width of the control, in pixels.  
  
### Remarks  
 This object is initialized to the system date and time. The window style of the internal <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object includes the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter and the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> styles. You cannot change these styles by using <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to change the style of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> control.  
  
### Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> class. This code snippet is part of the [Toolbar Date Time Picker sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_ToolbarDateTimePicker#1](../vs140/codesnippet/CPP/cmfctoolbardatetimectrl-class_1.cpp)]  
  
##  \<a name="cmfctoolbardatetimectrl__copyfrom">\</a>  CMFCToolBarDateTimeCtrl::CopyFrom  
 Copies the properties of another toolbar button to the current button.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A reference to the source button from which to copy.  
  
### Remarks  
 Call this method to copy another toolbar button to this toolbar button. <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> must be of type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbardatetimectrl__exporttomenubutton">\</a>  CMFCToolBarDateTimeCtrl::ExportToMenuButton  
 Copies text from the toolbar button to a menu.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A reference to the target menu button.  
  
### Return Value  
 This method returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method overrides the base class implementation ( [CMFCToolBarButton::ExportToMenuButton](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__exporttomenubutton)) by loading the string resource that is associated with the command ID of the control. For more information about string resources, see [CStringT::LoadString](../vs140/cstringt--loadstring.md).  
  
##  \<a name="cmfctoolbardatetimectrl__getbycmd">\</a>  CMFCToolBarDateTimeCtrl::GetByCmd  
 Retrieves the first <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object in the application that has the specified command ID.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The command ID of the button to retrieve.  
  
### Return Value  
 The first <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object in the application that has the specified command ID, or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> if no <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> objects have the specified command ID.  
  
### Remarks  
 This shared utility method is used by methods such as [CMFCToolBarDateTimeCtrl::SetTimeAll](#cmfctoolbardatetimectrl__settimeall) and [CMFCToolBarDateTimeCtrl::GetTimeAll](#cmfctoolbardatetimectrl__gettimeall) to set or get the time and date of all instances of the time picker control that have a specified command ID.  
  
##  \<a name="cmfctoolbardatetimectrl__getdatetimectrl">\</a>  CMFCToolBarDateTimeCtrl::GetDateTimeCtrl  
 Returns a pointer to the date and time picker control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to date and time picker control; or <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> if the control does not exist.  
  
### Remarks  
 The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> class initializes the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> data member when you insert a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object into a toolbar.  
  
##  \<a name="cmfctoolbardatetimectrl__gethwnd">\</a>  CMFCToolBarDateTimeCtrl::GetHwnd  
 Retrieves the window handle that is associated with the toolbar button.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The window handle that is associated with the date and time toolbar button.  
  
### Remarks  
 This method overrides the [CMFCToolBarButton::GetHwnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__gethwnd) method.  
  
##  \<a name="cmfctoolbardatetimectrl__gettime">\</a>  CMFCToolBarDateTimeCtrl::GetTime  
 Gets the selected time from the associated date and time picker control and puts it in a specified                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 In the first overload, a [COleDateTime](../vs140/coledatetime-class.md) object that will receive the system time information. In the second overload, a [CTime](../vs140/ctime-class.md) object that will receive the system time information.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to the                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure to receive the system time information. Must not be <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
### Return Value  
 In the first overload, nonzero if the time is successfully written to the [COleDateTime](../vs140/coledatetime-class.md) object; otherwise 0. In the second and third overloads, the return value is a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> that is equal to the dwFlag member that was set in the                         [NMDATETIMECHANGE](http://msdn.microsoft.com/library/windows/desktop/bb761730) structure.  
  
### Remarks  
 The method sets the                         [NMDATETIMECHANGE](http://msdn.microsoft.com/library/windows/desktop/bb761730) structure member dwFlags to indicate whether the date and time picker is set to a date and time. If the value equals GDT_NONE, the control is set to <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> status, and uses the DTS_SHOWNONE style. If the value returned equals GDT_VALID, the system time is successfully stored in the destination location.  
  
##  \<a name="cmfctoolbardatetimectrl__gettimeall">\</a>  CMFCToolBarDateTimeCtrl::GetTimeAll  
 Returns the time selected by the user from the time picker control button that has a specified command ID.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Specifies a toolbar button's command ID.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 In the first overload, a [COleDateTime](../vs140/coledatetime-class.md) object that will receive the system time information. In the second overload, a [CTime](../vs140/ctime-class.md) object that will receive the system time information.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A pointer to the                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure to receive the system time information. Must not be <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Return Value  
 If the framework cannot find a toolbar button that matches the command ID <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, the return value is zero in the first overload, and GDT_NONE in the other overloads. If the toolbar button is found, the return value is the same as the return value from a call to [CMFCToolBarDateTimeCtrl::GetTime](#cmfctoolbardatetimectrl__gettime) on that button. A return value of zero or GDT_NONE can occur when the button is found, which indicates that the call to <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> did not return a valid date for some other reason.  
  
### Remarks  
 This method looks for a toolbar button that has the specified command ID and calls [CMFCToolBarDateTimeCtrl::GetTime](#cmfctoolbardatetimectrl__gettime) method on that button.  
  
##  \<a name="cmfctoolbardatetimectrl__havehotborder">\</a>  CMFCToolBarDateTimeCtrl::HaveHotBorder  
 Determines whether a border of the button is displayed when a user selects the button.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if a button displays its border when selected; otherwise 0.  
  
### Remarks  
 This method returns a nonzero value if the control is visible.  
  
##  \<a name="cmfctoolbardatetimectrl__notifycommand">\</a>  CMFCToolBarDateTimeCtrl::NotifyCommand  
 Specifies whether the button processes the                 [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The notification message that is associated with the command.  
  
### Return Value  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> if the button processes the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> message, or <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> to indicate that the message should be handled by the parent toolbar.  
  
### Remarks  
 The framework calls this method when it is about to send a                         [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message to the parent window.  
  
 This method extends the base class implementation ( [CMFCToolBarButton::NotifyCommand](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__notifycommand)) by processing the                         [DTN_DATETIMECHANGE](http://msdn.microsoft.com/library/windows/desktop/bb761737) notification. It updates the internal time status and updates the time property of all <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> objects with the same command ID.  
  
##  \<a name="cmfctoolbardatetimectrl__onaddtocustomizepage">\</a>  CMFCToolBarDateTimeCtrl::OnAddToCustomizePage  
 Called by the framework when the button is added to a **Customize** dialog box.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::OnAddToCustomizePage](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onaddtocustomizepage), by copying the properties from the first date and time control in any toolbar that has the same command ID as this object. This method does nothing if no toolbar has a date and time control that has the same command ID as this object.  
  
 For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
##  \<a name="cmfctoolbardatetimectrl__onchangeparentwnd">\</a>  CMFCToolBarDateTimeCtrl::OnChangeParentWnd  
 Called by the framework when the button is inserted into a new toolbar.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The new parent window.  
  
### Remarks  
 This method overrides the base class implementation ( [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onchangeparentwnd)) by recreating the internal <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbardatetimectrl__onclick">\</a>  CMFCToolBarDateTimeCtrl::OnClick  
 Called by the framework when the user clicks the control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Unused.  
  
 [in] <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Unused.  
  
### Return Value  
 Nonzero if the button processes the click message; otherwise 0.  
  
### Remarks  
 This method overrides the base class implementation, [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onclick), by returning a nonzero value if the internal <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object is visible.  
  
##  \<a name="cmfctoolbardatetimectrl__onctlcolor">\</a>  CMFCToolBarDateTimeCtrl::OnCtlColor  
 Called by the framework when the parent toolbar handles a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The device context that displays the button.  
  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Unused.  
  
### Return Value  
 A handle to the global brush that the framework uses to paint the background of the button.  
  
### Remarks  
 This method overrides the base class implementation, [CMFCToolBarButton::OnCtlColor](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onctlcolor), by setting the text and background colors of the provided device context to the global text and background colors, respectively.  
  
 For more information about global options that are available to your application, see [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md).  
  
##  \<a name="cmfctoolbardatetimectrl__onglobalfontschanged">\</a>  CMFCToolBarDateTimeCtrl::OnGlobalFontsChanged  
 Called by the framework when the global font has changed.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnGlobalFontsChanged](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onglobalfontschanged)) by changing the font of the control to that of the global font.  
  
 For more information about global options that are available to your application, see [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md).  
  
##  \<a name="cmfctoolbardatetimectrl__onmove">\</a>  CMFCToolBarDateTimeCtrl::OnMove  
 Called by the framework when the parent toolbar moves.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 This method overrides the default class implementation ( [CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onmove)) by updating the position of the internal <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbardatetimectrl__onshow">\</a>  CMFCToolBarDateTimeCtrl::OnShow  
 Called by the framework when the button becomes visible or invisible.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Specifies whether the button is visible. If this parameter is <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, the button is visible. Otherwise, the button is not visible.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onshow)) by displaying the button if <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. Otherwise, this method hides the button.  
  
##  \<a name="cmfctoolbardatetimectrl__onsize">\</a>  CMFCToolBarDateTimeCtrl::OnSize  
 Called by the framework when the parent toolbar changes its size or position and this change causes the button to change size.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The new width of the button, in pixels.  
  
### Remarks  
 This method overrides the default class implementation ( [CMFCToolBarButton::OnSize](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onsize)) by updating the size and position of the internal <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfctoolbardatetimectrl__onupdatetooltip">\</a>  CMFCToolBarDateTimeCtrl::OnUpdateToolTip  
 Called by the framework when the parent toolbar updates its tooltip text.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The parent window.  
  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The zero-based index of the button in the parent button collection.  
  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The control that displays the tooltip text.  
  
 [out] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object that receives the updated tooltip text.  
  
### Return Value  
 Nonzero if the method updates the tooltip text; otherwise 0.  
  
### Remarks  
 This method extends the base class implementation ( [CMFCToolBarButton::OnUpdateToolTip](../vs140/cmfctoolbarbutton-class.md#cmfctoolbarbutton__onupdatetooltip)) by displaying the tooltip text that is associated with the button. If the button is not docked horizontally, this method does nothing and returns <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbardatetimectrl__settime">\</a>  CMFCToolBarDateTimeCtrl::SetTime  
 Sets the time and date in the time picker control.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 In the first version, a reference to a [COleDateTime](../vs140/coledatetime-class.md) object that contains the time to which the control will be set. In the second version, a pointer to a [CTime](../vs140/ctime-class.md) object that contains the time to which the control will be set.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 A pointer to the                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that contains the time to which the control will be set.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Sets the time in a date and time picker control by calling [CDateTimeCtrl::SetTime](../vs140/cdatetimectrl-class.md#cdatetimectrl__settime).  
  
##  \<a name="cmfctoolbardatetimectrl__settimeall">\</a>  CMFCToolBarDateTimeCtrl::SetTimeAll  
 Sets the time and date in all instances of the time picker control that have a specified command ID.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Specifies a toolbar button's command ID.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 In the first version, a [COleDateTime](../vs140/coledatetime-class.md) object that contains the time to which the control will be set. In the second version, a pointer to a [CTime](../vs140/ctime-class.md) object that contains the time to which the control will be set.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 A pointer to the                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure that contains the time to which the control will be set.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Looks for a toolbar button with the specified command ID and sets the time in a date and time picker control by calling [CMFCToolBarDateTimeCtrl::SetTime](#cmfctoolbardatetimectrl__settime).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolbarButton](../vs140/cmfctoolbarbutton-class.md)   
 [How to Put Controls on Toolbars](../vs140/walkthrough--putting-controls-on-toolbars.md)