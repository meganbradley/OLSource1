---
title: "CObject Class"
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
  - "CObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "base classes, MFC objects"
  - "objects [C++], base class for MFC"
  - "object classes"
  - "CObject class"
ms.assetid: 95e9acd3-d9eb-4ac0-b52b-ca4a501a7a3a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject Class
The principal base class for the Microsoft Foundation Class Library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CObject::CObject](#cobject__cobject)|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CObject::AssertValid](#cobject__assertvalid)|Validates this object's integrity.|  
|[CObject::Dump](#cobject__dump)|Produces a diagnostic dump of this object.|  
|[CObject::GetRuntimeClass](#cobject__getruntimeclass)|Returns the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure corresponding to this object's class.|  
|[CObject::IsKindOf](#cobject__iskindof)|Tests this object's relationship to a given class.|  
|[CObject::IsSerializable](#cobject__isserializable)|Tests to see whether this object can be serialized.|  
|[CObject::Serialize](#cobject__serialize)|Loads or stores an object from/to an archive.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CObject::operator delete](#cobject__operator_delete)|Special **delete** operator.|  
|[CObject::operator new](#cobject__operator_new)|Special **new** operator.|  
  
## Remarks  
 It serves as the root not only for library classes such as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, but also for the classes that you write. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> provides basic services, including  
  
-   Serialization support  
  
-   Run-time class information  
  
-   Object diagnostic output  
  
-   Compatibility with collection classes  
  
 Note that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> does not support multiple inheritance. Your derived classes can have only one <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> base class, and that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> must be leftmost in the hierarchy. It is permissible, however, to have structures and non- <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>-derived classes in right-hand multiple-inheritance branches.  
  
 You will realize major benefits from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> derivation if you use some of the optional macros in your class implementation and declarations.  
  
 The first-level macros, [DECLARE_DYNAMIC](../vs140/declare_dynamic.md) and [IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md), permit run-time access to the class name and its position in the hierarchy. This, in turn, allows meaningful diagnostic dumping.  
  
 The second-level macros, [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md), include all the functionality of the first-level macros, and they enable an object to be "serialized" to and from an "archive."  
  
 For information about deriving Microsoft Foundation classes and C++ classes in general and using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, see [Using CObject](../vs140/using-cobject.md) and [Serialization](../vs140/serialization-in-mfc.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cobject__assertvalid">\</a>  CObject::AssertValid  
 Validates this object's integrity.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> performs a validity check on this object by checking its internal state. In the Debug version of the library, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> may assert and thus terminate the program with a message that lists the line number and filename where the assertion failed.  
  
 When you write your own class, you should override the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function to provide diagnostic services for yourself and other users of your class. The overridden <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> usually calls the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function of its base class before checking data members unique to the derived class.  
  
 Because <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a **const** function, you are not permitted to change the object state during the test. Your own derived class <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> functions should not throw exceptions but rather should assert whether they detect invalid object data.  
  
 The definition of "validity" depends on the object's class. As a rule, the function should perform a "shallow check." That is, if an object contains pointers to other objects, it should check to see whether the pointers are not null, but it should not perform validity testing on the objects referred to by the pointers.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#7](../vs140/codesnippet/CPP/cobject-class_1.cpp)]  
  
 For another example, see [AfxDoForAllObjects](../vs140/afxdoforallobjects.md).  
  
##  \<a name="cobject__cobject">\</a>  CObject::CObject  
 These functions are the standard <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> constructors.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *objectSrc*  
 A reference to another <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
### Remarks  
 The default version is automatically called by the constructor of your derived class.  
  
 If your class is serializable (it incorporates the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> macro), then you must have a default constructor (a constructor with no arguments) in your class declaration. If you do not need a default constructor, declare a private or protected "empty" constructor. For more information, see [Using CObject](../vs140/using-cobject.md).  
  
 The standard C++ default class copy constructor does a member-by-member copy. The presence of the private <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> copy constructor guarantees a compiler error message if the copy constructor of your class is needed but not available. You must therefore provide a copy constructor if your class requires this capability.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class used in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#8](../vs140/codesnippet/CPP/cobject-class_2.cpp)]  
  
##  \<a name="cobject__dump">\</a>  CObject::Dump  
 Dumps the contents of your object to a [CDumpContext](../vs140/cdumpcontext-class.md) object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The diagnostic dump context for dumping, usually <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Remarks  
 When you write your own class, you should override the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function to provide diagnostic services for yourself and other users of your class. The overridden <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> usually calls the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function of its base class before printing data members unique to the derived class. <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> prints the class name if your class uses the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> macro.  
  
> [!NOTE]
>  Your <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function should not print a newline character at the end of its output.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> calls make sense only in the Debug version of the Microsoft Foundation Class Library. You should bracket calls, function declarations, and function implementations with **#ifdef _DEBUG**/ <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statements for conditional compilation.  
  
 Since <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is a **const** function, you are not permitted to change the object state during the dump.  
  
 The [CDumpContext insertion (<<) operator](../vs140/cdumpcontext-class.md#cdumpcontext__operator__lt__lt_) calls <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> when a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> pointer is inserted.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> permits only "acyclic" dumping of objects. You can dump a list of objects, for example, but if one of the objects is the list itself, you will eventually overflow the stack.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#9](../vs140/codesnippet/CPP/cobject-class_3.cpp)]  
  
##  \<a name="cobject__getruntimeclass">\</a>  CObject::GetRuntimeClass  
 Returns the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> structure corresponding to this object's class.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure corresponding to this object's class; never **NULL**.  
  
### Remarks  
 There is one <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> structure for each <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>-derived class. The structure members are as follows:  
  
-   **LPCSTR m_lpszClassName** A null-terminated string containing the ASCII class name.  
  
-   **int m_nObjectSize** The size of the object, in bytes. If the object has data members that point to allocated memory, the size of that memory is not included.  
  
-   **UINT m_wSchema** The schema number ( – 1 for nonserializable classes). See the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro for a description of schema number.  
  
-   **CObject\* ( PASCAL\* m_pfnCreateObject )( )** A function pointer to the default constructor that creates an object of your class (valid only if the class supports dynamic creation; otherwise, returns **NULL**).  
  
-   **CRuntimeClass\* ( PASCAL\* m_pfn_GetBaseClass )( )** If your application is dynamically linked to the AFXDLL version of MFC, a pointer to a function that returns the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> structure of the base class.  
  
-   **CRuntimeClass\* m_pBaseClass** If your application is statically linked to MFC, a pointer to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> structure of the base class.  
  
 This function requires use of the [IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md), [IMPLEMENT_DYNCREATE](../vs140/implement_dyncreate.md), or [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro in the class implementation. You will get incorrect results otherwise.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#10](../vs140/codesnippet/CPP/cobject-class_4.cpp)]  
  
##  \<a name="cobject__iskindof">\</a>  CObject::IsKindOf  
 Tests this object's relationship to a given class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A pointer to a [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure associated with your <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>-derived class.  
  
### Return Value  
 Nonzero if the object corresponds to the class; otherwise 0.  
  
### Remarks  
 This function tests <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to see if (1) it is an object of the specified class or (2) it is an object of a class derived from the specified class. This function works only for classes declared with the [DECLARE_DYNAMIC](../vs140/declare_dynamic.md), [DECLARE_DYNCREATE](../vs140/declare_dyncreate.md), or [DECLARE_SERIAL](../vs140/declare_serial.md) macro.  
  
 Do not use this function extensively because it defeats the C++ polymorphism feature. Use virtual functions instead.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#11](../vs140/codesnippet/CPP/cobject-class_5.cpp)]  
  
##  \<a name="cobject__isserializable">\</a>  CObject::IsSerializable  
 Tests whether this object is eligible for serialization.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if this object can be serialized; otherwise 0.  
  
### Remarks  
 For a class to be serializable, its declaration must contain the [DECLARE_SERIAL](../vs140/declare_serial.md) macro, and the implementation must contain the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro.  
  
> [!NOTE]
>  Do not override this function.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#12](../vs140/codesnippet/CPP/cobject-class_6.cpp)]  
  
##  \<a name="cobject__operator_delete">\</a>  CObject::operator delete  
 For the Release version of the library, operator **delete** frees the memory allocated by operator **new**.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 In the Debug version, operator **delete** participates in an allocation-monitoring scheme designed to detect memory leaks.  
  
 If you use the code line  
  
 [!code[NVC_MFCCObjectSample#14](../vs140/codesnippet/CPP/cobject-class_7.cpp)]  
  
 before any of your implementations in a .CPP file, then the third version of **delete** will be used, storing the filename and line number in the allocated block for later reporting. You do not have to worry about supplying the extra parameters; a macro takes care of that for you.  
  
 Even if you do not use <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> in Debug mode, you still get leak detection, but without the source-file line-number reporting described above.  
  
 If you override operators **new** and **delete**, you forfeit this diagnostic capability.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> class used in the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#15](../vs140/codesnippet/CPP/cobject-class_8.cpp)]  
  
##  \<a name="cobject__operator_new">\</a>  CObject::operator new  
 For the Release version of the library, operator **new** performs an optimal memory allocation in a manner similar to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 In the Debug version, operator **new** participates in an allocation-monitoring scheme designed to detect memory leaks.  
  
 If you use the code line  
  
 [!code[NVC_MFCCObjectSample#14](../vs140/codesnippet/CPP/cobject-class_7.cpp)]  
  
 before any of your implementations in a .CPP file, then the second version of **new** will be used, storing the filename and line number in the allocated block for later reporting. You do not have to worry about supplying the extra parameters; a macro takes care of that for you.  
  
 Even if you do not use <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> in Debug mode, you still get leak detection, but without the source-file line-number reporting described above.  
  
> [!NOTE]
>  If you override this operator, you must also override **delete**. Do not use the standard library **_new_handler** function.  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> class used in the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#16](../vs140/codesnippet/CPP/cobject-class_9.h)]  
  
##  \<a name="cobject__serialize">\</a>  CObject::Serialize  
 Reads or writes this object from or to an archive.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object to serialize to or from.  
  
### Remarks  
 You must override <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> for each class that you intend to serialize. The overridden <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> must first call the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> function of its base class.  
  
 You must also use the [DECLARE_SERIAL](../vs140/declare_serial.md) macro in your class declaration, and you must use the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro in the implementation.  
  
 Use [CArchive::IsLoading](../vs140/carchive-class.md#carchive__isloading) or [CArchive::IsStoring](../vs140/carchive-class.md#carchive__isstoring) to determine whether the archive is loading or storing.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is called by [CArchive::ReadObject](../vs140/carchive-class.md#carchive__readobject) and [CArchive::WriteObject](../vs140/carchive-class.md#carchive__writeobject). These functions are associated with the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> insertion operator ( **<\<**) and extraction operator ( **>>**).  
  
 For serialization examples, see the article [Serialization: Serializing an Object](../vs140/serialization--serializing-an-object.md).  
  
### Example  
 See [CObList::CObList](../vs140/coblist-class.md#coblist__coblist) for a listing of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> class used in all <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> examples.  
  
 [!code[NVC_MFCCObjectSample#13](../vs140/codesnippet/CPP/cobject-class_10.cpp)]  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)