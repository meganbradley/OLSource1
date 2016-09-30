---
title: "COleCurrency Class"
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
  - "CURRENCY"
  - "COleCurrency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fixed-point numbers"
  - "numbers, fixed-point"
  - "CURRENCY"
  - "COleCurrency class"
ms.assetid: 3a36e345-303f-46fb-a57c-858274378a8d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleCurrency Class
Encapsulates the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> data type of OLE automation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleCurrency::COleCurrency](#colecurrency__colecurrency)|Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleCurrency::Format](#colecurrency__format)|Generates a formatted string representation of a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[COleCurrency::GetStatus](#colecurrency__getstatus)|Gets the status (validity) of this <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[COleCurrency::ParseCurrency](#colecurrency__parsecurrency)|Reads a **CURRENCY** value from a string and sets the value of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[COleCurrency::SetCurrency](#colecurrency__setcurrency)|Sets the value of this <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
|[COleCurrency::SetStatus](#colecurrency__setstatus)|Sets the status (validity) for this <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator =](#colecurrency__operator__eq)|Copies a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> value.|  
|[operator +, -](#colecurrency__operator_add)|Adds, subtracts, and changes sign of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> values.|  
|[operator +=, -=](#colecurrency__operator_add__eq)|Adds and subtracts a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value from this <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[operator */](#colecurrency__operator_star)|Scales a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> value by an integer value.|  
|[operator *=, /=](#colecurrency__operator_star_eq)|Scales this <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> value by an integer value.|  
|[operator <<](#colecurrency__operator__lt__lt_and__gt__gt_)|Outputs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
|[operator >>](#colecurrency__operator__lt__lt_and__gt__gt_)|Inputs a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|[operator CURRENCY](#colecurrency__operator_currency)|Converts a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> value into a **CURRENCY**.|  
|[operator ==, <, <=, etc.](#colecurrency_relational_operators)|Compares two <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> values.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleCurrency::m_cur](#colecurrency__m_cur)|Contains the underlying **CURRENCY** for this <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[COleCurrency::m_status](#colecurrency__m_status)|Contains the status of this <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 **COleCurrency** does not have a base class.  
  
 **CURRENCY** is implemented as an 8-byte, two's-complement integer value scaled by 10,000. This gives a fixed-point number with 15 digits to the left of the decimal point and 4 digits to the right. The **CURRENCY** data type is extremely useful for calculations involving money, or for any fixed-point calculation where accuracy is important. It is one of the possible types for the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> data type of OLE automation.  
  
 **COleCurrency** also implements some basic arithmetic operations for this fixed-point type. The supported operations have been selected to control the rounding errors which occur during fixed-point calculations.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="colecurrency__colecurrency">\</a>  COleCurrency::COleCurrency  
 Constructs a **COleCurrency** object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A **CURRENCY** value to be copied into the new **COleCurrency** object.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 An existing **COleCurrency** object to be copied into the new **COleCurrency** object.  
  
 *varSrc*  
 An existing **VARIANT** data structure (possibly a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object) to be converted to a currency value ( <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>) and copied into the new **COleCurrency** object.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Indicate the units and fractional part (in 1/10,000's) of the value to be copied into the new **COleCurrency** object.  
  
### Remarks  
 All of these constructors create new **COleCurrency** objects initialized to the specified value. A brief description of each of these constructors follows. Unless otherwise noted, the status of the new **COleCurrency** item is set to valid.  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>Â **)**Â Â Â Constructs a **COleCurrency** object initialized to 0 (zero).  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>Â <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>Â **)**Â Â Â Constructs a **COleCurrency** object from a [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) value.  
  
-   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>Â <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>Â **)**Â Â Â Constructs a **COleCurrency** object from an existing **COleCurrency** object. The new object has the same status as the source object.  
  
-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>Â                                 *varSrc*Â **)**Â Â Â Constructs a **COleCurrency** object. Attempts to convert a [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) structure or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object to a currency ( <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>) value. If this conversion is successful, the converted value is copied into the new **COleCurrency** object. If it is not, the value of the **COleCurrency** object is set to zero (0) and its status to invalid.  
  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>Â <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>Â **)**Â Â Â Constructs a **COleCurrency** object from the specified numerical components. If the absolute value of the fractional part is greater than 10,000, the appropriate adjustment is made to the units. Note that the units and fractional part are specified by signed long values.  
  
 For more information, see the [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) and [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following examples show the effects of the zero-parameter and two-parameter constructors:  
  
 [!code[NVC_MFCOleContainer#10](../vs140/codesnippet/CPP/colecurrency-class_1.cpp)]  
  
##  \<a name="colecurrency__format">\</a>  COleCurrency::Format  
 Call this member function to create a formatted representation of the currency value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Indicates flags for locale settings. Only the following flag is relevant to currency:  
  
-   **LOCALE_NOUSEROVERRIDE**Â Â Â Use the system default locale settings, rather than custom user settings.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Indicates locale ID to use for the conversion.  
  
### Return Value  
 A <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> that contains the formatted currency value.  
  
### Remarks  
 It formats the value using the local language specifications (locale IDs). A currency symbol is not included in the value returned. If the status of this **COleCurrency** object is null, the return value is an empty string. If the status is invalid, the return string is specified by the string resource **IDS_INVALID_CURRENCY**.  
  
### Example  
 [!code[NVC_MFCOleContainer#11](../vs140/codesnippet/CPP/colecurrency-class_2.cpp)]  
  
##  \<a name="colecurrency__getstatus">\</a>  COleCurrency::GetStatus  
 Call this member function to get the status (validity) of a given **COleCurrency** object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Returns the status of this **COleCurrency** value.  
  
### Remarks  
 The return value is defined by the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> enumerated type that is defined within the **COleCurrency** class.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   **COleCurrency::valid**Â Â Â Indicates that this **COleCurrency** object is valid.  
  
-   **COleCurrency::invalid**Â Â Â Indicates that this **COleCurrency** object is invalid; that is, its value may be incorrect.  
  
-   **COleCurrency::null**Â Â Â Indicates that this **COleCurrency** object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a **COleCurrency** object is invalid in the following cases:  
  
-   If its value is set from a **VARIANT** or <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> value that could not be converted to a currency value.  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, for example <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or **\*=**.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using [SetStatus](#colecurrency__setstatus).  
  
 For more information on operations that may set the status to invalid, see the following member functions:  
  
-   [COleCurrency](#colecurrency__colecurrency)  
  
-   [operator =](#colecurrency__operator__eq)  
  
-   [operator + -](#colecurrency__operator_+,_-)  
  
-   [operator += and -=](#colecurrency__operator_+_eq,_-_eq)  
  
-   [operator * /](#colecurrency__operator_star)  
  
-   [operator *= and /=](#colecurrency__operator_star_eq)  
  
### Example  
 [!code[NVC_MFCOleContainer#12](../vs140/codesnippet/CPP/colecurrency-class_3.cpp)]  
  
##  \<a name="colecurrency__m_cur">\</a>  COleCurrency::m_cur  
 The underlying [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) structure for this **COleCurrency** object.  
  
### Remarks  
  
> [!CAUTION]
>  Changing the value in the **CURRENCY** structure accessed by the pointer returned by this function will change the value of this **COleCurrency** object. It does not change the status of this **COleCurrency** object.  
  
 For more information, see the [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) entry in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colecurrency__m_status">\</a>  COleCurrency::m_status  
 The type of this data member is the enumerated type <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, which is defined within the **COleCurrency** class.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 For a brief description of these status values, see the following list:  
  
-   **COleCurrency::valid**Â Â Â Indicates that this **COleCurrency** object is valid.  
  
-   **COleCurrency::invalid**Â Â Â Indicates that this **COleCurrency** object is invalid; that is, its value may be incorrect.  
  
-   **COleCurrency::null**Â Â Â Indicates that this **COleCurrency** object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
 The status of a **COleCurrency** object is invalid in the following cases:  
  
-   If its value is set from a **VARIANT** or <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> value that could not be converted to a currency value.  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, for example <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> or **\*=**.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using [SetStatus](#colecurrency__setstatus).  
  
 For more information on operations that may set the status to invalid, see the following member functions:  
  
-   [COleCurrency](#colecurrency__colecurrency)  
  
-   [operator =](#colecurrency__operator__eq)  
  
-   [operator +, -](#colecurrency__operator_+,_-)  
  
-   [operator +=, -=](#colecurrency__operator_+_eq,_-_eq)  
  
-   [operator */](#colecurrency__operator_star)  
  
-   [operator *=, /=](#colecurrency__operator_*_eq,___eq)  
  
    > [!CAUTION]
    >  This data member is for advanced programming situations. You should use the inline member functions [GetStatus](#colecurrency__getstatus) and [SetStatus](#colecurrency__setstatus). See <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> for further cautions regarding explicitly setting this data member.  
  
##  \<a name="colecurrency__operator__eq">\</a>  COleCurrency::operator =  
 These overloaded assignment operators copy the source currency value into this **COleCurrency** object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 A brief description of each operator follows:  
  
-   **operator =(**  <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  **)**Â Â Â The <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> value is copied into the **COleCurrency** object and its status is set to valid.  
  
-   **operator =(**  <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  **)**Â Â Â The value and status of the operand, an existing **COleCurrency** object are copied into this **COleCurrency** object.  
  
-   **operator =(**  *varSrc*  **)**Â Â Â If the conversion of the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> value (or [COleVariant](../vs140/colevariant-class.md) object) to a currency ( <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>) is successful, the converted value is copied into this **COleCurrency** object and its status is set to valid. If the conversion is not successful, the value of the **COleCurrency** object is set to 0 and its status to invalid.  
  
 For more information, see the [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e) and [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCOleContainer#15](../vs140/codesnippet/CPP/colecurrency-class_4.cpp)]  
  
##  \<a name="colecurrency__operator__add">\</a>  COleCurrency::operator +, -  
 These operators allow you to add and subtract two **COleCurrency** values to and from each other and to change the sign of a **COleCurrency** value.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 If either of the operands is null, the status of the resulting **COleCurrency** value is null.  
  
 If the arithmetic operation overflows, the resulting **COleCurrency** value is invalid.  
  
 If the operand is invalid and the other is not null, the status of the resulting **COleCurrency** value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](#colecurrency__m_status) member variable.  
  
### Example  
 [!code[NVC_MFCOleContainer#16](../vs140/codesnippet/CPP/colecurrency-class_5.cpp)]  
  
##  \<a name="colecurrency__operator__add_eq_eq">\</a>  COleCurrency::operator +=, -=  
 Allow you to add and subtract a **COleCurrency** value to and from this **COleCurrency** object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 If either of the operands is null, the status of this **COleCurrency** object is set to null.  
  
 If the arithmetic operation overflows, the status of this **COleCurrency** object is set to invalid.  
  
 If either of the operands is invalid and the other is not null, the status of this **COleCurrency** object is set to invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](#colecurrency__m_status) member variable.  
  
### Example  
 [!code[NVC_MFCOleContainer#17](../vs140/codesnippet/CPP/colecurrency-class_6.cpp)]  
  
##  \<a name="colecurrency__operator_star">\</a>  COleCurrency::operator * and /  
 Allow you to scale a **COleCurrency** value by an integral value.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 If the **COleCurrency** operand is null, the status of the resulting **COleCurrency** value is null.  
  
 If the arithmetic operation overflows or underflows, the status of the resulting **COleCurrency** value is invalid.  
  
 If the **COleCurrency** operand is invalid, the status of the resulting **COleCurrency** value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](#colecurrency__m_status) member variable.  
  
### Example  
 [!code[NVC_MFCOleContainer#18](../vs140/codesnippet/CPP/colecurrency-class_7.cpp)]  
  
##  \<a name="colecurrency__operator_star__eq__eq">\</a>  COleCurrency::operator *=, /=  
 Allow you to scale this **COleCurrency** value by an integral value.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 If the **COleCurrency** operand is null, the status of this **COleCurrency** object is set to null.  
  
 If the arithmetic operation overflows, the status of this **COleCurrency** object is set to invalid.  
  
 If the **COleCurrency** operand is invalid, the status of this **COleCurrency** object is set to invalid.  
  
 For more information on the valid, invalid, and null status values, see the [m_status](#colecurrency__m_status) member variable.  
  
### Example  
 [!code[NVC_MFCOleContainer#19](../vs140/codesnippet/CPP/colecurrency-class_8.cpp)]  
  
##  \<a name="colecurrency__operator__lt__lt_and__gt__gt_">\</a>  COleCurrency::operator &lt;&lt;, &gt;&gt;  
 Supports diagnostic dumping and storing to an archive.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The extraction ( **>>**) operator supports loading from an archive.  
  
##  \<a name="colecurrency__operator_currency">\</a>  COleCurrency::operator CURRENCY  
 Returns a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> structure whose value is copied from this **COleCurrency** object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="colecurrency__parsecurrency">\</a>  COleCurrency::ParseCurrency  
 Call this member function to parse a string to read a currency value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 *lpszCurrency*  
 A pointer to the null-terminated string which is to be parsed.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Indicates flags for locale settings, possibly the following flag:  
  
-   **LOCALE_NOUSEROVERRIDE**Â Â Â Use the system default locale settings, rather than custom user settings.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Indicates locale ID to use for the conversion.  
  
### Return Value  
 Nonzero if the string was successfully converted to a currency value, otherwise 0.  
  
### Remarks  
 It uses local language specifications (locale IDs) for the meaning of nonnumeric characters in the source string.  
  
 For a discussion of locale ID values, see [Supporting Multiple Languages](assetId:///47dc5add-232c-4268-b977-43e12da81ede).  
  
 If the string was successfully converted to a currency value, the value of this **COleCurrency** object is set to that value and its status to valid.  
  
 If the string could not be converted to a currency value or if there was a numerical overflow, the status of this **COleCurrency** object is invalid.  
  
 If the string conversion failed due to memory allocation errors, this function throws a [CMemoryException](../vs140/cmemoryexception-class.md). In any other error state, this function throws a [COleException](../vs140/coleexception-class.md).  
  
### Example  
 [!code[NVC_MFCOleContainer#13](../vs140/codesnippet/CPP/colecurrency-class_9.cpp)]  
  
##  \<a name="colecurrency_relational_operators">\</a>  COleCurrency Relational Operators  
 Compare two currency values and return nonzero if the condition is true; otherwise 0.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
  
> [!NOTE]
>  The return value of the ordering operations ( **<**, **\<=**, **>**, **>=**) is undefined if the status of either operand is null or invalid. The equality operators ( <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>) consider the status of the operands.  
  
### Example  
 [!code[NVC_MFCOleContainer#20](../vs140/codesnippet/CPP/colecurrency-class_10.cpp)]  
  
##  \<a name="colecurrency__setcurrency">\</a>  COleCurrency::SetCurrency  
 Call this member function to set the units and fractional part of this **COleCurrency** object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Indicate the units and fractional part (in 1/10,000's) of the value to be copied into this **COleCurrency** object.  
  
### Remarks  
 If the absolute value of the fractional part is greater than 10,000, the appropriate adjustment is made to the units, as shown in the third of the following examples.  
  
 Note that the units and fractional part are specified by signed long values. The fourth of the following examples shows what happens when the parameters have different signs.  
  
### Example  
 [!code[NVC_MFCOleContainer#14](../vs140/codesnippet/CPP/colecurrency-class_11.cpp)]  
  
##  \<a name="colecurrency__setstatus">\</a>  COleCurrency::SetStatus  
 Call this member function to set the status (validity) of this **COleCurrency** object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *status*  
 The new status for this **COleCurrency** object.  
  
### Remarks  
 The                         *status* parameter value is defined by the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> enumerated type, which is defined within the **COleCurrency** class.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   **COleCurrency::valid**Â Â Â Indicates that this **COleCurrency** object is valid.  
  
-   **COleCurrency::invalid**Â Â Â Indicates that this **COleCurrency** object is invalid; that is, its value may be incorrect.  
  
-   **COleCurrency::null**Â Â Â Indicates that this **COleCurrency** object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++ **NULL**.)  
  
    > [!CAUTION]
    >  This function is for advanced programming situations. This function does not alter the data in this object. It will most often be used to set the status to null or invalid. Note that the assignment operator ( [operator =](#colecurrency__operator__eq)) and [SetCurrency](#colecurrency__setcurrency) do set the status to of the object based on the source value(s).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant](../vs140/colevariant-class.md)