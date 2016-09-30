---
title: "IOleObjectImpl Class"
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
  - "ATL.IOleObjectImpl"
  - "ATL.IOleObjectImpl<T>"
  - "ATL::IOleObjectImpl"
  - "ATL::IOleObjectImpl<T>"
  - "IOleObjectImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX controls [C++], communication between container and control"
  - "IOleObject, ATL implementation"
  - "IOleObjectImpl class"
ms.assetid: 59750b2d-1633-4a51-a4c2-6455b6b90c45
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl Class
This class implements **IUnknown** and is the principal interface through which a container communicates with a control.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IOleObjectImpl::Advise](../vs140/ioleobjectimpl--advise.md)|Establishes an advisory connection with the control.|  
|[IOleObjectImpl::Close](../vs140/ioleobjectimpl--close.md)|Changes the control state from running to loaded.|  
|[IOleObjectImpl::DoVerb](../vs140/ioleobjectimpl--doverb.md)|Tells the control to perform one of its enumerated actions.|  
|[IOleObjectImpl::DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md)|Tells the control to discard any undo state it is maintaining.|  
|[IOleObjectImpl::DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md)|Tells the control to remove its user interface from view.|  
|[IOleObjectImpl::DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md)|Runs the control and installs its window, but does not install the control's user interface.|  
|[IOleObjectImpl::DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md)|Causes the control to be open-edited in a separate window.|  
|[IOleObjectImpl::DoVerbPrimary](../vs140/ioleobjectimpl--doverbprimary.md)|Performs the specified action when the user double-clicks the control. The control defines the action, usually to activate the control in-place.|  
|[IOleObjectImpl::DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md)|Shows a newly inserted control to the user.|  
|[IOleObjectImpl::DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md)|Activates the control in-place and shows the control's user interface, such as menus and toolbars.|  
|[IOleObjectImpl::EnumAdvise](../vs140/ioleobjectimpl--enumadvise.md)|Enumerates the control's advisory connections.|  
|[IOleObjectImpl::EnumVerbs](../vs140/ioleobjectimpl--enumverbs.md)|Enumerates actions for the control.|  
|[IOleObjectImpl::GetClientSite](../vs140/ioleobjectimpl--getclientsite.md)|Retrieves the control's client site.|  
|[IOleObjectImpl::GetClipboardData](../vs140/ioleobjectimpl--getclipboarddata.md)|Retrieves data from the Clipboard. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleObjectImpl::GetExtent](../vs140/ioleobjectimpl--getextent.md)|Retrieves the extent of the control's display area.|  
|[IOleObjectImpl::GetMiscStatus](../vs140/ioleobjectimpl--getmiscstatus.md)|Retrieves the status of the control.|  
|[IOleObjectImpl::GetMoniker](../vs140/ioleobjectimpl--getmoniker.md)|Retrieves the control's moniker. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleObjectImpl::GetUserClassID](../vs140/ioleobjectimpl--getuserclassid.md)|Retrieves the control's class identifier.|  
|[IOleObjectImpl::GetUserType](../vs140/ioleobjectimpl--getusertype.md)|Retrieves the control's user-type name.|  
|[IOleObjectImpl::InitFromData](../vs140/ioleobjectimpl--initfromdata.md)|Initializes the control from selected data. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleObjectImpl::IsUpToDate](../vs140/ioleobjectimpl--isuptodate.md)|Checks if the control is up to date. The ATL implementation returns <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.|  
|[IOleObjectImpl::OnPostVerbDiscardUndo](../vs140/ioleobjectimpl--onpostverbdiscardundo.md)|Called by [DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md) after the undo state is discarded.|  
|[IOleObjectImpl::OnPostVerbHide](../vs140/ioleobjectimpl--onpostverbhide.md)|Called by [DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md) after the control is hidden.|  
|[IOleObjectImpl::OnPostVerbInPlaceActivate](../vs140/ioleobjectimpl--onpostverbinplaceactivate.md)|Called by [DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md) after the control is activated in place.|  
|[IOleObjectImpl::OnPostVerbOpen](../vs140/ioleobjectimpl--onpostverbopen.md)|Called by [DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md) after the control has been opened for editing in a separate window.|  
|[IOleObjectImpl::OnPostVerbShow](../vs140/ioleobjectimpl--onpostverbshow.md)|Called by [DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md) after the control has been made visible.|  
|[IOleObjectImpl::OnPostVerbUIActivate](../vs140/ioleobjectimpl--onpostverbuiactivate.md)|Called by [DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md) after the control's user interface has been activated.|  
|[IOleObjectImpl::OnPreVerbDiscardUndo](../vs140/ioleobjectimpl--onpreverbdiscardundo.md)|Called by [DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md) before the undo state is discarded.|  
|[IOleObjectImpl::OnPreVerbHide](../vs140/ioleobjectimpl--onpreverbhide.md)|Called by [DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md) before the control is hidden.|  
|[IOleObjectImpl::OnPreVerbInPlaceActivate](../vs140/ioleobjectimpl--onpreverbinplaceactivate.md)|Called by [DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md) before the control is activated in place.|  
|[IOleObjectImpl::OnPreVerbOpen](../vs140/ioleobjectimpl--onpreverbopen.md)|Called by [DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md) before the control has been opened for editing in a separate window.|  
|[IOleObjectImpl::OnPreVerbShow](../vs140/ioleobjectimpl--onpreverbshow.md)|Called by [DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md) before the control has been made visible.|  
|[IOleObjectImpl::OnPreVerbUIActivate](../vs140/ioleobjectimpl--onpreverbuiactivate.md)|Called by [DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md) before the control's user interface has been activated.|  
|[IOleObjectImpl::SetClientSite](../vs140/ioleobjectimpl--setclientsite.md)|Tells the control about its client site in the container.|  
|[IOleObjectImpl::SetColorScheme](../vs140/ioleobjectimpl--setcolorscheme.md)|Recommends a color scheme to the control's application, if any. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleObjectImpl::SetExtent](../vs140/ioleobjectimpl--setextent.md)|Sets the extent of the control's display area.|  
|[IOleObjectImpl::SetHostNames](../vs140/ioleobjectimpl--sethostnames.md)|Tells the control the names of the container application and container document.|  
|[IOleObjectImpl::SetMoniker](../vs140/ioleobjectimpl--setmoniker.md)|Tells the control what its moniker is. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleObjectImpl::Unadvise](../vs140/ioleobjectimpl--unadvise.md)|Deletes an advisory connection with the control.|  
|[IOleObjectImpl::Update](../vs140/ioleobjectimpl--update.md)|Updates the control. The ATL implementation returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The [IOleObject](http://msdn.microsoft.com/library/windows/desktop/dd542709) interface is the principal interface through which a container communicates with a control. Class <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> provides a default implementation of this interface and implements **IUnknown** by sending information to the dump device in debug builds.  
  
 **Related Articles** [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md), [Creating an ATL Project](../vs140/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="ioleobjectimpl__advise">\</a>  IOleObjectImpl::Advise  
 Establishes an advisory connection with the control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 See [IOleObject::Advise](http://msdn.microsoft.com/library/windows/desktop/ms686573) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__close">\</a>  IOleObjectImpl::Close  
 Changes the control state from running to loaded.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 Deactivates the control and destroys the control window if it exists. If the control class data member [CComControlBase::m_bRequiresSave](../vs140/ccomcontrolbase--m_brequiressave.md) is **TRUE** and the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter is either <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, the control properties are saved before closing.  
  
 The pointers held in the control class data members [CComControlBase::m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md) and [CComControlBase::m_spAdviseSink](../vs140/ccomcontrolbase--m_spadvisesink.md) are released, and the data members [CComControlBase::m_bNegotiatedWnd](../vs140/ccomcontrolbase--m_bnegotiatedwnd.md), [CComControlBase::m_bWndless](../vs140/ccomcontrolbase--m_bwndless.md), and [CComControlBase::m_bInPlaceSiteEx](../vs140/ccomcontrolbase--m_binplacesiteex.md) are set to **FALSE**.  
  
 See [IOleObject::Close](http://msdn.microsoft.com/library/windows/desktop/ms683922) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__doverb">\</a>  IOleObjectImpl::DoVerb  
 Tells the control to perform one of its enumerated actions.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Depending on the value of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, one of the ATL <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> helper functions is called as follows:  
  
|*iVerb* Value|DoVerb helper function called|  
|-------------------|-----------------------------------|  
|**OLEIVERB_DISCARDUNDOSTATE**|[DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md)|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|[DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md)|  
|**OLEIVERB_INPLACEACTIVATE**|[DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md)|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|[DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md)|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|[DoVerbPrimary](../vs140/ioleobjectimpl--doverbprimary.md)|  
|**OLEIVERB_PROPERTIES**|[CComControlBase::DoVerbProperties](../vs140/ccomcontrolbase--doverbproperties.md)|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|[DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md)|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|[DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md)|  
  
 See [IOleObject::DoVerb](http://msdn.microsoft.com/library/windows/desktop/ms694508) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__doverbdiscardundo">\</a>  IOleObjectImpl::DoVerbDiscardUndo  
 Tells the control to discard any undo state it is maintaining.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
##  \<a name="ioleobjectimpl__doverbhide">\</a>  IOleObjectImpl::DoVerbHide  
 Deactivates and removes the control's user interface, and hides the control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control. Not used in the ATL implementation.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
##  \<a name="ioleobjectimpl__doverbinplaceactivate">\</a>  IOleObjectImpl::DoVerbInPlaceActivate  
 Runs the control and installs its window, but does not install the control's user interface.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control. Not used in the ATL implementation.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> values.  
  
### Remarks  
 Activates the control in place by calling [CComControlBase::InPlaceActivate](../vs140/ccomcontrolbase--inplaceactivate.md). Unless the control class's data member <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is **TRUE**, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> first attempts to activate the control as a windowless control (possible only if the container supports [IOleInPlaceSiteWindowless](http://msdn.microsoft.com/library/windows/desktop/ms682300)). If that fails, the function attempts to activate the control with extended features (possible only if the container supports [IOleInPlaceSiteEx](http://msdn.microsoft.com/library/windows/desktop/ms693461)). If that fails, the function attempts to activate the control with no extended features (possible only if the container supports [IOleInPlaceSite](http://msdn.microsoft.com/library/windows/desktop/ms686586)). If activation succeeds, the function notifies the container the control has been activated.  
  
##  \<a name="ioleobjectimpl__doverbopen">\</a>  IOleObjectImpl::DoVerbOpen  
 Causes the control to be open-edited in a separate window.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
##  \<a name="ioleobjectimpl__doverbprimary">\</a>  IOleObjectImpl::DoVerbPrimary  
 Defines the action taken when the user double-clicks the control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> values.  
  
### Remarks  
 By default, set to display the property pages. You can override this in your control class to invoke a different behavior on double-click; for example, play a video or go in-place active.  
  
##  \<a name="ioleobjectimpl__doverbshow">\</a>  IOleObjectImpl::DoVerbShow  
 Tells the container to make the control visible.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control. Not used in the ATL implementation.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> values.  
  
##  \<a name="ioleobjectimpl__doverbuiactivate">\</a>  IOleObjectImpl::DoVerbUIActivate  
 Activates the control's user interface and notifies the container that its menus are being replaced by composite menus.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control. Not used in the ATL implementation.  
  
### Return Value  
 One of the standard <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> values.  
  
##  \<a name="ioleobjectimpl__enumadvise">\</a>  IOleObjectImpl::EnumAdvise  
 Supplies an enumeration of registered advisory connections for this control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 See [IOleObject::EnumAdvise](http://msdn.microsoft.com/library/windows/desktop/ms682355) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__enumverbs">\</a>  IOleObjectImpl::EnumVerbs  
 Supplies an enumeration of registered actions (verbs) for this control by calling **OleRegEnumVerbs**.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 You can add verbs to your project's .rgs file. For example, see CIRCCTL.RGS in the [CIRC](../vs140/visual-c---samples.md) sample.  
  
 See [IOleObject::EnumVerbs](http://msdn.microsoft.com/library/windows/desktop/ms692781) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__getclientsite">\</a>  IOleObjectImpl::GetClientSite  
 Puts the pointer in the control class data member [CComControlBase::m_spClientSite](../vs140/ccomcontrolbase--m_spclientsite.md) into *ppClientSite* and increments the reference count on the pointer.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 See [IOleObject::GetClientSite](http://msdn.microsoft.com/library/windows/desktop/ms692603) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__getclipboarddata">\</a>  IOleObjectImpl::GetClipboardData  
 Retrieves data from the Clipboard.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 See [IOleObject::GetClipboardData](http://msdn.microsoft.com/library/windows/desktop/ms682288) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__getextent">\</a>  IOleObjectImpl::GetExtent  
 Retrieves a running control's display size in HIMETRIC units (0.01 millimeter per unit).  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The size is stored in the control class data member [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md).  
  
 See [IOleObject::GetExtent](http://msdn.microsoft.com/library/windows/desktop/ms692325) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__getmiscstatus">\</a>  IOleObjectImpl::GetMiscStatus  
 Returns a pointer to registered status information for the control by calling **OleRegGetMiscStatus**.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 The status information includes behaviors supported by the control and presentation data. You can add status information to your project's .rgs file.  
  
 See [IOleObject::GetMiscStatus](http://msdn.microsoft.com/library/windows/desktop/ms678521) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__getmoniker">\</a>  IOleObjectImpl::GetMoniker  
 Retrieves the control's moniker.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 See [IOleObject::GetMoniker](http://msdn.microsoft.com/library/windows/desktop/ms686576) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__getuserclassid">\</a>  IOleObjectImpl::GetUserClassID  
 Returns the control's class identifier.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 See [IOleObject::GetUserClassID](http://msdn.microsoft.com/library/windows/desktop/ms682313) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__getusertype">\</a>  IOleObjectImpl::GetUserType  
 Returns the control's user-type name by calling **OleRegGetUserType**.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 The user-type name is used for display in user-interfaces elements such as menus and dialog boxes. You can change the user-type name in your project's .rgs file.  
  
 See [IOleObject::GetUserType](http://msdn.microsoft.com/library/windows/desktop/ms688643) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__initfromdata">\</a>  IOleObjectImpl::InitFromData  
 Initializes the control from selected data.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 See [IOleObject::InitFromData](http://msdn.microsoft.com/library/windows/desktop/ms688510) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__isuptodate">\</a>  IOleObjectImpl::IsUpToDate  
 Checks if the control is up to date.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IOleObject::IsUpToDate](http://msdn.microsoft.com/library/windows/desktop/ms686624) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__onpostverbdiscardundo">\</a>  IOleObjectImpl::OnPostVerbDiscardUndo  
 Called by [DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md) after the undo state is discarded.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method with code you want executed after the undo state is discarded.  
  
##  \<a name="ioleobjectimpl__onpostverbhide">\</a>  IOleObjectImpl::OnPostVerbHide  
 Called by [DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md) after the control is hidden.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method with code you want executed after the control is hidden.  
  
##  \<a name="ioleobjectimpl__onpostverbinplaceactivate">\</a>  IOleObjectImpl::OnPostVerbInPlaceActivate  
 Called by [DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md) after the control is activated in place.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method with code you want executed after the control is activated in place.  
  
##  \<a name="ioleobjectimpl__onpostverbopen">\</a>  IOleObjectImpl::OnPostVerbOpen  
 Called by [DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md) after the control has been opened for editing in a separate window.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method with code you want executed after the control has been opened for editing in a separate window.  
  
##  \<a name="ioleobjectimpl__onpostverbshow">\</a>  IOleObjectImpl::OnPostVerbShow  
 Called by [DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md) after the control has been made visible.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method with code you want executed after the control has been made visible.  
  
##  \<a name="ioleobjectimpl__onpostverbuiactivate">\</a>  IOleObjectImpl::OnPostVerbUIActivate  
 Called by [DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md) after the control's user interface has been activated.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
### Remarks  
 Override this method with code you want executed after the control's user interface has been activated.  
  
##  \<a name="ioleobjectimpl__onpreverbdiscardundo">\</a>  IOleObjectImpl::OnPreVerbDiscardUndo  
 Called by [DoVerbDiscardUndo](../vs140/ioleobjectimpl--doverbdiscardundo.md) before the undo state is discarded.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
### Remarks  
 To prevent the undo state from being discarded, override this method to return an error HRESULT.  
  
##  \<a name="ioleobjectimpl__onpreverbhide">\</a>  IOleObjectImpl::OnPreVerbHide  
 Called by [DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md) before the control is hidden.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.  
  
### Remarks  
 To prevent the control from being hidden, override this method to return an error HRESULT.  
  
##  \<a name="ioleobjectimpl__onpreverbinplaceactivate">\</a>  IOleObjectImpl::OnPreVerbInPlaceActivate  
 Called by [DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md) before the control is activated in place.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 To prevent the control from being activated in place, override this method to return an error HRESULT.  
  
##  \<a name="ioleobjectimpl__onpreverbopen">\</a>  IOleObjectImpl::OnPreVerbOpen  
 Called by [DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md) before the control has been opened for editing in a separate window.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Remarks  
 To prevent the control from being opened for editing in a separate window, override this method to return an error HRESULT.  
  
##  \<a name="ioleobjectimpl__onpreverbshow">\</a>  IOleObjectImpl::OnPreVerbShow  
 Called by [DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md) before the control has been made visible.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Remarks  
 To prevent the control from being made visible, override this method to return an error HRESULT.  
  
##  \<a name="ioleobjectimpl__onpreverbuiactivate">\</a>  IOleObjectImpl::OnPreVerbUIActivate  
 Called by [DoVerbUIActivate](../vs140/ioleobjectimpl--doverbuiactivate.md) before the control's user interface has been activated.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
### Remarks  
 To prevent the control's user interface from being activated, override this method to return an error HRESULT.  
  
##  \<a name="ioleobjectimpl__setclientsite">\</a>  IOleObjectImpl::SetClientSite  
 Tells the control about its client site in the container.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Remarks  
 The method then returns <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
 See [IOleObject::SetClientSite](http://msdn.microsoft.com/library/windows/desktop/ms684013) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__setcolorscheme">\</a>  IOleObjectImpl::SetColorScheme  
 Recommends a color scheme to the control's application, if any.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 See [IOleObject::SetColorScheme](http://msdn.microsoft.com/library/windows/desktop/ms683971) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__setextent">\</a>  IOleObjectImpl::SetExtent  
 Sets the extent of the control's display area.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 Otherwise, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> stores the value pointed to by <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> in the control class data member [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md). This value is in HIMETRIC units (0.01 millimeter per unit).  
  
 If the control class data member [CComControlBase::m_bResizeNatural](../vs140/ccomcontrolbase--m_bresizenatural.md) is **TRUE**, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> also stores the value pointed to by <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> in the control class data member [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md).  
  
 If the control class data member [CComControlBase::m_bRecomposeOnResize](../vs140/ccomcontrolbase--m_brecomposeonresize.md) is **TRUE**, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> to notify all advisory sinks registered with the advise holder that the control size has changed.  
  
 See [IOleObject::SetExtent](http://msdn.microsoft.com/library/windows/desktop/ms694330) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__sethostnames">\</a>  IOleObjectImpl::SetHostNames  
 Tells the control the names of the container application and container document.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IOleObject::SetHostNames](http://msdn.microsoft.com/library/windows/desktop/ms680642) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__setmoniker">\</a>  IOleObjectImpl::SetMoniker  
 Tells the control what its moniker is.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 See [IOleObject::SetMoniker](http://msdn.microsoft.com/library/windows/desktop/ms679671) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__unadvise">\</a>  IOleObjectImpl::Unadvise  
 Deletes the advisory connection stored in the control class's <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> data member.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 See [IOleObject::Unadvise](http://msdn.microsoft.com/library/windows/desktop/ms693749) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleobjectimpl__update">\</a>  IOleObjectImpl::Update  
 Updates the control.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IOleObject::Update](http://msdn.microsoft.com/library/windows/desktop/ms679699) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [ActiveX Controls Interfaces](http://msdn.microsoft.com/library/windows/desktop/ms692724)   
 [Class Overview](../vs140/atl-class-overview.md)