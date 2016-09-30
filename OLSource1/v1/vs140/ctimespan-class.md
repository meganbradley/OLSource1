---
title: "CTimeSpan Class"
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
  - "ATL.CTimeSpan"
  - "CTimeSpan"
  - "timespan"
  - "ATL::CTimeSpan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "elapsed time, CTimeSpan object"
  - "timespan"
  - "time span"
  - "CTimeSpan class"
  - "shared classes, CTimeSpan"
  - "time, elapsed"
ms.assetid: ee1e42f6-1839-477a-8435-fb26ad475140
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTimeSpan Class
An amount of time, which is internally stored as the number of seconds in the time span.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CTimeSpan::CTimeSpan](#ctimespan__ctimespan)|Constructs                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects in various ways.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTimeSpan::Format](#ctimespan__format)|Converts a                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> into a formatted string.|  
|[CTimeSpan::GetDays](#ctimespan__getdays)|Returns a value that represents the number of complete days in this                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|[CTimeSpan::GetHours](#ctimespan__gethours)|Returns a value that represents the number of hours in the current day (–23 through 23).|  
|[CTimeSpan::GetMinutes](#ctimespan__getminutes)|Returns a value that represents the number of minutes in the current hour (–59 through 59).|  
|[CTimeSpan::GetSeconds](#ctimespan__getseconds)|Returns a value that represents the number of seconds in the current minute (–59 through 59).|  
|[CTimeSpan::GetTimeSpan](#ctimespan__gettimespan)|Returns the value of the                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[CTimeSpan::GetTotalHours](#ctimespan__gettotalhours)|Returns a value that represents the total number of complete hours in this                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|[CTimeSpan::GetTotalMinutes](#ctimespan__gettotalminutes)|Returns a value that represents the total number of complete minutes in this                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[CTimeSpan::GetTotalSeconds](#ctimespan__gettotalseconds)|Returns a value that represents the total number of complete seconds in this                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[CTimeSpan::Serialize64](#ctimespan__serialize64)|Serializes data to or from an archive.|  
  
### Operators  
  
|||  
|-|-|  
|[operator + –](#ctimespan__operator__add_-)|Adds and subtracts                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> objects.|  
|[operator += –=](#ctimespan__operator__add_eq_-_eq)|Adds and subtracts a                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object to and from this                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[operator == < etc.](#ctimespan_comparison_operators)|Compares two relative time values.|  
  
## Remarks  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> does not have a base class.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> functions convert seconds to various combinations of days, hours, minutes, and seconds.  
  
 The                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is stored in a                 **__time64_t** structure, which is 8 bytes.  
  
 A companion class,                 [CTime](../vs140/ctime-class.md), represents an absolute time.  
  
 The                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> classes are not designed for derivation. Because there are no virtual functions, the size of both                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects is exactly 8 bytes. Most member functions are inline.  
  
 For more information on using                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, see the articles                 [Date and Time](../vs140/date-and-time.md), and                 [Time Management](../vs140/time-management.md) in the                 *Run-Time Library Reference*.  
  
## Requirements  
 **Header:** atltime.h  
  
##  \<a name="ctimespan_comparison_operators">\</a>  CTimeSpan Comparison Operators  
 Comparison operators.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 The object to compare.  
  
### Return Value  
 These operators compare two relative time values. They return                         **true** if the condition is true; otherwise                         **false**.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#169](../vs140/codesnippet/CPP/ctimespan-class_1.cpp)]  
  
##  \<a name="ctimespan__ctimespan">\</a>  CTimeSpan::CTimeSpan  
 Constructs                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> objects in various ways.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *timeSpanSrc*  
 A                                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object that already exists.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A                                 **__time64_t** time value, which is the number of seconds in the time span. In Visual C++ versions 6.0 and earlier,                                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> was a value of                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. Visual C++ .NET or later silently converts a                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter to                                 **__time64_t**.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Days, hours, minutes, and seconds, respectively.  
  
### Remarks  
 All these constructors create a new                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object initialized with the specified relative time. Each constructor is described below:  
  
-   **CTimeSpan( );** Constructs an uninitialized                                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
-   **CTimeSpan( const CTimeSpan& );** Constructs a                                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object from another                                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> value.  
  
-   **CTimeSpan( __time64_t );** Constructs a                                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object from a                                 **__time64_t** type.  
  
-   **CTimeSpan( LONG**,                                 **int, int, int );** Constructs a                                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object from components with each component constrained to the following ranges:  
  
    |Component|Range|  
    |---------------|-----------|  
    |<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|0–25,000 (approximately)|  
    |<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|0–23|  
    |<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|0–59|  
    |<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|0–59|  
  
 Note that the Debug version of the Microsoft Foundation Class Library asserts if one or more of the time-day components is out of range. It is your responsibility to validate the arguments prior to calling.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#162](../vs140/codesnippet/CPP/ctimespan-class_2.cpp)]  
  
##  \<a name="ctimespan__format">\</a>  CTimeSpan::Format  
 Generates a formatted string that corresponds to this                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>,                             <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A formatting string similar to the                                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> formatting string. Formatting codes, preceded by a percent (                                <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>) sign, are replaced by the corresponding                                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> component. Other characters in the formatting string are copied unchanged to the returned string. The value and meaning of the formatting codes for                                 **Format** are listed below:  
  
-   **%D** Total days in this                                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
  
-   **%H** Hours in the current day  
  
-   **%M** Minutes in the current hour  
  
-   **%S** Seconds in the current minute  
  
-   **%%** Percent sign  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The ID of the string that identifies this format.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object that contains the formatted time.  
  
### Remarks  
 The Debug version of the library checks the formatting codes and asserts if the code is not in the list above.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#163](../vs140/codesnippet/CPP/ctimespan-class_3.cpp)]  
  
##  \<a name="ctimespan__getdays">\</a>  CTimeSpan::GetDays  
 Returns a value that represents the number of complete days in this                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of complete 24-hour days in the time span. This value may be negative if the time span is negative.  
  
### Remarks  
 Note that Daylight Savings Time can cause                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to return a potentially surprising result. For example, when DST is in effect,                         **GetDays** reports the number of days between April 1 and May 1 as 29, not 30, because one day in April is shortened by an hour and therefore does not count as a complete day.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#164](../vs140/codesnippet/CPP/ctimespan-class_4.cpp)]  
  
##  \<a name="ctimespan__gethours">\</a>  CTimeSpan::GetHours  
 Returns a value that represents the number of hours in the current day (–23 through 23).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of hours in the current day. The range is –23 through 23.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#165](../vs140/codesnippet/CPP/ctimespan-class_5.cpp)]  
  
##  \<a name="ctimespan__getminutes">\</a>  CTimeSpan::GetMinutes  
 Returns a value that represents the number of minutes in the current hour (–59 through 59).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of minutes in the current hour. The range is –59 through 59.  
  
### Example  
 See the example for                                 [GetHours](#ctimespan__gethours).  
  
##  \<a name="ctimespan__getseconds">\</a>  CTimeSpan::GetSeconds  
 Returns a value that represents the number of seconds in the current minute (–59 through 59).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of seconds in the current minute. The range is –59 through 59.  
  
### Example  
 See the example for                                 [GetHours](#ctimespan__gethours).  
  
##  \<a name="ctimespan__gettimespan">\</a>  CTimeSpan::GetTimeSpan  
 Returns the value of the                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the current value of the                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctimespan__gettotalhours">\</a>  CTimeSpan::GetTotalHours  
 Returns a value that represents the total number of complete hours in this                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Returns the total number of complete hours in this                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#166](../vs140/codesnippet/CPP/ctimespan-class_6.cpp)]  
  
##  \<a name="ctimespan__gettotalminutes">\</a>  CTimeSpan::GetTotalMinutes  
 Returns a value that represents the total number of complete minutes in this                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns the total number of complete minutes in this                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Example  
 See the example for                                 [GetTotalHours](#ctimespan__gettotalhours).  
  
##  \<a name="ctimespan__gettotalseconds">\</a>  CTimeSpan::GetTotalSeconds  
 Returns a value that represents the total number of complete seconds in this                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns the total number of complete seconds in this                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
### Example  
 See the example for                                 [GetTotalHours](#ctimespan__gettotalhours).  
  
##  \<a name="ctimespan__operator__add_-">\</a>  CTimeSpan::operator +, -  
 Adds and subtracts                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The value to add to the                                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object representing the result of the operation.  
  
### Remarks  
 These two operators allow you to add and subtract                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> objects to and from each other.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#167](../vs140/codesnippet/CPP/ctimespan-class_7.cpp)]  
  
##  \<a name="ctimespan__operator__add_eq_-_eq">\</a>  CTimeSpan::operator +=, -=  
 Adds and subtracts a                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object to and from this                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The value to add to the                                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The updated                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object.  
  
### Remarks  
 These operators allow you to add and subtract a                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object to and from this                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#168](../vs140/codesnippet/CPP/ctimespan-class_8.cpp)]  
  
##  \<a name="ctimespan__serialize64">\</a>  CTimeSpan::Serialize64  
  
> [!NOTE]
>  This method is only available in MFC projects.  
  
 Serializes the data associated with the member variable to or from an archive.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object that you want to update.  
  
### Return Value  
 The updated                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object.  
  
## See Also  
 [asctime](../vs140/asctime--_wasctime.md)   
 [_ftime](../vs140/_ftime--_ftime32--_ftime64.md)   
 [gmtime](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime](../vs140/localtime--_localtime32--_localtime64.md)   
 [strftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md)   
 [time](../vs140/time--_time32--_time64.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)