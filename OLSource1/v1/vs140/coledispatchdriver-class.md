---
title: "COleDispatchDriver Class"
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
  - "COleDispatchDriver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class"
  - "Automation clients, implementing Automation"
  - "OLE dispatch interface"
ms.assetid: 3ed98daf-cdc7-4374-8a0c-cf695a8d3657
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver Class
Implements the client side of OLE automation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::COleDispatchDriver](#coledispatchdriver__coledispatchdriver)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch)|Attaches an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> connection to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch)|Creates an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> connection and attaches it to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|[COleDispatchDriver::DetachDispatch](#coledispatchdriver__detachdispatch)|Detaches an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> connection, without releasing it.|  
|[COleDispatchDriver::GetProperty](#coledispatchdriver__getproperty)|Gets an automation property.|  
|[COleDispatchDriver::InvokeHelper](#coledispatchdriver__invokehelper)|Helper for calling automation methods.|  
|[COleDispatchDriver::ReleaseDispatch](#coledispatchdriver__releasedispatch)|Releases an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> connection.|  
|[COleDispatchDriver::SetProperty](#coledispatchdriver__setproperty)|Sets an automation property.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::operator =](#coledispatchdriver__operator__eq)|Copies the source value into the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[COleDispatchDriver::operator LPDISPATCH](#coledispatchdriver__operator_lpdispatch)|Accesses the underlying <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> pointer.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleDispatchDriver::m_bAutoRelease](#coledispatchdriver__m_bautorelease)|Specifies whether to release the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> during <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or object destruction.|  
|[COleDispatchDriver::m_lpDispatch](#coledispatchdriver__m_lpdispatch)|Indicates the pointer to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> interface attached to this <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
  
## Remarks  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> does not have a base class.  
  
 OLE dispatch interfaces provide access to an object's methods and properties. Member functions of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> attach, detach, create, and release a dispatch connection of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. Other member functions use variable argument lists to simplify calling **IDispatch::Invoke**.  
  
 This class can be used directly, but it is generally used only by classes created by the Add Class wizard. When you create new C++ classes by importing a type library, the new classes are derived from <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 For more information on using <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, see the following articles:  
  
-   [Automation Clients](../vs140/automation-clients.md)  
  
-   [Automation Servers](../vs140/automation-servers.md)  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="coledispatchdriver__attachdispatch">\</a>  COleDispatchDriver::AttachDispatch  
 Call the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> member function to attach an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> pointer to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Pointer to an OLE <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object to be attached to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies whether the dispatch is to be released when this object goes out of scope.  
  
### Remarks  
 This function releases any <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> pointer that is already attached to the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCOleContainer#3](../vs140/codesnippet/CPP/coledispatchdriver-class_1.cpp)]  
  
##  \<a name="coledispatchdriver__coledispatchdriver">\</a>  COleDispatchDriver::COleDispatchDriver  
 Constructs a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Pointer to an OLE <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object to be attached to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies whether the dispatch is to be released when this object goes out of scope.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Reference to an existing <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The form <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, **BOOL**<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> = **TRUE**) connects the [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) interface.  
  
 The form <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>( **const**<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>& <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>) copies an existing <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object and increments the reference count.  
  
 The form <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>( ) creates a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object but does not connect the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> interface. Before using <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>( ) without arguments, you should connect an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to it using either [COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch) or [COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch). For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch).  
  
##  \<a name="coledispatchdriver__createdispatch">\</a>  COleDispatchDriver::CreateDispatch  
 Creates an [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) interface object and attaches it to the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Class ID of the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> connection object to be created.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Pointer to an OLE exception object, which will hold the status code resulting from the creation.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Pointer to the programmatic identifier, such as "Excel.Document.5", of the automation object for which the dispatch object is to be created.  
  
### Return Value  
 Nonzero on success; otherwise 0.  
  
### Example  
 [!code[NVC_MFCOleContainer#4](../vs140/codesnippet/CPP/coledispatchdriver-class_2.cpp)]  
  
##  \<a name="coledispatchdriver__detachdispatch">\</a>  COleDispatchDriver::DetachDispatch  
 Detaches the current <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> connection from this object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the previously attached OLE <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is not released.  
  
 For more information about the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> type, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCOleContainer#5](../vs140/codesnippet/CPP/coledispatchdriver-class_3.cpp)]  
  
##  \<a name="coledispatchdriver__getproperty">\</a>  COleDispatchDriver::GetProperty  
 Gets the object property specified by <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Identifies the property to be retrieved.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Specifies the property to be retrieved. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](#coledispatchdriver__invokehelper).  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Address of the variable that will receive the property value. It must match the type specified by <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCOleContainer#6](../vs140/codesnippet/CPP/coledispatchdriver-class_4.cpp)]  
  
##  \<a name="coledispatchdriver__invokehelper">\</a>  COleDispatchDriver::InvokeHelper  
 Calls the object method or property specified by <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, in the context specified by <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Identifies the method or property to be invoked.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Flags describing the context of the call to **IDispatch::Invoke**. . For a list of possible values, see the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> parameter in                                  [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Specifies the type of the return value. For possible values, see the Remarks section.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Address of the variable that will receive the property value or return value. It must match the type specified by <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
 *...*  
 Variable list of parameters, of types specified in <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> parameter specifies the types of the parameters passed to the method or property. The variable list of arguments is represented by **...** in the syntax declaration.  
  
 Possible values for the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> argument are taken from the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> enumeration. Possible values are as follows:  
  
|Symbol|Return Type|  
|------------|-----------------|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|**short**|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|**double**|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|**CY**|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|**DATE**|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|  
|**VT_DISPATCH**|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> argument is a space-separated list of **VTS_** constants. One or more of these values, separated by spaces (not commas), specifies the function's parameter list. Possible values are listed with the [EVENT_CUSTOM](../vs140/event_custom.md) macro.  
  
 This function converts the parameters to **VARIANTARG** values, then invokes the                         [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) method. If the call to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> fails, this function will throw an exception. If the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> (status code) returned by **IDispatch::Invoke** is <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, this function throws a [COleException](../vs140/coleexception-class.md) object; otherwise it throws a [COleDispatchException](../vs140/coledispatchexception-class.md).  
  
 For more information, see [VARIANTARG](assetId:///e305240e-9e11-4006-98cc-26f4932d2118),                         [Implementing the IDispatch Interface](http://msdn.microsoft.com/library/windows/desktop/ms221037\(v=vs.85\).aspx),                         [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx), and                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [COleDispatchDriver::CreateDispatch](#coledispatchdriver__createdispatch).  
  
##  \<a name="coledispatchdriver__m_bautorelease">\</a>  COleDispatchDriver::m_bAutoRelease  
 If **TRUE**, the COM object accessed by [m_lpDispatch](#coledispatchdriver__m_lpdispatch) will be automatically released when [ReleaseDispatch](#coledispatchdriver__releasedispatch) is called or when this <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object is destroyed.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 By default, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> is set to **TRUE** in the constructor.  
  
 For more information on releasing COM objects, see                         [Implementing Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms693431) and                         [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCOleContainer#9](../vs140/codesnippet/CPP/coledispatchdriver-class_5.cpp)]  
  
##  \<a name="coledispatchdriver__m_lpdispatch">\</a>  COleDispatchDriver::m_lpDispatch  
 The pointer to the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> interface attached to this <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> data member is a public variable of type <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>.  
  
 For more information, see [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
  See the example for [COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch).  
  
##  \<a name="coledispatchdriver__operator__eq">\</a>  COleDispatchDriver::operator =  
 Copies the source value into the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A pointer to an existing <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
##  \<a name="coledispatchdriver__operator_lpdispatch">\</a>  COleDispatchDriver::operator LPDISPATCH  
 Accesses the underlying <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> pointer of the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFCOleContainer#8](../vs140/codesnippet/CPP/coledispatchdriver-class_6.cpp)]  
  
##  \<a name="coledispatchdriver__releasedispatch">\</a>  COleDispatchDriver::ReleaseDispatch  
 Releases the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> connection. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945)  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 If auto release has been set for this connection, this function calls **IDispatch::Release** before releasing the interface.  
  
### Example  
  See the example for [COleDispatchDriver::AttachDispatch](#coledispatchdriver__attachdispatch).  
  
##  \<a name="coledispatchdriver__setproperty">\</a>  COleDispatchDriver::SetProperty  
 Sets the OLE object property specified by <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Identifies the property to be set.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Specifies the type of the property to be set. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](#coledispatchdriver__invokehelper).  
  
 *...*  
 A single parameter of the type specified by <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCOleContainer#7](../vs140/codesnippet/CPP/coledispatchdriver-class_7.cpp)]  
  
## See Also  
 [MFC Sample CALCDRIV](../vs140/visual-c---samples.md)   
 [MFC Sample ACDUAL](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget](../vs140/ccmdtarget-class.md)