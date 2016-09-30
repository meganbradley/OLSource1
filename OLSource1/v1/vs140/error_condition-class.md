---
title: "error_condition Class"
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
  - "system_error/std::error_condition"
  - "std::error_condition"
  - "error_condition"
  - "std.error_condition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "error_condition class"
ms.assetid: 6690f481-97c9-4554-a0ff-851dc96b7a06
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# error_condition Class
Represents user-defined error codes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> stores an error code value and a pointer to an object that represents a [category](../vs140/error_category-class.md) of error codes used for reported user-defined errors.  
  
### Constructors  
  
|||  
|-|-|  
|[error_condition](#error_condition__error_condition)|Constructs an object of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[value_type](#error_condition__value_type)|A type that represents the stored error code value.|  
  
### Member Functions  
  
|||  
|-|-|  
|[assign](#error_condition__assign)|Assigns an error code value and category to an error condition.|  
|[category](#error_condition__category)|Returns the error category.|  
|[clear](#error_condition__clear)|Clears the error code value and category.|  
|[message](#error_condition__message)|Returns the name of the error code.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](#error_condition__operator_eq_eq)|Tests for equality between <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects.|  
|[operator!=](#error_condition__operator_neq)|Tests for inequality between <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects.|  
|[operator<](#error_condition__operator_lt_)|Tests if the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object is less than the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object passed in for comparison.|  
|[operator=](#error_condition__operator_eq)|Assigns a new enumeration value to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[operator bool](#error_condition__operator_bool)|Casts a variable of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<system_error>  
  
 **Namespace:** std  
  
##  \<a name="error_condition__assign">\</a>  error_condition::assign  
 Assigns an error code value and category to an error condition.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The error code value to store in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The error category to store in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The member function stores <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> as the error code value and a pointer to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="error_condition__category">\</a>  error_condition::category  
 Returns the error category.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the stored error category  
  
### Remarks  
  
##  \<a name="error_condition__clear">\</a>  error_condition::clear  
 Clears the error code value and category.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The member function stores a zero error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category) object.  
  
##  \<a name="error_condition__error_condition">\</a>  error_condition::error_condition  
 Constructs an object of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|The error code value to store in the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|The error category to store in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The enumeration value to store in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The first constructor stores a zero error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category).  
  
 The second constructor stores <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> as the error code value and a pointer to [error_category](assetId:///6fe57a15-63a1-4e79-8af4-6738e43e19c8).  
  
 The third constructor stores <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> as the error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category).  
  
##  \<a name="error_condition__message">\</a>  error_condition::message  
 Returns the name of the error code.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> representing the name of the error code.  
  
### Remarks  
 This member function returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
##  \<a name="error_condition__operator_eq_eq">\</a>  error_condition::operator==  
 Tests for equality between <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|The ojbect to be tested for equality.|  
  
### Return Value  
 **true** if the objects are equal; **false** if objects are not equal.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
##  \<a name="error_condition__operator_neq">\</a>  error_condition::operator!=  
 Tests for inequality between <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|The object to be tested for inequality.|  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object is not equal to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object passed in <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>; otherwise **false**.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
##  \<a name="error_condition__operator_lt_">\</a>  error_condition::operator&lt;  
 Tests if the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object is less than the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object passed in for comparison.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object to be compared.|  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object is less than the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object passed in for comparison; Otherwise, **false**.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
##  \<a name="error_condition__operator_eq">\</a>  error_condition::operator=  
 Assigns a new enumeration value to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|The enumeration value to assign to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object.|  
  
### Return Value  
 A reference to the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object that is being assigned the new enumeration value by the member function.  
  
### Remarks  
 The member operator stores <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> as the error code value and a pointer to the [generic_category](../vs140/-system_error--functions.md#generic_category). It returns <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
##  \<a name="error_condition__operator_bool">\</a>  error_condition::operator bool  
 Casts a variable of type <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The Boolean value of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The operator returns a value convertible to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> only if [value](#error_condition__value) is not equal to zero. The return type is convertible only to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, not to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> or other known scalar types.  
  
##  \<a name="error_condition__value">\</a>  error_condition::value  
 Returns the stored error code value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The stored error code value of type [value_type](#error_condition__value_type).  
  
### Remarks  
  
##  \<a name="error_condition__value_type">\</a>  error_condition::value_type  
 A type that represents the stored error code value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The type definition is a synonym for <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
## See Also  
 [error_category Class](../vs140/error_category-class.md)   
 [\<system_error>](../vs140/-system_error-.md)