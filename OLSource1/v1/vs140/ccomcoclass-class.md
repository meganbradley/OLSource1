---
title: "CComCoClass Class"
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
  - "CComCoClass"
  - "ATL.CComCoClass"
  - "ATL::CComCoClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComCoClass class"
  - "aggregation [C++], aggregation models"
ms.assetid: 67cfefa4-8df9-47fa-ad58-2d1a1ae25762
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCoClass Class
This class provides methods for creating instances of a class, and obtaining its properties.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 *pclsid*  
 A pointer to the CLSID of the object.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComCoClass::CreateInstance](../vs140/ccomcoclass--createinstance.md)|(Static) Creates an instance of the class and queries for an interface.|  
|[CComCoClass::Error](../vs140/ccomcoclass--error.md)|(Static) Returns rich error information to the client.|  
|[CComCoClass::GetObjectCLSID](../vs140/ccomcoclass--getobjectclsid.md)|(Static) Returns the object's class identifier.|  
|[CComCoClass::GetObjectDescription](../vs140/ccomcoclass--getobjectdescription.md)|(Static) Override to return the object's description.|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> provides methods for retrieving an object's CLSID, setting error information, and creating instances of the class. Any class registered in the [object map](assetId:///b57619cc-534f-4b8f-bfd4-0c12f937202f) should be derived from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> also defines the default class factory and aggregation model for your object. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> uses the following two macros:  
  
-   [DECLARE_CLASSFACTORY](../vs140/declare_classfactory.md) Declares the class factory to be [CComClassFactory](../vs140/ccomclassfactory-class.md).  
  
-   [DECLARE_AGGREGATABLE](../vs140/declare_aggregatable.md) Declares that your object can be aggregated.  
  
 You can override either of these defaults by specifying another macro in your class definition. For example, to use [CComClassFactory2](../vs140/ccomclassfactory2-class.md) instead of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, specify the [DECLARE_CLASSFACTORY2](../vs140/declare_classfactory2.md) macro:  
  
 [!code[NVC_ATL_COM#2](../vs140/codesnippet/CPP/ccomcoclass-class_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomcoclass__createinstance">\</a>  CComCoClass::CreateInstance  
 Use these <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> functions to create an instance of a COM object and retrieve an interface pointer without using the COM API.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The COM interface that should be returned via <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 *punkOuter*  
 [in] The outer unknown or controlling unknown of the aggregate.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [out] The address of a pointer variable that receives the requested interface pointer if creation succeeds.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value. See [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of possible return values.  
  
### Remarks  
 Use the first overload of this function for typical object creation; use the second overload when you need to aggregate the object being created.  
  
 The ATL class implementing the required COM object (that is, the class used as the first template parameter to [CComCoClass](../vs140/ccomcoclass-class.md)) must be in the same project as the calling code. The creation of the COM object is carried out by the class factory registered for this ATL class.  
  
 These functions are useful for creating objects that you have prevented from being externally creatable by using the [OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../vs140/object_entry_non_createable_ex_auto.md) macro. They are also useful in situations where you want to avoid the COM API for reasons of efficiency.  
  
 Note that the interface <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must have an IID associated with it that can be retrieved using the [__uuidof](../vs140/__uuidof-operator.md) operator.  
  
### Example  
 In the following example, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a wizard-generated ATL class derived from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> that implements the **IDocument** interface. The class is registered in the object map with the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> macro so clients can't create instances of the document using [CoCreateInstance](http://msdn.microsoft.com/library/windows/desktop/ms686615). <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a CoClass that provides a method on one of its own COM interfaces to create instances of the document class. The code below shows how easy it to create instances of the document class using the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member inherited from the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> base class.  
  
 [!code[NVC_ATL_COM#11](../vs140/codesnippet/CPP/ccomcoclass-class_2.cpp)]  
  
##  \<a name="ccomcoclass__error">\</a>  CComCoClass::Error  
 This static function sets up the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> interface to provide error information to the client.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 [in] The string describing the error. The Unicode version of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> specifies that <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is of type **LPCOLESTR**; the ANSI version specifies a type of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 [in] The IID of the interface defining the error or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> (the default value) if the error is defined by the operating system.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> you want returned to the caller. The default value is 0. For more details about <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, see Remarks.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 [in] The resource identifier where the error description string is stored. This value should lie between 0x0200 and 0xFFFF, inclusively. In debug builds, an **ASSERT** will result if <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> does not index a valid string. In release builds, the error description string will be set to "Unknown Error."  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 [in] The help context identifier for the error.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 [in] The path and name of the help file describing the error.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 [in] The handle to the resource. By default, this parameter is **_AtlModule::GetResourceInstance**, where **_AtlModule** is the global instance of [CAtlModule](../vs140/catlmodule-class.md).  
  
### Return Value  
 A standard <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> value. For details, see Remarks.  
  
### Remarks  
 To call <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, your object must implement the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> interface.  
  
 If the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter is nonzero, then <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> returns the value of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is zero, then the first four versions of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. The last two versions return the result of the macro **MAKE_HRESULT( 1, FACILITY_ITF,** <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> **)**.  
  
##  \<a name="ccomcoclass__getobjectclsid">\</a>  CComCoClass::GetObjectCLSID  
 Provides a consistent way of retrieving the object's CLSID.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The object's class identifier.  
  
##  \<a name="ccomcoclass__getobjectdescription">\</a>  CComCoClass::GetObjectDescription  
 This static function retrieves the text description for your class object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The class object's description.  
  
### Remarks  
 The default implementation returns **NULL**. You can override this method with the [DECLARE_OBJECT_DESCRIPTION](../vs140/declare_object_description.md) macro. For example:  
  
 [!code[NVC_ATL_COM#12](../vs140/codesnippet/CPP/ccomcoclass-class_3.h)]  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is called by **IComponentRegistrar::GetComponents**.                         **IComponentRegistrar** is an Automation interface that allows you to register and unregister individual components in a DLL. When you create a Component Registrar object with the ATL Project Wizard, the wizard will automatically implement the **IComponentRegistrar** interface. **IComponentRegistrar** is typically used by Microsoft Transaction Server.  
  
 For more information about the ATL Project Wizard, see the article [Creating an ATL Project](../vs140/creating-an-atl-project.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)