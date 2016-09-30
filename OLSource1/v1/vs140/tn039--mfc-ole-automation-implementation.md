---
title: "TN039: MFC-OLE Automation Implementation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "TN039: MFC/OLE Automation Implementation"
f1_keywords: 
  - "vc.mfc.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC, COM support"
  - "IDispatch interface"
  - "MFC, OLE DB and"
  - "TN039"
  - "Automation, MFC COM interface entry points"
ms.assetid: 765fa3e9-dd54-4f08-9ad2-26e0546ff8b6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN039: MFC-OLE Automation Implementation
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
## Overview of OLE IDispatch Interface  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface is the means by which applications expose methods and properties such that other applications such as Visual BASIC, or other languages, can make use of the application's features. The most important part of this interface is the **IDispatch::Invoke** function. MFC uses "dispatch maps" to implement **IDispatch::Invoke**. The dispatch map provides the MFC implementation information on the layout or "shape" of your <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived classes, such that it can directly manipulate the properties of the object, or call member functions within your object to satisfy **IDispatch::Invoke** requests.  
  
 For the most part, ClassWizard and MFC cooperate to hide most of the details of OLE automation from the application programmer. The programmer concentrates on the actual functionality to expose in the application and doesn't have to worry about the underlying plumbing.  
  
 There are cases, however, where it is necessary to understand what MFC is doing behind the scenes. This note will address how the framework assigns **DISPID**s to member functions and properties. Knowledge of the algorithm MFC uses for assigning **DISPID**s is only necessary when you need to know the IDs, such as when you create a "type library" for your application's objects.  
  
## MFC DISPID assignment  
 Although the end-user of automation (a Visual Basic user, for example), sees the actual names of the automation enabled properties and methods in their code (such as obj.ShowWindow), the implementation of **IDispatch::Invoke** does not receive the actual names. For optimization reasons, it receives a **DISPID**, which is a 32-bit "magic cookie" that describes the method or property that is to be accessed. These **DISPID** values are returned from the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> implementation through another method, called **IDispatch::GetIDsOfNames**. An automation client application will call <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> once for each member or property it intends to access, and cache them for later calls to **IDispatch::Invoke**. This way, the expensive string lookup is only done once per object use, instead of once per **IDispatch::Invoke** call.  
  
 MFC determines the **DISPID**s for each method and property based on two things:  
  
-   The distance from the top of the dispatch map (1 relative)  
  
-   The distance of the dispatch map from the most derived class (0 relative)  
  
 The **DISPID** is divided into two parts. The **LOWORD** of the **DISPID** contains the first component, the distance from the top of the dispatch map. The **HIWORD** contains the distance from the most derived class. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 As you can see, there are two classes, both of which expose OLE automation interfaces. One of these classes is derived from the other and thus leverages the base class's functionality, including the OLE automation part ("x" and "y" properties in this case).  
  
 MFC will generate **DISPID**s for class CDispPoint as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Since the properties are not in a base class, the **HIWORD** of the **DISPID** is always zero (the distance from the most derived class for CDispPoint is zero).  
  
 MFC will generate **DISPID**s for class CDisp3DPoint as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The Z property is given a **DISPID** with a zero **HIWORD** since it is defined in the class that is exposing the properties, CDisp3DPoint. Since the X and Y properties are defined in a base class, the **HIWORD** of the **DISPID** is 1, since the class in which these properties are defined is at a distance of one derivation from the most derived class.  
  
> [!NOTE]
>  The **LOWORD** is always determined by the position in the map, even if there exist entries in the map with explicit **DISPID** (see next section for information on the **_ID** versions of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> macros).  
  
## Advanced MFC Dispatch Map Features  
 There are a number of additional features that ClassWizard does not support with this release of Visual C++. ClassWizard supports <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> which define a method, member variable property, and get/set member function property, respectively. These capabilities are usually all that is needed to create most automation servers.  
  
 The following additional macros can be used when the ClassWizard supported macros are not adequate: <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## DISP_PROPERTY_NOTIFY — Macro Description  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Remarks  
  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Name of the class.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 External name of the property.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Name of the member variable in which the property is stored.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Name of member function to call when property is changed.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A value specifying the property's type.  
  
## Remarks  
 This macro is much like <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, except that it accepts an additional argument. The additional argument, *pfnAfterSet,* should be a member function that returns nothing and takes no parameters, 'void OnPropertyNotify()'. It will be called **after** the member variable has been modified.  
  
## DISP_PROPERTY_PARAM — Macro Description  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Remarks  
  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Name of the class.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 External name of the property.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Name of the member function used to get the property.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Name of the member function used to set the property.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A value specifying the property's type.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A string of space separated VTS_ for each parameter.  
  
## Remarks  
 Much like the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> macro, this macro defines a property accessed with separate Get and Set member functions. This macro, however, allows you to specify a parameter list for the property. This is useful for implementing properties that are indexed or parameterized in some other way. The parameters will always be placed first, followed by the new value for the property. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 would correspond to get and set member functions:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## DISP_XXXX_ID — Macro Descriptions  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Remarks  
  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Name of the class.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 External name of the property.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The fixed DISPID for the property or method.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Name of the member function used to get the property.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Name of the member function used to set the property.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The name of the member variable to map to the property  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A value specifying the property's type.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A string of space separated VTS_ for each parameter.  
  
## Remarks  
 These macros allow you to specify a **DISPID** instead of letting MFC automatically assign one. These advanced macros have the same names except that ID is appended to the macro name (e.g. **DISP_PROPERTY_ID**) and the ID is determined by the parameter specified just after the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter. See AFXDISP.H for more information on these macros. The **_ID** entries must be placed at the end of the dispatch map. They will affect the automatic **DISPID** generation in the same way as a non-**_ID** version of the macro would (the **DISPID**s are determined by position). For example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 MFC will generate DISPIDs for class CDisp3DPoint as follows:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifying a fixed **DISPID** is useful to maintain backward compatibility to a previously existing dispatch interface, or to implement certain system defined methods or properties (usually indicated by a negative **DISPID**, such as the **DISPID_NEWENUM** collection).  
  
#### Retrieving the IDispatch Interface for a COleClientItem  
 Many servers will support automation within their document objects, along with the OLE server functionality. In order to gain access to this automation interface, it is necessary to directly access the **COleClientItem::m_lpObject** member variable. The code below will retrieve the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> interface for an object derived from <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. You can include the code below in your application if you find this functionality necessary:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The dispatch interface returned from this function could then be used directly or attached to a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> for type-safe access. If you use it directly, make sure that you call its **Release** member when through with the pointer (the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> destructor does this by default).  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)