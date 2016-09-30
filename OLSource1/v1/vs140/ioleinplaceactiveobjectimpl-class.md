---
title: "IOleInPlaceActiveObjectImpl Class"
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
  - "IOleInPlaceActiveObjectImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IOleInPlaceActiveObjectImpl class"
  - "ActiveX controls [C++], communication between container and control"
  - "IOleInPlaceActiveObject, ATL implementation"
ms.assetid: 44e6cc6d-a2dc-4187-98e3-73cf0320dea9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleInPlaceActiveObjectImpl Class
This class provides methods for assisting communication between an in-place control and its container.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IOleInPlaceActiveObjectImpl::ContextSensitiveHelp](../vs140/ioleinplaceactiveobjectimpl--contextsensitivehelp.md)|Enables context-sensitive help. The ATL implementation returns **E_NOTIMPL**.|  
|[IOleInPlaceActiveObjectImpl::EnableModeless](../vs140/ioleinplaceactiveobjectimpl--enablemodeless.md)|Enables modeless dialog boxes. The ATL implementation returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[IOleInPlaceActiveObjectImpl::GetWindow](../vs140/ioleinplaceactiveobjectimpl--getwindow.md)|Gets a window handle.|  
|[IOleInPlaceActiveObjectImpl::OnDocWindowActivate](../vs140/ioleinplaceactiveobjectimpl--ondocwindowactivate.md)|Notifies the control when the container's document window is activated or deactivated. The ATL implementation returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[IOleInPlaceActiveObjectImpl::OnFrameWindowActivate](../vs140/ioleinplaceactiveobjectimpl--onframewindowactivate.md)|Notifies the control when the container's top-level frame window is activated or deactivated. The ATL implementation returns|  
|[IOleInPlaceActiveObjectImpl::ResizeBorder](../vs140/ioleinplaceactiveobjectimpl--resizeborder.md)|Informs the control it needs to resize its borders. The ATL implementation returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|[IOleInPlaceActiveObjectImpl::TranslateAccelerator](../vs140/ioleinplaceactiveobjectimpl--translateaccelerator.md)|Processes menu accelerator-key messages from the container. The ATL implementation returns **E_NOTIMPL**.|  
  
## Remarks  
 The [IOleInPlaceActiveObject](http://msdn.microsoft.com/library/windows/desktop/ms691299) interface assists communication between an in-place control and its container; for example, communicating the active state of the control and container, and informing the control it needs to resize itself. Class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> provides a default implementation of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and supports **IUnknown** by sending information to the dump device in debug builds.  
  
 **Related Articles** [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md), [Creating an ATL Project](../vs140/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="ioleinplaceactiveobjectimpl__contextsensitivehelp">\</a>  IOleInPlaceActiveObjectImpl::ContextSensitiveHelp  
 Enables context-sensitive help.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 See [IOleWindow::ContextSensitiveHelp](http://msdn.microsoft.com/library/windows/desktop/ms680059) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleinplaceactiveobjectimpl__enablemodeless">\</a>  IOleInPlaceActiveObjectImpl::EnableModeless  
 Enables modeless dialog boxes.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IOleInPlaceActiveObject::EnableModeless](http://msdn.microsoft.com/library/windows/desktop/ms680115) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleinplaceactiveobjectimpl__getwindow">\</a>  IOleInPlaceActiveObjectImpl::GetWindow  
 The container calls this function to get the window handle of the control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Some containers will not work with a control that has been windowless, even if it is currently windowed. In ATL's implementation, if the **CComControl::m_bWasOnceWindowless** data member is **TRUE**, the function returns **E_FAIL**. Otherwise, if \* *phwnd* is not **NULL**, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> assigns *phwnd* to the control class's data member <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 See [IOleWindow::GetWindow](http://msdn.microsoft.com/library/windows/desktop/ms687282) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleinplaceactiveobjectimpl__ondocwindowactivate">\</a>  IOleInPlaceActiveObjectImpl::OnDocWindowActivate  
 Notifies the control when the container's document window is activated or deactivated.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IOleInPlaceActiveObject::OnDocWindowActivate](http://msdn.microsoft.com/library/windows/desktop/ms687281) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleinplaceactiveobjectimpl__onframewindowactivate">\</a>  IOleInPlaceActiveObjectImpl::OnFrameWindowActivate  
 Notifies the control when the container's top-level frame window is activated or deactivated.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IOleInPlaceActiveObject::OnFrameWindowActivate](http://msdn.microsoft.com/library/windows/desktop/ms683969) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleinplaceactiveobjectimpl__resizeborder">\</a>  IOleInPlaceActiveObjectImpl::ResizeBorder  
 Informs the control it needs to resize its borders.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Remarks  
 See [IOleInPlaceActiveObject::ResizeBorder](http://msdn.microsoft.com/library/windows/desktop/ms680053) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="ioleinplaceactiveobjectimpl__translateaccelerator">\</a>  IOleInPlaceActiveObjectImpl::TranslateAccelerator  
 Processes menu accelerator-key messages from the container.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 This method supports the following return values:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if the message was translated successfully.  
  
 **S_FALSE** if the message was not translated.  
  
### Remarks  
 See [IOleInPlaceActiveObject::TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms693360) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [ActiveX Controls Interfaces](http://msdn.microsoft.com/library/windows/desktop/ms692724)   
 [Class Overview](../vs140/atl-class-overview.md)