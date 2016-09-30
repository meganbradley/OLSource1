---
title: "CDataPathProperty Class"
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
  - "CDataPathProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActiveX controls [C++], asynchronous"
  - "OLE controls [C++], asynchronous"
  - "CDataPathProperty class"
  - "asynchronous controls [C++]"
ms.assetid: 1f96efdb-54e4-460b-862c-eba5d4103488
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty Class
Implements an OLE control property that can be loaded asynchronously.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDataPathProperty::CDataPathProperty](#cdatapathproperty__cdatapathproperty)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDataPathProperty::GetControl](#cdatapathproperty__getcontrol)|Retrieves the asynchronous OLE control associated with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[CDataPathProperty::GetPath](#cdatapathproperty__getpath)|Retrieves the pathname of the property.|  
|[CDataPathProperty::Open](#cdatapathproperty__open)|Initiates loading of the asynchronous property for the associated ActiveX (OLE) control.|  
|[CDataPathProperty::ResetData](#cdatapathproperty__resetdata)|Calls <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to notify the container that the control properties have changed.|  
|[CDataPathProperty::SetControl](#cdatapathproperty__setcontrol)|Sets the asynchronous ActiveX (OLE) control associated with the property.|  
|[CDataPathProperty::SetPath](#cdatapathproperty__setpath)|Sets the pathname of the property.|  
  
## Remarks  
 Asynchronous properties are loaded after synchronous initiation.  
  
 The class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is derived from **CAysncMonikerFile**. To implement asynchronous properties in your OLE controls, derive a class from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and override [OnDataAvailable](../vs140/casyncmonikerfile-class.md#casyncmonikerfile__ondataavailable).  
  
 For more information about how to use asynchronous monikers and ActiveX controls in Internet applications, see the following articles:  
  
-   [Internet First Steps: ActiveX Controls](../vs140/activex-controls-on-the-internet.md)  
  
-   [Internet First Steps: Asynchronous Monikers](../vs140/asynchronous-monikers-on-the-internet.md)  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CFile](../vs140/cfile-class.md)  
  
 [COleStreamFile](../vs140/colestreamfile-class.md)  
  
 [CMonikerFile](../vs140/cmonikerfile-class.md)  
  
 [CAsyncMonikerFile](../vs140/casyncmonikerfile-class.md)  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxctl.h  
  
##  \<a name="cdatapathproperty__cdatapathproperty">\</a>  CDataPathProperty::CDataPathProperty  
 Constructs a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to the OLE control object to be associated with this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The path, which may be absolute or relative, used to create an asynchronous moniker that references the actual absolute location of the property. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> uses URLs, not filenames. If you want a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object for a file, prepend <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to the path.  
  
### Remarks  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is used by **Open** and retrieved by derived classes. If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is **NULL**, the control used with **Open** should be set with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is **NULL**, you can pass in the path through **Open** or set it with <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="cdatapathproperty__getcontrol">\</a>  CDataPathProperty::GetControl  
 Call this member function to retrieve the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object associated with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the OLE control associated with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object. **NULL** if not control is associated.  
  
##  \<a name="cdatapathproperty__getpath">\</a>  CDataPathProperty::GetPath  
 Call this member function to retrieve the path, set when the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object was constructed, or specified in **Open**, or specified in a previous call to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns the pathname to the property itself. Can be empty if no path has been specified.  
  
##  \<a name="cdatapathproperty__open">\</a>  CDataPathProperty::Open  
 Call this member function to initiate loading of the asynchronous property for the associated control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to the OLE control object to be associated with this <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A pointer to a file exception. In the event of an error, will be set to the cause.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The path, which may be absolute or relative, used to create an asynchronous moniker that references the actual absolute location of the property. <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> uses URLs, not filenames. If you want a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object for a file, prepend <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to the path.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The function attempts to obtain the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> interface from the control.  
  
 Before calling **Open** without a path, the value for the property's path must be set. This can be done when the object is constructed, or by calling the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> member function.  
  
 Before calling **Open** without a control, an ActiveX control (formerly known as an OLE control) can be associated with the object. This can be done when the object is constructed, or by calling <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 All overloads of [CAsyncMonikerFile::Open](../vs140/casyncmonikerfile-class.md#casyncmonikerfile__open) are also available from <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="cdatapathproperty__resetdata">\</a>  CDataPathProperty::ResetData  
 Call this function to get <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to notify the container that the control properties have changed, and all the information loaded asynchronously is no longer useful.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 Opening should be restarted. Derived classes can override this function for different defaults.  
  
##  \<a name="cdatapathproperty__setcontrol">\</a>  CDataPathProperty::SetControl  
 Call this member function to associate an asynchronous OLE control with the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to the asynchronous OLE control to be associated with the property.  
  
##  \<a name="cdatapathproperty__setpath">\</a>  CDataPathProperty::SetPath  
 Call this member function to set the pathname of the property.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A path, which may be absolute or relative, to the property being loaded asynchronously. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> uses URLs, not filenames. If you want a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object for a file, prepend <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to the path.  
  
## See Also  
 [MFC Sample Image](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncMonikerFile](../vs140/casyncmonikerfile-class.md)