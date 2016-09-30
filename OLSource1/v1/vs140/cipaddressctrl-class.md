---
title: "CIPAddressCtrl Class"
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
  - "CIPAddressCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IP address control"
  - "Internet address edit box"
  - "CIPAddressCtrl class"
  - "Internet protocol address box"
  - "common controls, Internet Explorer 4.0"
  - "Internet Explorer 4.0 common controls"
ms.assetid: 9764d2f4-cb14-4ba8-b799-7f57a55a47c6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CIPAddressCtrl Class
Provides the functionality of the Windows common IP Address control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CIPAddressCtrl::CIPAddressCtrl](#cipaddressctrl__cipaddressctrl)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CIPAddressCtrl::ClearAddress](#cipaddressctrl__clearaddress)|Clears the contents of the IP Address Control.|  
|[CIPAddressCtrl::Create](#cipaddressctrl__create)|Creates an IP Address Control and attaches it to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[CIPAddressCtrl::CreateEx](#cipaddressctrl__createex)|Creates an IP Address control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[CIPAddressCtrl::GetAddress](#cipaddressctrl__getaddress)|Retrieves the address values for all four fields in the IP Address Control.|  
|[CIPAddressCtrl::IsBlank](#cipaddressctrl__isblank)|Determines if all fields in the IP Address Control are empty.|  
|[CIPAddressCtrl::SetAddress](#cipaddressctrl__setaddress)|Sets the address values for all four fields in the IP Address Control.|  
|[CIPAddressCtrl::SetFieldFocus](#cipaddressctrl__setfieldfocus)|Sets the keyboard focus to the specified field in the IP Address Control.|  
|[CIPAddressCtrl::SetFieldRange](#cipaddressctrl__setfieldrange)|Sets the range in the specified field in the IP Address Control.|  
  
## Remarks  
 An IP Address control, a control similar to an edit control, allows you to enter and manipulate a numerical address in Internet Protocol (IP) format.  
  
 This control (and therefore the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class) is available only to programs running under Microsoft Internet Explorer 4.0 and later. They will also be available under future versions of Windows and Windows NT.  
  
 For more general information about the IP Address Control, see                 [IP Address Controls](http://msdn.microsoft.com/library/windows/desktop/bb761372) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="cipaddressctrl__cipaddressctrl">\</a>  CIPAddressCtrl::CIPAddressCtrl  
 Creates a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cipaddressctrl__clearaddress">\</a>  CIPAddressCtrl::ClearAddress  
 Clears the contents of the IP Address Control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 This member function implements the behavior of the Win32 message                         [IPM_CLEARADDRESS](http://msdn.microsoft.com/library/windows/desktop/bb761377), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cipaddressctrl__create">\</a>  CIPAddressCtrl::Create  
 Creates an IP Address Control and attaches it to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The IP Address control's style. Apply a combination of window styles. You must include the **WS_CHILD** style because the control must be a child window. See                                 [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the                                [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of windows styles.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A reference to the IP Address Control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A pointer to the IP Address Control's parent window. It must not be **NULL.**  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The IP Address Control's ID.  
  
### Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object in two steps.  
  
1.  Call the constructor, which creates the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
2.  Call **Create**, which creates the IP Address Control.  
  
 If you want to use extended windows styles with your control, call [CreateEx](#cipaddressctrl__createex) instead of **Create**.  
  
##  \<a name="cipaddressctrl__createex">\</a>  CIPAddressCtrl::CreateEx  
 Call this function to create a control (a child window) and associate it with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The IP Address control's style. Apply a combination of window styles. You must include the **WS_CHILD** style because the control must be a child window. See                                 [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the                                [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of windows styles.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> instead of [Create](#cipaddressctrl__create) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="cipaddressctrl__getaddress">\</a>  CIPAddressCtrl::GetAddress  
 Retrieves the address values for all four fields in the IP Address Control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A reference to the field 0 value from a packed IP address.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A reference to the field 1 value from a packed IP address.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A reference to the field 2 value from a packed IP address.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A reference to the field 3 value from a packed IP address.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A reference to the address of a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> value that receives the IP address. See **Remarks** for a table that shows how <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is filled.  
  
### Return Value  
 The number of non-blank fields in the IP Address Control.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [IPM_GETADDRESS](http://msdn.microsoft.com/library/windows/desktop/bb761378), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In the first prototype above, the numbers in fields 0 through 3 of the control, read left to right respectively, populate the four parameters. In the second prototype above, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is populated as follows.  
  
|Field|Bits containing the field value|  
|-----------|-------------------------------------|  
|0|24 through 31|  
|1|16 through 23|  
|2|8 through 15|  
|3|0 through 7|  
  
##  \<a name="cipaddressctrl__isblank">\</a>  CIPAddressCtrl::IsBlank  
 Determines if all fields in the IP Address Control are empty.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if all of the IP Address Control fields are empty; otherwise 0.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [IPM_ISBLANK](http://msdn.microsoft.com/library/windows/desktop/bb761379), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cipaddressctrl__setaddress">\</a>  CIPAddressCtrl::SetAddress  
 Sets the address values for all four fields in the IP Address Control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The field 0 value from a packed IP address.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The field 1 value from a packed IP address.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The field 2 value from a packed IP address.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The field 3 value from a packed IP address.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> value that contains the new IP address. See **Remarks** for a table that shows how the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> value is filled.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [IPM_SETADDRESS](http://msdn.microsoft.com/library/windows/desktop/bb761380), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In the first prototype above, the numbers in fields 0 through 3 of the control, read left to right respectively, populate the four parameters. In the second prototype above, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is populated as follows.  
  
|Field|Bits containing the field value|  
|-----------|-------------------------------------|  
|0|24 through 31|  
|1|16 through 23|  
|2|8 through 15|  
|3|0 through 7|  
  
##  \<a name="cipaddressctrl__setfieldfocus">\</a>  CIPAddressCtrl::SetFieldFocus  
 Sets the keyboard focus to the specified field in the IP Address Control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Zero-based field index to which the focus should be set. If this value is greater than the number of fields, focus is set to the first blank field. If all fields are non-blank, focus is set to the first field.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [IPM_SETFOCUS](http://msdn.microsoft.com/library/windows/desktop/bb761381), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cipaddressctrl__setfieldrange">\</a>  CIPAddressCtrl::SetFieldRange  
 Sets the range in the specified field in the IP Address Control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Zero-based field index to which the range will be applied.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A reference to an integer receiving the lower limit of the specified field in this IP Address Control.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A reference to an integer receiving the upper limit of the specified field in this IP Address Control.  
  
### Remarks  
 This member function implements the behavior of the Win32 message                         [IPM_SETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761382), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Use the two parameters, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, to indicate the lower and upper limits of the field, instead of the                         *wRange* parameter used with the Win32 message.  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)