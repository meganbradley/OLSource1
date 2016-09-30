---
title: "CComCompositeControl Class"
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
  - "CComCompositeControl"
  - "ATL::CComCompositeControl"
  - "ATL.CComCompositeControl<T>"
  - "ATL.CComCompositeControl"
  - "ATL::CComCompositeControl<T>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComCompositeControl class"
  - "composite controls, CComCompositeControl class"
ms.assetid: 1304b931-27e8-4fbc-be8e-bb226ad887fb
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCompositeControl Class
This class provides the methods required to implement a composite control.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Your class, derived from [CComObjectRoot](../vs140/ccomobjectroot-class.md) or [CComObjectRootEx](../vs140/ccomobjectrootex-class.md), as well as from any other interfaces you want to support for your composite control.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComCompositeControl::CComCompositeControl](../vs140/ccomcompositecontrol--ccomcompositecontrol.md)|The constructor.|  
|[CComCompositeControl::~CComCompositeControl](../vs140/ccomcompositecontrol--~ccomcompositecontrol.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCompositeControl::AdviseSinkMap](../vs140/ccomcompositecontrol--advisesinkmap.md)|Call this method to advise or unadvise all controls hosted by the composite control.|  
|[CComCompositeControl::CalcExtent](../vs140/ccomcompositecontrol--calcextent.md)|Call this method to calculate the size in **HIMETRIC** units of the dialog resource used to host the composite control.|  
|[CComCompositeControl::Create](../vs140/ccomcompositecontrol--create.md)|This method is called to create the control window for the composite control.|  
|[CComCompositeControl::CreateControlWindow](../vs140/ccomcompositecontrol--createcontrolwindow.md)|Call this method to create the control window and advise any hosted control.|  
|[CComCompositeControl::SetBackgroundColorFromAmbient](../vs140/ccomcompositecontrol--setbackgroundcolorfromambient.md)|Call this method to set the background color of the composite control using the container's background color.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComCompositeControl::m_hbrBackground](../vs140/ccomcompositecontrol--m_hbrbackground.md)|The background brush.|  
|[CComCompositeControl::m_hWndFocus](../vs140/ccomcompositecontrol--m_hwndfocus.md)|The handle of the window that currently has focus.|  
  
