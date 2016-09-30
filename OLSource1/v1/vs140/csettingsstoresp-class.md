---
title: "CSettingsStoreSP Class"
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
  - "CSettingsStoreSP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSettingsStoreSP class"
ms.assetid: bcd37f40-cfd4-4d17-a5ce-3bfabe995dcc
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStoreSP Class
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class is a helper class that you can use to create instances of the [CSettingsStore Class](../vs140/csettingsstore-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSettingsStoreSP::CSettingsStoreSP](#csettingsstoresp__csettingsstoresp)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSettingsStoreSP::Create](#csettingsstoresp__create)|Creates an instance of a class that is derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[CSettingsStoreSP::SetRuntimeClass](#csettingsstoresp__setruntimeclass)|Sets the runtime class. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method uses the runtime class to determine what class of objects to create.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Custom user data that is stored in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. You supply this data in the constructor of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-derived object that the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method creates.|  
  
## Remarks  
 You can use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class to redirect all MFC registry operations to other locations, such as an XML file or a database. To do this, follow these steps:  
  
1.  Create a class (such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) and derive it from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
2.  Use [DECLARE_DYNCREATE](../vs140/declare_dyncreate.md) and [IMPLEMENT_DYNCREATE](../vs140/implement_dyncreate.md) macros with your custom <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class to enable dynamic creation.  
  
3.  Override the virtual functions and implement the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> functions in your custom class. Implement any other functionality to read and write data to your desired location.  
  
4.  In your application, call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and pass in a pointer to the [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md) obtained from your class.  
  
 Whenever the framework would typically access the registry, it will now dynamically instantiate your custom class and use it to read or write data.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> uses a global static variable. Therefore, only one custom store is available at a time.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
##  \<a name="csettingsstoresp__create">\</a>  CSettingsStoreSP::Create  
 Creates a new instance of an object that is derived from the [CSettingsStore Class](../vs140/csettingsstore-class.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object is created in administrator mode.  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A Boolean parameter that determines whether a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object is created for read-only access.  
  
### Return Value  
 A reference to the newly created <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
### Remarks  
 You can use the method [CSettingsStoreSP::SetRuntimeClass](#csettingsstoresp__setruntimeclass) to determine what type of object <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> will create. By default, this method creates a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
 If you create a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object in administrator mode, the default location for all registry access is HKEY_LOCAL_MACHINE. Otherwise, the default location for all registry access is HKEY_CURRENT_USER.  
  
 If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the application must have administration rights. Otherwise, it will fail when it tries to access the registry.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_RibbonApp#33](../vs140/codesnippet/CPP/csettingsstoresp-class_1.cpp)]  
  
##  \<a name="csettingsstoresp__csettingsstoresp">\</a>  CSettingsStoreSP::CSettingsStoreSP  
 Constructs a [CSettingsStoreSP Class](../vs140/csettingsstoresp-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 User-defined data that the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object stores.  
  
### Remarks  
 The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object stores the data from <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> in the protected member variable <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
##  \<a name="csettingsstoresp__setruntimeclass">\</a>  CSettingsStoreSP::SetRuntimeClass  
 Sets the runtime class. The method [CSettingsStoreSP::Create](#csettingsstoresp__create) uses the runtime class to determine what type of object to create.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to the runtime class information for a class derived from the [CSettingsStore Class](../vs140/csettingsstore-class.md).  
  
### Return Value  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> if the class identified by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is not derived from <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can use the [CSettingsStoreSP Class](../vs140/csettingsstoresp-class.md) to derive classes from <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. Use the method <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if you want to create objects of a custom class that is derived from <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSettingsStore Class](../vs140/csettingsstore-class.md)