---
title: "CComControl Class"
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
  - "CComControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "control flags"
  - "CComControlBase class, CComControl class"
  - "stock properties, ATL"
  - "CComControl class"
  - "controls [ATL], control helper functions"
  - "ambient properties"
  - "controls [ATL], properties"
ms.assetid: 55368c27-bd16-45a7-b701-edb36157c8e8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControl Class
This class provides methods for creating and managing ATL controls.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The class implementing the control.  
  
 *WinBase*  
 The base class that implements windowing functions. Defaults to [CWindowImpl](../vs140/cwindowimpl-class.md).  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComControl::CComControl](../vs140/ccomcontrol--ccomcontrol.md)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComControl::ControlQueryInterface](../vs140/ccomcontrol--controlqueryinterface.md)|Retrieves a pointer to the requested interface.|  
|[CComControl::CreateControlWindow](../vs140/ccomcontrol--createcontrolwindow.md)|Creates a window for the control.|  
|[CComControl::FireOnChanged](../vs140/ccomcontrol--fireonchanged.md)|Notifies the container's sink that a control property has changed.|  
|[CComControl::FireOnRequestEdit](../vs140/ccomcontrol--fireonrequestedit.md)|Notifies the container's sink that a control property is about to change and that the object is asking the sink how to proceed.|  
|[CComControl::MessageBox](../vs140/ccomcontrol--messagebox.md)|Call this method to create, display, and operate a message box.|  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a set of useful control helper functions and essential data members for ATL controls. When you create a standard control or a DHTML control using the ATL Control Wizard, the wizard will automatically derive your class from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> derives most of its methods from [CComControlBase](../vs140/ccomcontrolbase-class.md).  
  
 For more information about creating a control, see the [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md). For more information about the ATL Project Wizard, see the article [Creating an ATL Project](../vs140/creating-an-atl-project.md).  
  
 For a demonstration of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> methods and data members, see the [CIRC](../vs140/visual-c---samples.md) sample.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 [CComControlBase](../vs140/ccomcontrolbase-class.md)  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="ccomcontrol__ccomcontrol">\</a>  CComControl::CComControl  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Calls the [CComControlBase](../vs140/ccomcontrolbase--ccomcontrolbase.md) constructor, passing the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> data member inherited through [CWindowImpl](../vs140/cwindowimpl-class.md).  
  
##  \<a name="ccomcontrol__controlqueryinterface">\</a>  CComControl::ControlQueryInterface  
 Retrieves a pointer to the requested interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [in] The GUID of the interface being requested.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or **NULL** if the interface is not found.  
  
### Remarks  
 Only handles interfaces in the COM map table.  
  
### Example  
 [!code[NVC_ATL_COM#15](../vs140/codesnippet/CPP/ccomcontrol-class_1.cpp)]  
  
##  \<a name="ccomcontrol__createcontrolwindow">\</a>  CComControl::CreateControlWindow  
 By default, creates a window for the control by calling <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [in] Handle to the parent or owner window. A valid window handle must be supplied. The control window is confined to the area of its parent window.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [in] The initial size and position of the window to be created.  
  
### Remarks  
 Override this method if you want to do something other than create a single window, for example, to create two windows, one of which becomes a toolbar for your control.  
  
### Example  
 [!code[NVC_ATL_COM#16](../vs140/codesnippet/CPP/ccomcontrol-class_2.cpp)]  
  
##  \<a name="ccomcontrol__fireonchanged">\</a>  CComControl::FireOnChanged  
 Notifies the container's sink that a control property has changed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *dispID*  
 [in] Identifier of the property that has changed.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 If your control class derives from [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638), this method calls [CFirePropNotifyEvent::FireOnChanged](../vs140/cfirepropnotifyevent--fireonchanged.md) to notify all connected <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interfaces that the specified control property has changed. If your control class does not derive from <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 This method is safe to call even if your control doesn't support connection points.  
  
### Example  
 [!code[NVC_ATL_COM#17](../vs140/codesnippet/CPP/ccomcontrol-class_3.cpp)]  
  
##  \<a name="ccomcontrol__fireonrequestedit">\</a>  CComControl::FireOnRequestEdit  
 Notifies the container's sink that a control property is about to change and that the object is asking the sink how to proceed.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *dispID*  
 [in] Identifier of the property about to change.  
  
### Return Value  
 One of the standard HRESULT values.  
  
### Remarks  
 If your control class derives from [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638), this method calls [CFirePropNotifyEvent::FireOnRequestEdit](../vs140/cfirepropnotifyevent--fireonrequestedit.md) to notify all connected <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> interfaces that the specified control property is about to change. If your control class does not derive from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, this method returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 This method is safe to call even if your control doesn't support connection points.  
  
### Example  
 [!code[NVC_ATL_COM#18](../vs140/codesnippet/CPP/ccomcontrol-class_4.cpp)]  
  
##  \<a name="ccomcontrol__messagebox">\</a>  CComControl::MessageBox  
 Call this method to create, display, and operate a message box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The text to be displayed in the message box.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The dialog box title. If NULL (the default), the title "Error" is used.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the contents and behavior of the dialog box. See the [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) entry in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] documentation for a list of the different message boxes available. The default provides a simple **OK** button.  
  
### Return Value  
 Returns an integer value specifying one of the menu-item values listed under [MessageBox](http://msdn.microsoft.com/library/windows/desktop/ms645505) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] documentation.  
  
### Remarks  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is useful both during development and as an easy way to display an error or warning message to the user.  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComCompositeControl Class](../vs140/ccomcompositecontrol-class.md)