## Remarks  
 Classes derived from class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> inherit the functionality of an ActiveX composite control. ActiveX controls derived from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are hosted by a standard dialog box. These types of controls are called composite controls because they are able to host other controls (native Windows controls and ActiveX controls).  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> identifies the dialog resource to use in creating the composite control by looking for an enumerated data member in the child class. The member IDD of this child class is set to the resource ID of the dialog resource that will be used as the control's window. The following is an example of the data member that the class derived from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> should contain to identify the dialog resource to be used for the control's window:  
  
 [!code[NVC_ATL_COM#13](../vs140/codesnippet/CPP/ccomcompositecontrol-class_1.h)]  
  
> [!NOTE]
>  Composite controls are always windowed controls, although they can contain windowless controls.  
  
 A control implemented by a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>-derived class has default tabbing behavior built in. When the control receives focus by being tabbed to in a containing application, successively pressing the TAB key will cause the focus to be cycled through all of the composite control's contained controls, then out of the composite control and on to the next item in the tab order of the container. The tab order of the hosted controls is determined by the dialog resource and determines the order in which tabbing will occur.  
  
> [!NOTE]
>  In order for accelerators to work properly with a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, it is necessary to load an accelerator table as the control is created, pass the handle and number of accelerators back into [IOleControlImpl::GetControlInfo](../vs140/iolecontrolimpl--getcontrolinfo.md), and finally destroy the table when the control is released.  
  
## Example  
 [!code[NVC_ATL_COM#14](../vs140/codesnippet/CPP/ccomcompositecontrol-class_2.h)]  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 [CComControlBase](../vs140/ccomcontrolbase-class.md)  
  
 [CComControl](../vs140/ccomcontrol-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="ccomcompositecontrol__advisesinkmap">\</a>  CComCompositeControl::AdviseSinkMap  
 Call this method to advise or unadvise all controls hosted by the composite control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 True if all controls are to be advised; otherwise false.  
  
### Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 All controls in the event sink map were connected or disconnected from their event source successfully.  
  
 **E_FAIL**  
 Not all controls in the event sink map could be connected or disconnected from their event source successfully.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 This error usually indicates a problem with an entry in the control's event sink map or a problem with a template argument used in an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> base class.  
  
 **CONNECT_E_ADVISELIMIT**  
 The connection point has already reached its limit of connections and cannot accept any more.  
  
 **CONNECT_E_CANNOTCONNECT**  
 The sink does not support the interface required by this connection point.  
  
 **CONNECT_E_NOCONNECTION**  
 The cookie value does not represent a valid connection. This error usually indicates a problem with an entry in the control's event sink map or a problem with a template argument used in an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> base class.  
  
### Remarks  
 The base implementation of this method searches through the entries in the event sink map. It then advises or unadvises the connection points to the COM objects described by the event sink map's sink entries. This member method also relies on the fact that the derived class inherits from one instance of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for every control in the sink map that is to be advised or unadvised.  
  
##  \<a name="ccomcompositecontrol__calcextent">\</a>  CComCompositeControl::CalcExtent  
 Call this method to calculate the size in **HIMETRIC** units of the dialog resource used to host the composite control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A reference to a **SIZE** structure to be filled by this method.  
  
### Return Value  
 TRUE if the control is hosted by a dialog box; otherwise FALSE.  
  
### Remarks  
 The size is returned in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> parameter.  
  
##  \<a name="ccomcompositecontrol__create">\</a>  CComCompositeControl::Create  
 This method is called to create the control window for the composite control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A handle to the parent window of the control.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Reserved.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Data to be passed to the control during control creation. The data passed as <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> will show up as the **LPARAM** parameter of the [WM_INITDIALOG](http://msdn.microsoft.com/library/windows/desktop/ms645428) message, which will be sent to the composite control when it gets created.  
  
### Return Value  
 A handle to the newly created composite control dialog box.  
  
### Remarks  
 This method is usually called during in-place activation of the control.  
  
##  \<a name="ccomcompositecontrol__ccomcompositecontrol">\</a>  CComCompositeControl::CComCompositeControl  
 The constructor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Initializes the [CComCompositeControl::m_hbrBackground](../vs140/ccomcompositecontrol--m_hbrbackground.md) and [CComCompositeControl::m_hWndFocus](../vs140/ccomcompositecontrol--m_hwndfocus.md) data members to NULL.  
  
##  \<a name="ccomcompositecontrol___dtorccomcompositecontrol">\</a>  CComCompositeControl::~CComCompositeControl  
 The destructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Deletes the background object, if it exists.  
  
##  \<a name="ccomcompositecontrol__createcontrolwindow">\</a>  CComCompositeControl::CreateControlWindow  
 Call this method to create the control window and advise any hosted controls.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A handle to the parent window of the control.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The position rectangle of the composite control in client coordinates relative to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns a handle to the newly created composite control dialog box.  
  
### Remarks  
 This method calls [CComCompositeControl::Create](../vs140/ccomcompositecontrol--create.md) and [CComCompositeControl::AdviseSinkMap](../vs140/ccomcompositecontrol--advisesinkmap.md).  
  
##  \<a name="ccomcompositecontrol__m_hbrbackground">\</a>  CComCompositeControl::m_hbrBackground  
 The background brush.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="ccomcompositecontrol__m_hwndfocus">\</a>  CComCompositeControl::m_hWndFocus  
 The handle of the window that currently has focus.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="ccomcompositecontrol__setbackgroundcolorfromambient">\</a>  CComCompositeControl::SetBackgroundColorFromAmbient  
 Call this method to set the background color of the composite control using the container's background color.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [Class Overview](../vs140/atl-class-overview.md)