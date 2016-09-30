---
title: "COleDateTime Class"
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
  - "COleDateTime"
  - "ATL.COleDateTime"
  - "ATL::COleDateTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared classes, COleDateTime"
  - "time-only values"
  - "Date data type, MFC encapsulation of"
  - "COleDateTime class"
  - "dates, handling in MFC"
  - "time, handling in MFC"
ms.assetid: e718f294-16ec-4649-88b6-a4dbae5178fb
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime Class
Encapsulates the             <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> data type that is used in OLE automation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDateTime::COleDateTime](#coledatetime__coledatetime)|Constructs a                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDateTime::Format](#coledatetime__format)|Generates a formatted string representation of a                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
|[COleDateTime::GetAsDBTIMESTAMP](#coledatetime__getasdbtimestamp)|Call this method to obtain the time in the                                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object as a                                         **DBTIMESTAMP** data structure.|  
|[COleDateTime::GetAsSystemTime](#coledatetime__getassystemtime)|Call this method to obtain the time in the                                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object as a                                         [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) data structure.|  
|[COleDateTime::GetAsUDATE](#coledatetime__getasudate)|Call this method to obtain the time in the                                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> as a                                         **UDATE** data structure.|  
|[COleDateTime::GetCurrentTime](#coledatetime__getcurrenttime)|Creates a                                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object that represents the current time (static member function).|  
|[COleDateTime::GetDay](#coledatetime__getday)|Returns the day this                                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object represents (1 – 31).|  
|[COleDateTime::GetDayOfWeek](#coledatetime__getdayofweek)|Returns the day of the week this                                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object represents (Sunday = 1).|  
|[COleDateTime::GetDayOfYear](#coledatetime__getdayofyear)|Returns the day of the year this                                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object represents (Jan 1 = 1).|  
|[COleDateTime::GetHour](#coledatetime__gethour)|Returns the hour this                                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object represents (0 – 23).|  
|[COleDateTime::GetMinute](#coledatetime__getminute)|Returns the minute this                                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object represents (0 – 59).|  
|[COleDateTime::GetMonth](#coledatetime__getmonth)|Returns the month this                                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object represents (1 – 12).|  
|[COleDateTime::GetSecond](#coledatetime__getsecond)|Returns the second this                                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object represents (0 – 59).|  
|[COleDateTime::GetStatus](#coledatetime__getstatus)|Gets the status (validity) of this                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.|  
|[COleDateTime::GetYear](#coledatetime__getyear)|Returns the year this                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object represents.|  
|[COleDateTime::ParseDateTime](#coledatetime__parsedatetime)|Reads a date/time value from a string and sets the value of                                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.|  
|[COleDateTime::SetDate](#coledatetime__setdate)|Sets the value of this                                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object to the specified date-only value.|  
|[COleDateTime::SetDateTime](#coledatetime__setdatetime)|Sets the value of this                                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object to the specified date/time value.|  
|[COleDateTime::SetStatus](#coledatetime__setstatus)|Sets the status (validity) of this                                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[COleDateTime::SetTime](#coledatetime__settime)|Sets the value of this                                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object to the specified time-only value.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[COleDateTime::operator ==, COleDateTime::operator <, etc.](#coledatetime_relational_operators)|Compare two                                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> values.|  
|[COleDateTime::operator +, COleDateTime::operator -](#coledatetime__operator__add_-)|Add and subtract                                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> values.|  
|[COleDateTime::operator +=, COleDateTime::operator -=](#coledatetime__operator__add_eq_-_eq)|Add and subtract a                                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> value from this                                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object.|  
|[COleDateTime::operator =](#coledatetime__operator__eq)|Copies a                                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> value.|  
|[COleDateTime::operator DATE, COleDateTime::operator Date*](#coledatetime__operator_date)|Converts a                                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> value into a                                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or a                                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleDateTime::m_dt](#coledatetime__m_dt)|Contains the underlying                                         **DATE** for this                                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.|  
|[COleDateTime::m_status](#coledatetime__m_status)|Contains the status of this                                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> does not have a base class.  
  
 It is one of the possible types for the                 [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) data type of OLE automation. A                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> value represents an absolute date and time value.  
  
 The                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> type is implemented as a floating-point value. Days are measured from December 30, 1899, at midnight. The following table shows some dates and their associated values:  
  
|Date|Value|  
|----------|-----------|  
|December 29, 1899, midnight|-1.0|  
|December 29, 1899, 6 A.M|-1.25|  
|December 30, 1899, midnight|0.0|  
|December 31, 1899, midnight|1.0|  
|January 1, 1900, 6 A.M.|2.25|  
  
> [!CAUTION]
>  Note in the table above that although day values become negative before midnight on December 30, 1899, time-of-day values do not. For example, 6:00 AM is always represented by a fractional value 0.25 regardless of whether the integer representing the day is positive (after December 30, 1899) or negative (before December 30, 1899). This means that a simple floating point comparison would erroneously sort a                     <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> representing 6:00 AM on 12/29/1899 as                     **later** than one representing 7:00 AM on the same day.  
  
 The                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> class handles dates from January 1, 100, through December 31, 9999. The                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> class uses the Gregorian calendar; it does not support Julian dates.                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> ignores Daylight Saving Time. (See                 [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).)  
  
> [!NOTE]
>  You can use the                     <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> format to retrieve a two-digit year only for dates starting at 1900. If you use the                     <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> format on a date before 1900, the code generates an ASSERT failure.  
  
 This type is also used to represent date-only or time-only values. By convention, the date 0 (December 30, 1899) is used for time-only values and the time 00:00 (midnight) is used for date-only values.  
  
 If you create a                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object by using a date less than 100, the date is accepted, but subsequent calls to                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, and                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> fail and return -1. Previously, you could use two-digit dates, but dates must be 100 or larger in MFC 4.2 and later.  
  
 To avoid problems, specify a four-digit date. For example:  
  
 [!code[NVC_ATLMFC_Utilities#1](../vs140/codesnippet/CPP/coledatetime-class_1.cpp)]  
  
 Basic arithmetic operations for the                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> values use the companion class                 [COleDateTimeSpan](../vs140/coledatetimespan-class.md).                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> values define a time interval. The relationship between these classes is similar to the one between                 [CTime](../vs140/ctime-class.md) and                 [CTimeSpan](../vs140/ctimespan-class.md).  
  
 For more information about the                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> classes, see the article                 [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
## Requirements  
 **Header:** ATLComTime.h  
  
##  \<a name="coledatetime_relational_operators">\</a>  COleDateTime Relational Operators  
 Comparison operators.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The                                 **COleDateTime** object to be compared.  
  
### Remarks  
  
> [!NOTE]
>  An ATLASSERT will occur if either of the two operands is invalid.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#13](../vs140/codesnippet/CPP/coledatetime-class_2.cpp)]  
  
### Example  
 The operators                                 **>=**,                                 **\<=**,                                 **>**, and                                 **<**, will assert if the                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object is set to null.  
  
 [!code[NVC_ATLMFC_Utilities#170](../vs140/codesnippet/CPP/coledatetime-class_3.cpp)]  
  
##  \<a name="coledatetime__coledatetime">\</a>  COleDateTime::COleDateTime  
 Constructs a                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object to be copied into the new                                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object.  
  
 *varSrc*  
 An existing                                 **VARIANT** data structure (possibly a                                 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object) to be converted to a date/time value (                                <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>) and copied into the new                                 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 A date/time (                                **DATE**) value to be copied into the new                                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> or                                 **__time64_t** value to be converted to a date/time value and copied into the new                                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> object.  
  
 *systimeSrc*  
 A                                 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> structure to be converted to a date/time value and copied into the new                                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> structure to be converted to a date/time value and copied into the new                                 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object. Note that                                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> uses Universal Coordinated Time (UTC), so if you pass a local time in the structure, your results will be incorrect. See                                 [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Indicate the date and time values to be copied into the new                                 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 MS-DOS date and time values to be converted to a date/time value and copied into the new                                 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A reference to a                                 \<xref:System.Data.OleDb.OleDbType.DBTimeStamp*> structure containing the current local time.  
  
### Remarks  
 All these constructors create new                         <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> objects initialized to the specified value. The following table shows valid ranges for each date and time component:  
  
|Date/time component|Valid range|  
|--------------------------|-----------------|  
|year|100 – 9999|  
|month|0 – 12|  
|day|0 – 31|  
|hour|0 – 23|  
|minute|0 – 59|  
|second|0 – 59|  
  
 Note that the actual upper bound for the day component varies based on the month and year components. For details, see the                         **SetDate** or                         <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> member functions.  
  
 Following is a brief description of each constructor:  
  
-   <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> object initialized to 0 (midnight, 30 December 1899).  
  
-   <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object from an existing                                 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.  
  
-   <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> *varSrc* **)** Constructs a                                 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object. Attempts to convert a                                 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> structure or                                 [COleVariant](../vs140/colevariant-class.md) object to a date/time (                                <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>) value. If this conversion is successful, the converted value is copied into the new                                 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object. If it is not, the value of the                                 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> object is set to 0 (midnight, 30 December 1899) and its status to invalid.  
  
-   <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object from a                                 **DATE** value.  
  
-   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object from a                                 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> value.  
  
-   <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> *systimeSrc* **)** Constructs a                                 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object from a                                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> value.  
  
-   <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> object from a                                 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> value. . Note that                                 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> uses Universal Coordinated Time (UTC), so if you pass a local time in the structure, your results will be incorrect. See                                 [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
-   <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> object from the specified numerical values.  
  
-   <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> **)** Constructs a                                 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object from the specified MS-DOS date and time values.  
  
 For more information on the                         <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> data type, see the                         [time](../vs140/time--_time32--_time64.md) function in the                         *Run-Time Library Reference*.  
  
 For more information, see the                         [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and                         [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structures in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
> [!NOTE]
>  The constructor using                             **DBTIMESTAMP** parameter is only available when OLEDB.h is included.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#2](../vs140/codesnippet/CPP/coledatetime-class_4.cpp)]  
  
##  \<a name="coledatetime__format">\</a>  COleDateTime::Format  
 Creates a formatted representation of the date/time value.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Indicates one of the following locale flags:  
  
-   <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> Use the system default locale settings, instead of custom user settings.  
  
-   <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> Ignore the date portion during parsing.  
  
-   <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> Ignore the time portion during parsing.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 Indicates locale ID to use for the conversion. For more information about language identifiers, see                                 [Language Identifiers](http://msdn.microsoft.com/library/windows/desktop/dd318691).  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A formatting string similar to the                                 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> formatting string. Each formatting code, preceded by a percent (                                <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>) sign, is replaced by the corresponding                                 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> component. Other characters in the formatting string are copied unchanged to the returned string. See the run-time function                                 [strftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for more information. The value and meaning of the formatting codes for                                 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> are:  
  
-   <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> Hours in the current day  
  
-   <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> Minutes in the current hour  
  
-   <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> Seconds in the current minute  
  
-   <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> Percent sign  
  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 The resource ID for the format-control string.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> that contains the formatted date/time value.  
  
### Remarks  
 If the status of this                         <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object is null, the return value is an empty string. If the status is invalid, the return string is specified by the string resource                         <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
 A brief description of the three forms for this function follows:  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>(                             <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>)  
 This form formats the value by using the language specifications (locale IDs) for date and time. Using the default parameters, this form will print the date and the time, unless the time portion is 0 (midnight), in which case it will print just the date, or the date portion is 0 (30 December 1899), in which case it will print just the time. If the date/time value is 0 (30 December 1899, midnight), this form with the default parameters will print midnight.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>(                             <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>)  
 This form formats the value by using the format string which contains special formatting codes that are preceded by a percent sign (%), as in                                 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>. The formatting string is passed as a parameter to the function. For more information about the formatting codes, see                                 [strftime, wcsftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) in the Run-Time Library Reference.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>(                             <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>)  
 This form formats the value by using the format string which contains special formatting codes that are preceded by a percent sign (%), as in                                 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>. The formatting string is a resource. The ID of this string resource is passed as the parameter. For more information about the formatting codes, see                                 [strftime, wcsftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) in the                                 *Run-Time Library Reference*.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#3](../vs140/codesnippet/CPP/coledatetime-class_5.cpp)]  
  
##  \<a name="coledatetime__getasdbtimestamp">\</a>  COleDateTime::GetAsDBTIMESTAMP  
 Call this method to obtain the time in the                 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> object as a                 **DBTIMESTAMP** data structure.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 A reference to a                                 \<xref:System.Data.OleDb.OleDbType.DBTimeStamp*> structure.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Stores the resulting time in the referenced                         <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> structure. The                         **DBTIMESTAMP** data structure initialized by this function will have its                         **fraction** member set to zero.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#4](../vs140/codesnippet/CPP/coledatetime-class_6.cpp)]  
  
##  \<a name="coledatetime__getassystemtime">\</a>  COleDateTime::GetAsSystemTime  
 Call this method to obtain the time in the                 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> object as a                 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> data structure.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *sysTime*  
 A reference to a                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure to receive the converted date/time value from the                                 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns                         **true** if successful;                         **false** if the conversion fails, or if the                         <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> object is                         **NULL** or invalid.  
  
### Remarks  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> stores the resulting time in the referenced                         *sysTime* object. The                         <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> data structure initialized by this function will have its                         **wMilliseconds** member set to zero.  
  
 See                         [GetStatus](#coledatetime__getstatus) for more information on the status information held in a                         <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> object.  
  
##  \<a name="coledatetime__getasudate">\</a>  COleDateTime::GetAsUDATE  
 Call this method to obtain the time in the                 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> object as a                 **UDATE** data structure.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 A reference to a                                 **UDATE** structure to receive the converted date/time value from the                                 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns                         **true** if successful;                         **false** if the conversion fails, or if the                         <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> object is                         **NULL** or invalid.  
  
### Remarks  
 A                         **UDATE** structure represents an "unpacked" date.  
  
##  \<a name="coledatetime__getcurrenttime">\</a>  COleDateTime::GetCurrentTime  
 Call this static member function to return the current date/time value.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_ATLMFC_Utilities#5](../vs140/codesnippet/CPP/coledatetime-class_7.cpp)]  
  
##  \<a name="coledatetime__getday">\</a>  COleDateTime::GetDay  
 Gets the day of the month represented by this date/time value.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The day of the month represented by the value of this                         <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> if the day could not be obtained.  
  
### Remarks  
 Valid return values range between 1 and 31.  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#6](../vs140/codesnippet/CPP/coledatetime-class_8.cpp)]  
  
##  \<a name="coledatetime__getdayofweek">\</a>  COleDateTime::GetDayOfWeek  
 Gets the day of the month represented by this date/time value.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The day of the week represented by the value of this                         <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> if the day of the week could not be obtained.  
  
### Remarks  
 Valid return values range between 1 and 7, where 1=Sunday, 2=Monday, and so on.  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#7](../vs140/codesnippet/CPP/coledatetime-class_9.cpp)]  
  
##  \<a name="coledatetime__getdayofyear">\</a>  COleDateTime::GetDayOfYear  
 Gets the day of the year represented by this date/time value.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The day of the year represented by the value of this                         <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> if the day of the year could not be obtained.  
  
### Remarks  
 Valid return values range between 1 and 366, where January 1 = 1.  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#8](../vs140/codesnippet/CPP/coledatetime-class_10.cpp)]  
  
##  \<a name="coledatetime__gethour">\</a>  COleDateTime::GetHour  
 Gets the hour represented by this date/time value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The hour represented by the value of this                         <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> if the hour could not be obtained.  
  
### Remarks  
 Valid return values range between 0 and 23.  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#9](../vs140/codesnippet/CPP/coledatetime-class_11.cpp)]  
  
##  \<a name="coledatetime__getminute">\</a>  COleDateTime::GetMinute  
 Gets the minute represented by this date/time value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The minute represented by the value of this                         <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> if the minute could not be obtained.  
  
### Remarks  
 Valid return values range between 0 and 59.  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
### Example  
 See the example for                                 [GetHour](#coledatetime__gethour).  
  
##  \<a name="coledatetime__getmonth">\</a>  COleDateTime::GetMonth  
 Gets the month represented by this date/time value.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The month represented by the value of this                         <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> if the month could not be obtained.  
  
### Remarks  
 Valid return values range between 1 and 12.  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
### Example  
 See the example for                                 [GetDay](#coledatetime__getday).  
  
##  \<a name="coledatetime__getsecond">\</a>  COleDateTime::GetSecond  
 Gets the second represented by this date/time value.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The second represented by the value of this                         <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> if the second could not be obtained.  
  
### Remarks  
 Valid return values range between 0 and 59.  
  
> [!NOTE]
>  The                             <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> class does not support leap seconds.  
  
 For more information about the implementation for                         <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
### Example  
 See the example for                                 [GetHour](#coledatetime__gethour).  
  
##  \<a name="coledatetime__getstatus">\</a>  COleDateTime::GetStatus  
 Gets the status (validity) of a given                 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns the status of this                         <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> value. If you call                         **GetStatus** on a                         <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> object constructed with the default, it will return valid. If you call                         **GetStatus** on a                         <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> object initialized with the constructor set to null,                         **GetStatus** will return null. See                         **Remarks** for more information.  
  
### Remarks  
 The return value is defined by the                         **DateTimeStatus** enumerated type, which is defined within the                         <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
  
 For a brief description of these status values, see the following list:  
  
-   <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> Indicates that an error occurred while attempting to obtain part of the date/time value.  
  
-   **COleDateTime::valid** Indicates that this                                 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> object is valid.  
  
-   **COleDateTime::invalid** Indicates that this                                 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> object is invalid; that is, its value may be incorrect.  
  
-   **COleDateTime::null** Indicates that this                                 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> object is null, that is, that no value has been supplied for this object. (This is "null" in the database sense of "having no value," as opposed to the C++                                 **NULL**.)  
  
 The status of a                         <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> object is invalid in the following cases:  
  
-   If its value is set from a                                 **VARIANT** or                                 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> value that could not be converted to a date/time value.  
  
-   If its value is set from a                                 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>, or                                 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> value that could not be converted to a valid date/time value.  
  
-   If its value is set by                                 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> with invalid parameter values.  
  
-   If this object has experienced an overflow or underflow during an arithmetic assignment operation, namely,                                 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>.  
  
-   If an invalid value was assigned to this object.  
  
-   If the status of this object was explicitly set to invalid using                                 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>.  
  
 For more information about the operations that may set the status to invalid, see the following member functions:  
  
-   [COleDateTime](#coledatetime__coledatetime)  
  
-   [SetDateTime](#coledatetime__setdatetime)  
  
-   [operator +, -](#coledatetime__operator__add_-)  
  
-   [operator +=, -=](#coledatetime__operator__add_eq_-_eq)  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#10](../vs140/codesnippet/CPP/coledatetime-class_12.cpp)]  
  
##  \<a name="coledatetime__getyear">\</a>  COleDateTime::GetYear  
 Gets the year represented by this date/time value.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The year represented by the value of this                         <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> object or                         <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> if the year could not be obtained.  
  
### Remarks  
 Valid return values range between 100 and 9999, which includes the century.  
  
 For information on other member functions that query the value of this                         <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
### Example  
 See the example for                                 [GetDay](#coledatetime__getday).  
  
##  \<a name="coledatetime__m_dt">\</a>  COleDateTime::m_dt  
 The underlying                 **DATE** structure for this                 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
  
> [!CAUTION]
>  Changing the value in the                             **DATE** object accessed by the pointer returned by this function will change the value of this                             <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> object. It does not change the status of this                             <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> object.  
  
 For more information about the implementation of the                         **DATE** object, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
##  \<a name="coledatetime__m_status">\</a>  COleDateTime::m_status  
 Contains the status of this                 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 The type of this data member is the enumerated type                         **DateTimeStatus**, which is defined within the                         <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> class. See                         [COleDateTime::GetStatus](#coledatetime__getstatus) for details.  
  
> [!CAUTION]
>  This data member is for advanced programming situations. You should use the inline member functions                             [GetStatus](#coledatetime__getstatus) and                             [SetStatus](#coledatetime__setstatus). See                             <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> for further cautions regarding explicitly setting this data member.  
  
##  \<a name="coledatetime__operator__eq">\</a>  COleDateTime::operator =  
 Copies a                 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> value.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Remarks  
 These overloaded assignment operators copy the source date/time value into this                         <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> object. A brief description of each these overloaded assignment operators follows:  
  
-   **operator =(**  <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  **)** The value and status of the operand are copied into this                                 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> object.  
  
-   **operator =(**  *varSrc*  **)** If the conversion of the                                 [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) value (or                                 [COleVariant](../vs140/colevariant-class.md) object) to a date/time (                                <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>) is successful, the converted value is copied into this                                 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> object and its status is set to valid. If the conversion is not successful, the value of this object is set to zero (30 December 1899, midnight) and its status to invalid.  
  
-   **operator =(** <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> **)** The                                 **DATE** value is copied into this                                 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder> object and its status is set to valid.  
  
-   **operator =(** <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> **)** The                                 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> or                                 **__time64_t** value is converted and copied into this                                 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid.  
  
-   **operator =(** *systimeSrc* **)** The                                 [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) value is converted and copied into this                                 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid.  
  
-   **operator =(** <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> **)** The                                 **UDATE** value is converted and copied into this                                 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; if unsuccessful, it is set to invalid. A                                 **UDATE** structure represents an "unpacked" date. See the function                                 [VarDateFromUdate](assetId:///1c924ac5-b896-49e1-9ccf-825ac7a030c8) for more details.  
  
-   **operator =(** <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> **)** The                                 [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) value is converted and copied into this                                 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> object. If the conversion is successful, the status of this object is set to valid; otherwise it is set to invalid.                                 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> uses Universal Coordinated Time (UTC), so if you pass a UTC time in the structure, your results will be converted from UTC time to local time, and will be stored as variant time. This behavior is the same as in Visual C++ 6.0 and Visual C++.NET 2003 SP2. See                                 [File Times](http://msdn.microsoft.com/library/windows/desktop/ms724290) in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 For more information, see the                         [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) entry in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information on the                         <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> data type, see the                         [time](../vs140/time--_time32--_time64.md) function in the                         *Run-Time Library Reference*.  
  
 For more information, see the                         [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) and                         [FILETIME](http://msdn.microsoft.com/library/windows/desktop/ms724284) structures in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
##  \<a name="coledatetime__operator__add_-">\</a>  COleDateTime::operator +, -  
 Add and subtract                 **ColeDateTime** values.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder> objects represent absolute times.                         [COleDateTimeSpan](../vs140/coledatetimespan-class.md) objects represent relative times. The first two operators allow you to add and subtract a                         <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> value from a                         <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> value. The third operator allows you to subtract one                         <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> value from another to yield a                         <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> value.  
  
 If either of the operands is null, the status of the resulting                         <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> value is null.  
  
 If the resulting                         <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> value falls outside the bounds of acceptable values, the status of that                         <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> value is invalid.  
  
 If either of the operands is invalid and the other is not null, the status of the resulting                         <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> value is invalid.  
  
 The                         **+** and                         **-** operators will assert if the                         <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> object is set to null. See                         [COleDateTime Relational Operators](#coledatetime_relational_operators) for an example.  
  
 For more information on the valid, invalid, and null status values, see the                         [m_status](#coledatetime__m_status) member variable.  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#12](../vs140/codesnippet/CPP/coledatetime-class_13.cpp)]  
  
##  \<a name="coledatetime__operator__add_eq_-_eq">\</a>  COleDateTime::operator +=, -=  
 Add and subtract a                 **ColeDateTime** value from this                 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 These operators allow you to add and subtract a                         <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> value to and from this                         <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>. If either of the operands is null, the status of the resulting                         <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> value is null.  
  
 If the resulting                         <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> value falls outside the bounds of acceptable values, the status of this                         <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> value is set to invalid.  
  
 If either of the operands is invalid and other is not null, the status of the resulting                         <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> value is invalid.  
  
 For more information on the valid, invalid, and null status values, see the                         [m_status](#coledatetime__m_status) member variable.  
  
 The                         **+=** and                         **-=** operators will assert if the                         <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> object is set to null. See                         [COleDateTime Relational Operators](#coledatetime_relational_operators) for an example.  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
##  \<a name="coledatetime__operator_date">\</a>  COleDateTime::operator DATE  
 Converts a                 **ColeDateTime** value into a                 **DATE**.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 This operator returns a                         **DATE** object whose value is copied from this                         <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> object. For more information about the implementation of the                         **DATE** object, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
 The                         **DATE** operator will assert if the                         <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> object is set to null. See                         [COleDateTime Relational Operators](#coledatetime_relational_operators) for an example.  
  
##  \<a name="coledatetime__parsedatetime">\</a>  COleDateTime::ParseDateTime  
 Parses a string to read a date/time value.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 A pointer to the null-terminated string which is to be parsed. For details, see Remarks.  
  
 <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>  
 Indicates flags for locale settings and parsing. One or more of the following flags:  
  
-   **LOCALE_NOUSEROVERRIDE** Use the system default locale settings, rather than custom user settings.  
  
-   **VAR_TIMEVALUEONLY** Ignore the date portion during parsing.  
  
-   **VAR_DATEVALUEONLY** Ignore the time portion during parsing.  
  
 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 Indicates locale ID to use for the conversion.  
  
### Return Value  
 Returns                         **true** if the string was successfully converted to a date/time value, otherwise                         **false**.  
  
### Remarks  
 If the string was successfully converted to a date/time value, the value of this                         <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> object is set to that value and its status to valid.  
  
> [!NOTE]
>  Year values must lie between 100 and 9999, inclusively.  
  
 The                         <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> parameter can take a variety of formats. For example, the following strings contain acceptable date/time formats:  
  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
  
 Note that the locale ID will also affect whether the string format is acceptable for conversion to a date/time value.  
  
 In the case of                         **VAR_DATEVALUEONLY**, the time value is set to time 0, or midnight. In the case of                         **VAR_TIMEVALUEONLY**, the date value is set to date 0, meaning 30 December 1899.  
  
 If the string could not be converted to a date/time value or if there was a numerical overflow, the status of this                         <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> object is invalid.  
  
 For more information about the bounds and implementation for                         <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
##  \<a name="coledatetime__setdate">\</a>  COleDateTime::SetDate  
 Sets the date of this                 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
 Indicate the date components to be copied into this                                 <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Zero if the value of this                         <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> object was set successfully; otherwise, 1. This return value is based on the                         **DateTimeStatus** enumerated type. For more information, see the                         [SetStatus](#coledatetime__setstatus) member function.  
  
### Remarks  
 The date is set to the specified values. The time is set to time 0, midnight.  
  
 See the following table for bounds for the parameter values:  
  
|Parameter|Bounds|  
|---------------|------------|  
|<CodeContentPlaceHolder>314\</CodeContentPlaceHolder>|100 – 9999|  
|<CodeContentPlaceHolder>315\</CodeContentPlaceHolder>|1 – 12|  
|<CodeContentPlaceHolder>316\</CodeContentPlaceHolder>|0 – 31|  
  
 If the day of the month overflows, it is converted to the correct day of the next month and the month and/or year is incremented accordingly. A day value of zero indicates the last day of the previous month. The behavior is the same as                         <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>.  
  
 If the date value specified by the parameters is not valid, the status of this object is set to                         **COleDateTime::invalid**. You should use                         [GetStatus](#coledatetime__getstatus) to check the validity of the                         **DATE** value and should not assume that the value of                         [m_dt](#coledatetime__m_dt) will remain unmodified.  
  
 Here are some examples of date values:  
  
|<CodeContentPlaceHolder>318\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>319\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>320\</CodeContentPlaceHolder>|Value|  
|-------------|--------------|------------|-----------|  
|2000|2|29|29 February 2000|  
|1776|7|4|4 July 1776|  
|1925|4|35|35 April 1925 (invalid date)|  
|10000|1|1|1 January 10000 (invalid date)|  
  
 To set both date and time, see                         [COleDateTime::SetDateTime](#coledatetime__setdatetime).  
  
 For information on member functions that query the value of this                         <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>322\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#11](../vs140/codesnippet/CPP/coledatetime-class_14.cpp)]  
  
##  \<a name="coledatetime__setdatetime">\</a>  COleDateTime::SetDateTime  
 Sets the date and time of this                 <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>  
 Indicate the date and time components to be copied into this                                 <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Zero if the value of this                         <CodeContentPlaceHolder>331\</CodeContentPlaceHolder> object was set successfully; otherwise, 1. This return value is based on the                         **DateTimeStatus** enumerated type. For more information, see the                         [SetStatus](#coledatetime__setstatus) member function.  
  
### Remarks  
 See the following table for bounds for the parameter values:  
  
|Parameter|Bounds|  
|---------------|------------|  
|<CodeContentPlaceHolder>332\</CodeContentPlaceHolder>|100 – 9999|  
|<CodeContentPlaceHolder>333\</CodeContentPlaceHolder>|1 – 12|  
|<CodeContentPlaceHolder>334\</CodeContentPlaceHolder>|0 – 31|  
|<CodeContentPlaceHolder>335\</CodeContentPlaceHolder>|0 – 23|  
|<CodeContentPlaceHolder>336\</CodeContentPlaceHolder>|0 – 59|  
|<CodeContentPlaceHolder>337\</CodeContentPlaceHolder>|0 – 59|  
  
 If the day of the month overflows, it is converted to the correct day of the next month and the month and/or year is incremented accordingly. A day value of zero indicates the last day of the previous month. The behavior is the same as                         [SystemTimeToVariantTime](assetId:///d9d69521-9b33-4fc5-8a1c-929f216db450).  
  
 If the date or time value specified by the parameters is not valid, the status of this object is set to invalid and the value of this object is not changed.  
  
 Here are some examples of time values:  
  
|<CodeContentPlaceHolder>338\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>339\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>340\</CodeContentPlaceHolder>|Value|  
|-------------|------------|------------|-----------|  
|1|3|3|01:03:03|  
|23|45|0|23:45:00|  
|25|30|0|Invalid|  
|9|60|0|Invalid|  
  
 Here are some examples of date values:  
  
|<CodeContentPlaceHolder>341\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>342\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>343\</CodeContentPlaceHolder>|Value|  
|-------------|--------------|------------|-----------|  
|1995|4|15|15 April 1995|  
|1789|7|14|17 July 1789|  
|1925|2|30|Invalid|  
|10000|1|1|Invalid|  
  
 To set the date only, see                         [COleDateTime::SetDate](#coledatetime__setdate). To set the time only, see                         [COleDateTime::SetTime](#coledatetime__settime).  
  
 For information on member functions that query the value of this                         <CodeContentPlaceHolder>344\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>345\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
### Example  
 See the example for                                 [GetStatus](#coledatetime__getstatus).  
  
##  \<a name="coledatetime__setstatus">\</a>  COleDateTime::SetStatus  
 Sets the status of this                 <CodeContentPlaceHolder>346\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *status*  
 The new status value for this                                 <CodeContentPlaceHolder>347\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The                         *status* parameter value is defined by the                         **DateTimeStatus** enumerated type, which is defined within the                         <CodeContentPlaceHolder>348\</CodeContentPlaceHolder> class. See                         [COleDateTime::GetStatus](#coledatetime__getstatus) for details.  
  
> [!CAUTION]
>  This function is for advanced programming situations. This function does not alter the data in this object. It will most often be used to set the status to                             <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> or                             **invalid**. Note that the assignment operator (                            [operator =](#coledatetime__operator__eq)) and                             [SetDateTime](#coledatetime__setdatetime) do set the status of the object based on the source value(s).  
  
### Example  
 See the example for                                 [GetStatus](#coledatetime__getstatus).  
  
##  \<a name="coledatetime__settime">\</a>  COleDateTime::SetTime  
 Sets the time of this                 <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>353\</CodeContentPlaceHolder>  
 Indicate the time components to be copied into this                                 <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Zero if the value of this                         <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> object was set successfully; otherwise, 1. This return value is based on the                         **DateTimeStatus** enumerated type. For more information, see the                         [SetStatus](#coledatetime__setstatus) member function.  
  
### Remarks  
 The time is set to the specified values. The date is set to date 0, meaning 30 December 1899.  
  
 See the following table for bounds for the parameter values:  
  
|Parameter|Bounds|  
|---------------|------------|  
|<CodeContentPlaceHolder>356\</CodeContentPlaceHolder>|0 – 23|  
|<CodeContentPlaceHolder>357\</CodeContentPlaceHolder>|0 – 59|  
|<CodeContentPlaceHolder>358\</CodeContentPlaceHolder>|0 – 59|  
  
 If the time value specified by the parameters is not valid, the status of this object is set to invalid and the value of this object is not changed.  
  
 Here are some examples of time values:  
  
|<CodeContentPlaceHolder>359\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>360\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>361\</CodeContentPlaceHolder>|Value|  
|-------------|------------|------------|-----------|  
|1|3|3|01:03:03|  
|23|45|0|23:45:00|  
|25|30|0|Invalid|  
|9|60|0|Invalid|  
  
 To set both date and time, see                         [COleDateTime::SetDateTime](#coledatetime__setdatetime).  
  
 For information on member functions that query the value of this                         <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> object, see the following member functions:  
  
-   [GetDay](#coledatetime__getday)  
  
-   [GetMonth](#coledatetime__getmonth)  
  
-   [GetYear](#coledatetime__getyear)  
  
-   [GetHour](#coledatetime__gethour)  
  
-   [GetMinute](#coledatetime__getminute)  
  
-   [GetSecond](#coledatetime__getsecond)  
  
-   [GetDayOfWeek](#coledatetime__getdayofweek)  
  
-   [GetDayOfYear](#coledatetime__getdayofyear)  
  
 For more information about the bounds for                         <CodeContentPlaceHolder>363\</CodeContentPlaceHolder> values, see the article                         [Date and Time: Automation Support](../vs140/date-and-time--automation-support.md).  
  
### Example  
 See the example for                                 [SetDate](#coledatetime__setdate).  
  
## See Also  
 [ColeVariant](../vs140/colevariant-class.md)   
 [CTime Class](../vs140/ctime-class.md)   
 [CTimeSpan Class](../vs140/ctimespan-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)