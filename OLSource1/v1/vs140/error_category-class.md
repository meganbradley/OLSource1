---
title: "error_category Class"
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
  - "std::error_category"
  - "system_error/std::error_category"
  - "error_category"
  - "std.error_category"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "error_category class"
ms.assetid: e0a71e14-852d-4905-acd6-5f8ed426706d
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# error_category Class
Represents the abstract, common base for objects that describes a category of error codes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Two predefined objects implement <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>: [generic_category](../vs140/-system_error--functions.md#generic_category) and [system_category](../vs140/-system_error--functions.md#system_category).  
  
### TypeDefs  
  
|||  
|-|-|  
|[value_type](#error_category__value_type)|A type that represents the stored error code value.|  
  
### Member Functions  
  
|||  
|-|-|  
|[default_error_condition](#error_category__default_error_condition)|Stores the error code value for an error condition object.|  
|[equivalent](#error_category__equivalent)|Returns a value that specifies whether error objects are equivalent.|  
|[message](#error_category__message)|Returns the name of the specified error code.|  
|[name](#error_category__name)|Returns the name of the category.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](#error_category__operator_eq_eq)|Tests for equality between <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects.|  
|[operator!=](#error_category__operator_neq)|Tests for inequality between <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects.|  
|[operator<](#error_category__operator_lt_)|Tests if the [error_category](../vs140/error_category-class.md) object is less than the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object passed in for comparison.|  
  
## Requirements  
 **Header:** \<system_error>  
  
 **Namespace:** std  
  
##  \<a name="error_category__default_error_condition">\</a>  error_category::default_error_condition  
 Stores the error code value for an error condition object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The error code value to store in the [error_condition](../vs140/error_condition-class.md).|  
  
### Return Value  
 Returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="error_category__equivalent">\</a>  error_category::equivalent  
 Returns a value that specifies whether error objects are equivalent.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The error code value to compare.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The [error_condition](../vs140/error_condition-class.md) object to compare.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The [error_code](../vs140/error_code-class.md) object to compare.|  
  
### Return Value  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the category and value are equal; otherwise, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first member function returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The second member function returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
##  \<a name="error_category__message">\</a>  error_category::message  
 Returns the name of the specified error code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The error code value to describe.|  
  
### Return Value  
 Returns a descriptive name of the error code <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> for the category.  
  
### Remarks  
  
##  \<a name="error_category__name">\</a>  error_category::name  
 Returns the name of the category.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the name of the category as a null-terminated byte string.  
  
### Remarks  
  
##  \<a name="error_category__operator_eq_eq">\</a>  error_category::operator==  
 Tests for equality between <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The object to be tested for equality.|  
  
### Return Value  
 **true** if the objects are equal; **false** if the objects are not equal.  
  
### Remarks  
 This member operator returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="error_category__operator_neq">\</a>  error_category::operator!=  
 Tests for inequality between <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|The object to be tested for inequality.|  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object is not equal to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object passed in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>; otherwise **false**.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="error_category__operator_lt_">\</a>  error_category::operator&lt;  
 Tests if the [error_category](../vs140/error_category-class.md) object is less than the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object passed in for comparison.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object to be compared.|  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object is less than the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object passed in for comparison; Otherwise, **false**.  
  
### Remarks  
 The member operator returns <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
##  \<a name="error_category__value_type">\</a>  error_category::value_type  
 A type that represents the stored error code value.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 This type definition is a synonym for <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
## See Also  
 [\<system_error>](../vs140/-system_error-.md)