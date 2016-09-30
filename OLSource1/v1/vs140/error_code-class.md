---
title: "error_code Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "error_code"
  - "std.error_code"
  - "std::error_code"
  - "system_error/std::error_code"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "error_code class"
ms.assetid: c09b4a96-cb14-4281-a319-63543f9b2b4a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# error_code Class
Represents low-level system errors that are implementation-specific.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An object of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class stores an error code value and a pointer to an object that represents a [category](../vs140/error_category-class.md) of error codes that describe reported low-level system errors.  
  
### Constructors  
  
|||  
|-|-|  
|[error_code](#error_code__error_code)|Constructs an object of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[value_type](#error_code__value_type)|A type that represents the stored error code value.|  
  
### Member Functions  
  
|||  
|-|-|  
|[assign](#error_code__assign)|Assigns an error code value and category to an error code.|  
|[category](#error_code__category)|Returns the error category.|  
|[clear](#error_code__clear)|Clears the error code value and category.|  
|[default_error_condition](#error_code__default_error_condition)|Returns the default error condition.|  
|[message](#error_code__message)|Returns the name of the error code.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](#error_code__operator_eq_eq)|Tests for equality between <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects.|  
|[operator!=](#error_code__operator_neq)|Tests for inequality between <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects.|  
|[operator<](#error_code__operator_lt_)|Tests if the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is less than the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object passed in for comparison.|  
|[operator=](#error_code__operator_eq)|Assigns a new enumeration value to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[operator bool](#error_code__operator_bool)|Casts a variable of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<system_error>  
  
 **Namespace:** std  
  
##  \<a name="error_code__assign">\</a>  error_code::assign  
 Assigns an error code value and category to an error code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The error code value to store in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|The error category to store in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The member function stores <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> as the error code value and a pointer to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
##  \<a name="error_code__category">\</a>  error_code::category  
 Returns the error category.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="error_code__clear">\</a>  error_code::clear  
 Clears the error code value and category.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The member function stores a zero error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category) object.  
  
##  \<a name="error_code__default_error_condition">\</a>  error_code::default_error_condition  
 Returns the default error condition.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The [error_condition](../vs140/error_condition-class.md) specified by [default_error_condition](../vs140/error_category-class.md#error_category__default_error_condition).  
  
### Remarks  
 This member function returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
##  \<a name="error_code__error_code">\</a>  error_code::error_code  
 Constructs an object of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|The error code value to store in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The error category to store in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|The enumeration value to store in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The first constructor stores a zero error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category).  
  
 The second constructor stores <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> as the error code value and a pointer to [error_category](assetId:///6fe57a15-63a1-4e79-8af4-6738e43e19c8).  
  
 The third constructor stores <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> as the error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category).  
  
##  \<a name="error_code__message">\</a>  error_code::message  
 Returns the name of the error code.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> representing the name of the error code.  
  
### Remarks  
 This member function returns <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="error_code__operator_eq_eq">\</a>  error_code::operator==  
 Tests for equality between <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|The object to be tested for equality.|  
  
### Return Value  
 **true** if the objects are equal; **false** if objects are not equal.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="error_code__operator_neq">\</a>  error_code::operator!=  
 Tests for inequality between <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|The object to be tested for inequality.|  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object is not equal to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object passed in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>; otherwise **false**.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
##  \<a name="error_code__operator_lt_">\</a>  error_code::operator&lt;  
 Tests if the [error_code](assetId:///09c6ef90-b6f8-430a-b584-e168716c7e31) object is less than the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object passed in for comparison.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|The error_code object to be compared.|  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object is less than the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object passed in for comparison; Otherwise, **false**.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
##  \<a name="error_code__operator_eq">\</a>  error_code::operator=  
 Assigns a new enumeration value to the [error_code](assetId:///09c6ef90-b6f8-430a-b584-e168716c7e31) object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|The enumeration value to assign to the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.|  
  
### Return Value  
 A reference to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object that is being assigned the new enumeration value by the member function.  
  
### Remarks  
 The member operator stores <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> as the error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category). It returns <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
##  \<a name="error_code__operator_bool">\</a>  error_code::operator bool  
 Casts a variable of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The Boolean value of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The operator returns a value convertible to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> only if [value](#error_code__value) is not equal to zero. The return type is convertible only to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, not to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> or other known scalar types.  
  
##  \<a name="error_code__value">\</a>  error_code::value  
 Returns the stored error code value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The stored error code value of type [value_type](#error_code__value_type).  
  
### Remarks  
  
##  \<a name="error_code__value_type">\</a>  error_code::value_type  
 A type that represents the stored error code value.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 This type definition is a synonym for <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
## See Also  
 [error_category Class](../vs140/error_category-class.md)   
 [\<system_error>](../vs140/-system_error-.md)