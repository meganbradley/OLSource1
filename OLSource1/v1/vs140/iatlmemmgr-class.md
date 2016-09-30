---
title: "IAtlMemMgr Class"
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
  - "IAtlMemMgr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IAtlMemMgr class"
  - "memory, managing"
  - "memory, memory manager"
ms.assetid: 18b2c569-25fe-4464-bdb6-3b1abef7154a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAtlMemMgr Class
This class represents the interface to a memory manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Allocate](../vs140/iatlmemmgr--allocate.md)|Call this method to allocate a block of memory.|  
|[Free](../vs140/iatlmemmgr--free.md)|Call this method to free a block of memory.|  
|[GetSize](../vs140/iatlmemmgr--getsize.md)|Call this method to retrieve the size of an allocated memory block.|  
|[Reallocate](../vs140/iatlmemmgr--reallocate.md)|Call this method to reallocate a block of memory.|  
  
## Remarks  
 This interface is implemented by [CComHeap](../vs140/ccomheap-class.md), [CCRTHeap](../vs140/ccrtheap-class.md), [CLocalHeap](../vs140/clocalheap-class.md), [CGlobalHeap](../vs140/cglobalheap-class.md), or [CWin32Heap](../vs140/cwin32heap-class.md).  
  
> [!NOTE]
>  The local and global heap functions are slower than other memory management functions, and do not provide as many features. Therefore, new applications should use the [heap functions](http://msdn.microsoft.com/library/windows/desktop/aa366711). These are available in the [CWin32Heap](../vs140/cwin32heap-class.md) class.  
  
## Example  
 [!code[NVC_ATL_Utilities#94](../vs140/codesnippet/CPP/iatlmemmgr-class_1.cpp)]  
  
## Requirements  
 **Header:** atlmem.h  
  
##  \<a name="iatlmemmgr__allocate">\</a>  IAtlMemMgr::Allocate  
 Call this method to allocate a block of memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
### Remarks  
 Call [IAtlMemMgr::Free](../vs140/iatlmemmgr--free.md) or [IAtlMemMgr::Reallocate](../vs140/iatlmemmgr--reallocate.md) to free the memory allocated by this method.  
  
### Example  
 For an example, see the [IAtlMemMgr Overview](../vs140/iatlmemmgr-class.md).  
  
##  \<a name="iatlmemmgr__free">\</a>  IAtlMemMgr::Free  
 Call this method to free a block of memory.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
### Remarks  
 Use this method to free memory obtained by [IAtlMemMgr::Allocate](../vs140/iatlmemmgr--allocate.md) or [IAtlMemMgr::Reallocate](../vs140/iatlmemmgr--reallocate.md).  
  
### Example  
 For an example, see the [IAtlMemMgr Overview](../vs140/iatlmemmgr-class.md).  
  
##  \<a name="iatlmemmgr__getsize">\</a>  IAtlMemMgr::GetSize  
 Call this method to retrieve the size of an allocated memory block.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
### Return Value  
 Returns the size of the memory block in bytes.  
  
### Example  
 For an example, see the [IAtlMemMgr Overview](../vs140/iatlmemmgr-class.md).  
  
##  \<a name="iatlmemmgr__reallocate">\</a>  IAtlMemMgr::Reallocate  
 Call this method to reallocate memory allocated by this memory manager.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
### Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
### Remarks  
 Call [IAtlMemMgr::Free](../vs140/iatlmemmgr--free.md) or [IAtlMemMgr::Reallocate](#vclrfiatlmemmgrreallocate) to free the memory allocated by this method.  
  
 Conceptually this method frees the existing memory and allocates a new memory block. In reality, the existing memory may be extended or otherwise reused.  
  
### Example  
 For an example, see the [IAtlMemMgr Overview](../vs140/iatlmemmgr-class.md).  
  
##  \<a name="iaxwinambientdispatch__get_allowcontextmenu">\</a>  IAxWinAmbientDispatch::get_AllowContextMenu  
 The **AllowContextMenu** property specifies whether the hosted control is allowed to display its own context menu.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *pbAllowContextMenu*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_allowshowui">\</a>  IAxWinAmbientDispatch::get_AllowShowUI  
 The **AllowShowUI** property specifies whether the hosted control is allowed to display its own user interface.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *pbAllowShowUI*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **VARIANT_FALSE** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_allowwindowlessactivation">\</a>  IAxWinAmbientDispatch::get_AllowWindowlessActivation  
 The **AllowWindowlessActivation** property specifies whether the container will allow windowless activation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *pbAllowWindowless*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_backcolor">\</a>  IAxWinAmbientDispatch::get_BackColor  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> property specifies the ambient background color of the container.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *pclrBackground*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **COLOR_BTNFACE** or **COLOR_WINDOW** as the default value of this property (depending on whether the parent of the host window is a dialog or not).  
  
##  \<a name="iaxwinambientdispatch__get_displayasdefault">\</a>  IAxWinAmbientDispatch::get_DisplayAsDefault  
 **DisplayAsDefault** is an ambient property that allows a control to find out if it is the default control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *pbDisplayAsDefault*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **VARIANT_FALSE** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_dochostdoubleclickflags">\</a>  IAxWinAmbientDispatch::get_DocHostDoubleClickFlags  
 The **DocHostDoubleClickFlags** property specifies the operation that should take place in response to a double-click.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pdwDocHostDoubleClickFlags*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **DOCHOSTUIDBLCLK_DEFAULT** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_dochostflags">\</a>  IAxWinAmbientDispatch::get_DocHostFlags  
 The **DocHostFlags** property specifies the user interface capabilities of the host object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 *pdwDocHostFlags*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **DOCHOSTUIFLAG_NO3DBORDER** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_font">\</a>  IAxWinAmbientDispatch::get_Font  
 The **Font** property specifies the ambient font of the container.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 [out] The address of an **IFontDisp** interface pointer used to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses the default GUI font or the system font as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_forecolor">\</a>  IAxWinAmbientDispatch::get_ForeColor  
 The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> property specifies the ambient foreground color of the container.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 *pclrForeground*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses the system window text color as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_localeid">\</a>  IAxWinAmbientDispatch::get_LocaleID  
 The **LocaleID** property specifies the ambient locale ID of the container.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 *plcidLocaleID*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses the user's default locale as the default value of this property.  
  
 With this method you can discover the Ambient LocalID, that is, the LocaleID of the program your control is being used in. Once you know the LocaleID, you can call code to load locale-specific captions, error message text, and so forth from a resource file or satellite DLL.  
  
##  \<a name="iaxwinambientdispatch__get_messagereflect">\</a>  IAxWinAmbientDispatch::get_MessageReflect  
 The **MessageReflect** ambient property specifies whether the container will reflect messages to the hosted control.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *pbMessageReflect*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_optionkeypath">\</a>  IAxWinAmbientDispatch::get_OptionKeyPath  
 The **OptionKeyPath** property specifies the registry key path to user settings.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 *pbstrOptionKeyPath*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> value.  
  
##  \<a name="iaxwinambientdispatch__get_showgrabhandles">\</a>  IAxWinAmbientDispatch::get_ShowGrabHandles  
 The **ShowGrabHandles** ambient property allows the control to find out if it should draw itself with grab handles.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *pbShowGrabHandles*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation always returns **VARIANT_FALSE** as the value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_showhatching">\</a>  IAxWinAmbientDispatch::get_ShowHatching  
 The **ShowHatching** ambient property allows the control to find out if it should draw itself hatched.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 *pbShowHatching*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation always returns **VARIANT_FALSE** as the value of this property.  
  
##  \<a name="iaxwinambientdispatch__get_usermode">\</a>  IAxWinAmbientDispatch::get_UserMode  
 The **UserMode** property specifies the ambient user mode of the container.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *pbUserMode*  
 [out] The address of a variable to receive the current value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_allowcontextmenu">\</a>  IAxWinAmbientDispatch::put_AllowContextMenu  
 The **AllowContextMenu** property specifies whether the hosted control is allowed to display its own context menu.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *bAllowContextMenu*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_allowshowui">\</a>  IAxWinAmbientDispatch::put_AllowShowUI  
 The **AllowShowUI** property specifies whether the hosted control is allowed to display its own user interface.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 *bAllowShowUI*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **VARIANT_FALSE** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_allowwindowlessactivation">\</a>  IAxWinAmbientDispatch::put_AllowWindowlessActivation  
 The **AllowWindowlessActivation** property specifies whether the container will allow windowless activation.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 *bAllowWindowless*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_backcolor">\</a>  IAxWinAmbientDispatch::put_BackColor  
 The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> property specifies the ambient background color of the container.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 *clrBackground*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **COLOR_BTNFACE** or **COLOR_WINDOW** as the default value of this property (depending on whether the parent of the host window is a dialog or not).  
  
##  \<a name="iaxwinambientdispatch__put_displayasdefault">\</a>  IAxWinAmbientDispatch::put_DisplayAsDefault  
 **DisplayAsDefault** is an ambient property that allows a control to find out if it is the default control.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **VARIANT_FALSE** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_dochostdoubleclickflags">\</a>  IAxWinAmbientDispatch::put_DocHostDoubleClickFlags  
 The **DocHostDoubleClickFlags** property specifies the operation that should take place in response to a double-click.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 *dwDocHostDoubleClickFlags*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **DOCHOSTUIDBLCLK_DEFAULT** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_dochostflags">\</a>  IAxWinAmbientDispatch::put_DocHostFlags  
 The **DocHostFlags** property specifies the user interface capabilities of the host object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *dwDocHostFlags*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses **DOCHOSTUIFLAG_NO3DBORDER** as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_font">\</a>  IAxWinAmbientDispatch::put_Font  
 The **Font** property specifies the ambient font of the container.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses the default GUI font or the system font as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_forecolor">\</a>  IAxWinAmbientDispatch::put_ForeColor  
 The <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> property specifies the ambient foreground color of the container.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 *clrForeground*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses the system window text color as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_localeid">\</a>  IAxWinAmbientDispatch::put_LocaleID  
 The **LocaleID** property specifies the ambient locale ID of the container.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 *lcidLocaleID*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses the user's default locale as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_messagereflect">\</a>  IAxWinAmbientDispatch::put_MessageReflect  
 The **MessageReflect** ambient property specifies whether the container will reflect messages to the hosted control.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatch__put_optionkeypath">\</a>  IAxWinAmbientDispatch::put_OptionKeyPath  
 The **OptionKeyPath** property specifies the registry key path to user settings.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *bstrOptionKeyPath*  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> value.  
  
##  \<a name="iaxwinambientdispatch__put_usermode">\</a>  IAxWinAmbientDispatch::put_UserMode  
 The **UserMode** property specifies the ambient user mode of the container.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 [in] The new value of this property.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The ATL host object implementation uses <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> as the default value of this property.  
  
##  \<a name="iaxwinambientdispatchex__setambientdispatch">\</a>  IAxWinAmbientDispatchEx::SetAmbientDispatch  
 This method is called to supplement the default ambient property interface with a user-defined interface.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 *pDispatch*  
 Pointer to the new interface.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 When <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> is called with a pointer to a new interface, this new interface will be used to invoke any properties or methods asked for by the hosted control — if those properties are not already provided by [IAxWinAmbientDispatch](../vs140/iaxwinambientdispatch-interface.md).  
  
##  \<a name="iaxwinhostwindow__attachcontrol">\</a>  IAxWinHostWindow::AttachControl  
 Attaches an existing (and previously initialized) control to the host object using the window identified by <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 *pUnkControl*  
 [in] A pointer to the **IUnknown** interface of the control to be attached to the host object.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 [in] A handle to the window to be used for hosting.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> value.  
  
##  \<a name="iaxwinhostwindow__createcontrol">\</a>  IAxWinHostWindow::CreateControl  
 Creates a control, initializes it, and hosts it in the window identified by <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 [in] A string identifying the control to create. Can be a CLSID (must include the braces), ProgID, URL, or raw HTML (prefixed by **MSHTML:**).  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 [in] A handle to the window to be used for hosting.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 [in] An interface pointer for a stream containing initialization data for the control. Can be **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> value.  
  
### Remarks  
 This window will be subclassed by the host object exposing this interface so that messages can be reflected to the control and other container features will work.  
  
 Calling this method is equivalent to calling [IAxWinHostWindow::CreateControlEx](../vs140/iaxwinhostwindow--createcontrolex.md).  
  
 To create a licensed ActiveX control, see [IAxWinHostWindowLic::CreateControlLic](../vs140/iaxwinhostwindowlic--createcontrollicex.md).  
  
##  \<a name="iaxwinhostwindow__createcontrolex">\</a>  IAxWinHostWindow::CreateControlEx  
 Creates an ActiveX control, initializes it, and hosts it in the specified window, similar to [IAxWinHostWindow::CreateControl](../vs140/iaxwinhostwindow--createcontrol.md).  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 [in] A string identifying the control to create. Can be a CLSID (must include the braces), ProgID, URL, or raw HTML (prefixed with **MSHTML:**).  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 [in] A handle to the window to be used for hosting.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 [in] An interface pointer for a stream containing initialization data for the control. Can be **NULL**.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the **IUnknown** interface of the created control. Can be **NULL**.  
  
 *riidAdvise*  
 [in] The interface identifier of an outgoing interface on the contained object. Can be **IID_NULL**.  
  
 *punkAdvise*  
 [in] A pointer to the **IUnknown** interface of the sink object to be connected to the connection point on the contained object specified by <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Unlike the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> method, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> also allows you to receive an interface pointer to the newly created control and set up an event sink to receive events fired by the control.  
  
 To create a licensed ActiveX control, see [IAxWinHostWindowLic::CreateControlLicEx](../vs140/iaxwinhostwindowlic--createcontrollicex.md).  
  
##  \<a name="iaxwinhostwindow__querycontrol">\</a>  IAxWinHostWindow::QueryControl  
 Returns the specified interface pointer provided by the hosted control.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 [in] The ID of an interface on the control being requested.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the specified interface of the created control.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> value.  
  
##  \<a name="iaxwinhostwindow__setexternaldispatch">\</a>  IAxWinHostWindow::SetExternalDispatch  
 Sets the external dispinterface, which is available to contained controls through the [IDocHostUIHandlerDispatch::GetExternal](../vs140/idochostuihandlerdispatch-interface.md) method.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 [in] A pointer to an <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> interface.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> value.  
  
##  \<a name="iaxwinhostwindow__setexternaluihandler">\</a>  IAxWinHostWindow::SetExternalUIHandler  
 Call this function to set the external [IDocHostUIHandlerDispatch](../vs140/idochostuihandlerdispatch-interface.md) interface for the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 [in] A pointer to an **IDocHostUIHandlerDispatch** interface.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> value.  
  
### Remarks  
 This function is used by controls (such as the Web browser control) that query the host's site for the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> interface.  
  
##  \<a name="iaxwinhostwindowlic__createcontrollic">\</a>  IAxWinHostWindowLic::CreateControlLic  
 Creates a licensed control, initializes it, and hosts it in the window identified by <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 [in] The BSTR that contains the license key for the control.  
  
### Remarks  
 See [IAxWinHostWindow::CreateControl](../vs140/iaxwinhostwindow--createcontrol.md) for a description of the remaining parameters and return value.  
  
 Calling this method is equivalent to calling [IAxWinHostWindowLic::CreateControlLicEx](../vs140/iaxwinhostwindowlic--createcontrollicex.md)  
  
### Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
##  \<a name="iaxwinhostwindowlic__createcontrollicex">\</a>  IAxWinHostWindowLic::CreateControlLicEx  
 Creates a licensed ActiveX control, initializes it, and hosts it in the specified window, similar to [IAxWinHostWindow::CreateControl](../vs140/iaxwinhostwindow--createcontrol.md).  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 [in] The BSTR that contains the license key for the control.  
  
### Remarks  
 See [IAxWinHostWindow::CreateControlEx](../vs140/iaxwinhostwindow--createcontrolex.md) for a description of the remaining parameters and return value.  
  
### Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)