---
title: "COleControl Class"
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
  - "COleControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE controls, MFC"
  - "windowless controls, MFC"
  - "windowless controls"
  - "controls [MFC], OLE"
  - "controls [MFC], windowless"
  - "COleControl class"
ms.assetid: 53e95299-38e8-447b-9c5f-a381d27f5123
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl Class
A powerful base class for developing OLE controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleControl::COleControl](#colecontrol__colecontrol)|Creates a <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleControl::AmbientAppearance](#colecontrol__ambientappearance)|Retrieves the current appearance of the control.|  
|[COleControl::AmbientBackColor](#colecontrol__ambientbackcolor)|Returns the value of the ambient BackColor property.|  
|[COleControl::AmbientDisplayName](#colecontrol__ambientdisplayname)|Returns the name of the control as specified by the container.|  
|[COleControl::AmbientFont](#colecontrol__ambientfont)|Returns the value of the ambient Font property.|  
|[COleControl::AmbientForeColor](#colecontrol__ambientforecolor)|Returns the value of the ambient ForeColor property.|  
|[COleControl::AmbientLocaleID](#colecontrol__ambientlocaleid)|Returns the container's locale ID.|  
|[COleControl::AmbientScaleUnits](#colecontrol__ambientscaleunits)|Returns the type of units used by the container.|  
|[COleControl::AmbientShowGrabHandles](#colecontrol__ambientshowgrabhandles)|Determines if grab handles should be displayed.|  
|[COleControl::AmbientShowHatching](#colecontrol__ambientshowhatching)|Determines if hatching should be displayed.|  
|[COleControl::AmbientTextAlign](#colecontrol__ambienttextalign)|Returns the type of text alignment specified by the container.|  
|[COleControl::AmbientUIDead](#colecontrol__ambientuidead)|Determines if the control should respond to user-interface actions.|  
|[COleControl::AmbientUserMode](#colecontrol__ambientusermode)|Determines the mode of the container.|  
|[COleControl::BoundPropertyChanged](#colecontrol__boundpropertychanged)|Notifies the container that a bound property has been changed.|  
|[COleControl::BoundPropertyRequestEdit](#colecontrol__boundpropertyrequestedit)|Requests permission to edit the property value.|  
|[COleControl::ClientToParent](#colecontrol__clienttoparent)|Translates a point relative to the control's origin to a point relative to its container's origin.|  
|[COleControl::ClipCaretRect](#colecontrol__clipcaretrect)|Adjusts a caret rectangle if it is overlapped by a control.|  
|[COleControl::ControlInfoChanged](#colecontrol__controlinfochanged)|Call this function after the set of mnemonics handled by the control has changed.|  
|[COleControl::DisplayError](#colecontrol__displayerror)|Displays stock Error events to the control's user.|  
|[COleControl::DoClick](#colecontrol__doclick)|Implementation of the stock <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> method.|  
|[COleControl::DoPropExchange](#colecontrol__dopropexchange)|Serializes the properties of a <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> object.|  
|[COleControl::DoSuperclassPaint](#colecontrol__dosuperclasspaint)|Redraws an OLE control that has been subclassed from a Windows control.|  
|[COleControl::EnableSimpleFrame](#colecontrol__enablesimpleframe)|Enables simple frame support for a control.|  
|[COleControl::ExchangeExtent](#colecontrol__exchangeextent)|Serializes the control's width and height.|  
|[COleControl::ExchangeStockProps](#colecontrol__exchangestockprops)|Serializes the control's stock properties.|  
|[COleControl::ExchangeVersion](#colecontrol__exchangeversion)|Serializes the control's version number.|  
|[COleControl::FireClick](#colecontrol__fireclick)|Fires the stock <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> event.|  
|[COleControl::FireDblClick](#colecontrol__firedblclick)|Fires the stock <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> event.|  
|[COleControl::FireError](#colecontrol__fireerror)|Fires the stock <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> event.|  
|[COleControl::FireEvent](#colecontrol__fireevent)|Fires a custom event.|  
|[COleControl::FireKeyDown](#colecontrol__firekeydown)|Fires the stock <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> event.|  
|[COleControl::FireKeyPress](#colecontrol__firekeypress)|Fires the stock <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> event.|  
|[COleControl::FireKeyUp](#colecontrol__firekeyup)|Fires the stock <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> event.|  
|[COleControl::FireMouseDown](#colecontrol__firemousedown)|Fires the stock <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> event.|  
|[COleControl::FireMouseMove](#colecontrol__firemousemove)|Fires the stock <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> event.|  
|[COleControl::FireMouseUp](#colecontrol__firemouseup)|Fires the stock <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> event.|  
|[COleControl::FireReadyStateChange](#colecontrol__firereadystatechange)|Fires an event when the control's ready state changes.|  
|[COleControl::GetActivationPolicy](#colecontrol__getactivationpolicy)|Alters the default activation behavior of a control that supports the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> interface.|  
|[COleControl::GetAmbientProperty](#colecontrol__getambientproperty)|Returns the value of the specified ambient property.|  
|[COleControl::GetAppearance](#colecontrol__getappearance)|Returns the value of the stock Appearance property.|  
|[COleControl::GetBackColor](#colecontrol__getbackcolor)|Returns the value of the stock BackColor property.|  
|[COleControl::GetBorderStyle](#colecontrol__getborderstyle)|Returns the value of the stock BorderStyle property.|  
|[COleControl::GetCapture](#colecontrol__getcapture)|Determines whether a windowless, activated control object has the mouse capture.|  
|[COleControl::GetClassID](#colecontrol__getclassid)|Retrieves the OLE class ID of the control.|  
|[COleControl::GetClientOffset](#colecontrol__getclientoffset)|Retrieves the difference between the upper left corner of the control's rectangular area and the upper left corner of its client area.|  
|[COleControl::GetClientRect](#colecontrol__getclientrect)|Retrieves the size of the control's client area.|  
|[COleControl::GetClientSite](#colecontrol__getclientsite)|Queries an object for the pointer to its current client site within its container.|  
|[COleControl::GetControlFlags](#colecontrol__getcontrolflags)|Retrieves the control flag settings.|  
|[COleControl::GetControlSize](#colecontrol__getcontrolsize)|Returns the position and size of the OLE control.|  
|[COleControl::GetDC](#colecontrol__getdc)|Provides a means for a windowless control to get a device context from its container.|  
|[COleControl::GetEnabled](#colecontrol__getenabled)|Returns the value of the stock Enabled property.|  
|[COleControl::GetExtendedControl](#colecontrol__getextendedcontrol)|Retrieves a pointer to an extended control object belonging to the container.|  
|[COleControl::GetFocus](#colecontrol__getfocus)|Determines whether the control has the focus.|  
|[COleControl::GetFont](#colecontrol__getfont)|Returns the value of the stock Font property.|  
|[COleControl::GetFontTextMetrics](#colecontrol__getfonttextmetrics)|Returns the metrics of a <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object.|  
|[COleControl::GetForeColor](#colecontrol__getforecolor)|Returns the value of the stock ForeColor property.|  
|[COleControl::GetHwnd](#colecontrol__gethwnd)|Returns the value of the stock hWnd property.|  
|[COleControl::GetMessageString](#colecontrol__getmessagestring)|Provides status bar text for a menu item.|  
|[COleControl::GetNotSupported](#colecontrol__getnotsupported)|Prevents access to a control's property value by the user.|  
|[COleControl::GetReadyState](#colecontrol__getreadystate)|Returns the control's readiness state.|  
|[COleControl::GetRectInContainer](#colecontrol__getrectincontainer)|Returns the control's rectangle relative to its container.|  
|[COleControl::GetStockTextMetrics](#colecontrol__getstocktextmetrics)|Returns the metrics of the stock Font property.|  
|[COleControl::GetText](#colecontrol__gettext)|Returns the value of the stock Text or Caption property.|  
|[COleControl::GetWindowlessDropTarget](#colecontrol__getwindowlessdroptarget)|Override to allow a windowless control to be the target of drag and drop operations.|  
|[COleControl::InitializeIIDs](#colecontrol__initializeiids)|Informs the base class of the IIDs the control will use.|  
|[COleControl::InternalGetFont](#colecontrol__internalgetfont)|Returns a <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> object for the stock Font property.|  
|[COleControl::InternalGetText](#colecontrol__internalgettext)|Retrieves the stock Caption or Text property.|  
|[COleControl::InternalSetReadyState](#colecontrol__internalsetreadystate)|Sets the control's readiness state and fires the ready-state-change event.|  
|[COleControl::InvalidateControl](#colecontrol__invalidatecontrol)|Invalidates an area of the displayed control, causing it to be redrawn.|  
|[COleControl::InvalidateRgn](#colecontrol__invalidatergn)|Invalidates the container window's client area within the given region. Can be used to redraw windowless controls in the region.|  
|[COleControl::IsConvertingVBX](#colecontrol__isconvertingvbx)|Allows specialized loading of an OLE control.|  
|[COleControl::IsModified](#colecontrol__ismodified)|Determines if the control state has changed.|  
|[COleControl::IsOptimizedDraw](#colecontrol__isoptimizeddraw)|Indicates whether the container supports optimized drawing for the current drawing operation.|  
|[COleControl::IsSubclassedControl](#colecontrol__issubclassedcontrol)|Called to determine if the control subclasses a Windows control.|  
|[COleControl::Load](#colecontrol__load)|Resets any previous asynchronous data and initiates a new load of the control's asynchronous property.|  
|[COleControl::LockInPlaceActive](#colecontrol__lockinplaceactive)|Determines if your control can be deactivated by the container.|  
|[COleControl::OnAmbientPropertyChange](#colecontrol__onambientpropertychange)|Called when an ambient property is changed.|  
|[COleControl::OnAppearanceChanged](#colecontrol__onappearancechanged)|Called when the stock Appearance property is changed.|  
|[COleControl::OnBackColorChanged](#colecontrol__onbackcolorchanged)|Called when the stock BackColor property is changed.|  
|[COleControl::OnBorderStyleChanged](#colecontrol__onborderstylechanged)|Called when the stock BorderStyle property is changed.|  
|[COleControl::OnClick](#colecontrol__onclick)|Called to fire the stock Click event.|  
|[COleControl::OnClose](#colecontrol__onclose)|Notifies the control that <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> has been called.|  
|[COleControl::OnDoVerb](#colecontrol__ondoverb)|Called after a control verb has been executed.|  
|[COleControl::OnDraw](#colecontrol__ondraw)|Called when a control is requested to redraw itself.|  
|[COleControl::OnDrawMetafile](#colecontrol__ondrawmetafile)|Called by the container when a control is requested to redraw itself using a metafile device context.|  
|[COleControl::OnEdit](#colecontrol__onedit)|Called by the container to UI Activate an OLE control.|  
|[COleControl::OnEnabledChanged](#colecontrol__onenabledchanged)|Called when the stock Enabled property is changed.|  
|[COleControl::OnEnumVerbs](#colecontrol__onenumverbs)|Called by the container to enumerate a control's verbs.|  
|[COleControl::OnEventAdvise](#colecontrol__oneventadvise)|Called when event handlers are connected or disconnected from a control.|  
|[COleControl::OnFontChanged](#colecontrol__onfontchanged)|Called when the stock Font property is changed.|  
|[COleControl::OnForeColorChanged](#colecontrol__onforecolorchanged)|Called when the stock ForeColor property is changed.|  
|[COleControl::OnFreezeEvents](#colecontrol__onfreezeevents)|Called when a control's events are frozen or unfrozen.|  
|[COleControl::OnGetColorSet](#colecontrol__ongetcolorset)|Notifies the control that <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> has been called.|  
|[COleControl::OnGetControlInfo](#colecontrol__ongetcontrolinfo)|Provides mnemonic information to the container.|  
|[COleControl::OnGetDisplayString](#colecontrol__ongetdisplaystring)|Called to obtain a string to represent a property value.|  
|[COleControl::OnGetInPlaceMenu](#colecontrol__ongetinplacemenu)|Requests the handle of the control's menu that will be merged with the container menu.|  
|[COleControl::OnGetNaturalExtent](#colecontrol__ongetnaturalextent)|Override to retrieve the control's display size closest to the proposed size and extent mode.|  
|[COleControl::OnGetPredefinedStrings](#colecontrol__ongetpredefinedstrings)|Returns strings representing possible values for a property.|  
|[COleControl::OnGetPredefinedValue](#colecontrol__ongetpredefinedvalue)|Returns the value corresponding to a predefined string.|  
|[COleControl::OnGetViewExtent](#colecontrol__ongetviewextent)|Override to retrieve the size of the control's display areas (can be used to enable two-pass drawing).|  
|[COleControl::OnGetViewRect](#colecontrol__ongetviewrect)|Override to convert control's size into a rectangle starting at a specific position.|  
|[COleControl::OnGetViewStatus](#colecontrol__ongetviewstatus)|Override to retrieve the control's view status.|  
|[COleControl::OnHideToolBars](#colecontrol__onhidetoolbars)|Called by the container when the control is UI deactivated.|  
|[COleControl::OnInactiveMouseMove](#colecontrol__oninactivemousemove)|Override to have the container for the inactive control under the mouse pointer dispatch <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> messages to the control.|  
|[COleControl::OnInactiveSetCursor](#colecontrol__oninactivesetcursor)|Override to have the container for the inactive control under the mouse pointer dispatch <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> messages to the control.|  
|[COleControl::OnKeyDownEvent](#colecontrol__onkeydownevent)|Called after the stock KeyDown event has been fired.|  
|[COleControl::OnKeyPressEvent](#colecontrol__onkeypressevent)|Called after the stock KeyPress event has been fired.|  
|[COleControl::OnKeyUpEvent](#colecontrol__onkeyupevent)|Called after the stock KeyUp event has been fired.|  
|[COleControl::OnMapPropertyToPage](#colecontrol__onmappropertytopage)|Indicates which property page to use for editing a property.|  
|[COleControl::OnMnemonic](#colecontrol__onmnemonic)|Called when a mnemonic key of the control has been pressed.|  
|[COleControl::OnProperties](#colecontrol__onproperties)|Called when the control's "Properties" verb has been invoked.|  
|[COleControl::OnQueryHitPoint](#colecontrol__onqueryhitpoint)|Override to query whether a control's display overlaps a given point.|  
|[COleControl::OnQueryHitRect](#colecontrol__onqueryhitrect)|Override to query whether a control's display overlaps any point in a given rectangle.|  
|[COleControl::OnRenderData](#colecontrol__onrenderdata)|Called by the framework to retrieve data in the specified format.|  
|[COleControl::OnRenderFileData](#colecontrol__onrenderfiledata)|Called by the framework to retrieve data from a file in the specified format.|  
|[COleControl::OnRenderGlobalData](#colecontrol__onrenderglobaldata)|Called by the framework to retrieve data from global memory in the specified format.|  
|[COleControl::OnResetState](#colecontrol__onresetstate)|Resets a control's properties to the default values.|  
|[COleControl::OnSetClientSite](#colecontrol__onsetclientsite)|Notifies the control that <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> has been called.|  
|[COleControl::OnSetData](#colecontrol__onsetdata)|Replaces the control's data with another value.|  
|[COleControl::OnSetExtent](#colecontrol__onsetextent)|Called after the control's extent has changed.|  
|[COleControl::OnSetObjectRects](#colecontrol__onsetobjectrects)|Called after the control's dimensions have been changed.|  
|[COleControl::OnShowToolBars](#colecontrol__onshowtoolbars)|Called when the control has been UI activated.|  
|[COleControl::OnTextChanged](#colecontrol__ontextchanged)|Called when the stock Text or Caption property is changed.|  
|[COleControl::OnWindowlessMessage](#colecontrol__onwindowlessmessage)|Processes window messages (other than mouse and keyboard messages) for windowless controls.|  
|[COleControl::ParentToClient](#colecontrol__parenttoclient)|Translates a point relative to the container's origin to a point relative to the control's origin.|  
|[COleControl::PostModalDialog](#colecontrol__postmodaldialog)|Notifies the container that a modal dialog box has been closed.|  
|[COleControl::PreModalDialog](#colecontrol__premodaldialog)|Notifies the container that a modal dialog box is about to be displayed.|  
|[COleControl::RecreateControlWindow](#colecontrol__recreatecontrolwindow)|Destroys and re-creates the control's window.|  
|[COleControl::Refresh](#colecontrol__refresh)|Forces a repaint of a control's appearance.|  
|[COleControl::ReleaseCapture](#colecontrol__releasecapture)|Releases mouse capture.|  
|[COleControl::ReleaseDC](#colecontrol__releasedc)|Releases the display device context of a container of a windowless control.|  
|[COleControl::ReparentControlWindow](#colecontrol__reparentcontrolwindow)|Resets the parent of the control window.|  
|[COleControl::ResetStockProps](#colecontrol__resetstockprops)|Initializes <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> stock properties to their default values.|  
|[COleControl::ResetVersion](#colecontrol__resetversion)|Initializes the version number to a given value.|  
|[COleControl::ScrollWindow](#colecontrol__scrollwindow)|Allows a windowless control to scroll an area within its in-place active image on the display.|  
|[COleControl::SelectFontObject](#colecontrol__selectfontobject)|Selects a custom Font property into a device context.|  
|[COleControl::SelectStockFont](#colecontrol__selectstockfont)|Selects the stock Font property into a device context.|  
|[COleControl::SerializeExtent](#colecontrol__serializeextent)|Serializes or initializes the display space for the control.|  
|[COleControl::SerializeStockProps](#colecontrol__serializestockprops)|Serializes or initializes the <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> stock properties.|  
|[COleControl::SerializeVersion](#colecontrol__serializeversion)|Serializes or initializes the control's version information.|  
|[COleControl::SetAppearance](#colecontrol__setappearance)|Sets the value of the stock Appearance property.|  
|[COleControl::SetBackColor](#colecontrol__setbackcolor)|Sets the value of the stock BackColor property.|  
|[COleControl::SetBorderStyle](#colecontrol__setborderstyle)|Sets the value of the stock BorderStyle property.|  
|[COleControl::SetCapture](#colecontrol__setcapture)|Causes the control's container window to take possession of the mouse capture on the control's behalf.|  
|[COleControl::SetControlSize](#colecontrol__setcontrolsize)|Sets the position and size of the OLE control.|  
|[COleControl::SetEnabled](#colecontrol__setenabled)|Sets the value of the stock Enabled property.|  
|[COleControl::SetFocus](#colecontrol__setfocus)|Causes the control's container window to take possession of the input focus on the control's behalf.|  
|[COleControl::SetFont](#colecontrol__setfont)|Sets the value of the stock Font property.|  
|[COleControl::SetForeColor](#colecontrol__setforecolor)|Sets the value of the stock ForeColor property.|  
|[COleControl::SetInitialSize](#colecontrol__setinitialsize)|Sets the size of an OLE control when first displayed in a container.|  
|[COleControl::SetModifiedFlag](#colecontrol__setmodifiedflag)|Changes the modified state of a control.|  
|[COleControl::SetNotPermitted](#colecontrol__setnotpermitted)|Indicates that an edit request has failed.|  
|[COleControl::SetNotSupported](#colecontrol__setnotsupported)|Prevents modification to a control's property value by the user.|  
|[COleControl::SetRectInContainer](#colecontrol__setrectincontainer)|Sets the control's rectangle relative to its container.|  
|[COleControl::SetText](#colecontrol__settext)|Sets the value of the stock Text or Caption property.|  
|[COleControl::ThrowError](#colecontrol__throwerror)|Signals that an error has occurred in an OLE control.|  
|[COleControl::TransformCoords](#colecontrol__transformcoords)|Transforms coordinate values between a container and the control.|  
|[COleControl::TranslateColor](#colecontrol__translatecolor)|Converts an **OLE_COLOR** value to a **COLORREF** value.|  
|[COleControl::WillAmbientsBeValidDuringLoad](#colecontrol__willambientsbevalidduringload)|Determines whether ambient properties will be available the next time the control is loaded.|  
|[COleControl::WindowProc](#colecontrol__windowproc)|Provides a Windows procedure for a <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> object.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleControl::DrawContent](#colecontrol__drawcontent)|Called by the framework when the control's appearance needs to be updated.|  
|[COleControl::DrawMetafile](#colecontrol__drawmetafile)|Called by the framework when the metafile device context is being used.|  
|[COleControl::IsInvokeAllowed](#colecontrol__isinvokeallowed)|Enables automation method invocation.|  
|[COleControl::SetInitialDataFormats](#colecontrol__setinitialdataformats)|Called by the framework to initialize the list of data formats supported by the control.|  
  
## Remarks  
 Derived from <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>, this class inherits all the functionality of a Windows window object plus additional functionality specific to OLE, such as event firing and the ability to support methods and properties.  
  
 OLE controls can be inserted into OLE container applications and communicate with the container by using a two-way system of event firing and exposing methods and properties to the container. Note that standard OLE containers only support the basic functionality of an OLE control. They are unable to support extended features of an OLE control. Event firing occurs when events are sent to the container as a result of certain actions taking place in the control. In turn, the container communicates with the control by using an exposed set of methods and properties analogous to the member functions and data members of a C++ class. This approach allows the developer to control the appearance of the control and notify the container when certain actions occur.  
  
## Windowless Controls  
 OLE controls can be used in-place active without a window. Windowless controls have significant advantages:  
  
-   Windowless controls can be transparent and non-rectangular  
  
-   Windowless controls reduce instance size and creation time of the object  
  
 Controls do not need a window. Services that a window offers can easily be provided via a single shared window (usually the container's) and a bit of dispatching code. Having a window is mostly an unnecessary complication on the object.  
  
 When windowless activation is used, the container (which does have a window) is responsible for providing services that would otherwise have been provided by the control's own window. For example, if your control needs to query the keyboard focus, query the mouse capture, or obtain a device context, these operations are managed by the container. The <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>[windowless-operation member functions](assetId:///e9e28f79-9a70-4ae4-a5aa-b3e92f1904df) invoke these operations on the container.  
  
 When windowless activation is enabled, the container delegates input messages to the control's <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> interface (an extension of                 [IOleInPlaceObject](http://msdn.microsoft.com/library/windows/desktop/ms692646) for windowless support). <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>'s implementation of this interface will dispatch these messages through your control's message map, after adjusting the mouse coordinates appropriately. You can process these messages like ordinary window messages, by adding the corresponding entries to the message map.  
  
 In a windowless control, you should always use the <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> member functions instead of the corresponding <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> member functions or their related Windows API functions.  
  
 OLE control objects can also create a window only when they become active, but the amount of work needed for the inactive-active transition goes up and the speed of the transition goes down. There are cases when this is a problem: as an example, consider a grid of text boxes. When cursoring up and down through the column, each control must be in-place activated and then deactivated. The speed of the inactive/active transition will directly affect the scrolling speed.  
  
 For more information on developing an OLE control framework, see the articles [MFC ActiveX Controls](../vs140/mfc-activex-controls.md) and [Overview: Creating an MFC ActiveX Control Program](../vs140/mfc-activex-control-wizard.md). For information on optimizing OLE controls, including windowless and flicker-free controls, see [MFC ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxctl.h  
  
##  \<a name="colecontrol__ambientbackcolor">\</a>  COleControl::AmbientBackColor  
 Returns the value of the ambient BackColor property.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The current value of the container's ambient BackColor property, if any. If the property is not supported, this function returns the system-defined Windows background color.  
  
### Remarks  
 The ambient BackColor property is available to all controls and is defined by the container. Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientdisplayname">\</a>  COleControl::AmbientDisplayName  
 The name the container has assigned to the control can be used in error messages displayed to the user.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The name of the OLE control. The default is a zero-length string.  
  
### Remarks  
 Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientfont">\</a>  COleControl::AmbientFont  
 Returns the value of the ambient Font property.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the container's ambient Font dispatch interface. The default value is **NULL**. If the return is not equal to **NULL**, you are responsible for releasing the font by calling its                         [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) member function.  
  
### Remarks  
 The ambient Font property is defined by the container and available to all controls.Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientforecolor">\</a>  COleControl::AmbientForeColor  
 Returns the value of the ambient ForeColor property.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The current value of the container's ambient ForeColor property, if any. If not supported, this function returns the system-defined Windows text color.  
  
### Remarks  
 The ambient ForeColor property is available to all controls and is defined by the container. Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientlocaleid">\</a>  COleControl::AmbientLocaleID  
 Returns the container's locale ID.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The value of the container's LocaleID property, if any. If this property is not supported, this function returns 0.  
  
### Remarks  
 The control can use the LocaleID to adapt its user interface for specific locales. Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientappearance">\</a>  COleControl::AmbientAppearance  
 Retrieves the current appearance setting for the control object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The appearance of the control:  
  
-   **0** Flat appearance  
  
-   **1** 3D appearance  
  
### Remarks  
 Call this function to retrieve the current value of the **DISPID_AMBIENT_APPEARANCE** property for the control.  
  
##  \<a name="colecontrol__ambientscaleunits">\</a>  COleControl::AmbientScaleUnits  
 Returns the type of units used by the container.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A string containing the ambient ScaleUnits of the container. If this property is not supported, this function returns a zero-length string.  
  
### Remarks  
 The container's ambient ScaleUnits property can be used to display positions or dimensions, labeled with the chosen unit, such as twips or centimeters. Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientshowgrabhandles">\</a>  COleControl::AmbientShowGrabHandles  
 Determines whether the container allows the control to display grab handles for itself when active.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if grab handles should be displayed; otherwise 0. If this property is not supported, this function returns nonzero.  
  
### Remarks  
 Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientshowhatching">\</a>  COleControl::AmbientShowHatching  
 Determines whether the container allows the control to display itself with a hatched pattern when UI active.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the hatched pattern should be shown; otherwise 0. If this property is not supported, this function returns nonzero.  
  
### Remarks  
 Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambienttextalign">\</a>  COleControl::AmbientTextAlign  
 Determines the ambient text alignment preferred by the control container.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The status of the container's ambient TextAlign property. If this property is not supported, this function returns 0.  
  
 The following is a list of valid return values:  
  
|Return value|Meaning|  
|------------------|-------------|  
|0|General alignment (numbers to the right, text to the left).|  
|1|Left justify|  
|2|Center|  
|3|Right justify|  
  
### Remarks  
 This property is available to all embedded controls and is defined by the container. Note that the container is not required to support this property.  
  
##  \<a name="colecontrol__ambientuidead">\</a>  COleControl::AmbientUIDead  
 Determines if the container wants the control to respond to user-interface actions.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the control should respond to user-interface actions; otherwise 0. If this property is not supported, this function returns 0.  
  
### Remarks  
 For example, a container might set this to **TRUE** in design mode.  
  
##  \<a name="colecontrol__ambientusermode">\</a>  COleControl::AmbientUserMode  
 Determines if the container is in design mode or user mode.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the container is in user mode; otherwise 0 (in design mode). If this property is not supported, this function returns TRUE.  
  
### Remarks  
 For example, a container might set this to **FALSE** in design mode.  
  
##  \<a name="colecontrol__boundpropertychanged">\</a>  COleControl::BoundPropertyChanged  
 Signals that the bound property value has changed.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The dispatch ID of a bound property of the control.  
  
### Remarks  
 This must be called every time the value of the property changes, even in cases where the change was not made through the property Set method. Be particularly aware of bound properties that are mapped to member variables. Any time such a member variable changes, <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> must be called.  
  
##  \<a name="colecontrol__boundpropertyrequestedit">\</a>  COleControl::BoundPropertyRequestEdit  
 Requests permission from the <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> interface to change a bound property value provided by the control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The dispatch ID of a bound property of the control.  
  
### Return Value  
 Nonzero if the change is permitted; otherwise 0. The default value is nonzero.  
  
### Remarks  
 If permission is denied, the control must not let the value of the property change. This can be done by ignoring or failing the action that attempted to change the property value.  
  
##  \<a name="colecontrol__clienttoparent">\</a>  COleControl::ClientToParent  
 Translates the coordinates of <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> into parent coordinates.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 Pointer to the bounds of the OLE control within the container. Not the client area but the area of the entire control including borders and scroll bars.  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 Pointer to the OLE client area point to be translated into the coordinates of the parent (container).  
  
### Remarks  
 On input <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> is relative to the origin of the client area of the OLE control (upper left corner of the client area of the control). On output <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> is relative to the origin of the parent (upper left corner of the container).  
  
##  \<a name="colecontrol__clipcaretrect">\</a>  COleControl::ClipCaretRect  
 Adjusts a caret rectangle if it is entirely or partially covered by overlapping, opaque objects.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 On input, a pointer to a [RECT](../vs140/rect-structure.md) structure that contains the caret area to be adjusted. On output, the adjusted caret area, or **NULL** if the caret rectangle is completely covered.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 A caret is a flashing line, block, or bitmap that typically indicates where text or graphics will be inserted.  
  
 A windowless object cannot safely show a caret without first checking whether the caret is partially or totally hidden by overlapping objects. In order to make that possible, an object can use <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> to get the caret adjusted (reduced) to ensure it fits in the clipping region.  
  
 Objects creating a caret should submit the caret rectangle to <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> and use the adjusted rectangle for the caret. If the caret is entirely hidden, this method will return **FALSE** and the caret should not be shown at all in this case.  
  
##  \<a name="colecontrol__colecontrol">\</a>  COleControl::COleControl  
 Constructs a <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 This function is normally not called directly. Instead the OLE control is usually created by its class factory.  
  
##  \<a name="colecontrol__controlinfochanged">\</a>  COleControl::ControlInfoChanged  
 Call this function when the set of mnemonics supported by the control has changed.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 Upon receiving this notification, the control's container obtains the new set of mnemonics by making a call to                         [IOleControl::GetControlInfo](http://msdn.microsoft.com/library/windows/desktop/ms693730). Note that the container is not required to respond to this notification.  
  
##  \<a name="colecontrol__displayerror">\</a>  COleControl::DisplayError  
 Called by the framework after the stock Error event has been handled (unless the event handler has suppressed the display of the error).  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *scode*  
 The status code value to be reported. For a complete list of possible codes, see the article [ActiveX Controls: Advanced Topics](../vs140/mfc-activex-controls--advanced-topics.md).  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 The description of the error being reported.  
  
 *lpszSource*  
 The name of the module generating the error (typically, the name of the OLE control module).  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 The name of the help file containing a description of the error.  
  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 The Help Context ID of the error being reported.  
  
### Remarks  
 The default behavior displays a message box containing the description of the error, contained in <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>.  
  
 Override this function to customize how errors are displayed.  
  
##  \<a name="colecontrol__doclick">\</a>  COleControl::DoClick  
 Simulates a mouse click action on the control.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 The overridable <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> member function will be called, and a stock Click event will be fired, if supported by the control.  
  
 This function is supported by the <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> base class as a stock method, called DoClick. For more information, see the article [ActiveX Controls: Methods](../vs140/mfc-activex-controls--methods.md).  
  
##  \<a name="colecontrol__dopropexchange">\</a>  COleControl::DoPropExchange  
 Called by the framework when loading or storing a control from a persistent storage representation, such as a stream or property set.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the property exchange, including its direction.  
  
### Remarks  
 This function normally makes calls to the **PX_** family of functions to load or store specific user-defined properties of an OLE control.  
  
 If Control Wizard has been used to create the OLE control project, the overridden version of this function will serialize the stock properties supported by <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> with a call to the base class function, <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>. As you add user-defined properties to your OLE control you will need to modify this function to serialize your new properties. For more information on serialization, see the article [ActiveX Controls: Serializing](../vs140/mfc-activex-controls--serializing.md).  
  
##  \<a name="colecontrol__dosuperclasspaint">\</a>  COleControl::DoSuperclassPaint  
 Redraws an OLE control that has been subclassed from a Windows control.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 A pointer to the device context of the control container.  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 The area in which the control is to be drawn.  
  
### Remarks  
 Call this function to properly handle the painting of a nonactive OLE control. This function should only be used if the OLE control subclasses a Windows control and should be called in the <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> function of your control.  
  
 For more information on this function and subclassing a Windows control, see the article [ActiveX Controls: Subclassing a Windows Control](../vs140/mfc-activex-controls--subclassing-a-windows-control.md).  
  
##  \<a name="colecontrol__drawcontent">\</a>  COleControl::DrawContent  
 Called by the framework when the control's appearance needs to be updated.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 Pointer to the device context.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 Rectangular area to be drawn in.  
  
### Remarks  
 This function directly calls the overridable <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> function.  
  
##  \<a name="colecontrol__drawmetafile">\</a>  COleControl::DrawMetafile  
 Called by the framework when the metafile device context is being used.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 Pointer to the metafile device context.  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 Rectangular area to be drawn in.  
  
##  \<a name="colecontrol__enablesimpleframe">\</a>  COleControl::EnableSimpleFrame  
 Enables the simple frame characteristic for an OLE control.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 This characteristic allows a control to support visual containment of other controls, but not true OLE containment. An example would be a group box with several controls inside. These controls are not OLE contained, but they are in the same group box.  
  
##  \<a name="colecontrol__exchangeextent">\</a>  COleControl::ExchangeExtent  
 Serializes or initializes the state of the control's extent (its dimensions in **HIMETRIC** units).  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 A pointer to a [CPropExchange](../vs140/cpropexchange-class.md) object. The framework supplies this object to establish the context of the property exchange, including its direction.  
  
### Return Value  
 Nonzero if the function succeeded; 0 otherwise.  
  
### Remarks  
 This function is normally called by the default implementation of <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__exchangestockprops">\</a>  COleControl::ExchangeStockProps  
 Serializes or initializes the state of the control's stock properties.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 A pointer to a [CPropExchange](../vs140/cpropexchange-class.md) object. The framework supplies this object to establish the context of the property exchange, including its direction.  
  
### Remarks  
 This function is normally called by the default implementation of <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__exchangeversion">\</a>  COleControl::ExchangeVersion  
 Serializes or initializes the state of a control's version information.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the property exchange, including its direction.  
  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 The current version number of the control.  
  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 Indicates whether persistent data should be converted to the latest format when saved, or maintained in the same format that was loaded.  
  
### Return Value  
 Nonzero of the function succeeded; 0 otherwise.  
  
### Remarks  
 Typically, this will be the first function called by a control's override of <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>. When loading, this function reads the version number of the persistent data, and sets the version attribute of the [CPropExchange](../vs140/cpropexchange-class.md) object accordingly. When saving, this function writes the version number of the persistent data.  
  
 For more information on persistence and versioning, see the article [ActiveX Controls: Serializing](../vs140/mfc-activex-controls--serializing.md).  
  
##  \<a name="colecontrol__fireclick">\</a>  COleControl::FireClick  
 Called by the framework when the mouse is clicked over an active control.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a Click event to occur, the control's Event map must have a stock Click event defined.  
  
##  \<a name="colecontrol__firedblclick">\</a>  COleControl::FireDblClick  
 Called by the framework when the mouse is double-clicked over an active control.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a DblClick event to occur, the control's Event map must have a stock DblClick event defined.  
  
##  \<a name="colecontrol__fireerror">\</a>  COleControl::FireError  
 Fires the stock Error event.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *scode*  
 The status code value to be reported. For a complete list of possible codes, see the article [ActiveX Controls: Advanced Topics](../vs140/mfc-activex-controls--advanced-topics.md).  
  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
 The description of the error being reported.  
  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 The Help ID of the error being reported.  
  
### Remarks  
 This event provides a way of signalling, at appropriate places in your code, that an error has occurred within your control. Unlike other stock events, such as Click or MouseMove, Error is never fired by the framework.  
  
 To report an error that occurs during a property get function, property set function, or automation method, call [COleControl::ThrowError](#colecontrol__throwerror).  
  
 The implementation of an OLE control's Stock Error event uses an <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> value. If your control uses this event, and is intended to be used in Visual Basic 4.0, you will receive errors because the <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> value is not supported in Visual Basic.  
  
 To fix this, manually change the <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> parameter in the control's .ODL file to a **long**. In addition, any custom event, method, or property that uses an <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> parameter also causes the same problem.  
  
##  \<a name="colecontrol__fireevent">\</a>  COleControl::FireEvent  
 Fires a user-defined event from your control with any number of optional arguments,.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 The dispatch ID of the event to be fired.  
  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 A descriptor for the event's parameter types.  
  
### Remarks  
 Usually this function should not be called directly. Instead you will call the event-firing functions in the event map section of your control's class declaration.  
  
 The <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> argument is a space-separated list of **VTS_**. One or more of these values, separated by spaces (not commas), specifies the function's parameter list. Possible values are as follows:  
  
|Symbol|Parameter type|  
|------------|--------------------|  
|**VTS_COLOR**|**OLE_COLOR**|  
|**VTS_FONT**|**IFontDisp\***|  
|**VTS_HANDLE**|<CodeContentPlaceHolder>244\</CodeContentPlaceHolder>|  
|**VTS_PICTURE**|**IPictureDisp\***|  
|**VTS_OPTEXCLUSIVE**|**OLE_OPTEXCLUSIVE\***|  
|**VTS_TRISTATE**|**OLE_TRISTATE**|  
|**VTS_XPOS_HIMETRIC**|**OLE_XPOS_HIMETRIC**|  
|**VTS_YPOS_HIMETRIC**|**OLE_YPOS_HIMETRIC**|  
|**VTS_XPOS_PIXELS**|**OLE_XPOS_PIXELS**|  
|**VTS_YPOS_PIXELS**|**OLE_YPOS_PIXELS**|  
|**VTS_XSIZE_PIXELS**|**OLE_XSIZE_PIXELS**|  
|**VTS_YSIZE_PIXELS**|**OLE_XSIZE_PIXELS**|  
|**VTS_XSIZE_HIMETRIC**|**OLE_XSIZE_HIMETRIC**|  
|**VTS_YSIZE_HIMETRIC**|**OLE_XSIZE_HIMETRIC**|  
  
> [!NOTE]
>  Additional variant constants have been defined for all variant types, with the exception of **VTS_FONT** and **VTS_PICTURE**, that provide a pointer to the variant data constant. These constants are named using the **VTS_P**<CodeContentPlaceHolder>245\</CodeContentPlaceHolder> convention. For example, **VTS_PCOLOR** is a pointer to a **VTS_COLOR** constant.  
  
##  \<a name="colecontrol__firekeydown">\</a>  COleControl::FireKeyDown  
 Called by the framework when a key is pressed while the control is UI active.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 Pointer to the virtual key code value of the pressed key. For a list of of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a KeyDown event to occur, the control's Event map must have a stock KeyDown event defined.  
  
##  \<a name="colecontrol__firekeypress">\</a>  COleControl::FireKeyPress  
 Called by the framework when a key is pressed and released while the custom control is UI Active within the container.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 A pointer to the character value of the key pressed.  
  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 The recipient of the event may modify <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>, for example, convert all lowercase characters to uppercase. If you want to examine the modified character, override <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
 For automatic firing of a KeyPress event to occur, the control's Event map must have a stock KeyPress event defined.  
  
##  \<a name="colecontrol__firekeyup">\</a>  COleControl::FireKeyUp  
 Called by the framework when a key is released while the custom control is UI Active within the container.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 Pointer to the virtual key code value of the released key. For a list of of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a KeyUp event to occur, the control's Event map must have a stock KeyUp event defined.  
  
##  \<a name="colecontrol__firemousedown">\</a>  COleControl::FireMouseDown  
 Called by the framework when a mouse button is pressed over an active custom control.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 The numeric value of the mouse button pressed. It can contain one of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was pressed down.  
  
-   **MIDDLE_BUTTON** The middle mouse button was pressed down.  
  
-   **RIGHT_BUTTON** The right mouse button was pressed down.  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
 *x*  
 The x-coordinate of the cursor when a mouse button was pressed down. The coordinate is relative to the upper-left corner of the control window.  
  
 *y*  
 The y-coordinate of the cursor when a mouse button was pressed down. The coordinate is relative to the upper-left corner of the control window.  
  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a MouseDown event to occur, the control's Event map must have a stock MouseDown event defined.  
  
##  \<a name="colecontrol__firemousemove">\</a>  COleControl::FireMouseMove  
 Called by the framework when the cursor is moved over an active custom control.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 The numeric value of the mouse buttons pressed. Contains a combination of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was pressed down during the action.  
  
-   **MIDDLE_BUTTON** The middle mouse button was pressed down during the action.  
  
-   **RIGHT_BUTTON** The right mouse button was pressed down during the action.  
  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
 *x*  
 The x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the control window.  
  
 *y*  
 The y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the control window.  
  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a MouseMove event to occur, the control's Event map must have a stock MouseMove event defined.  
  
##  \<a name="colecontrol__firemouseup">\</a>  COleControl::FireMouseUp  
 Called by the framework when a mouse button is released over an active custom control.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 The numeric value of the mouse button released. It can have one of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was released.  
  
-   **MIDDLE_BUTTON** The middle mouse button was released.  
  
-   **RIGHT_BUTTON** The right mouse button was released.  
  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
 *x*  
 The x-coordinate of the cursor when a mouse button was released. The coordinate is relative to the upper-left corner of the control window.  
  
 *y*  
 The y-coordinate of a cursor when a mouse button was released. The coordinate is relative to the upper-left corner of the control window.  
  
### Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a MouseUp event to occur, the control's Event map must have a stock MouseUp event defined.  
  
##  \<a name="colecontrol__firereadystatechange">\</a>  COleControl::FireReadyStateChange  
 Fires an event with the current value of the ready state of control.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 The ready state can be one of the following values:  
  
 **READYSTATE_UNINITIALIZED**  
 Default initialization state  
  
 **READYSTATE_LOADING**  
 Control is currently loading its properties  
  
 **READYSTATE_LOADED**  
 Control has been initialized  
  
 **READYSTATE_INTERACTIVE**  
 Control has enough data to be interactive but not all asynchronous data is yet loaded  
  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 Control has all its data  
  
 Use [GetReadyState](#colecontrol__getreadystate) to determine the control's current readiness.  
  
 [InternalSetReadyState](#colecontrol__internalsetreadystate) changes the ready state to the value supplied, then calls <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__getactivationpolicy">\</a>  COleControl::GetActivationPolicy  
 Alters the default activation behavior of a control that supports the <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 A combination of flags from the **POINTERINACTIVE** enumeration. Possible flags are:  
  
 **POINTERINACTIVE_ACTIVATEONENTRY**  
 The object should be in-place activated when the mouse enters it during a mouse move operation.  
  
 **POINTERINACTIVE_DEACTIVATEONLEAVE**  
 The object should be deactivated when the mouse leaves the object during a mouse move operation.  
  
 **POINTERINACTIVE_ACTIVATEONDRAG**  
 The object should be in-place activated when the mouse is dragged over it during a drag and drop operation.  
  
### Remarks  
 When the <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> interface is enabled, the container will delegate <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> messages to it. <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>'s implementation of this interface will dispatch these messages through your control's message map, after adjusting the mouse coordinates appropriately.  
  
 Whenever the container receives a <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> message with the mouse pointer over an inactive object supporting <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>, it should call <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> on the interface and return flags from the **POINTERINACTIVE** enumeration.  
  
 You can process these messages just like ordinary window messages, by adding the corresponding entries to the message map. In your handlers, avoid using the <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> member variable (or any member functions that uses it) without first checking that its value is non- **NULL**.  
  
 Any object intended to do more than set the mouse cursor and/or fire a mouse move event, such as give special visual feedback, should return the **POINTERINACTIVE_ACTIVATEONENTRY** flag and draw the feedback only when active. If the object returns this flag, the container should activate it in-place immediately and then forward it the same message that triggered the call to <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>.  
  
 If both the **POINTERINACTIVE_ACTIVATEONENTRY** and **POINTERINACTIVE_DEACTIVATEONLEAVE** flags are returned, then the object will only be activated when the mouse is over the object. If only the **POINTERINACTIVE_ACTIVATEONENTRY** flag is returned, then the object will only be activated once when the mouse first enters the object.  
  
 You may also want an inactive control to be the target of an OLE drag and drop operation. This requires activating the control at the moment the user drags an object over it, so that the control's window can be registered as a drop target. To cause activation to occur during a drag, return the **POINTERINACTIVE_ACTIVATEONDRAG** flag:  
  
 [!code[NVC_MFCAxCtl#1](../vs140/codesnippet/CPP/colecontrol-class_1.cpp)]  
  
 The information communicated by <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> should not be cached by a container. Instead, this method should be called every time the mouse enters an inactive object.  
  
 If an inactive object does not request to be in-place activated when the mouse enters it, its container should dispatch subsequent <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> messages to this object by calling [OnInactiveSetCursor](#colecontrol__oninactivesetcursor) as long as the mouse pointer stays over the object.  
  
 Enabling the <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> interface typically means that you want the control to be capable of processing mouse messages at all times. To get this behaviour in a container that doesn't support the <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> interface, you will need to have your control always activated when visible, which means the control should have the **OLEMISC_ACTIVATEWHENVISIBLE** flag among its miscellaneous flags. However, to prevent this flag from taking effect in a container that does support <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>, you can also specify the **OLEMISC_IGNOREACTIVATEWHENVISIBLE** flag:  
  
 [!code[NVC_MFCAxCtl#10](../vs140/codesnippet/CPP/colecontrol-class_2.cpp)]  
  
##  \<a name="colecontrol__getambientproperty">\</a>  COleControl::GetAmbientProperty  
 Gets the value of an ambient property of the container.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 *dwDispid*  
 The dispatch ID of the desired ambient property.  
  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 A variant type tag that specifies the type of the value to be returned in <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 A pointer to the address of the variable that will receive the property value or return value. The actual type of this pointer must match the type specified by <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>.  
  
|vtProp|Type of pvProp|  
|------------|--------------------|  
|<CodeContentPlaceHolder>281\</CodeContentPlaceHolder>|**BOOL\***|  
|<CodeContentPlaceHolder>282\</CodeContentPlaceHolder>|**CString\***|  
|<CodeContentPlaceHolder>283\</CodeContentPlaceHolder>|**short\***|  
|<CodeContentPlaceHolder>284\</CodeContentPlaceHolder>|**long\***|  
|<CodeContentPlaceHolder>285\</CodeContentPlaceHolder>|**float\***|  
|<CodeContentPlaceHolder>286\</CodeContentPlaceHolder>|**double\***|  
|<CodeContentPlaceHolder>287\</CodeContentPlaceHolder>|**CY\***|  
|**VT_COLOR**|**OLE_COLOR\***|  
|**VT_DISPATCH**|**LPDISPATCH\***|  
|**VT_FONT**|**LPFONTDISP\***|  
  
### Return Value  
 Nonzero if the ambient property is supported; otherwise 0.  
  
### Remarks  
 If you use <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> to retrieve the ambient DisplayName and ScaleUnits properties, set <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> to **CString\***. If you are retrieving the ambient Font property, set <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> to **VT_FONT** and <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> to **LPFONTDISP\***.  
  
 Note that functions have already been provided for common ambient properties, such as [AmbientBackColor](#colecontrol__ambientbackcolor) and [AmbientFont](#colecontrol__ambientfont).  
  
##  \<a name="colecontrol__getappearance">\</a>  COleControl::GetAppearance  
 Implements the Get function of your control's stock Appearance property.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 The return value specifies the current appearance setting as a **short** ( <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>) value, if successful. This value is zero if the control's appearance is flat and 1 if the control's appearance is 3D.  
  
##  \<a name="colecontrol__getbackcolor">\</a>  COleControl::GetBackColor  
 Implements the Get function of your control's stock BackColor property.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 The return value specifies the current background color as a **OLE_COLOR** value, if successful. This value can be translated to a **COLORREF** value with a call to <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__getborderstyle">\</a>  COleControl::GetBorderStyle  
 Implements the Get function of your control's stock BorderStyle property.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 1 if the control has a normal border; 0 if the control has no border.  
  
##  \<a name="colecontrol__getcapture">\</a>  COleControl::GetCapture  
 Determines whether the <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> object has the mouse capture.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 If the control is activated and windowless, returns **this** if the control currently has the mouse capture (as determined by the control's container), or **NULL** if it does not have the capture.  
  
 Otherwise, returns the <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> object that has the mouse capture (same as <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>).  
  
### Remarks  
 An activated windowless control receives the mouse capture when [SetCapture](#colecontrol__setcapture) is called.  
  
##  \<a name="colecontrol__getclassid">\</a>  COleControl::GetClassID  
 Called by the framework to retrieve the OLE class ID of the control.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 *pclsid*  
 Pointer to the location of the class ID.  
  
### Return Value  
 Nonzero if the call was not successful; otherwise 0.  
  
### Remarks  
 Usually implemented by the [IMPLEMENT_OLECREATE_EX](../vs140/implement_olecreate_ex.md) macro.  
  
##  \<a name="colecontrol__getclientoffset">\</a>  COleControl::GetClientOffset  
 Retrieves the difference between the upper left corner of the control's rectangular area and the upper left corner of its client area.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 *pdxOffset*  
 Pointer to the horizontal offset of the OLE control's client area.  
  
 *pdyOffset*  
 Pointer to the vertical offset of the OLE control's client area.  
  
### Remarks  
 The OLE control has a rectangular area within its container. The client area of the control is the control area excluding borders and scroll bars. The offset retrieved by <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> is the difference between the upper left corner of the control's rectangular area and the upper left corner of its client area. If your control has non-client elements other than the standard borders and scrollbars, override this member function to specify the offset.  
  
##  \<a name="colecontrol__getclientrect">\</a>  COleControl::GetClientRect  
 Retrieves the size of the control's client area.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> structure containing the dimensions of the windowless control's client area; that is, the control's size minus window borders, frames, scroll bars, and so on. The <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> parameter indicates the size of the control's client rectangle, not its position.  
  
##  \<a name="colecontrol__getclientsite">\</a>  COleControl::GetClientSite  
 Queries an object for the pointer to its current client site within its container.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the control's current client site in its container.  
  
### Remarks  
 The returned pointer points to an instance of <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> interface, implemented by containers, is the object's view of its context: where it is anchored in the document, where it gets its storage, user interface, and other resources.  
  
##  \<a name="colecontrol__getcontrolflags">\</a>  COleControl::GetControlFlags  
 Retrieves the control flag settings.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Return Value  
 An ORed combination of the flags in the ControlFlags enumeration:  
  
 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
  
### Remarks  
 By default, <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 If set, uses a begin-paint function tailored for OLE controls instead of the                                 [BeginPaint](http://msdn.microsoft.com/library/windows/desktop/dd183362) API (set by default).  
  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 If not set, disables the call to <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> made by <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> and gains a small speed advantage. If you are using windowless activation, the flag has no effect.  
  
 <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 If set, provides mouse interaction while your control is inactive by enabling <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>'s implementation of the <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> interface, which is disabled by default.  
  
 <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
 If set, eliminates extra drawing operations and the accompanying visual flicker. Use when your control draws itself identically in the inactive and active states. If you are using windowless activation, the flag has no effect.  
  
 <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
 If set, indicates your control uses windowless activation.  
  
 <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
 If set, indicates that the control will perform optimized drawing, if the container supports it.  
  
 For more information about <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> and other optimizations of OLE controls, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
##  \<a name="colecontrol__getcontrolsize">\</a>  COleControl::GetControlSize  
 Retrieves the size of the OLE control window.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 *pcx*  
 Specifies the width of the control in pixels.  
  
 *pcy*  
 Specifies the height of the control in pixels.  
  
### Remarks  
 Note that all coordinates for control windows are relative to the upper-left corner of the control.  
  
##  \<a name="colecontrol__getdc">\</a>  COleControl::GetDC  
 Provides for a windowless object to get a screen (or compatible) device context from its container.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 *lprcRect*  
 A pointer to the rectangle the windowless control wants to redraw, in client coordinates of the control. **NULL** means the full object's extent.  
  
 <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 Drawing attributes of the device context. Choices are:  
  
-   **OLEDC_NODRAW** Indicates that the object won't use the device context to perform any drawing but merely to get information about the display device. The container should simply pass the window's DC without further processing.  
  
-   **OLEDC_PAINTBKGND** Requests that the container paint the background before returning the DC. An object should use this flag if it is requesting a DC for redrawing an area with transparent background.  
  
-   **OLEDC_OFFSCREEN** Informs the container that the object wishes to render into an off-screen bitmap that should then be copied to the screen. An object should use this flag when the drawing operation it is about to perform generates a lot of flicker. The container is free to honor this request or not. However, if this flag is not set, the container must hand back an on-screen DC. This allows objects to perform direct screen operations such as showing a selection (via an **XOR** operation).  
  
### Return Value  
 Pointer to the display device context for the container <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> client area if successful; otherwise, the return value is **NULL**. The display device context can be used in subsequent GDI functions to draw in the client area of the container's window.  
  
### Remarks  
 The [ReleaseDC](#colecontrol__releasedc) member function must be called to release the context after painting. When calling <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>, objects pass the rectangle they wish to draw into in their own client coordinates. <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> translates these to coordinates of the container client area. The object should not request a desired drawing rectangle larger than its own client area rectangle, the size of which can be retrieved with [GetClientRect](#colecontrol__getclientrect). This prevents objects from inadvertently drawing where they are not supposed to.  
  
##  \<a name="colecontrol__getenabled">\</a>  COleControl::GetEnabled  
 Implements the Get function of your control's stock Enabled property.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the control is enabled; otherwise 0.  
  
##  \<a name="colecontrol__getextendedcontrol">\</a>  COleControl::GetExtendedControl  
 Obtains a pointer to an object maintained by the container that represents the control with an extended set of properties.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the container's extended control object. If there is no object available, the value is **NULL**.  
  
 This object may be manipulated through its <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> interface. You can also use <CodeContentPlaceHolder>331\</CodeContentPlaceHolder> to obtain other available interfaces provided by the object. However, the object is not required to support a specific set of interfaces. Note that relying on the specific features of a container's extended control object limits the portability of your control to other arbitrary containers.  
  
### Remarks  
 The function that calls this function is responsible for releasing the pointer when finished with the object. Note that the container is not required to support this object.  
  
##  \<a name="colecontrol__getfocus">\</a>  COleControl::GetFocus  
 Determines whether the <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> object has the focus.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 If the control is activated and windowless, returns **this** if the control currently has the keyboard focus (as determined by the control's container), or **NULL** if it does not have the focus.  
  
 Otherwise, returns the <CodeContentPlaceHolder>333\</CodeContentPlaceHolder> object that has the focus (same as <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>).  
  
### Remarks  
 An activated windowless control receives the focus when [SetFocus](#colecontrol__setfocus) is called.  
  
##  \<a name="colecontrol__getfont">\</a>  COleControl::GetFont  
 Implements the Get function of the stock Font property.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the font dispatch interface of the control's stock Font property.  
  
### Remarks  
 Note that the caller must release the object when finished. Within the implementation of the control, use <CodeContentPlaceHolder>335\</CodeContentPlaceHolder> to access the control's stock Font object. For more information on using fonts in your control, see the article [ActiveX Controls: Using Fonts in an ActiveX Control](../vs140/mfc-activex-controls--using-fonts.md).  
  
##  \<a name="colecontrol__getfonttextmetrics">\</a>  COleControl::GetFontTextMetrics  
 Measures the text metrics for any <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> object owned by the control.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 Pointer to a                                 [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure.  
  
 <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>  
 Reference to a [CFontHolder](../vs140/cfontholder-class.md) object.  
  
### Remarks  
 Such a font can be selected with the [COleControl::SelectFontObject](#colecontrol__selectfontobject) function. <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> will initialize the <CodeContentPlaceHolder>340\</CodeContentPlaceHolder> structure pointed to by <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> with valid metrics information about <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>'s font if successful, or fill the structure with zeros if not successful. You should use this function instead of                         [GetTextMetrics](http://msdn.microsoft.com/library/windows/desktop/dd144941) when painting your control because controls, like any embedded OLE object, may be required to render themselves into a metafile.  
  
 The <CodeContentPlaceHolder>343\</CodeContentPlaceHolder> structure for the default font is refreshed when the [SelectFontObject](#colecontrol__selectfontobject) function is called. You should call <CodeContentPlaceHolder>344\</CodeContentPlaceHolder> only after selecting the stock Font property to assure the information it provides is valid.  
  
##  \<a name="colecontrol__getforecolor">\</a>  COleControl::GetForeColor  
 Implements the Get function of the stock ForeColor property.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Return Value  
 The return value specifies the current foreground color as a **OLE_COLOR** value, if successful. This value can be translated to a                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value with a call to <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__gethwnd">\</a>  COleControl::GetHwnd  
 Implements the Get function of the stock hWnd property.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 The OLE control's window handle, if any; otherwise **NULL**.  
  
##  \<a name="colecontrol__getmessagestring">\</a>  COleControl::GetMessageString  
 Called by the framework to obtain a short string that describes the purpose of the menu item identified by <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>  
 A menu item ID.  
  
 <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object through which a string will be returned.  
  
### Remarks  
 This can be used to obtain a message for display in a status bar while the menu item is highlighted. The default implementation attempts to load a string resource identified by <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__getnotsupported">\</a>  COleControl::GetNotSupported  
 Prevents access to a control's property value by the user.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Remarks  
 Call this function in place of the Get function of any property where retrieval of the property by the control's user is not supported. One example would be a property that is write only.  
  
##  \<a name="colecontrol__getreadystate">\</a>  COleControl::GetReadyState  
 Returns the readiness state of the control.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Return Value  
 The readiness state of the control, one of the following values:  
  
 **READYSTATE_UNINITIALIZED**  
 Default initialization state  
  
 **READYSTATE_LOADING**  
 Control is currently loading its properties  
  
 **READYSTATE_LOADED**  
 Control has been initialized  
  
 **READYSTATE_INTERACTIVE**  
 Control has enough data to be interactive but not all asynchronous data is yet loaded  
  
 <CodeContentPlaceHolder>350\</CodeContentPlaceHolder>  
 Control has all its data  
  
### Remarks  
 Most simple controls never need to differentiate between **LOADED** and <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>. However, controls that support data path properties may not be ready to be interactive until at least some data is received asynchronously. A control should attempt to become interactive as soon as possible.  
  
##  \<a name="colecontrol__getrectincontainer">\</a>  COleControl::GetRectInContainer  
 Obtains the coordinates of the control's rectangle relative to the container, expressed in device units.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>  
 A pointer to the rectangle structure into which the control's coordinates will be copied.  
  
### Return Value  
 Nonzero if the control is in-place active; otherwise 0.  
  
### Remarks  
 The rectangle is only valid if the control is in-place active.  
  
##  \<a name="colecontrol__getstocktextmetrics">\</a>  COleControl::GetStockTextMetrics  
 Measures the text metrics for the control's stock Font property, which can be selected with the [SelectStockFont](#colecontrol__selectstockfont) function.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>353\</CodeContentPlaceHolder>  
 A pointer to a                                 [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure.  
  
### Remarks  
 The <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> function will initialize the <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> structure pointed to by <CodeContentPlaceHolder>356\</CodeContentPlaceHolder> with valid metrics information if successful, or fill the structure with zeros if not successful. Use this function instead of                         [GetTextMetrics](http://msdn.microsoft.com/library/windows/desktop/dd144941) when painting your control because controls, like any embedded OLE object, may be required to render themselves into a metafile.  
  
 The <CodeContentPlaceHolder>357\</CodeContentPlaceHolder> structure for the default font is refreshed when the <CodeContentPlaceHolder>358\</CodeContentPlaceHolder> function is called. You should call this function only after selecting the stock font to assure the information it provides is valid.  
  
##  \<a name="colecontrol__gettext">\</a>  COleControl::GetText  
 Implements the Get function of the stock Text or Caption property.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 The current value of the control text string or a zero-length string if no string is present.  
  
> [!NOTE]
>  For more information on the <CodeContentPlaceHolder>359\</CodeContentPlaceHolder> data type, see [Data Types](../vs140/data-types--mfc-.md) in the Macros and Globals section.  
  
### Remarks  
 Note that the caller of this function must call <CodeContentPlaceHolder>360\</CodeContentPlaceHolder> on the string returned in order to free the resource. Within the implementation of the control, use <CodeContentPlaceHolder>361\</CodeContentPlaceHolder> to access the control's stock Text or Caption property.  
  
##  \<a name="colecontrol__getwindowlessdroptarget">\</a>  COleControl::GetWindowlessDropTarget  
 Override <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> when you want a windowless control to be the target of an OLE drag and drop operation.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to the object's <CodeContentPlaceHolder>363\</CodeContentPlaceHolder> interface. Since it does not have a window, a windowless object cannot register an <CodeContentPlaceHolder>364\</CodeContentPlaceHolder> interface. However, to participate in drag and drop, a windowless object can still implement the interface and return it in <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>.  
  
### Remarks  
 Normally, this would require that the control's window be registered as a drop target. But since the control has no window of its own, the container will use its own window as a drop target. The control simply needs to provide an implementation of the <CodeContentPlaceHolder>366\</CodeContentPlaceHolder> interface to which the container can delegate calls at the appropriate time. For example:  
  
 [!code[NVC_MFCAxCtl#2](../vs140/codesnippet/CPP/colecontrol-class_3.cpp)]  
  
##  \<a name="colecontrol__initializeiids">\</a>  COleControl::InitializeIIDs  
 Informs the base class of the IIDs the control will use.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 *piidPrimary*  
 Pointer to the interface ID of the control's primary dispatch interface.  
  
 *piidEvents*  
 Pointer to the interface ID of the control's event interface.  
  
### Remarks  
 Call this function in the control's constructor to inform the base class of the interface IDs your control will be using.  
  
##  \<a name="colecontrol__internalgetfont">\</a>  COleControl::InternalGetFont  
 Accesses the stock Font property of your control  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a [CFontHolder](../vs140/cfontholder-class.md) object that contains the stock Font object.  
  
##  \<a name="colecontrol__internalgettext">\</a>  COleControl::InternalGetText  
 Accesses the stock Text or Caption property of your control.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the control text string.  
  
##  \<a name="colecontrol__internalsetreadystate">\</a>  COleControl::InternalSetReadyState  
 Sets the readiness state of the control.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 *lNewReadyState*  
 The readiness state to set for the control, one of the following values:  
  
 **READYSTATE_UNINITIALIZED**  
 Default initialization state  
  
 **READYSTATE_LOADING**  
 Control is currently loading its properties  
  
 **READYSTATE_LOADED**  
 Control has been initialized  
  
 **READYSTATE_INTERACTIVE**  
 Control has enough data to be interactive but not all asynchronous data is yet loaded  
  
 <CodeContentPlaceHolder>367\</CodeContentPlaceHolder>  
 Control has all its data  
  
### Remarks  
 Most simple controls never need to differentiate between **LOADED** and <CodeContentPlaceHolder>368\</CodeContentPlaceHolder>. However, controls that support data path properties may not be ready to be interactive until at least some data is received asynchronously. A control should attempt to become interactive as soon as possible.  
  
##  \<a name="colecontrol__invalidatecontrol">\</a>  COleControl::InvalidateControl  
 Forces the control to redraw itself.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 A pointer to the region of the control to be invalidated.  
  
 <CodeContentPlaceHolder>370\</CodeContentPlaceHolder>  
 Specifies whether the background within the update region is to be erased when the update region is processed.  
  
### Remarks  
 If <CodeContentPlaceHolder>371\</CodeContentPlaceHolder> has a **NULL** value, the entire control will be redrawn. If <CodeContentPlaceHolder>372\</CodeContentPlaceHolder> is not **NULL**, this indicates the portion of the control's rectangle that is to be invalidated. In cases where the control has no window, or is currently not active, the rectangle is ignored, and a call is made to the client site's                         [IAdviseSink::OnViewChange](http://msdn.microsoft.com/library/windows/desktop/ms694337) member function. Use this function instead of <CodeContentPlaceHolder>373\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__invalidatergn">\</a>  COleControl::InvalidateRgn  
 Invalidates the container window's client area within the given region.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>  
 A pointer to a [CRgn](../vs140/crgn-class.md) object that identifies the display region of the OLE object to invalidate, in client coordinates of the containing window. If this parameter is **NULL**, the extent is the entire object.  
  
 <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>  
 Specifies whether the background within the invalidated region is to be erased. If **TRUE**, the background is erased. If **FALSE**, the background remains unchanged.  
  
### Remarks  
 This can be used to redraw windowless controls within the container. The invalidated region, along with all other areas in the update region, is marked for painting when the next                         [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message is sent.  
  
 If <CodeContentPlaceHolder>377\</CodeContentPlaceHolder> is **TRUE** for any part of the update region, the background in the entire region, not just in the given part, is erased.  
  
##  \<a name="colecontrol__isconvertingvbx">\</a>  COleControl::IsConvertingVBX  
 Allows specialized loading of an OLE control.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the control is being converted; otherwise 0.  
  
### Remarks  
 When converting a form that uses VBX controls to one that uses OLE controls, special loading code for the OLE controls may be required. For example, if you are loading an instance of your OLE control, you might have a call to [PX_Font](../vs140/px_font.md) in your <CodeContentPlaceHolder>378\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFCAxCtl#3](../vs140/codesnippet/CPP/colecontrol-class_4.cpp)]  
  
 However, VBX controls did not have a Font object; each font property was saved individually. In this case, you would use <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> to distinguish between these two cases:  
  
 [!code[NVC_MFCAxCtl#4](../vs140/codesnippet/CPP/colecontrol-class_5.cpp)]  
  
 Another case would be if your VBX control saved proprietary binary data (in its **VBM_SAVEPROPERTY** message handler), and your OLE control saves its binary data in a different format. If you want your OLE control to be backward-compatible with the VBX control, you could read both the old and new formats using the <CodeContentPlaceHolder>380\</CodeContentPlaceHolder> function by distinguishing whether the VBX control or the OLE control was being loaded.  
  
 In your control's <CodeContentPlaceHolder>381\</CodeContentPlaceHolder> function, you can check for this condition and if true, execute load code specific to this conversion (such as the previous examples). If the control is not being converted, you can execute normal load code. This ability is only applicable to controls being converted from VBX counterparts.  
  
##  \<a name="colecontrol__isinvokeallowed">\</a>  COleControl::IsInvokeAllowed  
 Enables automation method invocation.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the control has been initialized; otherwise 0.  
  
### Remarks  
 The framework's implementation of **IDispatch::Invoke** calls **IsInvokeAllowed** to determine if a given function (identified by <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>) may be invoked. The default behavior for an OLE control is to allow automation methods to be invoked only if the control has been initialized; however, **IsInvokeAllowed** is a virtual function and may be overridden if necessary (for example, when the control is being used as an automation server). For more information, see Knowledge Base article Q166472, "HOWTO: Use an OLE Control as an Automation Server." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at                         [http://support.microsoft.com](http://support.microsoft.com/).  
  
##  \<a name="colecontrol__ismodified">\</a>  COleControl::IsModified  
 Determines if the control's state has been modified.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the control's state has been modified since it was last saved; otherwise 0.  
  
### Remarks  
 The state of a control is modified when a property changes value.  
  
##  \<a name="colecontrol__isoptimizeddraw">\</a>  COleControl::IsOptimizedDraw  
 Determines whether the container supports optimized drawing for the current drawing operation.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if the container supports optimized drawing for the current drawing operation; otherwise **FALSE**.  
  
### Remarks  
 If optimized drawing is supported, then the control need not select old objects (pens, brushes, fonts, etc.) into the device context when drawing is finished.  
  
##  \<a name="colecontrol__issubclassedcontrol">\</a>  COleControl::IsSubclassedControl  
 Called by the framework to determine if the control subclasses a Windows control.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the control is subclassed; otherwise 0.  
  
### Remarks  
 You must override this function and return **TRUE** if your OLE control subclasses a Windows control.  
  
##  \<a name="colecontrol__load">\</a>  COleControl::Load  
 Resets any previous data loaded asynchronously and initiates a new loading of the control's asynchronous property.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 *strNewPath*  
 A pointer to a string containing the path that references the absolute location of the asynchronous control property.  
  
 *prop*  
 A [CDataPathProperty](../vs140/cdatapathproperty-class.md) object implementing an asynchronous control property.  
  
##  \<a name="colecontrol__lockinplaceactive">\</a>  COleControl::LockInPlaceActive  
 Prevents the container from deactivating your control.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>383\</CodeContentPlaceHolder>  
 **TRUE** if the in-place active state of the control is to be locked; **FALSE** if it is to be unlocked.  
  
### Return Value  
 Nonzero if the lock was successful; otherwise 0.  
  
### Remarks  
 Note that every locking of the control must be paired with an unlocking of the control when finished. You should only lock your control for short periods, such as while firing an event.  
  
##  \<a name="colecontrol__onambientpropertychange">\</a>  COleControl::OnAmbientPropertyChange  
 Called by the framework when an ambient property of the container has changed value.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 *dispID*  
 The dispatch ID of the ambient property that changed, or **DISPID_UNKNOWN** if multiple properties have changed.  
  
##  \<a name="colecontrol__onappearancechanged">\</a>  COleControl::OnAppearanceChanged  
 Called by the framework when the stock Appearance property value has changed.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Remarks  
 Override this function if you want notification after this property changes. The default implementation calls <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__onbackcolorchanged">\</a>  COleControl::OnBackColorChanged  
 Called by the framework when the stock BackColor property value has changed.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Remarks  
 Override this function if you want notification after this property changes. The default implementation calls <CodeContentPlaceHolder>385\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__onborderstylechanged">\</a>  COleControl::OnBorderStyleChanged  
 Called by the framework when the stock BorderStyle property value has changed.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>.  
  
 Override this function if you want notification after this property changes.  
  
##  \<a name="colecontrol__onclick">\</a>  COleControl::OnClick  
 Called by the framework when a mouse button has been clicked or the DoClick stock method has been invoked.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 *iButton*  
 Index of a mouse button. Can have one of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was clicked.  
  
-   **MIDDLE_BUTTON** The middle mouse button was clicked.  
  
-   **RIGHT_BUTTON** The right mouse button was clicked.  
  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>.  
  
 Override this member function to modify or extend the default handling.  
  
##  \<a name="colecontrol__onclose">\</a>  COleControl::OnClose  
 Called by the framework when the container has called the control's **IOleControl::Close** function.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>  
 Flag that indicates whether the object should be saved before loading. Valid values are:  
  
-   <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>390\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>391\</CodeContentPlaceHolder>  
  
### Remarks  
 By default, <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> saves the control object if it has been modified and <CodeContentPlaceHolder>393\</CodeContentPlaceHolder> is either <CodeContentPlaceHolder>394\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>395\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__ondoverb">\</a>  COleControl::OnDoVerb  
 Called by the framework when the container calls the **IOleObject::DoVerb** member function.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>396\</CodeContentPlaceHolder>  
 The index of the control verb to be invoked.  
  
 <CodeContentPlaceHolder>397\</CodeContentPlaceHolder>  
 A pointer to the Windows message that caused the verb to be invoked.  
  
 <CodeContentPlaceHolder>398\</CodeContentPlaceHolder>  
 The handle to the parent window of the control. If the execution of the verb creates a window (or windows), <CodeContentPlaceHolder>399\</CodeContentPlaceHolder> should be used as the parent.  
  
 <CodeContentPlaceHolder>400\</CodeContentPlaceHolder>  
 A pointer to a [RECT](../vs140/rect-structure.md) structure into which the coordinates of the control, relative to the container, will be copied.  
  
### Return Value  
 Nonzero if call was successful; otherwise 0.  
  
### Remarks  
 The default implementation uses the <CodeContentPlaceHolder>401\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>402\</CodeContentPlaceHolder> message map entries to determine the proper function to invoke.  
  
 Override this function to change the default handling of verb.  
  
##  \<a name="colecontrol__ondraw">\</a>  COleControl::OnDraw  
 Called by the framework to draw the OLE control in the specified bounding rectangle using the specified device context.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>  
 The device context in which the drawing occurs.  
  
 <CodeContentPlaceHolder>404\</CodeContentPlaceHolder>  
 The rectangular area of the control, including the border.  
  
 <CodeContentPlaceHolder>405\</CodeContentPlaceHolder>  
 The rectangular area of the control that is invalid.  
  
### Remarks  
 <CodeContentPlaceHolder>406\</CodeContentPlaceHolder> is typically called for screen display, passing a screen device context as <CodeContentPlaceHolder>407\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>408\</CodeContentPlaceHolder> parameter identifies the rectangle in the target device context (relative to its current mapping mode). The <CodeContentPlaceHolder>409\</CodeContentPlaceHolder> parameter is the actual rectangle that is invalid. In some cases this will be a smaller area than <CodeContentPlaceHolder>410\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__ondrawmetafile">\</a>  COleControl::OnDrawMetafile  
 Called by the framework to draw the OLE control in the specified bounding rectangle using the specified metafile device context.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>411\</CodeContentPlaceHolder>  
 The device context in which the drawing occurs.  
  
 <CodeContentPlaceHolder>412\</CodeContentPlaceHolder>  
 The rectangular area of the control, including the border.  
  
### Remarks  
 The default implementation calls the [OnDraw](#colecontrol__ondraw) function.  
  
##  \<a name="colecontrol__onedit">\</a>  COleControl::OnEdit  
 Causes the control to be UI activated.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>413\</CodeContentPlaceHolder>  
 A pointer to the Windows message that invoked the verb.  
  
 <CodeContentPlaceHolder>414\</CodeContentPlaceHolder>  
 A handle to the parent window of the control.  
  
 <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>  
 A pointer to the rectangle used by the control in the container.  
  
### Return Value  
 Nonzero if the call is successful; otherwise 0.  
  
### Remarks  
 This has the same effect as invoking the control's <CodeContentPlaceHolder>416\</CodeContentPlaceHolder> verb.  
  
 This function is typically used as the handler function for an <CodeContentPlaceHolder>417\</CodeContentPlaceHolder> message map entry. This makes an "Edit" verb available on the control's "Object" menu. For example:  
  
 [!code[NVC_MFCAxCtl#5](../vs140/codesnippet/CPP/colecontrol-class_6.cpp)]  
  
##  \<a name="colecontrol__onenabledchanged">\</a>  COleControl::OnEnabledChanged  
 Called by the framework when the stock Enabled property value has changed.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Remarks  
 Override this function if you want notification after this property changes. The default implementation calls [InvalidateControl](#colecontrol__invalidatecontrol).  
  
##  \<a name="colecontrol__onenumverbs">\</a>  COleControl::OnEnumVerbs  
 Called by the framework when the container calls the **IOleObject::EnumVerbs** member function.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>418\</CodeContentPlaceHolder>  
 A pointer to the **IEnumOLEVERB** object that enumerates the control's verbs.  
  
### Return Value  
 Nonzero if verbs are available; otherwise 0.  
  
### Remarks  
 The default implementation enumerates the <CodeContentPlaceHolder>419\</CodeContentPlaceHolder> entries in the message map.  
  
 Override this function to change the default way of enumerating verbs.  
  
##  \<a name="colecontrol__oneventadvise">\</a>  COleControl::OnEventAdvise  
 Called by the framework when an event handler is connected to or disconnected from an OLE control.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>420\</CodeContentPlaceHolder>  
 **TRUE** indicates that an event handler has been connected to the control. **FALSE** indicates that an event handler has been disconnected from the control.  
  
##  \<a name="colecontrol__onfontchanged">\</a>  COleControl::OnFontChanged  
 Called by the framework when the stock Font property value has changed.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>421\</CodeContentPlaceHolder>. If the control is subclassing a Windows control, the default implementation also sends a **WM_SETFONT** message to the control's window.  
  
 Override this function if you want notification after this property changes.  
  
### Example  
 [!code[NVC_MFCAxCtl#6](../vs140/codesnippet/CPP/colecontrol-class_7.cpp)]  
  
##  \<a name="colecontrol__onforecolorchanged">\</a>  COleControl::OnForeColorChanged  
 Called by the framework when the stock ForeColor property value has changed.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>422\</CodeContentPlaceHolder>.  
  
 Override this function if you want notification after this property changes.  
  
##  \<a name="colecontrol__onfreezeevents">\</a>  COleControl::OnFreezeEvents  
 Called by the framework after the container calls **IOleControl::FreezeEvents**.  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>423\</CodeContentPlaceHolder>  
 **TRUE** if the control's event handling is frozen; otherwise **FALSE**.  
  
### Remarks  
 The default implementation does nothing.  
  
 Override this function if you want additional behavior when event handling is frozen or unfrozen.  
  
##  \<a name="colecontrol__ongetcolorset">\</a>  COleControl::OnGetColorSet  
 Called by the framework when the container calls the **IViewObject::GetColorSet** member function.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>424\</CodeContentPlaceHolder>  
 Points to the target device for which the picture should be rendered. If this value is **NULL**, the picture should be rendered for a default target device, usually a display device.  
  
 <CodeContentPlaceHolder>425\</CodeContentPlaceHolder>  
 Specifies the information context on the target device indicated by <CodeContentPlaceHolder>426\</CodeContentPlaceHolder>. This parameter can be a device context, but is not one necessarily. If <CodeContentPlaceHolder>427\</CodeContentPlaceHolder> is **NULL**, <CodeContentPlaceHolder>428\</CodeContentPlaceHolder> should also be **NULL**.  
  
 *ppColorSet*  
 A pointer to the location into which the set of colors that would be used should be copied. If the function does not return the color set, **NULL** is returned.  
  
### Return Value  
 Nonzero if a valid color set is returned; otherwise 0.  
  
### Remarks  
 The container calls this function to obtain all the colors needed to draw the OLE control. The container can use the color sets obtained in conjunction with the colors it needs to set the overall color palette. The default implementation returns **FALSE**.  
  
 Override this function to do any special processing of this request.  
  
##  \<a name="colecontrol__ongetcontrolinfo">\</a>  COleControl::OnGetControlInfo  
 Called by the framework when the control's container has requested information about the control.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>429\</CodeContentPlaceHolder>  
 Pointer to a                                 [CONTROLINFO](http://msdn.microsoft.com/library/windows/desktop/ms680734) structure to be filled in.  
  
### Remarks  
 This information consists primarily of a description of the control's mnemonic keys. The default implementation fills <CodeContentPlaceHolder>430\</CodeContentPlaceHolder> with default information.  
  
 Override this function if your control needs to process mnemonic keys.  
  
##  \<a name="colecontrol__ongetdisplaystring">\</a>  COleControl::OnGetDisplayString  
 Called by the framework to obtain a string that represents the current value of the property identified by <CodeContentPlaceHolder>431\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>432\</CodeContentPlaceHolder>  
 The dispatch ID of a property of the control.  
  
 <CodeContentPlaceHolder>433\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object through which a string will be returned.  
  
### Return Value  
 Nonzero if a string has been returned in                         *strValue;* otherwise 0.  
  
### Remarks  
 Override this function if your control has a property whose value cannot be directly converted to a string and you want the property's value to be displayed in a container-supplied property browser.  
  
##  \<a name="colecontrol__ongetinplacemenu">\</a>  COleControl::OnGetInPlaceMenu  
 Called by the framework when the control is UI activated to obtain the menu to be merged into the container's existing menu.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
### Return Value  
 The handle of the control's menu, or **NULL** if the control has none. The default implementation returns **NULL**.  
  
### Remarks  
 For more information on merging OLE resources, see the article [Menus and Resources (OLE)](../vs140/menus-and-resources--ole-.md).  
  
##  \<a name="colecontrol__ongetnaturalextent">\</a>  COleControl::OnGetNaturalExtent  
 Called by the framework in response to a container's **IViewObjectEx::GetNaturalExtent** request.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>434\</CodeContentPlaceHolder>  
 Specifies how the object is to be represented. Representations include content, an icon, a thumbnail, or a printed document. Valid values are taken from the enumeration                                 [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**.  
  
 *lindex*  
 The portion of the object that is of interest. Currently only -1 is valid.  
  
 <CodeContentPlaceHolder>435\</CodeContentPlaceHolder>  
 Points to the                                 [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure defining the target device for which the object's size should be returned.  
  
 <CodeContentPlaceHolder>436\</CodeContentPlaceHolder>  
 Specifies the information context for the target device indicated by the <CodeContentPlaceHolder>437\</CodeContentPlaceHolder> parameter from which the object can extract device metrics and test the device's capabilities. If <CodeContentPlaceHolder>438\</CodeContentPlaceHolder> is **NULL**, the object should ignore the value in the <CodeContentPlaceHolder>439\</CodeContentPlaceHolder> parameter.  
  
 *pExtentInfo*  
 Points to the **DVEXTENTINFO** structure that specifies sizing data. The **DVEXTENTINFO** structure is:  
  
 <CodeContentPlaceHolder>440\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>441\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>442\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>443\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>444\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>445\</CodeContentPlaceHolder>  
  
 The structure member <CodeContentPlaceHolder>446\</CodeContentPlaceHolder> can take one of two values:  
  
-   **DVEXTENT_CONTENT** Inquire how big the control should be to exactly fit content (snap-to-size)  
  
-   **DVEXTENT_INTEGRAL** When resizing, pass proposed size to control  
  
 <CodeContentPlaceHolder>447\</CodeContentPlaceHolder>  
 Points to sizing data returned by control. The returned sizing data is set to -1 for any dimension that was not adjusted.  
  
### Return Value  
 Nonzero if it successfully returns or adjusts the size; otherwise 0.  
  
### Remarks  
 Override this function to return the object's display size closest to the proposed size and extent mode in the **DVEXTENTINFO** structure. The default implementation returns **FALSE** and makes no adjustments to the size.  
  
##  \<a name="colecontrol__ongetpredefinedstrings">\</a>  COleControl::OnGetPredefinedStrings  
 Called by the framework to obtain a set of predefined strings representing the possible values for a property.  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>448\</CodeContentPlaceHolder>  
 The dispatch ID of a property of the control.  
  
 <CodeContentPlaceHolder>449\</CodeContentPlaceHolder>  
 A string array to be filled in with return values.  
  
 <CodeContentPlaceHolder>450\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>451\</CodeContentPlaceHolder> array to be filled in with return values.  
  
### Return Value  
 Nonzero if elements have been added to <CodeContentPlaceHolder>452\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>453\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this function if your control has a property with a set of possible values that can be represented by strings. For each element added to <CodeContentPlaceHolder>454\</CodeContentPlaceHolder>, you should add a corresponding "cookie" element to                         *pCookieArray.* These "cookie" values may later be passed by the framework to the <CodeContentPlaceHolder>455\</CodeContentPlaceHolder> function.  
  
##  \<a name="colecontrol__ongetpredefinedvalue">\</a>  COleControl::OnGetPredefinedValue  
 Called by the framework to obtain the value corresponding to one of the predefined strings previously returned by an override of <CodeContentPlaceHolder>456\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>457\</CodeContentPlaceHolder>  
 The dispatch ID of a property of the control.  
  
 <CodeContentPlaceHolder>458\</CodeContentPlaceHolder>  
 A cookie value previously returned by an override of <CodeContentPlaceHolder>459\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>460\</CodeContentPlaceHolder>  
 Pointer to a **VARIANT** structure through which a property value will be returned.  
  
### Return Value  
 Nonzero if a value has been returned in <CodeContentPlaceHolder>461\</CodeContentPlaceHolder>; otherwise 0.  
  
##  \<a name="colecontrol__ongetviewextent">\</a>  COleControl::OnGetViewExtent  
 Called by the framework in response to a container's                 [IViewObject2::GetExtent](http://msdn.microsoft.com/library/windows/desktop/ms684032) request.  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Parameters  
 *dwDrawAspect*  
 <CodeContentPlaceHolder>462\</CodeContentPlaceHolder> describing which form, or aspect, of an object is to be displayed. Valid values are taken from the enumeration                                 [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**.  
  
 *lindex*  
 The portion of the object that is of interest. Currently only –1 is valid.  
  
 <CodeContentPlaceHolder>463\</CodeContentPlaceHolder>  
 Points to the                                 [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure defining the target device for which the object's size should be returned.  
  
 *lpsizel*  
 Points to the location where the object's size is returned.  
  
### Return Value  
 Nonzero if extent information is successfully returned; otherwise 0.  
  
### Remarks  
 Override this function if your control uses two-pass drawing, and its opaque and transparent parts have different dimensions.  
  
##  \<a name="colecontrol__ongetviewrect">\</a>  COleControl::OnGetViewRect  
 Called by the framework in response to a container's **IViewObjectEx::GetRect** request.  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>464\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>465\</CodeContentPlaceHolder> describing which form, or aspect, of an object is to be displayed. Valid values are taken from the enumeration                                 [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**:  
  
-   <CodeContentPlaceHolder>466\</CodeContentPlaceHolder> Bounding rectangle of the whole object. Top-left corner at the object's origin and size equal to the extent returned by **GetViewExtent***.*  
  
-   **DVASPECT_OPAQUE** Objects with a rectangular opaque region return that rectangle. Others fail.  
  
-   **DVASPECT_TRANSPARENT** Rectangle covering all transparent or irregular parts.  
  
 <CodeContentPlaceHolder>467\</CodeContentPlaceHolder>  
 Points to the                                 [RECTL](http://msdn.microsoft.com/library/windows/desktop/dd162907) structure specifying the rectangle in which the object should be drawn. This parameter controls the positioning and stretching of the object.  
  
### Return Value  
 Nonzero if the rectangle sized to the object is successfully returned; otherwise 0.  
  
### Remarks  
 The object's size is converted by <CodeContentPlaceHolder>468\</CodeContentPlaceHolder> into a rectangle starting at a specific position (the default is the upper left corner of the display). Override this function if your control uses two-pass drawing, and its opaque and transparent parts have different dimensions.  
  
##  \<a name="colecontrol__ongetviewstatus">\</a>  COleControl::OnGetViewStatus  
 Called by the framework in response to a container's **IViewObjectEx::GetViewStatus** request.  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Return Value  
 One of the values of the **VIEWSTATUS** enumeration if successful; otherwise 0. Possible values are any combination of the following:  
  
 **VIEWSTATUS_OPAQUE**  
 Object is completely opaque. If this bit is not set, the object contains transparent parts. This bit applies only to content-related aspects and not to <CodeContentPlaceHolder>469\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>470\</CodeContentPlaceHolder>.  
  
 **VIEWSTATUS_SOLIDBKGND**  
 Object has a solid background (consisting in a solid color, not a brush pattern). This bit is meaningful only if **VIEWSTATUS_OPAQUE** is set and applies only to content-related aspects and not to <CodeContentPlaceHolder>471\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>472\</CodeContentPlaceHolder>.  
  
 **VIEWSTATUS_DVASPECTOPAQUE**  
 Object supports **DVASPECT_OPAQUE**. All **IViewObjectEx** methods that take a drawing aspect as a parameter can be called with this aspect.  
  
 **VIEWSTATUS_DVASPECTTRANSPARENT**  
 Object supports **DVASPECT_TRANSPARENT**. All **IViewObjectEx** methods that take a drawing aspect as a parameter can be called with this aspect.  
  
### Remarks  
 Override this function if your control uses two-pass drawing. The default implementation returns **VIEWSTATUS_OPAQUE**.  
  
##  \<a name="colecontrol__onhidetoolbars">\</a>  COleControl::OnHideToolBars  
 Called by the framework when the control is UI deactivated.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Remarks  
 The implementation should hide all toolbars displayed by <CodeContentPlaceHolder>473\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__oninactivemousemove">\</a>  COleControl::OnInactiveMouseMove  
 Called by the container for the inactive object under the mouse pointer on receipt of a <CodeContentPlaceHolder>474\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>475\</CodeContentPlaceHolder>  
 The object bounding rectangle, in client coordinates of the containing window. Tells the object its exact position and size on the screen when the <CodeContentPlaceHolder>476\</CodeContentPlaceHolder> message was received.  
  
 *x*  
 The x coordinate of the mouse location in client coordinates of the containing window.  
  
 *y*  
 The y coordinate of the mouse location in client coordinates of the containing window.  
  
 <CodeContentPlaceHolder>477\</CodeContentPlaceHolder>  
 Identifies the current state of the keyboard modifier keys on the keyboard. Valid values can be a combination of any of the flags **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_BUTTON**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
### Remarks  
 Note that window client coordinates (pixels) are used to pass the mouse cursor position. This is made possible by also passing the bounding rectangle of the object in the same coordinate system.  
  
##  \<a name="colecontrol__oninactivesetcursor">\</a>  COleControl::OnInactiveSetCursor  
 Called by the container for the inactive object under the mouse pointer on receipt of a <CodeContentPlaceHolder>478\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>479\</CodeContentPlaceHolder>  
 The object bounding rectangle, in client coordinates of the containing window. Tells the object its exact position and size on the screen when the <CodeContentPlaceHolder>480\</CodeContentPlaceHolder> message was received.  
  
 *x*  
 The x coordinate of the mouse location in client coordinates of the containing window.  
  
 *y*  
 The y coordinate of the mouse location in client coordinates of the containing window.  
  
 *dwMouseMsg*  
 The identifier of the mouse message for which a <CodeContentPlaceHolder>481\</CodeContentPlaceHolder> occurred.  
  
 *bSetAlways*  
 Specifies whether or not the object must set the cursor. If **TRUE**, the object must set the cursor; if **FALSE**, the cursor is not obligated to set the cursor, and should return **S_FALSE** in that case.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Note that window client coordinates (pixels) are used to pass the mouse cursor position. This is made possible by also passing the bounding rectangle of the object in the same coordinate system.  
  
##  \<a name="colecontrol__onkeydownevent">\</a>  COleControl::OnKeyDownEvent  
 Called by the framework after a stock KeyDown event has been processed.  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>482\</CodeContentPlaceHolder>  
 The virtual key code value of the pressed key. For a list of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>483\</CodeContentPlaceHolder>  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
### Remarks  
 Override this function if your control needs access to the key information after the event has been fired.  
  
##  \<a name="colecontrol__onkeypressevent">\</a>  COleControl::OnKeyPressEvent  
 Called by the framework after the stock KeyPress event has been fired.  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>484\</CodeContentPlaceHolder>  
 Contains the virtual key code value of the key pressed. For a list of standard virtual key codes, see Winuser.h  
  
### Remarks  
 Note that the <CodeContentPlaceHolder>485\</CodeContentPlaceHolder> value may have been modified by the container.  
  
 Override this function if you want notification after this event occurs.  
  
##  \<a name="colecontrol__onkeyupevent">\</a>  COleControl::OnKeyUpEvent  
 Called by the framework after a stock KeyDown event has been processed.  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>486\</CodeContentPlaceHolder>  
 The virtual key code value of the pressed key. For a list of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>487\</CodeContentPlaceHolder>  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
### Remarks  
 Override this function if your control needs access to the key information after the event has been fired.  
  
##  \<a name="colecontrol__onmappropertytopage">\</a>  COleControl::OnMapPropertyToPage  
 Called by the framework to obtain the class ID of a property page that implements editing of the specified property.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>488\</CodeContentPlaceHolder>  
 The dispatch ID of a property of the control.  
  
 <CodeContentPlaceHolder>489\</CodeContentPlaceHolder>  
 Pointer to a **CLSID** structure through which a class ID will be returned.  
  
 *pbPageOptional*  
 Returns an indicator of whether use of the specified property page is optional.  
  
### Return Value  
 Nonzero if a class ID has been returned in <CodeContentPlaceHolder>490\</CodeContentPlaceHolder>; otherwise 0.  
  
### Remarks  
 Override this function to provide a way to invoke your control's property pages from the container's property browser.  
  
##  \<a name="colecontrol__onmnemonic">\</a>  COleControl::OnMnemonic  
 Called by the framework when the container has detected that a mnemonic key of the OLE control has been pressed.  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>491\</CodeContentPlaceHolder>  
 Pointer to the Windows message generated by a mnemonic key press.  
  
##  \<a name="colecontrol__onproperties">\</a>  COleControl::OnProperties  
 Called by the framework when the control's properties verb has been invoked by the container.  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>492\</CodeContentPlaceHolder>  
 A pointer to the Windows message that invoked the verb.  
  
 <CodeContentPlaceHolder>493\</CodeContentPlaceHolder>  
 A handle to the parent window of the control.  
  
 <CodeContentPlaceHolder>494\</CodeContentPlaceHolder>  
 A pointer to the rectangle used by the control in the container.  
  
### Return Value  
 Nonzero if the call is successful; otherwise 0.  
  
### Remarks  
 The default implementation displays a modal property dialog box.  
  
 You can also use this function to cause the display of your control's property pages. Make a call to the <CodeContentPlaceHolder>495\</CodeContentPlaceHolder> function, passing the handle of your control's parent in the <CodeContentPlaceHolder>496\</CodeContentPlaceHolder> parameter. In this case, the values of the <CodeContentPlaceHolder>497\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>498\</CodeContentPlaceHolder> parameters are ignored.  
  
##  \<a name="colecontrol__onqueryhitpoint">\</a>  COleControl::OnQueryHitPoint  
 Called by the framework in response to a container's **IViewObjectEx::QueryHitPoint** request.  
  
<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>499\</CodeContentPlaceHolder>  
 Specifies how the object is represented. Valid values are taken from the enumeration                                 [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**.  
  
 <CodeContentPlaceHolder>500\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>501\</CodeContentPlaceHolder> structure specifying the bounding rectangle of the OLE control client area.  
  
 <CodeContentPlaceHolder>502\</CodeContentPlaceHolder>  
 Pointer to the **POINT** structure specifying the point to be checked for a hit. The point is specified in OLE client area coordinates.  
  
 <CodeContentPlaceHolder>503\</CodeContentPlaceHolder>  
 The distance that defines "close" to the point checked for a hit.  
  
 <CodeContentPlaceHolder>504\</CodeContentPlaceHolder>  
 Pointer to the result of the hit query. One of the following values:  
  
-   **HITRESULT_OUTSIDE** <CodeContentPlaceHolder>505\</CodeContentPlaceHolder> is outside the OLE object and not close.  
  
-   **HITRESULT_TRANSPARENT** *ptlLoc* is within the bounds of the OLE object, but not close to the image. For example, a point in the middle of a transparent circle could be **HITRESULT_TRANSPARENT**.  
  
-   **HITRESULT_CLOSE** <CodeContentPlaceHolder>506\</CodeContentPlaceHolder> is inside or outside the OLE object but close enough to the object to be considered inside. Small, thin, or detailed objects may use this value. Even if a point is outside the bounding rectangle of an object it may still be close (this is needed for hitting small objects).  
  
-   **HITRESULT_HIT** <CodeContentPlaceHolder>507\</CodeContentPlaceHolder> is within the image of the object.  
  
### Return Value  
 Nonzero if a hit result is successfully returned; otherwise 0. A hit is an overlap with the OLE control display area.  
  
### Remarks  
 Queries whether an object's display rectangle overlaps the given point (hits the point). <CodeContentPlaceHolder>508\</CodeContentPlaceHolder> can be overridden to test hits for non-rectangular objects.  
  
##  \<a name="colecontrol__onqueryhitrect">\</a>  COleControl::OnQueryHitRect  
 Called by the framework in response to a container's **IViewObjectEx::QueryHitRect** request.  
  
<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>509\</CodeContentPlaceHolder>  
 Specifies how the object is to be represented. Valid values are taken from the enumeration                                 [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**.  
  
 <CodeContentPlaceHolder>510\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>511\</CodeContentPlaceHolder> structure specifying the bounding rectangle of the OLE control client area.  
  
 *prcLoc*  
 Pointer to the <CodeContentPlaceHolder>512\</CodeContentPlaceHolder> structure specifying the rectangle to be checked for a hit (overlap with the object rectangle), relative to the upper left corner of the object.  
  
 <CodeContentPlaceHolder>513\</CodeContentPlaceHolder>  
 Not used.  
  
 <CodeContentPlaceHolder>514\</CodeContentPlaceHolder>  
 Pointer to the result of the hit query. One of the following values:  
  
-   **HITRESULT_OUTSIDE** no point in the rectangle is hit by the OLE object.  
  
-   **HITRESULT_HIT** at least one point in the rectangle would be a hit on the object.  
  
### Return Value  
 Nonzero if a hit result is successfully returned; otherwise 0.  
  
### Remarks  
 Queries whether an object's display rectangle overlaps any point in the given rectangle (hits the rectangle). <CodeContentPlaceHolder>515\</CodeContentPlaceHolder> can be overridden to test hits for non-rectangular objects.  
  
##  \<a name="colecontrol__onrenderdata">\</a>  COleControl::OnRenderData  
 Called by the framework to retrieve data in the specified format.  
  
<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>516\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>517\</CodeContentPlaceHolder>  
 Points to a                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data is to be returned.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the control object using the [DelayRenderData](../vs140/coledatasource-class.md#coledatasource__delayrenderdata) or [DelayRenderFileData](../vs140/coledatasource-class.md#coledatasource__delayrenderfiledata) member functions for delayed rendering. The default implementation of this function calls <CodeContentPlaceHolder>518\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>519\</CodeContentPlaceHolder>, respectively, if the supplied storage medium is either a file or memory. If the requested format is <CodeContentPlaceHolder>520\</CodeContentPlaceHolder> or the persistent property set format, the default implementation renders the appropriate data and returns nonzero. Otherwise, it returns 0 and does nothing.  
  
 If                         *lpStgMedium->tymed* is **TYMED_NULL**, the **STGMEDIUM** should be allocated and filled as specified by                         *lpFormatEtc->tymed*. If not **TYMED_NULL**, the **STGMEDIUM** should be filled in place with the data.  
  
 Override this function to provide your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If your data is small and fixed in size, override <CodeContentPlaceHolder>521\</CodeContentPlaceHolder>. If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>522\</CodeContentPlaceHolder>.  
  
 For more information, see the **FORMATETC** and **STGMEDIUM** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colecontrol__onrenderfiledata">\</a>  COleControl::OnRenderFileData  
 Called by the framework to retrieve data in the specified format when the storage medium is a file.  
  
<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>523\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>524\</CodeContentPlaceHolder>  
 Points to a [CFile](../vs140/cfile-class.md) object in which the data is to be rendered.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the control object using the [DelayRenderData](../vs140/coledatasource-class.md#coledatasource__delayrenderdata) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 Override this function to provide your data in the requested format and medium. Depending on your data, you might want to override one of the other versions of this function instead. If you want to handle multiple storage mediums, override <CodeContentPlaceHolder>525\</CodeContentPlaceHolder>. If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>526\</CodeContentPlaceHolder>.  
  
 For more information, see the **FORMATETC** structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colecontrol__onrenderglobaldata">\</a>  COleControl::OnRenderGlobalData  
 Called by the framework to retrieve data in the specified format when the specified storage medium is global memory.  
  
<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>527\</CodeContentPlaceHolder>  
 Points to the                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format in which information is requested.  
  
 <CodeContentPlaceHolder>528\</CodeContentPlaceHolder>  
 Points to a handle to global memory in which the data is to be returned. If no memory has been allocated, this parameter can be **NULL**.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The specified format is one previously placed in the control object using the [DelayRenderData](../vs140/coledatasource-class.md#coledatasource__delayrenderdata) member function for delayed rendering. The default implementation of this function simply returns **FALSE**.  
  
 If <CodeContentPlaceHolder>529\</CodeContentPlaceHolder> is **NULL**, then a new <CodeContentPlaceHolder>530\</CodeContentPlaceHolder> should be allocated and returned in <CodeContentPlaceHolder>531\</CodeContentPlaceHolder>. Otherwise, the <CodeContentPlaceHolder>532\</CodeContentPlaceHolder> specified by <CodeContentPlaceHolder>533\</CodeContentPlaceHolder> should be filled with the data. The amount of data placed in the <CodeContentPlaceHolder>534\</CodeContentPlaceHolder> must not exceed the current size of the memory block. Also, the block cannot be reallocated to a larger size.  
  
 Override this function to provide your data in the requested format and medium. Depending on your data, you may want to override one of the other versions of this function instead. If you want to handle multiple storage mediums, override <CodeContentPlaceHolder>535\</CodeContentPlaceHolder>. If your data is in a file, or is of variable size, override <CodeContentPlaceHolder>536\</CodeContentPlaceHolder>.  
  
 For more information, see the **FORMATETC** structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colecontrol__onresetstate">\</a>  COleControl::OnResetState  
 Called by the framework when the control's properties should be set to their default values.  
  
<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation calls [DoPropExchange](#colecontrol__dopropexchange), passing a <CodeContentPlaceHolder>537\</CodeContentPlaceHolder> object that causes properties to be set to their default values.  
  
 The control writer can insert initialization code for the OLE control in this overridable. This function is called when                         [IPersistStream::Load](http://msdn.microsoft.com/library/windows/desktop/ms680568) or                         [IPersistStorage::Load](http://msdn.microsoft.com/library/windows/desktop/ms680557) fails, or                         [IPersistStreamInit::InitNew](http://msdn.microsoft.com/library/windows/desktop/ms690234) or                         [IPersistStorage::InitNew](http://msdn.microsoft.com/library/windows/desktop/ms687194) is called, without first calling either **IPersistStream::Load** or **IPersistStorage::Load**.  
  
##  \<a name="colecontrol__onsetclientsite">\</a>  COleControl::OnSetClientSite  
 Called by the framework when the container has called the control's **IOleControl::SetClientSite** function.  
  
<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
### Remarks  
 By default, <CodeContentPlaceHolder>538\</CodeContentPlaceHolder> checks whether data path properties are loaded and, if they are, calls <CodeContentPlaceHolder>539\</CodeContentPlaceHolder>.  
  
 Override this function to do any special processing of this notification. In particular, overrides of this function should call the base class.  
  
##  \<a name="colecontrol__onsetdata">\</a>  COleControl::OnSetData  
 Called by the framework to replace the control's data with the specified data.  
  
<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>540\</CodeContentPlaceHolder>  
 Pointer to a                                 [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format of the data.  
  
 <CodeContentPlaceHolder>541\</CodeContentPlaceHolder>  
 Pointer to a                                 [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data resides.  
  
 <CodeContentPlaceHolder>542\</CodeContentPlaceHolder>  
 **TRUE** if the control should free the storage medium; **FALSE** if the control should not free the storage medium.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If the data is in the persistent property set format, the default implementation modifies the control's state accordingly. Otherwise, the default implementation does nothing. If <CodeContentPlaceHolder>543\</CodeContentPlaceHolder> is **TRUE**, then a call to **ReleaseStgMedium** is made; otherwise not.  
  
 Override this function to replace the control's data with the specified data.  
  
 For more information, see the **FORMATETC** and **STGMEDIUM** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colecontrol__onsetextent">\</a>  COleControl::OnSetExtent  
 Called by the framework when the control's extent needs to be changed, as a result of a call to                 [IOleObject::SetExtent](http://msdn.microsoft.com/library/windows/desktop/ms694330).  
  
<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>544\</CodeContentPlaceHolder>  
 A pointer to the **SIZEL** structure that uses long integers to represent the width and height of the control, expressed in **HIMETRIC** units.  
  
### Return Value  
 Nonzero if the size change was accepted; otherwise 0.  
  
### Remarks  
 The default implementation handles the resizing of the control's extent. If the control is in-place active, a call to the container's **OnPosRectChanged** is then made.  
  
 Override this function to alter the default resizing of your control.  
  
##  \<a name="colecontrol__onsetobjectrects">\</a>  COleControl::OnSetObjectRects  
 Called by the framework to implement a call to                 [IOleInPlaceObject::SetObjectRects](http://msdn.microsoft.com/library/windows/desktop/ms683767).  
  
<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
### Parameters  
 *lpRectPos*  
 A pointer to a [RECT](../vs140/rect-structure.md) structure indicating the control's new position and size relative to the container.  
  
 <CodeContentPlaceHolder>545\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>546\</CodeContentPlaceHolder> structure indicating a rectangular area to which the control is to be clipped.  
  
### Return Value  
 Nonzero if the repositioning was accepted; otherwise 0.  
  
### Remarks  
 The default implementation automatically handles the repositioning and resizing of the control window and returns **TRUE**.  
  
 Override this function to alter the default behavior of this function.  
  
##  \<a name="colecontrol__onshowtoolbars">\</a>  COleControl::OnShowToolBars  
 Called by the framework when the control has been UI activated.  
  
<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation does nothing.  
  
##  \<a name="colecontrol__ontextchanged">\</a>  COleControl::OnTextChanged  
 Called by the framework when the stock Caption or Text property value has changed.  
  
<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation calls <CodeContentPlaceHolder>547\</CodeContentPlaceHolder>.  
  
 Override this function if you want notification after this property changes.  
  
##  \<a name="colecontrol__onwindowlessmessage">\</a>  COleControl::OnWindowlessMessage  
 Called by the framework in response to a container's **IOleInPlaceObjectWindowless::OnWindowMessage** request.  
  
<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>548\</CodeContentPlaceHolder>  
 Message identifier as passed by Windows.  
  
 <CodeContentPlaceHolder>549\</CodeContentPlaceHolder>  
 As passed by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the <CodeContentPlaceHolder>550\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>551\</CodeContentPlaceHolder>  
 As passed by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the <CodeContentPlaceHolder>552\</CodeContentPlaceHolder> parameter.  
  
 *plResult*  
 Windows result code. Specifies the result of the message processing and depends on the message sent.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Processes window messages for windowless controls. <CodeContentPlaceHolder>553\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>554\</CodeContentPlaceHolder> should be used for window messages other than mouse messages and keyboard messages. <CodeContentPlaceHolder>555\</CodeContentPlaceHolder> provides [SetCapture](#colecontrol__setcapture) and [SetFocus](#colecontrol__setfocus) specifically to get mouse capture and keyboard focus for windowless OLE objects.  
  
 Because windowless objects do not have a window, they need a mechanism to let the container dispatch messages to them. A windowless OLE object gets messages from its container, through the <CodeContentPlaceHolder>556\</CodeContentPlaceHolder> method on the <CodeContentPlaceHolder>557\</CodeContentPlaceHolder> interface (an extension of                         [IOleInPlaceObject](http://msdn.microsoft.com/library/windows/desktop/ms692646) for windowless support). <CodeContentPlaceHolder>558\</CodeContentPlaceHolder> does not take an <CodeContentPlaceHolder>559\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="colecontrol__parenttoclient">\</a>  COleControl::ParentToClient  
 Translates the coordinates of <CodeContentPlaceHolder>560\</CodeContentPlaceHolder> into client coordinates.  
  
<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>561\</CodeContentPlaceHolder>  
 Pointer to the bounds of the OLE control within the container. Not the client area but the area of the entire control including borders and scroll bars.  
  
 <CodeContentPlaceHolder>562\</CodeContentPlaceHolder>  
 Pointer to the parent (container) point to be translated into the coordinates of the client area of the control.  
  
 <CodeContentPlaceHolder>563\</CodeContentPlaceHolder>  
 Specifies whether or not hit testing is to be done on the point.  
  
### Return Value  
 If <CodeContentPlaceHolder>564\</CodeContentPlaceHolder> is **FALSE**, returns **HTNOWHERE**. If <CodeContentPlaceHolder>565\</CodeContentPlaceHolder> is **TRUE**, returns the location in which the parent (container) point landed in the client area of the OLE control and is one of the following mouse hit-test values:  
  
-   **HTBORDER** In the border of a window that does not have a sizing border.  
  
-   **HTBOTTOM** In the lower horizontal border of the window.  
  
-   **HTBOTTOMLEFT** In the lower-left corner of the window border.  
  
-   **HTBOTTOMRIGHT** In the lower-right corner of the window border.  
  
-   **HTCAPTION** In a title-bar area.  
  
-   **HTCLIENT** In a client area.  
  
-   **HTERROR** On the screen background or on a dividing line between windows (same as **HTNOWHERE** except that the **DefWndProc** Windows function produces a system beep to indicate an error).  
  
-   **HTGROWBOX** In a size box.  
  
-   **HTHSCROLL** In the horizontal scroll bar.  
  
-   **HTLEFT** In the left border of the window.  
  
-   **HTMAXBUTTON** In a Maximize button.  
  
-   **HTMENU** In a menu area.  
  
-   **HTMINBUTTON** In a Minimize button.  
  
-   **HTNOWHERE** On the screen background or on a dividing line between windows.  
  
-   **HTREDUCE** In a Minimize button.  
  
-   **HTRIGHT** In the right border of the window.  
  
-   **HTSIZE** In a size box (same as **HTGROWBOX**).  
  
-   **HTSYSMENU** In a Control menu or in a Close button in a child window.  
  
-   **HTTOP** In the upper horizontal border of the window.  
  
-   **HTTOPLEFT** In the upper-left corner of the window border.  
  
-   **HTTOPRIGHT** In the upper-right corner of the window border.  
  
-   **HTTRANSPARENT** In a window currently covered by another window.  
  
-   **HTVSCROLL** In the vertical scroll bar.  
  
-   **HTZOOM** In a Maximize button.  
  
### Remarks  
 On input <CodeContentPlaceHolder>566\</CodeContentPlaceHolder> is relative to the origin of the parent (upper left corner of the container). On output <CodeContentPlaceHolder>567\</CodeContentPlaceHolder> is relative to the origin of the client area of the OLE control (upper left corner of the client area of the control).  
  
##  \<a name="colecontrol__postmodaldialog">\</a>  COleControl::PostModalDialog  
 Notifies the container that a modal dialog box has been closed.  
  
<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>568\</CodeContentPlaceHolder>  
 Handle to the parent window of the modal dialog box.  
  
### Remarks  
 Call this function after displaying any modal dialog box. You must call this function so that the container can enable any top-level windows disabled by <CodeContentPlaceHolder>569\</CodeContentPlaceHolder>. This function should be paired with a call to <CodeContentPlaceHolder>570\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__premodaldialog">\</a>  COleControl::PreModalDialog  
 Notifies the container that a modal dialog box is about to be displayed.  
  
<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>571\</CodeContentPlaceHolder>  
 Handle to the parent window of the modal dialog box.  
  
### Remarks  
 Call this function before displaying any modal dialog box. You must call this function so that the container can disable all its top-level windows. After the modal dialog box has been displayed, you must then call <CodeContentPlaceHolder>572\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrol__recreatecontrolwindow">\</a>  COleControl::RecreateControlWindow  
 Destroys and re-creates the control's window.  
  
<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
### Remarks  
 This may be necessary if you need to change the window's style bits.  
  
##  \<a name="colecontrol__refresh">\</a>  COleControl::Refresh  
 Forces a repaint of the OLE control.  
  
<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
### Remarks  
 This function is supported by the <CodeContentPlaceHolder>573\</CodeContentPlaceHolder> base class as a stock method, called Refresh. This allows users of your OLE control to repaint the control at a specific time. For more information on this method, see the article [ActiveX Controls: Methods](../vs140/mfc-activex-controls--methods.md).  
  
##  \<a name="colecontrol__releasecapture">\</a>  COleControl::ReleaseCapture  
 Releases mouse capture.  
  
<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If the control currently has the mouse capture, the capture is released. Otherwise, this function has no effect.  
  
##  \<a name="colecontrol__releasedc">\</a>  COleControl::ReleaseDC  
 Releases the display device context of a container of a windowless control, freeing the device context for use by other applications.  
  
<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>574\</CodeContentPlaceHolder>  
 Identifies the container device context to be released.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The application must call <CodeContentPlaceHolder>575\</CodeContentPlaceHolder> for each call to [GetDC](#colecontrol__getdc).  
  
##  \<a name="colecontrol__reparentcontrolwindow">\</a>  COleControl::ReparentControlWindow  
 Sets the parent of the control.  
  
<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
### Parameters  
 *hWndOuter*  
 The handle of the control window.  
  
 <CodeContentPlaceHolder>576\</CodeContentPlaceHolder>  
 The handle of the new parent window.  
  
### Remarks  
 Call this function to reset the parent of the control window.  
  
##  \<a name="colecontrol__resetstockprops">\</a>  COleControl::ResetStockProps  
 Initializes the state of the <CodeContentPlaceHolder>577\</CodeContentPlaceHolder> stock properties to their default values.  
  
<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
### Remarks  
 The properties are: Appearance, BackColor, BorderStyle, Caption, Enabled, Font, ForeColor, hWnd, and Text. For a description of stock properties, see [ActiveX Controls: Adding Stock Properties](../vs140/mfc-activex-controls--adding-stock-properties.md).  
  
 You can improve a control's binary initialization performance by using <CodeContentPlaceHolder>578\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>579\</CodeContentPlaceHolder> to override <CodeContentPlaceHolder>580\</CodeContentPlaceHolder>. See the example below. For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
### Example  
 [!code[NVC_MFCAxCtl#7](../vs140/codesnippet/CPP/colecontrol-class_8.cpp)]  
  
##  \<a name="colecontrol__resetversion">\</a>  COleControl::ResetVersion  
 Initializes the version number to specified value.  
  
<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>581\</CodeContentPlaceHolder>  
 The version number to be assigned to the control.  
  
### Remarks  
 You can improve a control's binary initialization performance by using <CodeContentPlaceHolder>582\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>583\</CodeContentPlaceHolder> to override <CodeContentPlaceHolder>584\</CodeContentPlaceHolder>. See the example at [ResetStockProps](#colecontrol__resetstockprops). For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
##  \<a name="colecontrol__scrollwindow">\</a>  COleControl::ScrollWindow  
 Allows a windowless OLE object to scroll an area within its in-place active image on the screen.  
  
<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>585\</CodeContentPlaceHolder>  
 Specifies the amount, in device units, of horizontal scrolling. This parameter must be a negative value to scroll to the left.  
  
 <CodeContentPlaceHolder>586\</CodeContentPlaceHolder>  
 Specifies the amount, in device units, of vertical scrolling. This parameter must be a negative value to scroll upward.  
  
 <CodeContentPlaceHolder>587\</CodeContentPlaceHolder>  
 Points to a [CRect](../vs140/crect-class.md) object or [RECT](../vs140/rect-structure.md) structure that specifies the portion of the OLE object's client area to scroll, in client coordinates of the containing window. If <CodeContentPlaceHolder>588\</CodeContentPlaceHolder> is **NULL**, the entire OLE object's client area is scrolled.  
  
 <CodeContentPlaceHolder>589\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>590\</CodeContentPlaceHolder> object or <CodeContentPlaceHolder>591\</CodeContentPlaceHolder> structure that specifies the rectangle to clip to. Only pixels inside the rectangle are scrolled. Bits outside the rectangle are not affected even if they are in the <CodeContentPlaceHolder>592\</CodeContentPlaceHolder> rectangle. If <CodeContentPlaceHolder>593\</CodeContentPlaceHolder> is **NULL**, no clipping is performed on the scroll rectangle.  
  
##  \<a name="colecontrol__selectfontobject">\</a>  COleControl::SelectFontObject  
 Selects a font into a device context.  
  
<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>594\</CodeContentPlaceHolder>  
 Pointer to a device context object.  
  
 <CodeContentPlaceHolder>595\</CodeContentPlaceHolder>  
 Reference to the [CFontHolder](../vs140/cfontholder-class.md) object representing the font to be selected.  
  
### Return Value  
 A pointer to the previously selected font. When the caller has finished all drawing operations that use                         *fontHolder,* it should reselect the previously selected font by passing it as a parameter to [CDC::SelectObject](../vs140/cdc-class.md#cdc__selectobject).  
  
##  \<a name="colecontrol__selectstockfont">\</a>  COleControl::SelectStockFont  
 Selects the stock Font property into a device context.  
  
<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>596\</CodeContentPlaceHolder>  
 The device context into which the font will be selected.  
  
### Return Value  
 A pointer to the previously selected <CodeContentPlaceHolder>597\</CodeContentPlaceHolder> object. You should use [CDC::SelectObject](../vs140/cdc-class.md#cdc__selectobject) to select this font back into the device context when you are finished.  
  
##  \<a name="colecontrol__serializeextent">\</a>  COleControl::SerializeExtent  
 Serializes or initializes the state of the display space allotted to the control.  
  
<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>598\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>599\</CodeContentPlaceHolder> object to serialize to or from.  
  
### Remarks  
 You can improve a control's binary persistence performance by using <CodeContentPlaceHolder>600\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>601\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>602\</CodeContentPlaceHolder> to override **COleControl::Serialize**. See the example below. For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
### Example  
 [!code[NVC_MFCAxCtl#8](../vs140/codesnippet/CPP/colecontrol-class_9.cpp)]  
  
##  \<a name="colecontrol__serializestockprops">\</a>  COleControl::SerializeStockProps  
 Serializes or initializes the state of the <CodeContentPlaceHolder>603\</CodeContentPlaceHolder> stock properties: Appearance, BackColor, BorderStyle, Caption, Enabled, Font, ForeColor, and Text.  
  
<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>604\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>605\</CodeContentPlaceHolder> object to serialize to or from.  
  
### Remarks  
 For a description of stock properties, see [ActiveX Controls: Adding Stock Properties](../vs140/mfc-activex-controls--adding-stock-properties.md).  
  
 You can improve a control's binary persistence performance by using <CodeContentPlaceHolder>606\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>607\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>608\</CodeContentPlaceHolder> to override **COleControl::Serialize**. For an example, see the code at [SerializeExtent](#colecontrol__serializeextent). For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
##  \<a name="colecontrol__serializeversion">\</a>  COleControl::SerializeVersion  
 Serializes or initializes the state of a control's version information.  
  
<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>609\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>610\</CodeContentPlaceHolder> object to serialize to or from.  
  
 <CodeContentPlaceHolder>611\</CodeContentPlaceHolder>  
 The current version number of the control.  
  
 <CodeContentPlaceHolder>612\</CodeContentPlaceHolder>  
 Indicates whether persistent data should be converted to the latest format when it is saved, or maintained in the same format it had when it was loaded.  
  
### Return Value  
 The version number of the control. If the specified archive is loading, <CodeContentPlaceHolder>613\</CodeContentPlaceHolder> returns the version loaded from that archive. Otherwise, it returns the currently loaded version.  
  
### Remarks  
 You can improve a control's binary persistence performance by using <CodeContentPlaceHolder>614\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>615\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>616\</CodeContentPlaceHolder> to override **COleControl::Serialize**. For an example, see the code at [SerializeExtent](#colecontrol__serializeextent). For further information on optimizing initialization, see [ActiveX Controls: Optimization](../vs140/mfc-activex-controls--optimization.md).  
  
##  \<a name="colecontrol__setappearance">\</a>  COleControl::SetAppearance  
 Sets the stock Appearance property value of your control.  
  
<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
### Parameters  
 *sAppearance*  
 A **short** ( <CodeContentPlaceHolder>617\</CodeContentPlaceHolder>) value to be used for the appearance of your control. A value of zero sets the control's appearance to flat and a value of 1 sets the control's appearance to 3D.  
  
### Remarks  
 For more about stock properties, see [ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md).  
  
##  \<a name="colecontrol__setbackcolor">\</a>  COleControl::SetBackColor  
 Sets the stock BackColor property value of your control.  
  
<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
### Parameters  
 *dwBackColor*  
 An **OLE_COLOR** value to be used for background drawing of your control.  
  
### Remarks  
 For more information on using this property and other related properties, see the article [ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md).  
  
##  \<a name="colecontrol__setborderstyle">\</a>  COleControl::SetBorderStyle  
 Sets the stock BorderStyle property value of your control.  
  
<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
### Parameters  
 *sBorderStyle*  
 The new border style for the control; 0 indicates no border and 1 indicates a normal border.  
  
### Remarks  
 The control window will then be re-created and <CodeContentPlaceHolder>618\</CodeContentPlaceHolder> called.  
  
##  \<a name="colecontrol__setcapture">\</a>  COleControl::SetCapture  
 Causes the control's container window to take possession of the mouse capture on the control's behalf.  
  
<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the **CWnd** window object that previously received mouse input.  
  
### Remarks  
 If the control is activated and windowless, this function causes the control's container window to take possession of the mouse capture, on the control's behalf. Otherwise, this function causes the control itself to take possession of the mouse capture (same as <CodeContentPlaceHolder>619\</CodeContentPlaceHolder>).  
  
##  \<a name="colecontrol__setcontrolsize">\</a>  COleControl::SetControlSize  
 Sets the size of the OLE control window and notifies the container that the control site is changing.  
  
<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>620\</CodeContentPlaceHolder>  
 Specifies the new width of the control in pixels.  
  
 <CodeContentPlaceHolder>621\</CodeContentPlaceHolder>  
 Specifies the new height of the control in pixels.  
  
### Return Value  
 Nonzero if the call was successful; otherwise 0.  
  
### Remarks  
 This function should not be used in your control's constructor.  
  
 Note that all coordinates for control windows are relative to the upper-left corner of the control.  
  
##  \<a name="colecontrol__setenabled">\</a>  COleControl::SetEnabled  
 Sets the stock Enabled property value of your control.  
  
<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>622\</CodeContentPlaceHolder>  
 **TRUE** if the control is to be enabled; otherwise **FALSE**.  
  
### Remarks  
 After setting this property, **OnEnabledChange** is called.  
  
##  \<a name="colecontrol__setfocus">\</a>  COleControl::SetFocus  
 Causes the control's container window to take possession of the input focus on the control's behalf.  
  
<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the **CWnd** window object that previously had the input focus, or **NULL** if there is no such window.  
  
### Remarks  
 If the control is activated and windowless, this function causes the control's container window to take possession of the input focus, on the control's behalf. The input focus directs keyboard input to the container's window, and the container dispatches all subsequent keyboard messages to the OLE object that calls <CodeContentPlaceHolder>623\</CodeContentPlaceHolder>. Any window that previously had the input focus loses it.  
  
 If the control is not windowless, this function causes the control itself to take possession of the input focus (same as <CodeContentPlaceHolder>624\</CodeContentPlaceHolder>).  
  
##  \<a name="colecontrol__setfont">\</a>  COleControl::SetFont  
 Sets the stock Font property of your control.  
  
<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
### Parameters  
 *pFontDisp*  
 A pointer to a Font dispatch interface.  
  
##  \<a name="colecontrol__setforecolor">\</a>  COleControl::SetForeColor  
 Sets the stock ForeColor property value of your control.  
  
<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
### Parameters  
 *dwForeColor*  
 An **OLE_COLOR** value to be used for foreground drawing of your control.  
  
### Remarks  
 For more information on using this property and other related properties, see the article [ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md).  
  
##  \<a name="colecontrol__setinitialdataformats">\</a>  COleControl::SetInitialDataFormats  
 Called by the framework to initialize the list of data formats supported by the control.  
  
<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation specifies two formats: <CodeContentPlaceHolder>625\</CodeContentPlaceHolder> and the persistent property set.  
  
##  \<a name="colecontrol__setinitialsize">\</a>  COleControl::SetInitialSize  
 Sets the size of an OLE control when first displayed in a container.  
  
<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>626\</CodeContentPlaceHolder>  
 The initial width of the OLE control in pixels.  
  
 <CodeContentPlaceHolder>627\</CodeContentPlaceHolder>  
 The initial height of the OLE control in pixels.  
  
### Remarks  
 Call this function in your constructor to set the initial size of your control. The initial size is measured in device units, or pixels. It is recommended that this call be made in your control's constructor.  
  
##  \<a name="colecontrol__setmodifiedflag">\</a>  COleControl::SetModifiedFlag  
 Changes the modified state of a control.  
  
<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>628\</CodeContentPlaceHolder>  
 The new value for the control's modified flag. **TRUE** indicates that the control's state has been modified; **FALSE** indicates that the control's state has just been saved.  
  
### Remarks  
 Call this function whenever a change occurs that would affect your control's persistent state. For example, if the value of a persistent property changes, call this function with <CodeContentPlaceHolder>629\</CodeContentPlaceHolder>**TRUE**.  
  
##  \<a name="colecontrol__setnotpermitted">\</a>  COleControl::SetNotPermitted  
 Indicates that an edit request has failed.  
  
<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
### Remarks  
 Call this function when <CodeContentPlaceHolder>630\</CodeContentPlaceHolder> fails. This function throws an exception of type **COleDispScodeException** to indicate that the set operation was not permitted.  
  
##  \<a name="colecontrol__setnotsupported">\</a>  COleControl::SetNotSupported  
 Prevents modification to a control's property value by the user.  
  
<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
### Remarks  
 Call this function in place of the Set function of any property where modification of the property value by the control's user is not supported. One example would be a property that is read only.  
  
##  \<a name="colecontrol__setrectincontainer">\</a>  COleControl::SetRectInContainer  
 Sets the coordinates of the control's rectangle relative to the container, expressed in device units.  
  
<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>631\</CodeContentPlaceHolder>  
 A pointer to a rectangle containing the control's new coordinates relative to the container.  
  
### Return Value  
 Nonzero if the call was successful; otherwise 0.  
  
### Remarks  
 If the control is open, it is resized; otherwise the container's **OnPosRectChanged** function is called.  
  
##  \<a name="colecontrol__settext">\</a>  COleControl::SetText  
 Sets the value of your control's stock Caption or Text property.  
  
<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>632\</CodeContentPlaceHolder>  
 A pointer to a character string.  
  
### Remarks  
 Note that the stock Caption and Text properties are both mapped to the same value. This means that any changes made to either property will automatically change both properties. In general, a control should support either the stock Caption or Text property, but not both.  
  
##  \<a name="colecontrol__throwerror">\</a>  COleControl::ThrowError  
 Signals the occurrence of an error in your control.  
  
<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>633\</CodeContentPlaceHolder>  
 The status code value to be reported. For a complete list of possible codes, see the article [ActiveX Controls: Advanced Topics](../vs140/mfc-activex-controls--advanced-topics.md).  
  
 <CodeContentPlaceHolder>634\</CodeContentPlaceHolder>  
 The string resource ID of the exception to be reported.  
  
 <CodeContentPlaceHolder>635\</CodeContentPlaceHolder>  
 The help ID of the topic to be reported on.  
  
 <CodeContentPlaceHolder>636\</CodeContentPlaceHolder>  
 A string containing an explanation of the exception to be reported.  
  
### Remarks  
 This function should only be called from within a Get or Set function for an OLE property, or the implementation of an OLE automation method. If you need to signal errors that occur at other times, you should fire the stock Error event.  
  
##  \<a name="colecontrol__transformcoords">\</a>  COleControl::TransformCoords  
 Transforms coordinate values between **HIMETRIC** units and the container's native units.  
  
<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
### Parameters  
 *lpptlHimetric*  
 Pointer to a **POINTL** structure containing coordinates in **HIMETRIC** units.  
  
 *lpptfContainer*  
 Pointer to a **POINTF** structure containing coordinates in the container's unit size.  
  
 <CodeContentPlaceHolder>637\</CodeContentPlaceHolder>  
 A combination of the following values:  
  
-   **XFORMCOORDS_POSITION** A position in the container.  
  
-   **XFORMCOORDS_SIZE** A size in the container.  
  
-   **XFORMCOORDS_HIMETRICTOCONTAINER** Transform **HIMETRIC** units to the container's units.  
  
-   **XFORMCOORDS_CONTAINERTOHIMETRIC** Transform the container's units to **HIMETRIC** units.  
  
### Remarks  
 The first two flags, **XFORMCOORDS_POSITION** and **XFORMCOORDS_SIZE**, indicate whether the coordinates should be treated as a position or a size. The remaining two flags indicate the direction of transformation.  
  
##  \<a name="colecontrol__translatecolor">\</a>  COleControl::TranslateColor  
 Converts a color value from the **OLE_COLOR** data type to the                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) data type.  
  
<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>638\</CodeContentPlaceHolder>  
 A **OLE_COLOR** data type. For more information, see the Windows                                 [OleTranslateColor](http://msdn.microsoft.com/library/windows/desktop/ms694353) function.  
  
 <CodeContentPlaceHolder>639\</CodeContentPlaceHolder>  
 A handle to an optional palette; can be **NULL**.  
  
### Return Value  
 An RGB (red, green, blue) 32-bit color value that defines the solid color closest to the <CodeContentPlaceHolder>640\</CodeContentPlaceHolder> value that the device can represent.  
  
### Remarks  
 This function is useful to translate the stock ForeColor and BackColor properties to **COLORREF** types used by [CDC](../vs140/cdc-class.md) member functions.  
  
##  \<a name="colecontrol__willambientsbevalidduringload">\</a>  COleControl::WillAmbientsBeValidDuringLoad  
 Determines whether your control should use the values of ambient properties as default values, when it is subsequently loaded from its persistent state.  
  
<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero indicates that ambient properties will be valid; otherwise ambient properties will not be valid.  
  
### Remarks  
 In some containers, your control may not have access to its ambient properties during the initial call to the override of <CodeContentPlaceHolder>641\</CodeContentPlaceHolder>. This is the case if the container calls                         [IPersistStreamInit::Load](http://msdn.microsoft.com/library/windows/desktop/ms680730) or                         [IPersistStorage::Load](http://msdn.microsoft.com/library/windows/desktop/ms680557) prior to calling                         [IOleObject::SetClientSite](http://msdn.microsoft.com/library/windows/desktop/ms684013) (that is, if it does not honor the **OLEMISC_SETCLIENTSITEFIRST** status bit).  
  
##  \<a name="colecontrol__windowproc">\</a>  COleControl::WindowProc  
 Provides a Windows procedure for a <CodeContentPlaceHolder>642\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>643\</CodeContentPlaceHolder>  
 Specifies the Windows message to be processed.  
  
 <CodeContentPlaceHolder>644\</CodeContentPlaceHolder>  
 Provides additional information used in processing the message. The parameter value depends on the message.  
  
 <CodeContentPlaceHolder>645\</CodeContentPlaceHolder>  
 Provides additional information used in processing the message. The parameter value depends on the message.  
  
### Return Value  
 The return value of the message dispatched.  
  
### Remarks  
 Call this function to dispatch specific messages through the control's message map.  
  
## See Also  
 [MFC Sample CIRC3](../vs140/visual-c---samples.md)   
 [MFC Sample TESTHELP](../vs140/visual-c---samples.md)   
 [COlePropertyPage](../vs140/colepropertypage-class.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontHolder](../vs140/cfontholder-class.md)   
 [CPictureHolder](../vs140/cpictureholder-class.md)