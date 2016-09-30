---
title: "CRuntimeClass Structure"
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
  - "CRuntimeClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRuntimeClass structure"
  - "dynamic class information"
  - "runtime, class information"
  - "run-time class, CRuntimeClass structure"
ms.assetid: de62b6ef-90d4-420f-8c70-f58b36976a2b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRuntimeClass Structure
Each class derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is associated with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure that you can use to obtain information about an object or its base class at run time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRuntimeClass::CreateObject](#cruntimeclass__createobject)|Creates an object during run time.|  
|[CRuntimeClass::FromName](#cruntimeclass__fromname)|Creates an object during run time using the familiar class name.|  
|[CRuntimeClass::IsDerivedFrom](#cruntimeclass__isderivedfrom)|Determines if the class is derived from the specified class.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CRuntimeClass::m_lpszClassName](#cruntimeclass__m_lpszclassname)|The name of the class.|  
|[CRuntimeClass::m_nObjectSize](#cruntimeclass__m_nobjectsize)|The size of the object in bytes.|  
|[CRuntimeClass::m_pBaseClass](#cruntimeclass__m_pbaseclass)|A pointer to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure of the base class.|  
|[CRuntimeClass::m_pfnCreateObject](#cruntimeclass__m_pfncreateobject)|A pointer to the function that dynamically creates the object.|  
|[CRuntimeClass::m_pfnGetBaseClass](#cruntimeclass__m_pfngetbaseclass)|Returns the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure (only available when dynamically linked).|  
|[CRuntimeClass::m_wSchema](#cruntimeclass__m_wschema)|The schema number of the class.|  
  
## Remarks  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a structure and therefore does not have a base class.  
  
 The ability to determine the class of an object at run time is useful when extra type checking of function arguments is needed, or when you must write special-purpose code based on the class of an object. Run-time class information is not supported directly by the C++ language.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> provides information on the related C++ object, such as a pointer to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> of the base class and the ASCII class name of the related class. This structure also implements various functions that can be used to dynamically create objects, specifying the type of object by using a familiar name, and determining if the related class is derived from a specific class.  
  
 For more information on using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, see the article [Accessing Run-Time Class Information](../vs140/accessing-run-time-class-information.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cruntimeclass__createobject">\</a>  CRuntimeClass::CreateObject  
 Call this function to dynamically create the specified class during run time.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The familiar name of the class to be created.  
  
### Return Value  
 A pointer to the newly created object, or **NULL** if the class name is not found or there is insufficient memory to create the object.  
  
### Remarks  
 Classes derived from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can support dynamic creation, which is the ability to create an object of a specified class at run time. Document, view, and frame classes, for example, should support dynamic creation. For more information on dynamic creation and the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member, see [CObject Class](../vs140/using-cobject.md) and [CObject Class: Specifying Levels of Functionality](../vs140/specifying-levels-of-functionality.md).  
  
### Example  
  See the example for [IsDerivedFrom](#cruntimeclass__isderivedfrom).  
  
##  \<a name="cruntimeclass__fromname">\</a>  CRuntimeClass::FromName  
 Call this function to retrieve the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure associated with the familiar name.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The familiar name of a class derived from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object, corresponding to the name as passed in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The function returns **NULL** if no matching class name was found.  
  
### Example  
 [!code[NVC_MFCCObjectSample#17](../vs140/codesnippet/CPP/cruntimeclass-structure_1.cpp)]  
  
##  \<a name="cruntimeclass__isderivedfrom">\</a>  CRuntimeClass::IsDerivedFrom  
 Call this function to determine if the calling class is derived from the class specified in the                 *pBaseClass* parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *pBaseClass*  
 The familiar name of a class derived from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Return Value  
 **TRUE** if the class calling <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is derived from the base class whose <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure is given as a parameter; otherwise **FALSE**.  
  
### Remarks  
 The relationship is determined by "walking" from the member's class up the chain of derived classes all the way to the top. This function only returns **FALSE** if no match is found for the base class.  
  
> [!NOTE]
>  To use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> structure, you must include the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> macro in the implementation of the class for which you want to retrieve run-time object information.  
  
 For more information on using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, see the article [CObject Class: Accessing Run-Time Class Information](../vs140/accessing-run-time-class-information.md).  
  
### Example  
 [!code[NVC_MFCCObjectSample#18](../vs140/codesnippet/CPP/cruntimeclass-structure_2.cpp)]  
  
##  \<a name="cruntimeclass__m_lpszclassname">\</a>  CRuntimeClass::m_lpszClassName  
 A null-terminated string containing the ASCII class name.  
  
### Remarks  
 This name can be used to create an instance of the class using the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function.  
  
### Example  
  See the example for [IsDerivedFrom](#cruntimeclass__isderivedfrom).  
  
##  \<a name="cruntimeclass__m_nobjectsize">\</a>  CRuntimeClass::m_nObjectSize  
 The size of the object, in bytes.  
  
### Remarks  
 If the object has data members that point to allocated memory, the size of that memory is not included.  
  
### Example  
  See the example for [IsDerivedFrom](#cruntimeclass__isderivedfrom).  
  
##  \<a name="cruntimeclass__m_pbaseclass">\</a>  CRuntimeClass::m_pBaseClass  
 If your application statically links to MFC, this data member contains a pointer to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> structure of the base class.  
  
### Remarks  
 If your application dynamically links to the MFC library, see [m_pfnGetBaseClass](#cruntimeclass__m_pfngetbaseclass).  
  
### Example  
  See the example for [IsDerivedFrom](#cruntimeclass__isderivedfrom).  
  
##  \<a name="cruntimeclass__m_pfncreateobject">\</a>  CRuntimeClass::m_pfnCreateObject  
 A function pointer to the default constructor that creates an object of your class.  
  
### Remarks  
 This pointer is only valid if the class supports dynamic creation; otherwise, the function returns **NULL**.  
  
##  \<a name="cruntimeclass__m_pfngetbaseclass">\</a>  CRuntimeClass::m_pfnGetBaseClass  
 If your application uses the MFC library as a shared DLL, this data member points to a function that returns the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structure of the base class.  
  
### Remarks  
 If your application statically links to the MFC library, see [m_pBaseClass](#cruntimeclass__m_pbaseclass).  
  
### Example  
  See the example for [IsDerivedFrom](#cruntimeclass__isderivedfrom).  
  
##  \<a name="cruntimeclass__m_wschema">\</a>  CRuntimeClass::m_wSchema  
 The schema number ( -1 for nonserializable classes).  
  
### Remarks  
 For more information on schema numbers, see the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro.  
  
### Example  
  See the example for [IsDerivedFrom](#cruntimeclass__isderivedfrom).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::GetRuntimeClass](../vs140/cobject-class.md#cobject__getruntimeclass)   
 [CObject::IsKindOf](../vs140/cobject-class.md#cobject__iskindof)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)   
 [IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md)   
 [IMPLEMENT_DYNCREATE](../vs140/implement_dyncreate.md)   
 [IMPLEMENT_SERIAL](../vs140/implement_serial.md)