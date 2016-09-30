---
title: "CAxWindow Class"
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
  - "CAxWindowT"
  - "CAxWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAxWindow class"
  - "ATL, hosting ActiveX controls"
ms.assetid: 85e79261-43e4-4770-bde0-1ff87f222b0f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow Class
This class provides methods for manipulating a window hosting an ActiveX control.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AttachControl](../vs140/caxwindow--attachcontrol.md)|Attaches an existing ActiveX control to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[CAxWindow](../vs140/caxwindow--caxwindow.md)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[CreateControl](../vs140/caxwindow--createcontrol.md)|Creates an ActiveX control, initializes it, and hosts it in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> window.|  
|[CreateControlEx](../vs140/caxwindow--createcontrolex.md)|Creates an ActiveX control and retrieves an interface pointer (or pointers) from the control.|  
|[GetWndClassName](../vs140/caxwindow--getwndclassname.md)|(Static) Retrieves the predefined class name of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[QueryControl](../vs140/caxwindow--querycontrol.md)|Retrieves the **IUnknown** of the hosted ActiveX control.|  
|[QueryHost](../vs140/caxwindow--queryhost.md)|Retrieves the **IUnknown** pointer of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[SetExternalDispatch](../vs140/caxwindow--setexternaldispatch.md)|Sets the external dispatch interface used by the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[SetExternalUIHandler](../vs140/caxwindow--setexternaluihandler.md)|Sets the external **IDocHostUIHandler** interface used by the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/caxwindow--operator-=.md)|Assigns an **HWND** to an existing **CAxWindow** object.|  
  
## Remarks  
 This class provides methods for manipulating a window that hosts an ActiveX control. The hosting is provided by "                **AtlAxWin80"**, which is wrapped by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is implemented as a specialization of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class. This specialization is declared as:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 If you need to change the base class, you can use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and specify the new base class as a template argument.  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="caxwindow__attachcontrol">\</a>  CAxWindow::AttachControl  
 Creates a new host object if one isn't already present and attaches the specified control to the host.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 [in] A pointer to the **IUnknown** of the control.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 [out] A pointer to the **IUnknown** of the host (the **AxWin** object).  
  
### Return Value  
 A standard <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The control object being attached must be correctly initialized before calling <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="caxwindow__caxwindow">\</a>  CAxWindow::CAxWindow  
 Constructs a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object using an existing window object handle.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A handle to an existing window object.  
  
##  \<a name="caxwindow__createcontrol">\</a>  CAxWindow::CreateControl  
 Creates an ActiveX control, initializes it, and hosts it in the specified window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to a string to create the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:\<HTML>\<BODY>This is a line of text\</BODY>\</HTML>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream. Only the ProgID and CLSID are supported in Windows Mobile platforms. Windows CE embedded platforms, other than Windows Mobile with support for CE IE support all types including ProgID, CLSID, URL, reference to active document, and fragment of HTML.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 [in] A pointer to a stream that is used to initialize the properties of the control. Can be **NULL**.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the **IUnknown** of the container. Can be **NULL**.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The resource ID of an HTML resource. The WebBrowser control will be created and loaded with the specified resource.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value.  
  
### Remarks  
 If the second version of this method is used, an HTML control is created and bound to the resource identified by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 This method gives you the same result as calling:  
  
 [!code[NVC_ATL_Windowing#42](../vs140/codesnippet/CPP/caxwindow-class_1.cpp)]  
  
 See [CAxWindow2T::CreateControlLic](../vs140/caxwindow2t--createcontrollic.md) to create, initialize, and host a licensed ActiveX control.  
  
### Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
##  \<a name="caxwindow__createcontrolex">\</a>  CAxWindow::CreateControlEx  
 Creates an ActiveX control, initializes it, and hosts it in the specified window.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to a string to create the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:\<HTML>\<BODY>This is a line of text\</BODY>\</HTML>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream. Only the ProgID and CLSID are supported in Windows Mobile platforms. Windows CE embedded platforms, other than Windows Mobile with support for CE IE support all types including ProgID, CLSID, URL, reference to active document, and fragment of HTML.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 [in] A pointer to a stream that is used to initialize the properties of the control. Can be **NULL**.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the **IUnknown** of the container. Can be **NULL**.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 [out] The address of a pointer that will receive the **IUnknown** of the control. Can be **NULL**.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 [in] The interface identifier of an outgoing interface on the contained object. Can be **IID_NULL**.  
  
 *punkSink*  
 [in] A pointer to the **IUnknown** interface of the sink object to be connected to the connection point on the contained object specified by <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 [in] The resource ID of an HTML resource. The WebBrowser control will be created and loaded with the specified resource.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> value.  
  
### Remarks  
 This method is similar to [CAxWindow::CreateControl](../vs140/caxwindow--createcontrol.md), but unlike that method, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> also allows you to receive an interface pointer to the newly created control and set up an event sink to receive events fired by the control.  
  
 See [CAxWindow2T::CreateControlLicEx](../vs140/caxwindow2t--createcontrollicex.md) to create, initialize, and host a licensed ActiveX control.  
  
### Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
##  \<a name="caxwindow__getwndclassname">\</a>  CAxWindow::GetWndClassName  
 Retrieves the name of the window class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a string containing the name of the window class that can host nonlicensed ActiveX controls.  
  
##  \<a name="caxwindow__operator__eq">\</a>  CAxWindow::operator =  
 Assigns an <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to an existing <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A handle to an existing window.  
  
### Return Value  
 Returns a reference to the current <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
##  \<a name="caxwindow__querycontrol">\</a>  CAxWindow::QueryControl  
 Retrieves the specified interface of the hosted control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 [in] Specifies the IID of the control's interface.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 [out] A pointer to the interface of the control. In the template version of this method, there is no need for a reference ID as long as a typed interface with an associated UUID is passed.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 [in] The interface that is being queried for.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> value.  
  
##  \<a name="caxwindow__queryhost">\</a>  CAxWindow::QueryHost  
 Returns the specified interface of the host.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 [in] Specifies the IID of the control's interface.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 [out] A pointer to the interface on the host. In the template version of this method, there is no need for a reference ID as long as a typed interface with an associated UUID is passed.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 [in] The interface that is being queried for.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The interface of the host allows access to the underlying functionality of the window-hosting code, implemented by **AxWin**.  
  
##  \<a name="caxwindow__setexternaldispatch">\</a>  CAxWindow::SetExternalDispatch  
 Sets the external dispatch interface for the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 [in] A pointer to an <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> interface.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> value.  
  
##  \<a name="caxwindow__setexternaluihandler">\</a>  CAxWindow::SetExternalUIHandler  
 Sets the external [IDocHostUIHandlerDispatch](../vs140/idochostuihandlerdispatch-interface.md) interface for the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pUIHandler*  
 [in] A pointer to an **IDocHostUIHandlerDispatch** interface.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The external <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> interface is used by controls that query the host's site for the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> interface. The WebBrowser control is one control that does this.  
  
## See Also  
 [ATLCON Sample](../vs140/visual-c---samples.md)   
 [CWindow Class](../vs140/cwindow-class.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Control Containment FAQ](../vs140/atl-control-containment-faq.md)