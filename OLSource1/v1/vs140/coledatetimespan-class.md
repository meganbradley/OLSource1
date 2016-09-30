---
title: "COleDateTimeSpan Class"
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
  - "ATL.COleDateTimeSpan"
  - "COleDateTimeSpan"
  - "ATL::COleDateTimeSpan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "timespan"
  - "time span"
  - "shared classes, COleDateTimeSpan"
  - "Date data type, MFC encapsulation of"
  - "COleDateTimeSpan class"
ms.assetid: 7441526d-a30a-4019-8fb3-3fee6f897cbe
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTimeSpan Class
Represents a relative time, a time span.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDateTimeSpan::COleDateTimeSpan](#coledatetimespan__coledatetimespan)|Constructs a                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDateTimeSpan::Format](#coledatetimespan__format)|Generates a formatted string representation of a                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[COleDateTimeSpan::GetDays](#coledatetimespan__getdays)|Returns the day portion of the span this                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::GetHours](#coledatetimespan__gethours)|Returns the hour portion of the span this                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::GetMinutes](#coledatetimespan__getminutes)|Returns the minute portion of the span this                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::GetSeconds](#coledatetimespan__getseconds)|Returns the second portion of the span this                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::GetStatus](#coledatetimespan__getstatus)|Gets the status (validity) of this                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
|[COleDateTimeSpan::GetTotalDays](#coledatetimespan__gettotaldays)|Returns the number of days this                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::GetTotalHours](#coledatetimespan__gettotalhours)|Returns the number of hours this                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::GetTotalMinutes](#coledatetimespan__gettotalminutes)|Returns the number of minutes this                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::GetTotalSeconds](#coledatetimespan__gettotalseconds)|Returns the number of seconds this                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object represents.|  
|[COleDateTimeSpan::SetDateTimeSpan](#coledatetimespan__setdatetimespan)|Sets the value of this                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
|[COleDateTimeSpan::SetStatus](#coledatetimespan__setstatus)|Sets the status (validity) of this                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|||  
|-|-|  
|[operator +, -](#coledatetimespan__operator__add_-)|Add, subtract, and change sign for                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> values.|  
|[operator +=, -=](#coledatetimespan__operator__add_eq_-_eq)|Add and subtract a                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> value from this                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> value.|  
|[operator =](#coledatetimespan__operator__eq)|Copies a                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> value.|  
|[operator ==, <, <=](#coledatetimespan_relational_operators)|Compare two                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> values.|  
|[operator double](#coledatetimespan__operator_double)|Converts this                                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> value to a                                         **double**.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleDateTimeSpan::m_span](#coledatetimespan__m_span)|Contains the underlying                                         **double** for this                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.|  
|[COleDateTimeSpan::m_status](#coledatetimespan__m_status)|Contains the status of this                                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> does not have a base class.  
  
 A                 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> keeps time in days.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is used with its companion class                 [COleDateTime](../vs140/coledatetime-class.md).                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> encapsulates the                 **DATE** data type of OLE automation.                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> represents absolute time values. All                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> calculations involve                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> values. The relation between these classes is analogous to the one between                 [CTime](../vs140/ctime-class.md) and                 [CTimeSpan](../vs140/ctimespan-class.md).  
  
 For more information on the                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> classes, see the article                 [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** ATLComTime.h  
  
##  \<a name="coledatetimespan_relational_operators">\</a>  COleDateTimeSpan Relational Operators  
 Comparison operators.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *dateSpan*  
 The                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to compare.  
  
### Return Value  
 These operators compare two date/time-span values and return                         **true** if the condition is true; otherwise                         **false**.  
  
### Remarks  
  
> [!NOTE]
>  An ATLASSERT will occur if either operand is invalid.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#25](../vs140/codesnippet/CPP/coledatetimespan-class_1.cpp)]  
  
 [!code[NVC_ATLMFC_Utilities#26](../vs140/codesnippet/CPP/coledatetimespan-class_2.cpp)]  
  
##  \<a name="coledatetimespan__coledatetimespan">\</a>  COleDateTimeSpan::COleDateTimeSpan  
 Constructs a                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The number of days to be copied into the new                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Indicate the day and time values to be copied into the new                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
### Remarks  
 All of these constructors create new                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> objects initialized to the specified value. A brief description of each of these constructors follows:  
  
-   **COleDateTimeSpan( )** Constructs a                                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object initialized to 0.  
  
-   **COleDateTimeSpan(** <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object from a floating-point value.  
  
-   **COleDateTimeSpan(** <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object initialized to the specified numerical values.  
  
 The status of the new                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object is set to valid.  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#14](../vs140/codesnippet/CPP/coledatetimespan-class_3.cpp)]  
  
##  \<a name="coledatetimespan__format">\</a>  COleDateTimeSpan::Format  
 Generates a formatted string representation of a                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A formatting string similar to the                                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> formatting string. Formatting codes, preceded by a percent (                                <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>) sign, are replaced by the corresponding                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> component. Other characters in the formatting string are copied unchanged to the returned string. The value and meaning of the formatting codes for                                 **Format** are listed below:  
  
-   **%H** Hours in the current day  
  
-   **%M** Minutes in the current hour  
  
-   **%S** Seconds in the current minute  
  
-   **%%** Percent sign  
  
 The four format codes listed above are the only codes that Format will accept.  
  
-  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The resource ID for the format-control string.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> that contains the formatted date/time-span value.  
  
### Remarks  
 Call these functions to create a formatted representation of the time-span value. If the status of this                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object is null, the return value is an empty string. If the status is invalid, the return string is specified by the string resource                         **IDS_INVALID_DATETIMESPAN**.  
  
 A brief description of the forms for this function follows:  
  
 **Format(**  <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  **)**  
 This form formats the value using the format string that contains special formatting codes that are preceded by a percent sign (%), as in                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. The formatting string is passed as a parameter to the function.  
  
 **Format(**  <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  **)**  
 This form formats the value using the format string that contains special formatting codes that are preceded by a percent sign (%), as in                                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. The formatting string is a resource. The ID of this string resource is passed as the parameter.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#15](../vs140/codesnippet/CPP/coledatetimespan-class_4.cpp)]  
  
##  \<a name="coledatetimespan__getdays">\</a>  COleDateTimeSpan::GetDays  
 Retrieves the day portion of this date/time-span value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The day portion of this date/time-span value.  
  
### Remarks  
 The return values from this function range between approximately – 3,615,000 and 3,615,000.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#16](../vs140/codesnippet/CPP/coledatetimespan-class_5.cpp)]  
  
##  \<a name="coledatetimespan__gethours">\</a>  COleDateTimeSpan::GetHours  
 Retrieves the hour portion of this date/time-span value.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The hours portion of this date/time-span value.  
  
### Remarks  
 The return values from this function range between – 23 and 23.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#17](../vs140/codesnippet/CPP/coledatetimespan-class_6.cpp)]  
  
##  \<a name="coledatetimespan__getminutes">\</a>  COleDateTimeSpan::GetMinutes  
 Retrieves the minute portion of this date/time-span value.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The minutes portion of this date/time-span value.  
  
### Remarks  
 The return values from this function range between – 59 and 59.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#18](../vs140/codesnippet/CPP/coledatetimespan-class_7.cpp)]  
  
##  \<a name="coledatetimespan__getseconds">\</a>  COleDateTimeSpan::GetSeconds  
 Retrieves the second portion of this date/time-span value.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The seconds portion of this date/time-span value.  
  
### Remarks  
 The return values from this function range between – 59 and 59.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#19](../vs140/codesnippet/CPP/coledatetimespan-class_8.cpp)]  
  
##  \<a name="coledatetimespan__getstatus">\</a>  COleDateTimeSpan::GetStatus  
 Gets the status (validity) of this                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The status of this                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The return value is defined by the                         **DateTimeSpanStatus** enumerated type, which is defined within the                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   **COleDateTimeSpan::valid** Indicates that this                                 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object is valid.  
  
-   **COleDateTimeSpan::invalid** Indicates that this                                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTimeSpan::null** Indicates that this                                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++                                 **NULL**.)  
  
 The status of a                         <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object is invalid in the following cases:  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, namely,                                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using                                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
 For more information about the operations that may set the status to invalid, see                         [COleDateTimeSpan::operator +, -](../vs140/coledatetime-class.md#coledatetime__operator__add_-) and                         [COleDateTimeSpan::operator +=, -=](../vs140/coledatetime-class.md#coledatetime__operator__add_eq_-_eq).  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
##  \<a name="coledatetimespan__gettotaldays">\</a>  COleDateTimeSpan::GetTotalDays  
 Retrieves this date/time-span value expressed in days.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 This date/time-span value expressed in days. Although this function is prototyped to return a double, it will always return an integer value.  
  
### Remarks  
 The return values from this function range between approximately – 3.65e6 and 3.65e6.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#20](../vs140/codesnippet/CPP/coledatetimespan-class_9.cpp)]  
  
##  \<a name="coledatetimespan__gettotalhours">\</a>  COleDateTimeSpan::GetTotalHours  
 Retrieves this date/time-span value expressed in hours.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 This date/time-span value expressed in hours. Although this function is prototyped to return a double, it will always return an integer value.  
  
### Remarks  
 The return values from this function range between approximately – 8.77e7 and 8.77e7.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 See the example for                                 [GetTotalDays](#coledatetimespan__gettotaldays).  
  
##  \<a name="coledatetimespan__gettotalminutes">\</a>  COleDateTimeSpan::GetTotalMinutes  
 Retrieves this date/time-span value expressed in minutes.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 This date/time-span value expressed in minutes. Although this function is prototyped to return a double, it will always return an integer value.  
  
### Remarks  
 The return values from this function range between approximately – 5.26e9 and 5.26e9.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 See the example for                                 [GetTotalDays](#coledatetimespan__gettotaldays).  
  
##  \<a name="coledatetimespan__gettotalseconds">\</a>  COleDateTimeSpan::GetTotalSeconds  
 Retrieves this date/time-span value expressed in seconds.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 This date/time-span value expressed in seconds. Although this function is prototyped to return a double, it will always return an integer value.  
  
### Remarks  
 The return values from this function range between approximately – 3.16e11 to 3.16e11.  
  
 For other functions that query the value of a                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
### Example  
 See the example for                                 [GetTotalDays](#coledatetimespan__gettotaldays).  
  
##  \<a name="coledatetimespan__m_span">\</a>  COleDateTimeSpan::m_span  
 The underlying                 **double** value for this                 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 This value expresses the date/time-span in days.  
  
> [!CAUTION]
>  Changing the value in the                             **double** data member will change the value of this                             <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object. It does not change the status of this                             <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
##  \<a name="coledatetimespan__m_status">\</a>  COleDateTimeSpan::m_status  
 The type for this data member is the enumerated type                 **DateTimeSpanStatus**, which is defined within the                 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   **COleDateTimeSpan::valid** Indicates that this                                 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object is valid.  
  
-   **COleDateTimeSpan::invalid** Indicates that this                                 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTimeSpan::null** Indicates that this                                 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++                                 **NULL**.)  
  
 The status of a                         <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object is invalid in the following cases:  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, namely,                                 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using                                 [SetStatus](#coledatetimespan__setstatus).  
  
 For more information about the operations that may set the status to invalid, see                         [COleDateTimeSpan::operator +, -](../vs140/coledatetime-class.md#coledatetime__operator__add_-) and                         [COleDateTimeSpan::operator +=, -=](../vs140/coledatetime-class.md#coledatetime__operator__add_eq_-_eq).  
  
> [!CAUTION]
>  This data member is for advanced programming situations. You should use the inline member functions                             [GetStatus](#coledatetimespan__getstatus) and                             [SetStatus](#coledatetimespan__setstatus). See                             <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> for further cautions regarding explicitly setting this data member.  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
##  \<a name="coledatetimespan__operator__eq">\</a>  COleDateTimeSpan::operator =  
 Copies a                 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> value.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 This overloaded assignment operator copies the source date/time-span value into this                         <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object.  
  
##  \<a name="coledatetimespan__operator__add_-">\</a>  COleDateTimeSpan::operator +, -  
 Add, subtract, and change sign for                 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> values.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 The first two operators let you add and subtract date/time-span values. The third lets you change the sign of a date/time-span value.  
  
 If either of the operands is null, the status of the resulting                         <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> value is null.  
  
 If either of the operands is invalid and the other is not null, the status of the resulting                         <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the                         [m_status](#coledatetimespan__m_status) member variable.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#23](../vs140/codesnippet/CPP/coledatetimespan-class_10.cpp)]  
  
##  \<a name="coledatetimespan__operator__add_eq_-_eq">\</a>  COleDateTimeSpan::operator +=, -=  
 Add and subtract a                 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> value from this                 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> value.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 These operators let you add and subtract date/time-span values from this                         <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object. If either of the operands is null, the status of the resulting                         <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> value is null.  
  
 If either of the operands is invalid and the other is not null, the status of the resulting                         <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the                         [m_status](#coledatetimespan__m_status) member variable.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#24](../vs140/codesnippet/CPP/coledatetimespan-class_11.cpp)]  
  
##  \<a name="coledatetimespan__operator_double">\</a>  COleDateTimeSpan::operator double  
 Converts this                 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> value to a                 **double**.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 This operator returns the value of this                         <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> value as a floating-point number of days.  
  
##  \<a name="coledatetimespan__setdatetimespan">\</a>  COleDateTimeSpan::SetDateTimeSpan  
 Sets the value of this date/time-span value.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 Indicate the date-span and time-span values to be copied into this                                 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object.  
  
### Remarks  
 For functions that query the value of a                         <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDays](#coledatetimespan__getdays)  
  
-   [GetHours](#coledatetimespan__gethours)  
  
-   [GetMinutes](#coledatetimespan__getminutes)  
  
-   [GetSeconds](#coledatetimespan__getseconds)  
  
-   [GetTotalDays](#coledatetimespan__gettotaldays)  
  
-   [GetTotalHours](#coledatetimespan__gettotalhours)  
  
-   [GetTotalMinutes](#coledatetimespan__gettotalminutes)  
  
-   [GetTotalSeconds](#coledatetimespan__gettotalseconds)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#21](../vs140/codesnippet/CPP/coledatetimespan-class_12.cpp)]  
  
##  \<a name="coledatetimespan__setstatus">\</a>  COleDateTimeSpan::SetStatus  
 Sets the status (validity) of this                 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *status*  
 The new status value for this                                 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The                         *Status* parameter value is defined by the                         **DateTimeSpanStatus** enumerated type, which is defined within the                         <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   **COleDateTimeSpan::valid** Indicates that this                                 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object is valid.  
  
-   **COleDateTimeSpan::invalid** Indicates that this                                 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTimeSpan::null** Indicates that this                                 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++                                 **NULL**.)  
  
    > [!CAUTION]
    >  This function is for advanced programming situations. This function does not alter the data in this object. It will most often be used to set the status to                                     <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> or                                     **invalid**. Note that the assignment operator (                                    [operator =](#coledatetimespan__operator__eq)) and                                     [SetDateTimeSpan](#coledatetimespan__setdatetimespan) do set the status of the object based on the source value(s).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#22](../vs140/codesnippet/CPP/coledatetimespan-class_13.cpp)]  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [CTime Class](../vs140/ctime-class.md)   
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)