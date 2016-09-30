---
title: "CAxWindow2T Class"
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
  - "ATL::CAxWindow2T<TBase>"
  - "ATL::CAxWindow2T"
  - "CAxWindow2T"
  - "ATL.CAxWindow2T<TBase>"
  - "ATL.CAxWindow2T"
  - "CAxWindow2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAxWindow2 class"
ms.assetid: b87bc943-7991-4537-b902-2138d7f4d837
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow2T Class
This class provides methods for manipulating a window that hosts an ActiveX control, and also has support for hosting licensed ActiveX controls.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TBase*  
 The class from which <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> derives.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAxWindow2T::CAxWindow2T](../vs140/caxwindow2t--caxwindow2t.md)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAxWindow2T::Create](../vs140/caxwindow2t--create.md)|Creates a host window.|  
|[CAxWindow2T::CreateControlLic](../vs140/caxwindow2t--createcontrollic.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window.|  
|[CAxWindow2T::CreateControlLicEx](../vs140/caxwindow2t--createcontrollicex.md)|Creates a licensed ActiveX control, initializes it, hosts it in the specified window, and retrieves an interface pointer (or pointers) from the control.|  
|[CAxWindow2T::GetWndClassName](../vs140/caxwindow2t--getwndclassname.md)|Static method that retrieves the name of the window class.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CAxWindow2T::operator =](../vs140/caxwindow2t--operator-=.md)|Assigns an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to an existing <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> provides methods for manipulating a window that hosts an ActiveX control. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> also has support for hosting licensed ActiveX controls. The hosting is provided by "                **AtlAxWinLic80**", which is wrapped by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 Class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is implemented as a specialization of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class. This specialization is declared as:  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> members are documented under [CAxWindow](../vs140/caxwindow-class.md).  
  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses the members of this class.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="caxwindow2t__caxwindow2t">\</a>  CAxWindow2T::CAxWindow2T  
 Constructs a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A handle of an existing window.  
  
##  \<a name="caxwindow2t__create">\</a>  CAxWindow2T::Create  
 Creates a host window.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> calls [CWindow::Create](../vs140/cwindow--create.md) with the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter set to the window class that provides control hosting (                        **AtlAxWinLic80**).  
  
 See <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> for a description of the parameters and return value.  
  
 **Note** If 0 is used as the value for the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter, it must be specified as 0U (the default value) to avoid a compiler error.  
  
### Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
##  \<a name="caxwindow2t__createcontrollic">\</a>  CAxWindow2T::CreateControlLic  
 Creates a licensed ActiveX control, initializes it, and hosts it in the specified window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The license key for the control; NULL if creating a nonlicensed control.  
  
### Remarks  
 See [CAxWindow::CreateControl](../vs140/caxwindow--createcontrol.md) for a description of the remaining parameters and return value.  
  
### Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="caxwindow2t__createcontrollicex">\</a>  CAxWindow2T::CreateControlLicEx  
 Creates a licensed ActiveX control, initializes it, hosts it in the specified window, and retrieves an interface pointer (or pointers) from the control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The license key for the control; NULL if creating a nonlicensed control.  
  
### Remarks  
 See [CAxWindow::CreateControlEx](../vs140/caxwindow--createcontrolex.md) for a description of the remaining parameters and return value.  
  
### Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
##  \<a name="caxwindow2t__getwndclassname">\</a>  CAxWindow2T::GetWndClassName  
 Retrieves the name of the window class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a string containing the name of the window class (                        **AtlAxWinLic80**) that can host licensed and nonlicensed ActiveX controls.  
  
##  \<a name="caxwindow2t__operator__eq">\</a>  CAxWindow2T::operator =  
 Assigns an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to an existing <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A handle of an existing window.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Control Containment FAQ](../vs140/atl-control-containment-faq.md)