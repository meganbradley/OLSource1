---
title: "IQuickActivateImpl Class"
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
  - "ATL::IQuickActivateImpl"
  - "ATL::IQuickActivateImpl<T>"
  - "ATL.IQuickActivateImpl"
  - "ATL.IQuickActivateImpl<T>"
  - "IQuickActivateImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "activating ATL controls"
  - "controls [ATL], activating"
  - "IQuickActivateImpl class"
  - "IQuickActivate ATL implementation"
ms.assetid: aa80c056-1041-494e-b21d-2acca7dc27ea
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IQuickActivateImpl Class
This class combines containers' control initialization into a single call.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IQuickActivateImpl::GetContentExtent](../vs140/iquickactivateimpl--getcontentextent.md)|Retrieves the current display size for a running control.|  
|[IQuickActivateImpl::QuickActivate](../vs140/iquickactivateimpl--quickactivate.md)|Performs quick initialization of controls being loaded.|  
|[IQuickActivateImpl::SetContentExtent](../vs140/iquickactivateimpl--setcontentextent.md)|Informs the control of how much display space the container has assigned to it.|  
  
## Remarks  
 The [IQuickActivate](http://msdn.microsoft.com/library/windows/desktop/ms690146) interface helps containers avoid delays when loading controls by combining initialization in a single call. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method allows the container to pass a pointer to a [QACONTAINER](http://msdn.microsoft.com/library/windows/desktop/ms688630) structure that holds pointers to all the interfaces the control needs. On return, the control passes back a pointer to a [QACONTROL](http://msdn.microsoft.com/library/windows/desktop/ms693721) structure that holds pointers to its own interfaces, which are used by the container. Class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provides a default implementation of **IQuickActivate** and implements **IUnknown** by sending information to the dump device in debug builds.  
  
 **Related Articles** [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md), [Creating an ATL Project](../vs140/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="iquickactivateimpl__getcontentextent">\</a>  IQuickActivateImpl::GetContentExtent  
 Retrieves the current display size for a running control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The size is for a full rendering of the control and is specified in HIMETRIC units.  
  
 See [IQuickActivate::GetContentExtent](http://msdn.microsoft.com/library/windows/desktop/ms693792) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iquickactivateimpl__quickactivate">\</a>  IQuickActivateImpl::QuickActivate  
 Performs quick initialization of controls being loaded.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The structure contains pointers to interfaces needed by the control and the values of some ambient properties. Upon return, the control passes a pointer to a [QACONTROL](http://msdn.microsoft.com/library/windows/desktop/ms693721) structure that contains pointers to its own interfaces that the container requires, and additional status information.  
  
 See [IQuickActivate::QuickActivate](http://msdn.microsoft.com/library/windows/desktop/ms682421) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iquickactivateimpl__setcontentextent">\</a>  IQuickActivateImpl::SetContentExtent  
 Informs the control of how much display space the container has assigned to it.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The size is specified in HIMETRIC units.  
  
 See [IQuickActivate::SetContentExtent](http://msdn.microsoft.com/library/windows/desktop/ms678806) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)